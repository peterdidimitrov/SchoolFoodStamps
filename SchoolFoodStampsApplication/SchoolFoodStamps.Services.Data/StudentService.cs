using Microsoft.EntityFrameworkCore;
using SchoolFoodStamps.Data.Common;
using SchoolFoodStamps.Data.Models;
using SchoolFoodStamps.Services.Data.Interfaces;
using SchoolFoodStamps.Web.ViewModels.Student;
using SchoolFoodStamps.Services.Data.Models.Students;
using System.Globalization;

namespace SchoolFoodStamps.Services.Data
{
    public class StudentService : IStudentService
    {
        private readonly IRepository repository;


        public StudentService(IRepository repository)
        {
            this.repository = repository;
        }

        public async Task CreateAsync(StudentFormViewModel formModel)
        {

            Student student = new Student()
            {
                FirstName = formModel.FirstName,
                LastName = formModel.LastName,
                DateOfBirth = DateTime.Parse(formModel.DateOfBirth, CultureInfo.InvariantCulture),
                ClassNumber = Byte.Parse(formModel.ClassNumber),
                ClassLetter = Char.Parse(formModel.ClassLetter),
                ParentId = Guid.Parse(formModel.ParentId),
                SchoolId = Guid.Parse(formModel.SchoolId)
            };

            Parent? parent = await repository.GetByIdAsync<Parent>(Guid.Parse(formModel.ParentId));
            parent!.Students.Add(student);

            School? school = await repository.GetByIdAsync<School>(Guid.Parse(formModel.SchoolId));
            school!.Students.Add(student);

            await repository.AddAsync(student);
            await repository.SaveChangesAsync();
        }

        public async Task EditAsync(StudentFormViewModel formModel, Student student)
        {
            student.FirstName = formModel.FirstName;
            student.LastName = formModel.LastName;
            student.DateOfBirth = DateTime.Parse(formModel.DateOfBirth, CultureInfo.InvariantCulture);
            student.ClassNumber = Byte.Parse(formModel.ClassNumber);
            student.ClassLetter = Char.Parse(formModel.ClassLetter);
            student.SchoolId = Guid.Parse(formModel.SchoolId);

            await repository.SaveChangesAsync();
        }

        public List<ClassLetter> GetAllClassLetters()
        {
            List<ClassLetter> classLetters = new List<ClassLetter>();
            foreach (ClassLetter letter in Enum.GetValues(typeof(ClassLetter)))
            {
                classLetters.Add(letter);
            }

            return classLetters;
        }

        public List<byte> GetAllClassNumbers()
        {
            List<byte> classNumbers = new List<byte>();

            for (byte i = 1; i <= 12; i++)
            {
                classNumbers.Add(i);
            }
            return classNumbers;
        }

        public async Task<IEnumerable<StudentViewModel>> GetAllStudentByParentAsync(string parentId)
        {
            return await repository
                .AllReadOnly<Student>()
                .Where(s => s.ParentId == Guid.Parse(parentId))
                .Select(s => new StudentViewModel
                {
                    Id = s.Id.ToString(),
                    Name = $"{s.FirstName} {s.LastName}",
                    SchoolName = s.School.Name,
                    StudentClass = $"{s.ClassNumber} {s.ClassLetter}"
                })
                .ToListAsync();
        }

        public async Task<AllStudentsFilteredAndPagedServiceModel> GetAllStudentBySchoolAsync(AllStudentsQueryModel queryModel, string schoolId)
        {
            IQueryable<Student> studentQuery = repository
                .AllReadOnly<Student>()
                .Where(s => s.SchoolId == Guid.Parse(schoolId))
                .AsQueryable();

            if (!string.IsNullOrWhiteSpace(queryModel.Name))
            {
                string wildCard = $"%{queryModel.Name.ToLower()}%";

                studentQuery = studentQuery
                    .Where(h => EF.Functions.Like(h.FirstName + " " + h.LastName, wildCard));
            }

            if (!string.IsNullOrWhiteSpace(queryModel.ClassNumber))
            {
                studentQuery = studentQuery
                    .Where(s => s.ClassNumber.ToString() == queryModel.ClassNumber);
            }

            if (!string.IsNullOrWhiteSpace(queryModel.ClassLetter))
            {
                string wildCard = $"%{queryModel.ClassLetter.ToLower()}%";

                studentQuery = studentQuery
                    .Where(h => EF.Functions.Like(h.ClassLetter.ToString(), wildCard));
            }

            studentQuery = queryModel.StudentSorting switch
            {
                StudentSorting.Name => studentQuery
                    .OrderBy(s => s.FirstName)
                    .ThenBy(s => s.LastName),
                StudentSorting.Class => studentQuery
                    .OrderBy(s => s.ClassNumber)
                    .ThenBy(s => s.ClassLetter),
                StudentSorting.HasFoodStamps => studentQuery
                    .Where(s => s.FoodStamps.Count() > 0),
                StudentSorting.School => studentQuery
                    .OrderByDescending(s => s.School.Name),
                _ => studentQuery
                    .OrderBy(s => s.SchoolId.ToString() != null)
            };

            IEnumerable<StudentViewModel> allStudents = await studentQuery
                .Skip((queryModel.CurrentPage - 1) * queryModel.StudentsPerPage)
                .Take(queryModel.StudentsPerPage)
                .Select(s => new StudentViewModel
                {
                    Id = s.Id.ToString(),
                    Name = $"{s.FirstName} {s.LastName}",
                    SchoolName = s.School.Name,
                    StudentClass = $"{s.ClassNumber} {s.ClassLetter}"
                })
                .ToListAsync();

            int totalStudents = await studentQuery.CountAsync();

            return new AllStudentsFilteredAndPagedServiceModel()
            {
                TotalStudentsCount = totalStudents,
                Students = allStudents
            };
        }

        public async Task<IEnumerable<StudentViewModel>> GetAllStudentsAsync()
        {
            return await repository
                .AllReadOnly<Student>()
                .AsNoTracking()
                .Select(s => new StudentViewModel
                {
                    Id = s.Id.ToString(),
                    Name = $"{s.FirstName} {s.LastName}",
                    SchoolName = s.School.Name,
                    StudentClass = $"{s.ClassNumber} {s.ClassLetter}"
                })
                .ToListAsync();
        }

        public async Task<Student?> GetStudentByIdAsync(Guid studentId)
        {
            return await repository
                .GetByIdAsync<Student>(studentId);
        }


    }
}
