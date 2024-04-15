using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Moq;
using SchoolFoodStamps.Data;
using SchoolFoodStamps.Data.Common;
using SchoolFoodStamps.Data.Models;
using SchoolFoodStamps.Services.Data;
using SchoolFoodStamps.Services.Data.Interfaces;
using SchoolFoodStamps.Web.ViewModels.School;
using static SchoolFoodStamps.Services.Tests.DataBaseSeeder;


namespace SchoolFoodStamps.Services.Tests
{
    public class SchoolServiceTests
    {
        private DbContextOptions<SchoolFoodStampsDbContext> dbOptions;
        private SchoolFoodStampsDbContext dbContext;
        private ISchoolService schoolService;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            this.dbOptions = new DbContextOptionsBuilder<SchoolFoodStampsDbContext>()
                .UseInMemoryDatabase("SchoolFoodStampInMemory" + Guid.NewGuid().ToString())
                .Options;

            this.dbContext = new SchoolFoodStampsDbContext(dbOptions);

            this.dbContext.Database.EnsureDeleted();

            SeedDataBase(this.dbContext);

            var repositoryMock = new Mock<IRepository>();

            repositoryMock.Setup(repo => repo.AllReadOnly<School>())
                .Returns(this.dbContext.Schools.AsQueryable().AsNoTracking());

            repositoryMock.Setup(repo => repo.All<School>())
                .Returns(this.dbContext.Schools.AsQueryable());

            repositoryMock.Setup(r => r.AddAsync(It.IsAny<School>()))
                .Callback((School school) =>
                {
                    this.dbContext.Schools.Add(school);
                });
            repositoryMock.Setup(r => r.SaveChangesAsync())
                .Returns(() => this.dbContext.SaveChangesAsync());

            repositoryMock.Setup(r => r.GetByIdAsync<School>(It.IsAny<object>()))
                .Returns<object>(id => this.dbContext.Schools.FindAsync(id).AsTask());

            var userManagerMock = new Mock<UserManager<ApplicationUser>>(Mock.Of<IUserStore<ApplicationUser>>(), null!, null!, null!, null!, null!, null!, null!, null!);
            userManagerMock.Setup(u => u.FindByIdAsync(It.IsAny<string>()))
                .ReturnsAsync((string userId) =>
                {
                    return new ApplicationUser { Id = Guid.Parse(userId), UserName = "testuUser" };
                });
            userManagerMock.Setup(u => u.AddToRoleAsync(It.IsAny<ApplicationUser>(), It.IsAny<string>()))
                .ReturnsAsync(IdentityResult.Success);

            this.schoolService = new SchoolService(userManagerMock.Object, repositoryMock.Object);
        }

        [Test]
        public async Task CreateSchoolAsyncShouldCreateSchool()
        {
            SchoolFormViewModel school = new SchoolFormViewModel
            {
                Name = "TestSchool",
                Address = "TestAddress",
                IdentificationNumber = "123456987",
                CateringCompanyId = "03320670-824F-44FF-8768-6FC0EDB64CC8",
                UserId = "AE67ADEF-86A9-4C12-AFFB-457F91A3EE8E",
            };

            await this.schoolService.CreateAsync(school);

            School? createdSchool = await this.dbContext.Schools.FirstOrDefaultAsync(s => s.UserId.ToString().ToLower() == school.UserId.ToLower());

            Assert.That(createdSchool!.Name, Is.EqualTo(school.Name));
            Assert.That(createdSchool.Address, Is.EqualTo(school.Address));
            Assert.That(createdSchool.IdentificationNumber, Is.EqualTo(school.IdentificationNumber));
            Assert.That(createdSchool.CateringCompanyId, Is.EqualTo(Guid.Parse(school.CateringCompanyId)));
            Assert.That(createdSchool.UserId, Is.EqualTo(Guid.Parse(school.UserId)));
        }

        [Test]
        public async Task ExistsByIdAsyncShouldReturnTrueIfSchoolExists()
        {
            string schoolId = "6CD00C11-B0CB-428A-9143-DF5743105A92";

            bool result = await this.schoolService.ExistsByIdAsync(schoolId.ToLower());

            Assert.That(result, Is.True);
        }

        [Test]
        public async Task ExistsByIdAsyncShouldReturnFalseIfSchoolDoesNotExist()
        {
            string schoolId = "6CD00C11-B0CB-428A-9143-DF5743105A93";

            bool result = await this.schoolService.ExistsByIdAsync(schoolId.ToLower());

            Assert.That(result, Is.False);
        }

