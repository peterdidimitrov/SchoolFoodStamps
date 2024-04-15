using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Moq;
using SchoolFoodStamps.Data;
using SchoolFoodStamps.Data.Common;
using SchoolFoodStamps.Data.Models;
using SchoolFoodStamps.Services.Data;
using SchoolFoodStamps.Services.Data.Interfaces;
using SchoolFoodStamps.Web.ViewModels.Parent;
using static SchoolFoodStamps.Services.Tests.DataBaseSeeder;

namespace SchoolFoodStamps.Services.Tests
{
    public class ParentServiceTests
    {
        private DbContextOptions<SchoolFoodStampsDbContext> dbOptions;
        private SchoolFoodStampsDbContext dbContext;
        private IParentService parentService;

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

            repositoryMock.Setup(repo => repo.AllReadOnly<Parent>())
                .Returns(this.dbContext.Parents.AsQueryable().AsNoTracking());

            repositoryMock.Setup(repo => repo.All<Parent>())
                .Returns(this.dbContext.Parents.AsQueryable());

            repositoryMock.Setup(r => r.AddAsync(It.IsAny<Parent>()))
                .Callback((Parent parent) =>
                {
                    this.dbContext.Parents.Add(parent);
                });
            repositoryMock.Setup(r => r.SaveChangesAsync())
                .Returns(() => this.dbContext.SaveChangesAsync());

            repositoryMock.Setup(r => r.GetByIdAsync<Parent>(It.IsAny<object>()))
                .Returns<object>(id => this.dbContext.Parents.FindAsync(id).AsTask());

            var userManagerMock = new Mock<UserManager<ApplicationUser>>(Mock.Of<IUserStore<ApplicationUser>>(), null!, null!, null!, null!, null!, null!, null!, null!);
            userManagerMock.Setup(u => u.FindByIdAsync(It.IsAny<string>()))
                .ReturnsAsync((string userId) =>
                {
                    return new ApplicationUser { Id = Guid.Parse(userId), UserName = "testuUser" };
                });
            userManagerMock.Setup(u => u.AddToRoleAsync(It.IsAny<ApplicationUser>(), It.IsAny<string>()))
                .ReturnsAsync(IdentityResult.Success);

            this.parentService = new ParentService(userManagerMock.Object, repositoryMock.Object);
        }

        [Test]
        public async Task CreateAsyncShouldCreateParent()
        {
            ParentFormViewModel parent = new ParentFormViewModel()
            {
                FirstName = "Test",
                LastName = "Test",
                Address = "Test",
                UserId = Guid.NewGuid().ToString()
            };

            await this.parentService.CreateAsync(parent);

            Parent? createdParent = await this.dbContext.Parents.FirstOrDefaultAsync(p => p.UserId.ToString().ToLower() == parent.UserId.ToLower());

            Assert.That(createdParent!.FirstName, Is.EqualTo(parent.FirstName));
            Assert.That(createdParent.LastName, Is.EqualTo(parent.LastName));
            Assert.That(createdParent.Address, Is.EqualTo(parent.Address));
            Assert.That(createdParent.UserId, Is.EqualTo(Guid.Parse(parent.UserId)));
        }

        [Test]
        public async Task GetParentByUserIdAsyncShouldReturnParent()
        {
            string userId = "F4E56355-18AE-42A7-B082-25A2CF382D3D";

            ParentFormViewModel? createdParent = await this.parentService.GetParentByUserIdAsync(userId);

            Assert.That(createdParent!.FirstName, Is.EqualTo("Petar"));
            Assert.That(createdParent.LastName, Is.EqualTo("Ivanov"));
            Assert.That(createdParent.Address, Is.EqualTo("Sofia, Bulgaria"));
        }

        [Test]
        public async Task ExistsByUserIdAsyncShouldReturnTrueIfParentExists()
        {
            string userId = "F4E56355-18AE-42A7-B082-25A2CF382D3D";

            bool exists = await this.parentService.ExistsByUserIdAsync(userId);

            Assert.That(exists, Is.True);
        }

        [Test]
        public async Task ExistsByUserIdAsyncShouldReturnFalseIfParentDoesNotExist()
        {
            string userId = "F4E56355-18AE-42A7-B082-25A2CF385D3D";

            bool exists = await this.parentService.ExistsByUserIdAsync(userId);

            Assert.That(exists, Is.False);
        }

        [Test]
        public async Task GetParentIdAsyncShouldReturnParentId()
        {
            string userId = "4AA8654E-1465-4839-814C-A62A69D532E9";

            string? parentId = await this.parentService.GetParentIdAsync(userId);

            Assert.That(parentId, Is.EqualTo("FEC4E958-BF56-4247-A6C8-51FAE40D852D".ToLower()));
        }

        [Test]
        public async Task GetParentIdAsyncShouldReturnNullIfParentDoesNotExist()
        {
            string userId = "4AA8654E-1465-4839-814C-A62A69D532E8";

            string? parentId = await this.parentService.GetParentIdAsync(userId);

            Assert.That(parentId, Is.Null);
        }

        [Test]
        public async Task UpdateAsyncShouldUpdateParent()
        {
            ParentFormViewModel parent = new ParentFormViewModel()
            {
                Id = "63281334-434E-4327-B1B7-84B32A9D3D82",
                FirstName = "Test",
                LastName = "Test",
                Address = "Test",
            };

            await this.parentService.UpdateAsync(parent);

            Parent? updatedParent = await this.dbContext.Parents.FindAsync(Guid.Parse(parent.Id));

            Assert.That(updatedParent!.FirstName, Is.EqualTo(parent.FirstName));
            Assert.That(updatedParent.LastName, Is.EqualTo(parent.LastName));
            Assert.That(updatedParent.Address, Is.EqualTo(parent.Address));
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            this.dbContext.Database.EnsureDeleted();
        }
    }
}
