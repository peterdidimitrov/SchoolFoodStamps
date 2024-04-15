using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SchoolFoodStamps.Data.Common;
using SchoolFoodStamps.Data.Models;
using SchoolFoodStamps.Services.Data.Interfaces;
using SchoolFoodStamps.Web.ViewModels.Parent;

namespace SchoolFoodStamps.Services.Data
{
    public class ParentService : IParentService
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IRepository repository;

        public ParentService(UserManager<ApplicationUser> userManager, IRepository repository)
        {
            this.userManager = userManager;
            this.repository = repository;
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

            await repository.AddAsync(parent);
            await repository.SaveChangesAsync();
        }

        public async Task<bool> ExistsByUserIdAsync(string userId)
        {
            return await repository
                .AllReadOnly<Parent>()
                .AnyAsync(p => p.UserId == Guid.Parse(userId));
        }

        public async Task<ParentFormViewModel?> GetParentByUserIdAsync(string userId)
        {
            return await repository
                .AllReadOnly<Parent>()
                .Where(p => p.UserId == Guid.Parse(userId))
                .Select(p => new ParentFormViewModel()
                {
                    Id = p.Id.ToString(),
                    FirstName = p.FirstName,
                    LastName = p.LastName,
                    Address = p.Address,
                    PhoneNumber = p.User.PhoneNumber,
                    UserId = p.UserId.ToString()
                })
                .FirstOrDefaultAsync();
        }

        public async Task<string?> GetParentIdAsync(string userId)
        {
            Parent? parent = await repository
                .AllReadOnly<Parent>()
                .FirstOrDefaultAsync(p => p.UserId == Guid.Parse(userId));

            if (parent == null)
            {
                return null;
            }

            return parent.Id.ToString();
        }

        public async Task UpdateAsync(ParentFormViewModel formModel)
        {
            Parent? parent = await repository.GetByIdAsync<Parent>(Guid.Parse(formModel.Id));

            parent!.FirstName = formModel.FirstName;
            parent.LastName = formModel.LastName;
            parent.Address = formModel.Address;

            await repository.SaveChangesAsync();
        }
    }
}