        [Test]
        public async Task ExistsByIdentificationNumberAsyncShouldReturnTrueIfSchoolExists()
        {
            string identificationNumber = "121756787";

            bool result = await this.schoolService.ExistsByIdentificationNumberAsync(identificationNumber);

            Assert.That(result, Is.True);
        }

        [Test]
        public async Task ExistsByIdentificationNumberAsyncShouldReturnFalseIfSchoolDoesNotExist()
        {
            string identificationNumber = "121756788";

            bool result = await this.schoolService.ExistsByIdentificationNumberAsync(identificationNumber);

            Assert.That(result, Is.False);
        }

        [Test]
        public async Task ExistsByUserIdAsyncShouldReturnTrueIfSchoolExists()
        {
            string userId = "7A40A6C8-B237-4C18-8272-4C8D21C4B5D0";

            bool result = await this.schoolService.ExistsByUserIdAsync(userId);

            Assert.That(result, Is.True);
        }

        [Test]
        public async Task ExistsByUserIdAsyncShouldReturnFalseIfSchoolDoesNotExist()
        {
            string userId = "7A40A6C8-B237-4C18-8272-4C8D21C4B5D1";

            bool result = await this.schoolService.ExistsByUserIdAsync(userId);

            Assert.That(result, Is.False);
        }

        [Test]
        public async Task GetAllSchoolsAsyncShouldReturnAllSchools()
        {
            IEnumerable<SchoolViewModel> schools = await this.schoolService.GetAllSchoolsAsync();

            Assert.That(schools.Count(), Is.EqualTo(3));
        }

        [Test]
        public async Task GetAllSchoolsByCateringCompanyIdAsyncShouldReturnAllSchoolsByCateringCompanyId()
        {
            string cateringCompanyId = "EFD31B6C-2A3C-4989-824F-2387C9951234";

            IEnumerable<SchoolViewModel> schools = await this.schoolService.GetAllSchoolsByCateringCompanyIdAsync(cateringCompanyId);

            Assert.That(schools.Count(), Is.EqualTo(1));
        }

        [Test]
        public async Task GetSchoolByUserIdAsyncShouldReturnSchoolByUserId()
        {
            string userId = "AE67ADEF-86A9-4C12-AFFB-457F91A3EE8E";

            SchoolFormViewModel? school = await this.schoolService.GetSchoolByUserIdAsync(userId);

            Assert.That(school!.Name, Is.EqualTo("TestSchool"));
            Assert.That(school.Address, Is.EqualTo("TestAddress"));
            Assert.That(school.IdentificationNumber, Is.EqualTo("123456987"));
            Assert.That(school.CateringCompanyId, Is.EqualTo("03320670-824F-44FF-8768-6FC0EDB64CC8".ToLower()));
            Assert.That(school.UserId, Is.EqualTo("AE67ADEF-86A9-4C12-AFFB-457F91A3EE8E".ToLower()));
        }

        [Test]
        public async Task GetSchoolIdAsyncShouldReturnSchoolIdByUserId()
        {
            string userId = "D35E9B04-D31B-40F6-8D0D-DA225A969421";

            string? schoolId = await this.schoolService.GetSchoolIdAsync(userId);

            Assert.That(schoolId, Is.EqualTo("6CD00C11-B0CB-428A-9143-DF5743105A92".ToLower()));
        }

        [Test]
        public async Task UpdateAsyncShouldUpdateSchool()
        {
            SchoolFormViewModel school = new SchoolFormViewModel
            {
                Id = "6CD00C11-B0CB-428A-9143-DF5743105A92",
                Name = "TestSchool",
                Address = "TestAddress",
                IdentificationNumber = "123456987",
                CateringCompanyId = "03320670-824F-44FF-8768-6FC0EDB64CC8",
                UserId = "d35e9b04-d31b-40f6-8d0d-da225a969421",
            };

            await this.schoolService.UpdateAsync(school);

            School? updatedSchool = await this.dbContext.Schools.FirstOrDefaultAsync(s => s.Id.ToString().ToLower() == school.Id.ToLower());

            Assert.That(updatedSchool!.Name, Is.EqualTo(school.Name));
            Assert.That(updatedSchool.Address, Is.EqualTo(school.Address));
            Assert.That(updatedSchool.IdentificationNumber, Is.EqualTo(school.IdentificationNumber));
            Assert.That(updatedSchool.CateringCompanyId, Is.EqualTo(Guid.Parse(school.CateringCompanyId)));
            Assert.That(updatedSchool.UserId, Is.EqualTo(Guid.Parse(school.UserId)));
        }


        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            this.dbContext.Database.EnsureDeleted();
        }
    }
}
