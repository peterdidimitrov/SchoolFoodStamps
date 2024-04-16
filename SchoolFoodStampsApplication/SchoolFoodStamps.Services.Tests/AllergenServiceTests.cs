using Microsoft.EntityFrameworkCore;
using Moq;
using SchoolFoodStamps.Data;
using SchoolFoodStamps.Data.Common;
using SchoolFoodStamps.Data.Models;
using SchoolFoodStamps.Services.Data;
using SchoolFoodStamps.Services.Data.Interfaces;
using SchoolFoodStamps.Web.ViewModels.Allergen;
using static SchoolFoodStamps.Services.Tests.DataBaseSeeder;

namespace SchoolFoodStamps.Services.Tests
{
    public class AllergenServiceTests
    {
        private DbContextOptions<SchoolFoodStampsDbContext> dbOptions;
        private SchoolFoodStampsDbContext dbContext;
        private IAllergenService allergenService;

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

            repositoryMock.Setup(repo => repo.AllReadOnly<Allergen>())
                .Returns(this.dbContext.Allergens.AsQueryable().AsNoTracking());

            repositoryMock.Setup(r => r.GetByIdAsync<Allergen>(It.IsAny<object>()))
                .Returns<object>(id => this.dbContext.Allergens.FindAsync(id).AsTask());

            this.allergenService = new AllergenService(repositoryMock.Object);
        }

        [Test]
        public async Task GetAllAsyncShouldReturnAllAllergens()
        {
            IEnumerable<AllergenViewModel> allergens = await this.allergenService.GetAllAsync();

            Assert.That(allergens.Count(), Is.EqualTo(14));
        }
        [Test]
        public async Task GetByIdAsyncShouldReturnAllergen()
        {
            Allergen? allergen = await this.allergenService.GetByIdAsync("1");

            Assert.That(allergen!.Name, Is.EqualTo("Gluten"));
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            this.dbContext.Database.EnsureDeleted();
            this.dbContext.Dispose();
        }
    }
}
