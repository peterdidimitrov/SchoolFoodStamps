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
    public class DishMenuServiceTests
    {
        private DbContextOptions<SchoolFoodStampsDbContext> dbOptions;
        private SchoolFoodStampsDbContext dbContext;
        private IDishMenuService dishMenuService;

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

            repositoryMock.Setup(repo => repo.AllReadOnly<DishMenu>())
                .Returns(this.dbContext.DishMenus.AsQueryable().AsNoTracking());

            repositoryMock.Setup(r => r.GetByIdAsync<DishMenu>(It.IsAny<object>()))
                .Returns<object>(id => this.dbContext.DishMenus.FindAsync(id).AsTask());

            repositoryMock.Setup(r => r.SaveChangesAsync())
                .Returns(() => this.dbContext.SaveChangesAsync());

            this.dishMenuService = new DishMenuService(repositoryMock.Object);
        }

        [Test]
        public async Task GetDishMenuByMenuIdAndDishIdAsyncReturnDishMenu()
        {
            DishMenu? dishMenu = await this.dishMenuService.GetDishMenuByMenuIdAndDishIdAsync(2, 1);

            Assert.That(dishMenu!.DishId, Is.EqualTo(2));
            Assert.That(dishMenu!.MenuId, Is.EqualTo(1));
        }

        [Test]
        public async Task AddDishToMenuAsyncShouldAddDishToMenu()
        {
            Dish? dish = await this.dbContext.Dishes.FirstOrDefaultAsync(d => d.Id == 1);

            Menu? menu = await this.dbContext.Menus.FirstOrDefaultAsync(m => m.Id == 1);

            await this.dishMenuService.AddDishToMenuAsync(dish!, menu!);

            DishMenu? dishMenu = await this.dishMenuService.GetDishMenuByMenuIdAndDishIdAsync(dish!.Id, menu!.Id);

            Assert.That(dishMenu!.DishId, Is.EqualTo(dish.Id));
            Assert.That(dishMenu!.MenuId, Is.EqualTo(menu.Id));
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            this.dbContext.Database.EnsureDeleted();
            this.dbContext.Dispose();
        }
    }
}
