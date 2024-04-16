using Microsoft.EntityFrameworkCore;
using Moq;
using SchoolFoodStamps.Data;
using SchoolFoodStamps.Data.Common;
using SchoolFoodStamps.Data.Models;
using SchoolFoodStamps.Services.Data;
using SchoolFoodStamps.Services.Data.Interfaces;
using SchoolFoodStamps.Services.Data.Models.Students;
using SchoolFoodStamps.Web.ViewModels.Student;
using static SchoolFoodStamps.Services.Tests.DataBaseSeeder;

namespace SchoolFoodStamps.Services.Tests
{
    public class StudentServiceTests
    {
        private DbContextOptions<SchoolFoodStampsDbContext> dbOptions;
        private SchoolFoodStampsDbContext dbContext;
        private IStudentService studentService;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            this.dbOptions = new DbContextOptionsBuilder<SchoolFoodStampsDbContext>()
                .UseInMemoryDatabase("SchoolFoodStampInMemory" + Guid.NewGuid().ToString())
                .Options;

            this.dbContext = new SchoolFoodStampsDbContext(dbOptions);

            this.dbContext.Database.EnsureDeleted();

            SeedDataBase(this.dbContext);

            Mock<IRepository> repositoryMock = new Mock<IRepository>();

            repositoryMock.Setup(repo => repo.AllReadOnly<Student>())
                .Returns(this.dbContext.Students.AsQueryable().AsNoTracking());

            repositoryMock.Setup(r => r.GetByIdAsync<Student>(It.IsAny<object>()))
                .Returns<object>(id => this.dbContext.Students.FindAsync(id).AsTask());

            repositoryMock.Setup(r => r.AddAsync(It.IsAny<Student>()))
                .Callback((Student student) =>
                {
                    this.dbContext.Students.Add(student);
                });

            repositoryMock.Setup(r => r.GetByIdAsync<Student>(It.IsAny<object>()))
    .Returns<object>(id => this.dbContext.Students.FindAsync(id).AsTask());

            repositoryMock.Setup(r => r.SaveChangesAsync())
                .Returns(() => this.dbContext.SaveChangesAsync());

            this.studentService = new StudentService(repositoryMock.Object);
        }

        [Test]
        public async Task GetStudentByIdAsyncReturnStudent()
        {
            Student? student = await this.studentService.GetStudentByIdAsync(Guid.Parse("A1ABC1D5-3718-4639-AB42-D7A1E9A0FCB0"));

            Assert.That(student!.Id, Is.EqualTo(Guid.Parse("A1ABC1D5-3718-4639-AB42-D7A1E9A0FCB0")));
            Assert.That(student!.FirstName, Is.EqualTo("John"));
            Assert.That(student!.LastName, Is.EqualTo("Doe"));
            Assert.That(student!.DateOfBirth, Is.EqualTo(DateTime.Parse("2010-01-01")));
            Assert.That(student!.ClassNumber, Is.EqualTo(3));
            Assert.That(student!.ClassLetter, Is.EqualTo('B'));
            Assert.That(student!.ParentId, Is.EqualTo(Guid.Parse("63281334-434E-4327-B1B7-84B32A9D3D82".ToLower())));
            Assert.That(student!.SchoolId, Is.EqualTo(Guid.Parse("E3AF4B8E-8F07-4962-838E-670BD305758F".ToLower())));
            Assert.That(student!.IsActive, Is.EqualTo(true));
        }

        [Test]
        public async Task CreateAsyncShouldCreateStudent()
        {
            StudentFormViewModel studentFormViewModel = new StudentFormViewModel()
            {
                FirstName = "Pesho",
                LastName = "Peshov",
                DateOfBirth = "2011-01-01",
                ClassNumber = "4",
                ClassLetter = "A",
                ParentId = "63281334-434E-4327-B1B7-84B32A9D3D82",
                SchoolId = "E3AF4B8E-8F07-4962-838E-670BD305758F"
            };

            await this.studentService.CreateAsync(studentFormViewModel);

            IEnumerable<Student> students = await this.dbContext.Students.ToListAsync();

            Student? student = await this.dbContext.Students.FirstOrDefaultAsync(s => s.FirstName == "Pesho");

            Assert.That(student!.FirstName, Is.EqualTo("Pesho"));
            Assert.That(student!.LastName, Is.EqualTo("Peshov"));
            Assert.That(student!.DateOfBirth, Is.EqualTo(DateTime.Parse("2011-01-01")));
            Assert.That(student!.ClassNumber, Is.EqualTo(4));
            Assert.That(student!.ClassLetter, Is.EqualTo('A'));
            Assert.That(student!.ParentId, Is.EqualTo(Guid.Parse("63281334-434E-4327-B1B7-84B32A9D3D82")));
            Assert.That(student!.SchoolId, Is.EqualTo(Guid.Parse("E3AF4B8E-8F07-4962-838E-670BD305758F")));
            Assert.That(student!.IsActive, Is.EqualTo(true));
        }

        [Test]
        public async Task DeleteAsyncShouldDeleteStudent()
        {
            int result = await this.studentService.DeleteAsync(Guid.Parse("49D7ED09-30B0-4B52-B3D4-B2C7C318CCD1"));

            Student? student = await this.dbContext.Students.FirstOrDefaultAsync(s => s.Id == Guid.Parse("49D7ED09-30B0-4B52-B3D4-B2C7C318CCD1"));

            Assert.That(result, Is.EqualTo(1));
            Assert.That(student!.FirstName, Is.EqualTo(string.Empty));
            Assert.That(student!.LastName, Is.EqualTo(string.Empty));
            Assert.That(student!.DateOfBirth, Is.Null);
            Assert.That(student!.IsActive, Is.EqualTo(false));
        }

