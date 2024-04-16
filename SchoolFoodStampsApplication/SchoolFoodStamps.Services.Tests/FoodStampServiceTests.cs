using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using Moq;
using SchoolFoodStamps.Data;
using SchoolFoodStamps.Data.Common;
using SchoolFoodStamps.Data.Models;
using SchoolFoodStamps.Services.Data;
using SchoolFoodStamps.Services.Data.Interfaces;
using SchoolFoodStamps.Services.Data.Models.FoodStamps;
using SchoolFoodStamps.Web.ViewModels.FoodStamp;
using SchoolFoodStamps.Web.ViewModels.Student;
using System.Globalization;
using static SchoolFoodStamps.Services.Tests.DataBaseSeeder;

namespace SchoolFoodStamps.Services.Tests
{
    public class FoodStampServiceTests
    {
        private DbContextOptions<SchoolFoodStampsDbContext> dbOptions;
        private SchoolFoodStampsDbContext dbContext;
        private IFoodStampService foodStampService;

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

            repositoryMock.Setup(repo => repo.AllReadOnly<FoodStamp>())
                .Returns(this.dbContext.FoodStamps.AsQueryable().AsNoTracking());

            repositoryMock.Setup(r => r.GetByIdAsync<FoodStamp>(It.IsAny<object>()))
                .Returns<object>(id => this.dbContext.FoodStamps.FindAsync(id).AsTask());

            repositoryMock.Setup(r => r.AddAsync(It.IsAny<FoodStamp>()))
                .Callback((FoodStamp stamp) =>
                {
                    this.dbContext.FoodStamps.Add(stamp);
                });

            repositoryMock.Setup(r => r.SaveChangesAsync())
                .Returns(() => this.dbContext.SaveChangesAsync());

            this.foodStampService = new FoodStampService(repositoryMock.Object);
        }

        [Test]
        public async Task GetAllFoodStampsByStudentIdAsyncReturnAllFoodStamps()
        {
            AllFoodStampsQueryModel<StudentViewModel> allFoodStampsQueryModel = new AllFoodStampsQueryModel<StudentViewModel>
            {
                SearchId = "A1ABC1D5-3718-4639-AB42-D7A1E9A0FCB0",
            };

            AllFoodStampsFilteredAndPagedServiceModel model = await this.foodStampService.GetAllFoodStampsByStudentIdAsync(allFoodStampsQueryModel, "A1ABC1D5-3718-4639-AB42-D7A1E9A0FCB0");

            Assert.That(model.FoodStamps.Count, Is.EqualTo(1));
        }

        [Test]
        public async Task GetFoodStampByIdAsyncReturnFoodStamp()
        {
            FoodStamp? foodStamp = await this.foodStampService.GetFoodStampByIdAsync("FB33981C-AE8C-48EA-BF27-3DC5A763D7F9");

            Assert.That(foodStamp!.Id, Is.EqualTo(Guid.Parse("FB33981C-AE8C-48EA-BF27-3DC5A763D7F9")));
        }

        [Test]
        public async Task UpdateFoodStampAsyncUpdateFoodStamp()
        {
            DateTime expiryDate = DateTime.ParseExact("01/01/2025 00:00", "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            FoodStampFormViewModel model = new FoodStampFormViewModel
            {
                Id = "FB33981C-AE8C-48EA-BF27-3DC5A763D7F9",
                StudentId = "A1ABC1D5-3718-4639-AB42-D7A1E9A0FCB0",
                ExpiryDate = expiryDate.ToString("dd/MM/yyyy HH:mm"),
                RenewedDate = DateTime.UtcNow.ToString("dd/MM/yyyy HH:mm"),
                Status = "Renewed",
                MenuId = "1",
            };

            FoodStamp? foodStamp = await this.dbContext.FoodStamps.FindAsync(Guid.Parse("FB33981C-AE8C-48EA-BF27-3DC5A763D7F9"));

            await this.foodStampService.UpdateFoodStampAsync(foodStamp!, model);

            FoodStamp? renewedFoodStamp = await this.dbContext.FoodStamps.FindAsync(Guid.Parse("FB33981C-AE8C-48EA-BF27-3DC5A763D7F9"));

            Assert.That(renewedFoodStamp!.ExpiryDate, Is.EqualTo(expiryDate));
            Assert.That(renewedFoodStamp!.Status, Is.EqualTo(FoodStampStatus.Renewed));
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            this.dbContext.Database.EnsureDeleted();
            this.dbContext.Dispose();
        }
    }
}
