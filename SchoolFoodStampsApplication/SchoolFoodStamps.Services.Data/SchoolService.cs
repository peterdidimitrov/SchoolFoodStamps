using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SchoolFoodStamps.Data.Common;
using SchoolFoodStamps.Data.Models;
using SchoolFoodStamps.Services.Data.Interfaces;
using SchoolFoodStamps.Web.ViewModels.School;

namespace SchoolFoodStamps.Services.Data
{
    public class SchoolService : ISchoolService
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IRepository repository;
        

        public SchoolService(UserManager<ApplicationUser> userManager, IRepository repository)
        {
            this.userManager = userManager;
            this.repository = repository;
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

            CateringCompany? cateringCompany = await repository.GetByIdAsync<CateringCompany>(Guid.Parse(formModel.CateringCompanyId));

            cateringCompany!.Schools.Add(school);

            await repository.AddAsync(school);
            await repository.SaveChangesAsync();
        }

        public async Task<bool> ExistsByIdAsync(string Id)
        {
            return await repository
                .AllReadOnly<School>()
                .AnyAsync(s => s.Id.ToString() == Id);
        }

        public async Task<bool> ExistsByIdentificationNumberAsync(string identificationNumber)
        {
            return await repository
                .AllReadOnly<School>()
                .AnyAsync(s => s.IdentificationNumber == identificationNumber);
        }

        public async Task<bool> ExistsByUserIdAsync(string userId)
        {
            return await repository
                .AllReadOnly<School>()
                .AnyAsync(s => s.UserId == Guid.Parse(userId));
        }

        public async Task<IEnumerable<SchoolViewModel>> GetAllSchoolsAsync()
        {
            return await repository
               .AllReadOnly<School>()
               .OrderBy(c => c.Name)
               .Select(c => new SchoolViewModel()
               {
                   Id = c.Id.ToString(),
                   Name = c.Name
               })
               .ToListAsync();
        }
    }
}
