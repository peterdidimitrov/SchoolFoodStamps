using Microsoft.EntityFrameworkCore;
using Moq;
using SchoolFoodStamps.Data;
using SchoolFoodStamps.Data.Common;
using SchoolFoodStamps.Data.Models;
using SchoolFoodStamps.Services.Data;
using SchoolFoodStamps.Services.Data.Interfaces;
using SchoolFoodStamps.Web.ViewModels.Menu;
using static SchoolFoodStamps.Services.Tests.DataBaseSeeder;

namespace SchoolFoodStamps.Services.Tests
{
    public class MenuServiceTests
    {
        private DbContextOptions<SchoolFoodStampsDbContext> dbOptions;
        private SchoolFoodStampsDbContext dbContext;
        private IMenuService menuService;

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

            repositoryMock.Setup(repo => repo.AllReadOnly<Menu>())
                .Returns(this.dbContext.Menus.AsQueryable().AsNoTracking());

            repositoryMock.Setup(repositoryMock => repositoryMock.AddAsync(It.IsAny<Menu>()))
                .Callback<Menu>(menu => this.dbContext.Menus.Add(menu));

            repositoryMock.Setup(r => r.GetByIdAsync<Menu>(It.IsAny<object>()))
                .Returns<object>(id => this.dbContext.Menus.FindAsync(id).AsTask());

            repositoryMock.Setup(r => r.SaveChangesAsync())
                .Returns(() => this.dbContext.SaveChangesAsync());

            this.menuService = new MenuService(repositoryMock.Object);
        }

        [Test]
        public async Task GetMenuByIdAsyncReturnMenu()
        {
            Menu menu = this.dbContext.Menus.First();

            Menu? result = await this.menuService.GetMenuByIdAsync(menu.Id);

            Assert.That(result!.Id, Is.EqualTo(menu.Id));
        }

        [Test]
        public async Task CreateAsyncShouldCreateMenu()
        {
            MenuFormViewModel menuFormViewModel = new MenuFormViewModel
            {
                DayOfWeek = "Monday",
                CateringCompanyId = Guid.NewGuid().ToString()
            };

            await this.menuService.CreateAsync(menuFormViewModel);

            Assert.That(this.dbContext.Menus.Count(), Is.EqualTo(6));
            Assert.That(this.dbContext.Menus.Last().DayOfWeek, Is.EqualTo(CustomDayOfWeek.Monday));
        }

        [Test]
        public async Task DeleteAsyncShouldDeleteMenu()
        {
            Menu? menu = this.dbContext.Menus.FirstOrDefault(m => m.Id == 5);

            int result = await this.menuService.DeleteAsync(menu!.Id);

            Menu? deletedMenu = this.dbContext.Menus.FirstOrDefault(m => m.Id == 5);

            Assert.That(result, Is.EqualTo(1));
            Assert.That(this.dbContext.Menus.Count(), Is.EqualTo(6));
            Assert.That(deletedMenu!.IsActive, Is.False);
        }

        [Test]
        public async Task EditAsyncShouldEditMenu()
        {
            MenuFormViewModel menuFormViewModel = new MenuFormViewModel
            {
                Id = "1",
                DayOfWeek = "Tuesday"
            };

            int result = await this.menuService.EditAsync(menuFormViewModel);

            Menu? menu = this.dbContext.Menus.FirstOrDefault(m => m.Id == 1);

            Assert.That(result, Is.EqualTo(1));
            Assert.That(menu!.DayOfWeek, Is.EqualTo(CustomDayOfWeek.Tuesday));
        }

        [Test]
        public async Task ExistsByIdAsyncShouldReturnTrue()
        {
            bool result = await this.menuService.ExistsByIdAsync(1);

            Assert.That(result, Is.True);
        }

        [Test]
        public async Task GetAllAsyncShouldReturnAllMenus()
        {
            IEnumerable<MenuViewModel> menus = await this.menuService.GetAllAsync("EFD31B6C-2A3C-4989-824F-2387C9951234");

            Menu? menu = this.dbContext.Menus.First();

            Assert.That(menus.Count(), Is.EqualTo(4));
            Assert.That(menu.DayOfWeek, Is.EqualTo(CustomDayOfWeek.Tuesday));
        }

        [Test]
        public async Task GetAllAsyncShouldReturnEmptyCollection()
        {
            IEnumerable<MenuViewModel> menus = await this.menuService.GetAllAsync("EFD31B6C-2A3C-4989-824F-2387C9951235");

            Assert.That(menus.Count(), Is.EqualTo(0));
        }

        [Test]
        public async Task GetMenuByCateringCompanyIdAndDayOfWeekAsyncShouldReturnMenu()
        {
            Menu? menu = await this.menuService.GetMenuByCateringCompanyIdAndDayOfWeekAsync("EFD31B6C-2A3C-4989-824F-2387C9951235", CustomDayOfWeek.Tuesday);
        }

        [Test]
        public async Task GetMenuByCateringCompanyIdAndDayOfWeekAsyncShouldReturnNull()
        {
            Menu? menu = await this.menuService.GetMenuByCateringCompanyIdAndDayOfWeekAsync("EFD31B6C-2A3C-4989-824F-2387C9951234", CustomDayOfWeek.Monday);

            Assert.That(menu, Is.Null);
        }

        [Test]
        public async Task GetMenuDetailsByIdAsyncShouldReturnMenuDetails()
        {
            MenuViewModel? menu = await this.menuService.GetMenuDetailsByIdAsync(1);

            Assert.That(menu!.Id, Is.EqualTo(1));
        }

        [Test]
        public async Task GetMenuDetailsByIdAsyncShouldReturnNull()
        {
            MenuViewModel? menu = await this.menuService.GetMenuDetailsByIdAsync(7);

            Assert.That(menu, Is.Null);
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            this.dbContext.Database.EnsureDeleted();
            this.dbContext.Dispose();
        }
    }
}
