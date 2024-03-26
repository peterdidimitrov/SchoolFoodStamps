using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SchoolFoodStamps.Data.Common;
using SchoolFoodStamps.Data.Models;
using SchoolFoodStamps.Services.Data.Interfaces;
using SchoolFoodStamps.Web.ViewModels.CateringCompany;
using SchoolFoodStamps.Web.ViewModels.School;

namespace SchoolFoodStamps.Services.Data
{
    public class CateringCompanyService : ICateringCompanyService
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IRepository repository;

        public CateringCompanyService(UserManager<ApplicationUser> userManager, IRepository repository)
        {
            this.userManager = userManager;
            this.repository = repository;
        }

        public async Task<IEnumerable<CateringCompanyViewModel>> GetAllCateringCompaniesAsync()
        {
            return await repository
               .AllReadOnly<CateringCompany>()
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

            await repository.AddAsync(cateringCompany);
            await repository.SaveChangesAsync();
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

        public async Task<CateringCompanyFormViewModel?> GetCateringCompanyByUserIdAsync(string userId)
        {
            return await repository
                .AllReadOnly<CateringCompany>()
                .Where(c => c.UserId == Guid.Parse(userId))
                .Select(c => new CateringCompanyFormViewModel()
                {
                    Id = c.Id.ToString(),
                    Name = c.Name,
                    Address = c.Address,
                    IdentificationNumber = c.IdentificationNumber,
                    PhoneNumber = c.User.PhoneNumber
                })
                .FirstOrDefaultAsync();
        }

        public async Task UpdateAsync(CateringCompanyFormViewModel formModel)
        {
            CateringCompany? catering = await repository.GetByIdAsync<CateringCompany>(Guid.Parse(formModel.Id));

            catering!.Name = formModel.Name;
            catering.Address = formModel.Address;
            catering.IdentificationNumber = formModel.IdentificationNumber;

            await repository.SaveChangesAsync();
        }
    }
}