        [Test]
        public async Task EditAsyncShouldEditStudent()
        {
            Student? student = await this.dbContext.Students.FirstOrDefaultAsync(s => s.Id == Guid.Parse("69D5EEFD-E902-4706-8BD8-B523BB24B9B6"));

            StudentFormViewModel studentFormViewModel = new StudentFormViewModel()
            {
                FirstName = "Pesho",
                LastName = "Peshov",
                DateOfBirth = "2011-01-01",
                ClassNumber = "4",
                ClassLetter = "A",
                ParentId = "63281334-434E-4327-B1B7-84B32A9D3D82",
                SchoolId = "E3AF4B8E-8F07-4962-838E-670BD305758F"
            };

            await this.studentService.EditAsync(studentFormViewModel, student!);

            Student? editedStudent = await this.dbContext.Students.FirstOrDefaultAsync(s => s.Id == Guid.Parse("69D5EEFD-E902-4706-8BD8-B523BB24B9B6"));

            Assert.That(editedStudent!.FirstName, Is.EqualTo("Pesho"));
            Assert.That(editedStudent.LastName, Is.EqualTo("Peshov"));
            Assert.That(editedStudent.DateOfBirth, Is.EqualTo(DateTime.Parse("2011-01-01")));
            Assert.That(editedStudent.ClassNumber, Is.EqualTo(4));
            Assert.That(editedStudent.ClassLetter, Is.EqualTo('A'));
            Assert.That(editedStudent.SchoolId, Is.EqualTo(Guid.Parse("E3AF4B8E-8F07-4962-838E-670BD305758F")));
            Assert.That(editedStudent.IsActive, Is.EqualTo(true));
        }

        [Test]
        public void GetAllClassLettersShouldReturnAllClassLetters()
        {
            List<ClassLetter> classLetters = this.studentService.GetAllClassLetters();

            Assert.That(classLetters.Count, Is.EqualTo(5));
            Assert.That(classLetters[0], Is.EqualTo(ClassLetter.A));
        }

        [Test]
        public void GetAllClassNumbersShouldReturnAllClassNumbers()
        {
            List<byte> classNumbers = this.studentService.GetAllClassNumbers();

            Assert.That(classNumbers.Count, Is.EqualTo(12));
            Assert.That(classNumbers[0], Is.EqualTo(1));
        }

        [Test]
        public async Task GetStudentByIdAsyncShouldReturnNull()
        {
            Student? student = await this.studentService.GetStudentByIdAsync(Guid.Parse("A1ABC1D5-3718-4639-AB42-D7A1E9A0FCB1"));

            Assert.That(student, Is.Null);
        }

        [Test]
        public async Task GetAllStudentByParentAsyncShouldReturnStudents()
        {
            IEnumerable<StudentViewModel> students = await this.studentService.GetAllStudentByParentAsync("63281334-434E-4327-B1B7-84B32A9D3D82");

            Assert.That(students.Count(), Is.EqualTo(2));
        }

        [Test]
        public async Task GetAllStudentByParentAsyncShouldReturnEmptyCollection()
        {
            IEnumerable<StudentViewModel> students = await this.studentService.GetAllStudentByParentAsync("A1ABC1D5-3718-4639-AB42-D7A1E9A0FCB0");

            Assert.That(students.Count(), Is.EqualTo(0));
        }

        [Test]
        public async Task GetAllStudentByParentAsyncShouldReturnEmptyCollectionWhenParentIdIsInvalid()
        {
            IEnumerable<StudentViewModel> students = await this.studentService.GetAllStudentByParentAsync("A1ABC1D5-3718-4639-AB42-D7A1E9A0FCB1");

            Assert.That(students.Count(), Is.EqualTo(0));
        }

        [Test]
        public async Task GetAllStudentBySchoolAsyncShouldReturnStudents()
        {
            AllStudentsQueryModel queryModel = new AllStudentsQueryModel()
            {
                Name = "John",
                ClassNumber = "3"
            };

            AllStudentsFilteredAndPagedServiceModel model = await this.studentService.GetAllStudentBySchoolAsync(queryModel, "E3AF4B8E-8F07-4962-838E-670BD305758F");

            Assert.That(model.Students.Count(), Is.EqualTo(1));
            Assert.That(model.Students.First().Name, Is.EqualTo("John Doe"));
        }

        [Test]
        public async Task GetAllStudentsByParentIdAsyncShouldReturnEmptyCollection()
        {
            IEnumerable<StudentViewModel> students = await this.studentService.GetAllStudentByParentAsync("A1ABC1D5-3718-4639-AB42-D7A1E9A0FCB1");

            Assert.That(students.Count(), Is.EqualTo(0));
        }

        [Test]
        public async Task GetAllStudentsAsyncShouldReturnAllStudents()
        {
            IEnumerable<StudentViewModel> students = await this.studentService.GetAllStudentsAsync();

            Assert.That(students.Count(), Is.EqualTo(3));
        }

        [Test]
        public async Task GetAllStudentsByParentIdAsyncShouldReturnStudents()
        {
            IEnumerable<StudentViewModel> students = await this.studentService.GetAllStudentsByParentIdAsync("63281334-434E-4327-B1B7-84B32A9D3D82");

            Assert.That(students.Count(), Is.EqualTo(2));
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            this.dbContext.Database.EnsureDeleted();
            this.dbContext.Dispose();
        }
    }
}