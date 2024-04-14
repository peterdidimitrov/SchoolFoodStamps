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
using Microsoft.Extensions.Logging;

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

            var formModel = new CateringCompanyFormViewModel
            {
                Id = "97C32DF3-7A02-49A9-871B-0B27C4C37CB5",
                Name = "New Company Name",
                Address = "New Company Address",
                IdentificationNumber = "123456789"
            };

            var repositoryMock = new Mock<IRepository>();
            repositoryMock.Setup(r => r.AllReadOnly<CateringCompany>()).Returns(this.dbContext.CateringCompanies.AsQueryable());


            repositoryMock.Setup(r => r.GetByIdAsync<CateringCompany>(formModel.Id))
    .Returns((object id) => this.dbContext.CateringCompanies.FindAsync(id));


            var userManagerMock = new Mock<UserManager<ApplicationUser>>(Mock.Of<IUserStore<ApplicationUser>>(), null!, null!, null!, null!, null!, null!, null!, null!);
            userManagerMock.Setup(u => u.FindByIdAsync(It.IsAny<string>()))
                .ReturnsAsync((string userId) =>
                {
                    return new ApplicationUser { Id = Guid.Parse(userId), UserName = "testuUser" };
                });

            this.cateringCompanyService = new CateringCompanyService(userManagerMock.Object, repositoryMock.Object);
        }

        [Test]
        public void GetAllCateringCompaniesAsync_Returns_All_Companies()
        {
            var result = this.cateringCompanyService.GetAllCateringCompaniesAsync().Result;

            Assert.That(result, Has.Exactly(1).Matches<CateringCompanyViewModel>(
        c => c.Id == "EFD31B6C-2A3C-4989-824F-2387C9951234".ToLower() && c.Name == "ET SAM-DPD"));
            Assert.That(result, Has.Exactly(1).Matches<CateringCompanyViewModel>(
        c => c.Id == "8E91E660-535C-4F3A-B2FB-CC4E28682345".ToLower() && c.Name == "HealtyFoodForChildren"));

            Assert.That(result.Count(), Is.EqualTo(3));
        }

        [Test]
        public void ExistsById_Returns_True_If_Company_Exists()
        {
            var result = this.cateringCompanyService.ExistsByIdAsync("EFD31B6C-2A3C-4989-824F-2387C9951234".ToLower()).Result;

            Assert.That(result, Is.True);
        }

        [Test]
        public void ExistsById_Returns_False_If_Company_Does_Not_Exist()
        {
            var result = this.cateringCompanyService.ExistsByIdAsync("EF431B6C-2A3C-4989-824F-2387C9951235".ToLower()).Result;

            Assert.That(result, Is.False);
        }

        [Test]
        public void CreateAsync_Creates_New_Company()
        {
            var formModel = new CateringCompanyFormViewModel()
            {
                Name = "New Company",
                Address = "New Address",
                IdentificationNumber = "123456789",
                UserId = "AE67ADEF-86A9-4C12-AFFB-457F91A3EE8E",
                PhoneNumber = "123456789"
            };

            this.cateringCompanyService.CreateAsync(formModel).Wait();

            var result = this.cateringCompanyService.ExistsByIdentificationNumberAsync("123456789").Result;

            Assert.That(result, Is.True);
        }

        [Test]
        public void ExistsByIdentificationNumber_Returns_True_If_Company_Exists()
        {
            var result = this.cateringCompanyService.ExistsByIdentificationNumberAsync("121756888").Result;

            Assert.That(result, Is.True);
        }

        [Test]
        public void ExistsByIdentificationNumber_Returns_False_If_Company_Does_Not_Exist()
        {
            var result = this.cateringCompanyService.ExistsByIdentificationNumberAsync("153456789").Result;

            Assert.That(result, Is.False);
        }

        [Test]
        public void ExistsByUserId_Returns_True_If_Company_Exists()
        {
            var result = this.cateringCompanyService.ExistsByUserIdAsync("FEC4E958-BF56-4247-A6C8-51FAE40D852D").Result;

            Assert.That(result, Is.True);
        }

        [Test]
        public void ExistsByUserId_Returns_False_If_Company_Does_Not_Exist()
        {
            var result = this.cateringCompanyService.ExistsByUserIdAsync("FEC4E958-BF56");
        }

        [Test]
        public void GetCateringCompanyByUserIdAsync_Returns_Company_With_Passed_UserId()
        {
            var result = this.cateringCompanyService.GetCateringCompanyByUserIdAsync("97C32DF3-7A02-49A9-871B-0B27C4C37CB5").Result;

            Assert.That(result, Is.Not.Null);
            Assert.That(result!.Name, Is.EqualTo("HealtyFoodForChildren"));
            Assert.That(result!.IdentificationNumber, Is.EqualTo("121756889"));
            Assert.That(result!.Id, Is.EqualTo(Guid.Parse("8E91E660-535C-4F3A-B2FB-CC4E28682345")));
        }

        [Test]
        public void GetCateringCompanyByUserIdAsync_Returns_Null_If_Company_Does_Not_Exist()
        {
            var result = this.cateringCompanyService.GetCateringCompanyByUserIdAsync("97C32DF3-7A02-49A9-871B-0B27C8C37CB5").Result;

            Assert.That(result, Is.Null);
        }

        [Test]
        public void UpdateAsync_ShouldUpdateCateringCompany()
        {
            var formModel = new CateringCompanyFormViewModel
            {
                Id = "97C32DF3-7A02-49A9-871B-0B27C4C37CB5",
                Name = "New Company Name",
                Address = "New Company Address",
                IdentificationNumber = "123456789"
            };

            this.cateringCompanyService.UpdateAsync(formModel);

            var cateringCompany = this.cateringCompanyService.GetCateringCompanyByUserIdAsync("97C32DF3-7A02-49A9-871B-0B27C4C37CB5").Result;

            Assert.That(formModel.Name, Is.EqualTo(cateringCompany!.Name));
            Assert.That(cateringCompany.Address, Is.EqualTo(formModel.Address));
            Assert.That(cateringCompany.IdentificationNumber, Is.EqualTo(formModel.IdentificationNumber));
            //repositoryMock.Verify(r => r.SaveChangesAsync(), Times.Once);
        }


        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            this.dbContext.Database.EnsureDeleted();
        }
    }
}