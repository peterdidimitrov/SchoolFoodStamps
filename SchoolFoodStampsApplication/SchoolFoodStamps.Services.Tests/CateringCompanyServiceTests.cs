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

            var repositoryMock = new Mock<IRepository>();
            repositoryMock.Setup(r => r.AllReadOnly<CateringCompany>()).Returns(this.dbContext.CateringCompanies.AsQueryable());

            this.cateringCompanyService = new CateringCompanyService(null, repositoryMock.Object);
        }

        [Test]
        public void GetAllCateringCompaniesAsync_Returns_All_Companies()
        {
            var result = this.cateringCompanyService.GetAllCateringCompaniesAsync().Result;

            Assert.That(result, Has.Exactly(1).Matches<CateringCompanyViewModel>(
        c => c.Id == "EFD31B6C-2A3C-4989-824F-2387C9951234".ToLower() && c.Name == "ET SAM-DPD"));
            Assert.That(result, Has.Exactly(1).Matches<CateringCompanyViewModel>(
        c => c.Id == "8E91E660-535C-4F3A-B2FB-CC4E28682345".ToLower() && c.Name == "HealtyFoodForChildren"));

            Assert.That(result.Count(), Is.EqualTo(2));
        }
    }
}