using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SchoolFoodStamps.Data;
using SchoolFoodStamps.Services.Data.Interfaces;
using SchoolFoodStamps.Web.ViewModels.Parent;

namespace SchoolFoodStamps.Services.Data
{
    public class ParentService : IParentService
    {
        private readonly SchoolFoodStampsDbContext dbContext;
        private readonly UserManager<ApplicationUser> userManager;

        public ParentService(SchoolFoodStampsDbContext _dbContext, UserManager<ApplicationUser> _userManager)
        {
            this.dbContext = _dbContext;
            this.userManager = _userManager;
        }

        public Task CreateAsync(ParentFormViewModel formModel)
        {
            throw new NotImplementedException();
        }

        //public async Task<bool> ExistsByUserIdAsync(string userId)
        //{
        //    return await userManager.Users.AnyAsync(u => u.Id == Guid.Parse(userId));
        //}
    }
}
