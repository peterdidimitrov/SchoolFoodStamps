﻿using Microsoft.EntityFrameworkCore;
using SchoolFoodStamps.Data.Common;
using SchoolFoodStamps.Data.Models;
using SchoolFoodStamps.Services.Data.Interfaces;
using SchoolFoodStamps.Web.ViewModels.Student;

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
                DateOfBirth = DateTime.Parse(formModel.DateOfBirth!),
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
                .AsNoTracking()
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

        public async Task<IEnumerable<StudentViewModel>> GetAllStudentBySchoolAsync(string schoolId)
        {
            return await repository
                .AllReadOnly<Student>()
                .AsNoTracking()
                .Where(s => s.SchoolId == Guid.Parse(schoolId))
                .Select(s => new StudentViewModel
                {
                    Id = s.Id.ToString(),
                    Name = $"{s.FirstName} {s.LastName}",
                    SchoolName = s.School.Name,
                    StudentClass = $"{s.ClassNumber} {s.ClassLetter}"
                })
                .ToListAsync();
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
    }
}