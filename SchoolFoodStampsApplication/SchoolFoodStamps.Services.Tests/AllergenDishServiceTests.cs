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
    public class AllergenDishServiceTests
    {
        private DbContextOptions<SchoolFoodStampsDbContext> dbOptions;
        private SchoolFoodStampsDbContext dbContext;
        private IAllergenDishService allergenDishService;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            this.dbOptions = new DbContextOptionsBuilder<SchoolFoodStampsDbContext>()
                .UseInMemoryDatabase("SchoolFoodStampInMemory" + Guid.NewGuid().ToString())
                //.EnableSensitiveDataLogging()
                //.LogTo(Console.WriteLine)
                .Options;

            this.dbContext = new SchoolFoodStampsDbContext(dbOptions);

            this.dbContext.Database.EnsureDeleted();

            SeedDataBase(this.dbContext);

            Mock<IRepository> repositoryMock = new Mock<IRepository>();

            repositoryMock.Setup(repo => repo.AllReadOnly<AllergenDish>())
                .Returns(this.dbContext.AllergenDishes.AsQueryable().AsNoTracking());

            repositoryMock.Setup(r => r.GetByIdAsync<AllergenDish>(It.IsAny<object>()))
                .Returns<object>(id => this.dbContext.AllergenDishes.FindAsync(id).AsTask());

            repositoryMock.Setup(r => r.SaveChangesAsync())
                .Returns(() => this.dbContext.SaveChangesAsync());

            //repositoryMock.Setup(r => r.Delete(It.IsAny<AllergenDish>()))
            //    .Callback<AllergenDish>(entity => this.dbContext.AllergenDishes.Remove(entity));

            this.allergenDishService = new AllergenDishService(repositoryMock.Object);
        }

        [Test]
        public async Task GetAllergenDishByDishIdAndAllergenIdAsyncReturnAllAllergenDishes()
        {
            AllergenDish? allergenDish = await this.allergenDishService.GetAllergenDishByDishIdAndAllergenIdAsync(1,  1);

            Assert.That(allergenDish!.DishId, Is.EqualTo(1));
            Assert.That(allergenDish!.AllergenId, Is.EqualTo(1));
        }

        [Test]
        public async Task AddAllergenToDishAsyncShouldAddAllergenToDish()
        {
            Dish? dish = await this.dbContext.Dishes.FirstOrDefaultAsync(d => d.Id == 1);

            Allergen? allergen = await this.dbContext.Allergens.FirstOrDefaultAsync(a => a.Id == 2);

            await this.allergenDishService.AddAllergenToDishAsync(dish!, allergen!);

            AllergenDish? allergenDish = await this.allergenDishService.GetAllergenDishByDishIdAndAllergenIdAsync(dish!.Id, allergen!.Id);

            Assert.That(allergenDish!.DishId, Is.EqualTo(dish.Id));
            Assert.That(allergenDish!.AllergenId, Is.EqualTo(allergen.Id));
        }

        //[Test]
        //public async Task RemoveAllergenFromDishAsyncShouldRemoveAllergenFromDish()
        //{
        //    Dish? dish = await this.dbContext.Dishes.FirstOrDefaultAsync(d => d.Id == 3);

        //    Allergen? allergen = await this.dbContext.Allergens.FirstOrDefaultAsync(a => a.Id == 9);

        //    AllergenDish? allergenDish = await this.allergenDishService.GetAllergenDishByDishIdAndAllergenIdAsync(dish!.Id, allergen!.Id);

        //    await this.allergenDishService.RemoveAllergenFromDishAsync(dish!, allergen!, allergenDish!);

        //    AllergenDish? removedAllergenDish = await this.allergenDishService.GetAllergenDishByDishIdAndAllergenIdAsync(dish!.Id, allergen!.Id);

        //    Assert.That(removedAllergenDish, Is.Null);
        //}

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            this.dbContext.Database.EnsureDeleted();
            this.dbContext.Dispose();
        }
    }
}
