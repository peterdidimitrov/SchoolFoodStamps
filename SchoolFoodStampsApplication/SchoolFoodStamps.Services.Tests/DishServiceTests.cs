using Microsoft.EntityFrameworkCore;
using Moq;
using SchoolFoodStamps.Data;
using SchoolFoodStamps.Data.Common;
using SchoolFoodStamps.Data.Models;
using SchoolFoodStamps.Services.Data;
using SchoolFoodStamps.Services.Data.Interfaces;
using SchoolFoodStamps.Web.ViewModels.Dish;
using static SchoolFoodStamps.Services.Tests.DataBaseSeeder;

namespace SchoolFoodStamps.Services.Tests
{
    public class DishServiceTests
    {
        private DbContextOptions<SchoolFoodStampsDbContext> dbOptions;
        private SchoolFoodStampsDbContext dbContext;
        private IDishService dishService;

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

            repositoryMock.Setup(repo => repo.AllReadOnly<Dish>())
                .Returns(this.dbContext.Dishes.AsQueryable().AsNoTracking());

            repositoryMock.Setup(r => r.AddAsync(It.IsAny<Dish>()))
                .Callback<Dish>(dish => this.dbContext.Dishes.Add(dish));

            repositoryMock.Setup(r => r.SaveChangesAsync())
                .Returns(() => this.dbContext.SaveChangesAsync());

            repositoryMock.Setup(r => r.GetByIdAsync<Dish>(It.IsAny<object>()))
                .Returns<object>(id => this.dbContext.Dishes.FindAsync(id).AsTask());

            this.dishService = new DishService(repositoryMock.Object);
        }

        [Test]
        public async Task GetAllAsyncShouldReturnAllDishes()
        {
            CateringCompany cateringCompany = new CateringCompany
            {
                Id = Guid.Parse("EFD31B6C-2A3C-4989-824F-2387C9951234"),
                Name = "ET SAM-DPD",
                Address = null,
                IdentificationNumber = "121756888",
                UserId = Guid.Parse("FEC4E958-BF56-4247-A6C8-51FAE40D852D")
            };

            IEnumerable<DishViewModel> dishes = await this.dishService.GetAllAsync(cateringCompany.Id.ToString());

            Assert.That(dishes.Count(), Is.EqualTo(15));
            Assert.That(dishes.Last().Name, Is.EqualTo("Test Dish"));
        }

        [Test]
        public async Task GetByIdAsyncShouldReturnDish()
        {
            Dish? dish = await this.dishService.GetDishByIdAsync(1);

            Assert.That(dish!.Name, Is.EqualTo("Turkey and Cheese Sandwich"));
        }

        [Test]
        public async Task CreateAsyncShouldCreateDish()
        {
            DishFormViewModel dishFormViewModel = new DishFormViewModel
            {
                Name = "Test Dish",
                Description = "Test Description",
                Weight = "100",
                CateringCompanyId = "EFD31B6C-2A3C-4989-824F-2387C9951234"
            };

            await this.dishService.CreateAsync(dishFormViewModel);

            Assert.That(this.dbContext.Dishes.Count(), Is.EqualTo(16));
            Assert.That(this.dbContext.Dishes.Find(16)!.Name, Is.EqualTo("Test Dish"));
        }

        [Test]
        public async Task EditAsyncShouldEditDish()
        {
            DishFormViewModel dishFormViewModel = new DishFormViewModel
            {
                Name = "Test Dish",
                Description = "Test Description",
                Weight = "100",
                CateringCompanyId = "EFD31B6C-2A3C-4989-824F-2387C9951234"
            };

            Dish? dish = await this.dbContext.Dishes.FindAsync(2);

            await this.dishService.EditAsync(dishFormViewModel, dish!);

            Assert.That(this.dbContext.Dishes.Where(d => d.IsActive == true).Count(), Is.EqualTo(15));
            Assert.That(this.dbContext.Dishes.Find(2)!.Name, Is.EqualTo("Test Dish"));
        }

        [Test]
        public async Task DeleteAsyncShouldDeleteDish()
        {
            int result = await this.dishService.DeleteAsync(3);

            IEnumerable<Dish> dishes = await this.dbContext.Dishes.Where(d => d.IsActive == true).ToListAsync();

            Assert.That(result, Is.EqualTo(1));
            Assert.That(this.dbContext.Dishes.Count(), Is.EqualTo(16));
            Assert.That(this.dbContext.Dishes.Find(3)!.IsActive, Is.False);
            Assert.That(this.dbContext.Dishes.Find(3)!.Name, Is.EqualTo(string.Empty));
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            this.dbContext.Database.EnsureDeleted();
        }
    }
}
