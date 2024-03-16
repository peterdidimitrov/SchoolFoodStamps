using SchoolFoodStamps.Data;
using SchoolFoodStamps.Data.Models;
using SchoolFoodStamps.Services.Data.Interfaces;
using SchoolFoodStamps.Web.ViewModels.Student;

namespace SchoolFoodStamps.Services.Data
{
    public class StudentService : IStudentService
    {
        private readonly SchoolFoodStampsDbContext dbContext;

        public StudentService(SchoolFoodStampsDbContext _dbContext)
        {
            this.dbContext = _dbContext;
        }

        public async Task CreateAsync(StudentFormViewModel formModel)
        {
            Student student = new Student()
            {
                FirstName = formModel.FirstName,
                LastName = formModel.LastName,
                DateOfBirth = DateTime.Parse(formModel.DateOfBirth),
                ClassNumber = Byte.Parse(formModel.ClassNumber),
                ClassLetter = Char.Parse(formModel.ClassLetter),
                ParentId = Guid.Parse(formModel.ParentId),
                SchoolId = Guid.Parse(formModel.SchoolId)
            };

            Parent? parent = await dbContext.Parents.FindAsync(Guid.Parse(formModel.ParentId));
            parent!.Students.Add(student);

            School? school = await dbContext.Schools.FindAsync(Guid.Parse(formModel.SchoolId));
            school!.Students.Add(student);

            await dbContext.Students.AddAsync(student);
            await dbContext.SaveChangesAsync();
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

        public Task<IEnumerable<StudentFormViewModel>> GetAllStudentsAsync()
        {
            throw new NotImplementedException();
        }
    }
}
