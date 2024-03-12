using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SchoolFoodStamps.Data;
using SchoolFoodStamps.Data.Models;
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

        public async Task CreateAsync(ParentFormViewModel formModel)
        {
            Parent  parent = new Parent()
            {
                FirstName = formModel.FirstName,
                LastName = formModel.LastName,
                Address = formModel.Address,
                UserId = Guid.Parse(formModel.UserId)
            };

            ApplicationUser user = await userManager.FindByIdAsync(formModel.UserId);
            await userManager.AddToRoleAsync(user, "Parent");

            if (formModel.PhoneNumber != null)
            {
                user.PhoneNumber = formModel.PhoneNumber;
            }

            await dbContext.Parents.AddAsync(parent);
            await dbContext.SaveChangesAsync();
        }

        public async Task<bool> ExistsByUserIdAsync(string userId)
        {
            return await dbContext.Parents.AnyAsync(p => p.UserId == Guid.Parse(userId));
        }
    }
}
