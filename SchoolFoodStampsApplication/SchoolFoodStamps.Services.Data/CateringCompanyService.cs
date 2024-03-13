using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SchoolFoodStamps.Data;
using SchoolFoodStamps.Data.Models;
using SchoolFoodStamps.Services.Data.Interfaces;
using SchoolFoodStamps.Web.ViewModels.CateringCompany;

namespace SchoolFoodStamps.Services.Data
{
    public class CateringCompanyService : ICateringCompanyService
    {
        private readonly SchoolFoodStampsDbContext dbContext;
        private readonly UserManager<ApplicationUser> userManager;

        public CateringCompanyService(SchoolFoodStampsDbContext _dbContext, UserManager<ApplicationUser> _userManager)
        {
            this.dbContext = _dbContext;
            this.userManager = _userManager;
        }

        public async Task<IEnumerable<CateringCompanyViewModel>> GetAllCateringCompaniesAsync()
        {
            return await dbContext
               .CateringCompanies
               .AsNoTracking()
               .OrderBy(c => c.Name)
               .Select(c => new CateringCompanyViewModel()
               {
                   Id = c.Id.ToString(),
                   Name = c.Name
               })
               .ToListAsync();
        }

        public async Task<bool> ExistsByIdAsync(string Id)
        {
            return await dbContext
                .CateringCompanies
                .AnyAsync(c => c.Id.ToString() == Id);
        }

        public async Task CreateAsync(CateringCompanyFormViewModel formModel)
        {
            CateringCompany cateringCompany = new CateringCompany()
            {
                Name = formModel.Name,
                Address = formModel.Address,
                IdentificationNumber = formModel.IdentificationNumber,
                UserId = Guid.Parse(formModel.UserId)
            };

            ApplicationUser user = await userManager.FindByIdAsync(formModel.UserId);
            await userManager.AddToRoleAsync(user, "CateringCompany");

            if (formModel.PhoneNumber != null)
            {
                user.PhoneNumber = formModel.PhoneNumber;
            }

            await dbContext.CateringCompanies.AddAsync(cateringCompany);
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
