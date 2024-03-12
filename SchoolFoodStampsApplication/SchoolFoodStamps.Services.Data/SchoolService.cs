using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SchoolFoodStamps.Data;
using SchoolFoodStamps.Data.Models;
using SchoolFoodStamps.Services.Data.Interfaces;
using SchoolFoodStamps.Web.ViewModels.School;

namespace SchoolFoodStamps.Services.Data
{
    public class SchoolService : ISchoolService
    {
        private readonly SchoolFoodStampsDbContext dbContext;
        private readonly UserManager<ApplicationUser> userManager;
        

        public SchoolService(SchoolFoodStampsDbContext _dbContext, UserManager<ApplicationUser> _userManager)
        {
            this.dbContext = _dbContext;
            this.userManager = _userManager;
        }

        public async Task CreateAsync(SchoolFormViewModel formModel)
        {
            School school = new School()
            {
                Name = formModel.Name,
                Address = formModel.Address,
                IdentificationNumber = formModel.IdentificationNumber,
                CateringCompanyId = Guid.Parse(formModel.CateringCompanyId),
                UserId = Guid.Parse(formModel.UserId)
            };

            ApplicationUser user = await userManager.FindByIdAsync(formModel.UserId);
            await userManager.AddToRoleAsync(user, "School");

            if (formModel.PhoneNumber != null)
            {
                user.PhoneNumber = formModel.PhoneNumber;
            }

            await dbContext.Schools.AddAsync(school);
            await dbContext.SaveChangesAsync();
        }

        public async Task<bool> ExistsByIdentificationNumberAsync(string identificationNumber)
        {
            return await dbContext
                .Schools
                .AnyAsync(s => s.IdentificationNumber == identificationNumber);
        }

        public async Task<bool> ExistsByUserIdAsync(string userId)
        {
            return await dbContext.Schools.AnyAsync(s => s.UserId == Guid.Parse(userId));
        }
    }
}
