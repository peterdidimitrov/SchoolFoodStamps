using Microsoft.EntityFrameworkCore;
using Moq;
using SchoolFoodStamps.Data;
using SchoolFoodStamps.Data.Common;
using SchoolFoodStamps.Data.Models;
using SchoolFoodStamps.Services.Data;
using SchoolFoodStamps.Services.Data.Interfaces;
using static SchoolFoodStamps.Services.Tests.DataBaseSeeder;

namespace SchoolFoodStamps.Services.Tests
{
    public class FoodStampStatusValidationServiceTests
    {
        private DbContextOptions<SchoolFoodStampsDbContext> dbOptions;
        private SchoolFoodStampsDbContext dbContext;
        private IFoodStampStatusValidationService foodStampStatusValidationService;


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

            Mock<IFoodStampService> foodStampServiceMock = new Mock<IFoodStampService>();

            repositoryMock.Setup(repo => repo.All<FoodStamp>())
                .Returns(this.dbContext.FoodStamps.AsQueryable());

            repositoryMock.Setup(r => r.SaveChangesAsync())
                .Returns(() => this.dbContext.SaveChangesAsync());

            this.foodStampStatusValidationService = new FoodStampStatusValidationService(foodStampServiceMock.Object, repositoryMock.Object);
        }

        [Test]
        public async Task ValidateFoodStampStatusesAsync_ShouldSetFoodStampStatusToExpired_WhenFoodStampIsExpired()
        {
            DateTime currentTime = new DateTime(2025, 1, 1, 16, 1, 0);

            await this.foodStampStatusValidationService.ValidateFoodStampStatusesAsync(currentTime);

            IEnumerable<FoodStamp> foodStamps = await this.dbContext.FoodStamps.Where(fs => fs.Status.ToString() == "Expired").ToListAsync();

            FoodStamp? foodStamp = await this.dbContext.FoodStamps.FirstOrDefaultAsync();

            Assert.That(foodStamp!.Status, Is.EqualTo(FoodStampStatus.Expired));
            Assert.That(foodStamps.Count(), Is.EqualTo(3));
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            this.dbContext.Database.EnsureDeleted();
            this.dbContext.Dispose();
        }
    }
}
