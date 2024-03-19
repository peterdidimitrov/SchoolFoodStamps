using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SchoolFoodStamps.Data;
using SchoolFoodStamps.Data.Common;
using SchoolFoodStamps.Data.Models;
using SchoolFoodStamps.Services.Data.Interfaces;
using SchoolFoodStamps.Web.ViewModels.CateringCompany;

namespace SchoolFoodStamps.Services.Data
{
    public class CateringCompanyService : ICateringCompanyService
    {
        private readonly SchoolFoodStampsDbContext dbContext;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IRepository repository;

        public CateringCompanyService(SchoolFoodStampsDbContext _dbContext, UserManager<ApplicationUser> _userManager, IRepository _repository)
        {
            dbContext = _dbContext;
            userManager = _userManager;
            repository = _repository;
        }

        public async Task<IEnumerable<CateringCompanyViewModel>> GetAllCateringCompaniesAsync()
        {
            return await repository
                .AllReadOnly<CateringCompany>()
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
            return await repository
                .AllReadOnly<CateringCompany>()
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
            return await repository
                .AllReadOnly<CateringCompany>()
                .AnyAsync(c => c.IdentificationNumber == identificationNumber);
        }

        public async Task<bool> ExistsByUserIdAsync(string userId)
        {
            return await repository
                .AllReadOnly<CateringCompany>()
                .AnyAsync(s => s.UserId == Guid.Parse(userId));
        }
    }
}
