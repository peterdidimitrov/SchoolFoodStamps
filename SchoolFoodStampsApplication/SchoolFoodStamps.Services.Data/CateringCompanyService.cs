using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SchoolFoodStamps.Data.Common;
using SchoolFoodStamps.Data.Models;
using SchoolFoodStamps.Services.Data.Interfaces;
using SchoolFoodStamps.Web.ViewModels.CateringCompany;


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

        public async Task<CateringCompany?> GetCateringCompanyByUserIdAsync(string userId)
        {
            return await repository
                .AllReadOnly<CateringCompany>()
                .Include(c => c.Schools)
                .Include(c => c.FoodStamps)
                .Include(c => c.Menus)
                .Include(c => c.Dishes)
                .OrderBy(c => c.Name)
                .Where(c => c.UserId == Guid.Parse(userId))
                .Select(c => new CateringCompany()
                {
                    Id = c.Id,
                    Name = c.Name,
                    Address = c.Address,
                    IdentificationNumber = c.IdentificationNumber,
                    Menus = c.Menus,
                    Schools = c.Schools,
                    FoodStamps = c.FoodStamps,
                    Dishes = c.Dishes
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

        public async Task<string?> GetCateringCompanyIdAsync(string userId)
        {
            return await repository
                .AllReadOnly<CateringCompany>()
                .Where(c => c.UserId == Guid.Parse(userId))
                .Select(c => c.Id.ToString())
                .FirstOrDefaultAsync();
        }

        public async Task<string?> GetCateringCompanyIdBySchoolIdAsync(string schoolId)
        {
            return await repository
                .AllReadOnly<School>()
                .Where(s => s.Id == Guid.Parse(schoolId))
                .Select(s => s.CateringCompanyId.ToString())
                .FirstOrDefaultAsync();
        }

        public async Task<CateringCompany?> GetCateringCompanyByIdAsync(string cateringCompanyId)
        {
            return await repository
                .AllReadOnly<CateringCompany>()
                .Include(c => c.Schools)
                .Include(c => c.FoodStamps)
                .Include(c => c.Menus)
                .Include(c => c.Dishes)
                .OrderBy(c => c.Name)
                .Where(c => c.Id == Guid.Parse(cateringCompanyId))
                .Select(c => new CateringCompany()
                {
                    Id = c.Id,
                    Name = c.Name,
                    Address = c.Address,
                    IdentificationNumber = c.IdentificationNumber,
                    Menus = c.Menus,
                    Schools = c.Schools,
                    FoodStamps = c.FoodStamps,
                    Dishes = c.Dishes
                })
                .FirstOrDefaultAsync();
        }
    }
}
