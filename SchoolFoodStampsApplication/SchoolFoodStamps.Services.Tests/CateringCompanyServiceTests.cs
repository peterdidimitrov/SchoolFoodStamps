using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Moq;
using SchoolFoodStamps.Data;
using SchoolFoodStamps.Data.Common;
using SchoolFoodStamps.Data.Models;
using SchoolFoodStamps.Services.Data;
using SchoolFoodStamps.Services.Data.Interfaces;
using SchoolFoodStamps.Web.ViewModels.CateringCompany;
using static SchoolFoodStamps.Services.Tests.DataBaseSeeder;

namespace SchoolFoodStamps.Services.Tests
{
    public class CateringCompanyServiceTests
    {
        private DbContextOptions<SchoolFoodStampsDbContext> dbOptions;
        private SchoolFoodStampsDbContext dbContext;
        private ICateringCompanyService cateringCompanyService;


        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            this.dbOptions = new DbContextOptionsBuilder<SchoolFoodStampsDbContext>()
                .UseInMemoryDatabase("SchoolFoodStampInMemory" + Guid.NewGuid().ToString())
                .Options;

            this.dbContext = new SchoolFoodStampsDbContext(this.dbOptions);

            this.dbContext.Database.EnsureDeleted();

            SeedDataBase(this.dbContext);

            Mock<IRepository> repositoryMock = new Mock<IRepository>();
            repositoryMock.Setup(repo => repo.AllReadOnly<CateringCompany>())
                .Returns(this.dbContext.CateringCompanies.AsQueryable().AsNoTracking());

            repositoryMock.Setup(repo => repo.AllReadOnly<School>())
                .Returns(this.dbContext.Schools.AsQueryable().AsNoTracking());

            repositoryMock.Setup(repo => repo.All<CateringCompany>())
                .Returns(this.dbContext.CateringCompanies.AsQueryable());

            repositoryMock.Setup(r => r.AddAsync(It.IsAny<CateringCompany>()))
                .Callback((CateringCompany cateringCompany) =>
                {
                    this.dbContext.CateringCompanies.Add(cateringCompany);
                });
            repositoryMock.Setup(r => r.SaveChangesAsync())
                .Returns(() => this.dbContext.SaveChangesAsync());

            repositoryMock.Setup(r => r.GetByIdAsync<CateringCompany>(It.IsAny<object>()))
                .Returns<object>(id => this.dbContext.CateringCompanies.FindAsync(id).AsTask());

            var userManagerMock = new Mock<UserManager<ApplicationUser>>(Mock.Of<IUserStore<ApplicationUser>>(), null!, null!, null!, null!, null!, null!, null!, null!);
            userManagerMock.Setup(u => u.FindByIdAsync(It.IsAny<string>()))
                .ReturnsAsync((string userId) =>
                {
                    return new ApplicationUser { Id = Guid.Parse(userId), UserName = "testuUser" };
                });
            userManagerMock.Setup(u => u.AddToRoleAsync(It.IsAny<ApplicationUser>(), It.IsAny<string>()))
                .ReturnsAsync(IdentityResult.Success);

            this.cateringCompanyService = new CateringCompanyService(userManagerMock.Object, repositoryMock.Object);
        }

        [Test]
        public async Task GetAllCateringCompaniesAsync_Returns_All_Companies()
        {
            var result = await this.cateringCompanyService.GetAllCateringCompaniesAsync();

            Assert.That(result, Has.Exactly(1).Matches<CateringCompanyViewModel>(
        c => c.Id == "EFD31B6C-2A3C-4989-824F-2387C9951234".ToLower() && c.Name == "ET SAM-DPD"));
            Assert.That(result, Has.Exactly(1).Matches<CateringCompanyViewModel>(
        c => c.Id == "8E91E660-535C-4F3A-B2FB-CC4E28682345".ToLower() && c.Name == "HealtyFoodForChildren"));

            Assert.That(result.Count(), Is.EqualTo(3));
        }

        [Test]
        public async Task ExistsById_Returns_True_If_Company_Exists()
        {
            var result = await this.cateringCompanyService.ExistsByIdAsync("EFD31B6C-2A3C-4989-824F-2387C9951234".ToLower());

            Assert.That(result, Is.True);
        }

        [Test]
        public async Task ExistsById_Returns_False_If_Company_Does_Not_Exist()
        {
            var result = await this.cateringCompanyService.ExistsByIdAsync("EF431B6C-2A3C-4989-824F-2387C9951235".ToLower());

            Assert.That(result, Is.False);
        }

        [Test]
        public async Task CreateAsync_Creates_New_Company()
        {
            var formModel = new CateringCompanyFormViewModel()
            {
                Name = "New Company",
                Address = "New Address",
                IdentificationNumber = "123456789",
                UserId = "AE67ADEF-86A9-4C12-AFFB-457F91A3EE8E",
                PhoneNumber = "123456789"
            };

            await this.cateringCompanyService.CreateAsync(formModel);

            var result = await this.cateringCompanyService.ExistsByIdentificationNumberAsync("123456789");

            Assert.That(result, Is.True);
        }

        [Test]
        public async Task ExistsByIdentificationNumberAsync_Returns_True_If_Company_Exists()
        {
            var result = await this.cateringCompanyService.ExistsByIdentificationNumberAsync("121756888");

            Assert.That(result, Is.True);
        }

        [Test]
        public async Task ExistsByIdentificationNumberAsync_Returns_False_If_Company_Does_Not_Exist()
        {
            var result = await this.cateringCompanyService.ExistsByIdentificationNumberAsync("153456789");

            Assert.That(result, Is.False);
        }

        [Test]
        public async Task ExistsByUserIdAsync_Returns_True_If_Company_Exists()
        {
            var result = await this.cateringCompanyService.ExistsByUserIdAsync("FEC4E958-BF56-4247-A6C8-51FAE40D852D");

            Assert.That(result, Is.True);
        }

        [Test]
        public async Task ExistsByUserIdAsync_Returns_False_If_Company_Does_Not_Exist()
        {
            var result = await this.cateringCompanyService.ExistsByUserIdAsync("FEC4E958-BF56-4A47-A6C8-51FAE40D852D");

            Assert.That(result, Is.False);
        }

        [Test]
        public async Task GetCateringCompanyByUserIdAsync_Returns_Company_With_Passed_UserId()
        {
            var result = await this.cateringCompanyService.GetCateringCompanyByUserIdAsync("97C32DF3-7A02-49A9-871B-0B27C4C37CB5");

            Assert.That(result, Is.Not.Null);
            Assert.That(result!.Name, Is.EqualTo("HealtyFoodForChildren"));
            Assert.That(result!.IdentificationNumber, Is.EqualTo("121756889"));
            Assert.That(result!.Id, Is.EqualTo(Guid.Parse("8E91E660-535C-4F3A-B2FB-CC4E28682345")));
        }

        [Test]
        public async Task GetCateringCompanyByUserIdAsync_Returns_Null_If_Company_Does_Not_Exist()
        {
            var result = await this.cateringCompanyService.GetCateringCompanyByUserIdAsync("97C32DF3-7A02-49A9-871B-0B27C8C37CB5");

            Assert.That(result, Is.Null);
        }

        [Test]
        public async Task UpdateAsync_ShouldUpdateCateringCompany()
        {
            var formModel = new CateringCompanyFormViewModel
            {
                Id = "8E91E660-535C-4F3A-B2FB-CC4E28682345",
                Name = "New Company Name",
                Address = "New Company Address",
                IdentificationNumber = "123456789"
            };

            await this.cateringCompanyService.UpdateAsync(formModel);

            var cateringCompany = await this.cateringCompanyService.GetCateringCompanyByUserIdAsync("97C32DF3-7A02-49A9-871B-0B27C4C37CB5");

            Assert.That(formModel.Name, Is.EqualTo(cateringCompany!.Name));
            Assert.That(cateringCompany.Address, Is.EqualTo(formModel.Address));
            Assert.That(cateringCompany.IdentificationNumber, Is.EqualTo(formModel.IdentificationNumber));
        }

        [Test]
        public async Task GetCateringCompanyIdAsync_Returns_CateringCompanyId()
        {
            IList<CateringCompany> companies = this.dbContext.CateringCompanies.ToList();

            var result = await this.cateringCompanyService.GetCateringCompanyIdAsync("FEC4E958-BF56-4247-A6C8-51FAE40D852D");

            Assert.That(result, Is.EqualTo("EFD31B6C-2A3C-4989-824F-2387C9951234".ToLower()));
        }

        [Test]
        public async Task GetCateringCompanyIdAsync_Returns_Null_If_Company_Does_Not_Exist()
        {
            var result = await this.cateringCompanyService.GetCateringCompanyIdAsync("FEC4E958-BF56-4247-A6C8-51FAE40D852E");

            Assert.That(result, Is.Null);
        }

        [Test]
        public async Task GetCateringCompanyByIdAsync_Returns_CateringCompany()
        {
            var result = await this.cateringCompanyService.GetCateringCompanyByIdAsync("EFD31B6C-2A3C-4989-824F-2387C9951234");

            Assert.That(result, Is.Not.Null);
            Assert.That(result!.Name, Is.EqualTo("ET SAM-DPD"));
            Assert.That(result!.IdentificationNumber, Is.EqualTo("121756888"));
            Assert.That(result!.Id, Is.EqualTo(Guid.Parse("EFD31B6C-2A3C-4989-824F-2387C9951234".ToLower())));
        }

        [Test]
        public async Task GetCateringCompanyByIdAsync_Returns_Null_If_Company_Does_Not_Exist()
        {
            var result = await this.cateringCompanyService.GetCateringCompanyByIdAsync("EFD31B6C-2A3C-4989-824F-2387C9951235");

            Assert.That(result, Is.Null);
        }

        [Test]
        public async Task GetCateringCompanyIdBySchoolIdAsync_Returns_CateringCompanyId()
        {
            var result = await this.cateringCompanyService.GetCateringCompanyIdBySchoolIdAsync("E3AF4B8E-8F07-4962-838E-670BD305758F");

            Assert.That(result, Is.EqualTo("EFD31B6C-2A3C-4989-824F-2387C9951234".ToLower()));
        }

        [Test]
        public async Task GetCateringCompanyIdBySchoolIdAsync_Returns_Null_If_Company_Does_Not_Exist()
        {
            var result = await this.cateringCompanyService.GetCateringCompanyIdBySchoolIdAsync("EFD31B6C-2A3C-4989-824F-2387C9951235");

            Assert.That(result, Is.Null);
        }


        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            this.dbContext.Database.EnsureDeleted();
            this.dbContext.Dispose();
        }
    }
}