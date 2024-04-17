using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SchoolFoodStamps.Data.Common;
using SchoolFoodStamps.Data.Models;
using SchoolFoodStamps.Services.Data.Interfaces;
using SchoolFoodStamps.Web.ViewModels.User;

namespace SchoolFoodStamps.Services.Data
{
    public class UserService : IUserService
    {
        private readonly IRepository repository;
        private readonly UserManager<ApplicationUser> userManager;

        public UserService(IRepository repository, UserManager<ApplicationUser> userManager)
        {
            this.repository = repository;
            this.userManager = userManager;
        }

        public async Task<IEnumerable<UserViewModel>> AllAsync()
        {
            List<UserViewModel> allUsers = await this.repository
                .AllReadOnly<ApplicationUser>()
                .Select(u => new UserViewModel()
                {
                    Id = u.Id.ToString(),
                    Email = u.Email,
                    PhoneNumber = u.PhoneNumber,
                })
                .ToListAsync();

            foreach (UserViewModel user in allUsers)
            {
                ApplicationUser currentUser = await userManager.FindByIdAsync(user.Id);

                IList<string> roles = await userManager.GetRolesAsync(currentUser);

                if (roles.Contains("Parent"))
                {
                    Parent? parent = this.repository
                        .AllReadOnly<Parent>()
                        .FirstOrDefault(p => p.UserId.ToString() == user.Id);

                    if (parent != null)
                    {
                        user.FullName = parent.FirstName + " " + parent.LastName;
                    }
                    else
                    {
                        user.FullName = string.Empty;
                    }
                }

                if (roles.Contains("CatringCompany"))
                {
                    CateringCompany? cateringCompany = this.repository
                        .AllReadOnly<CateringCompany>()
                        .FirstOrDefault(c => c.UserId.ToString() == user.Id);

                    if (cateringCompany != null)
                    {
                        user.FullName = cateringCompany.Name;
                    }
                    else
                    {
                        user.FullName = string.Empty;
                    }
                }

                if (roles.Contains("School"))
                {
                    School? school = this.repository
                        .AllReadOnly<School>()
                        .FirstOrDefault(c => c.UserId.ToString() == user.Id);

                    if (school != null)
                    {
                        user.FullName = school.Name;
                    }
                    else
                    {
                        user.FullName = string.Empty;
                    }
                }
            }

            return allUsers;
        }

        public async Task<string> GetFullNameByEmailAsync(string email)
        {
            ApplicationUser? user = await this.repository
                        .AllReadOnly<ApplicationUser>()
                        .FirstOrDefaultAsync(u => u.Email == email);

            if (user != null)
            {
                return await GetTheUserName(user);
            }

            return string.Empty;
        }

        public async Task<string> GetFullNameByIdAsync(string userId)
        {
            ApplicationUser? user = await this.repository
                        .AllReadOnly<ApplicationUser>()
                        .FirstOrDefaultAsync(u => u.Id.ToString() == userId);

            if (user != null)
            {
                return await GetTheUserName(user);
            }

            return string.Empty;
        }

        private async Task<string> GetTheUserName(ApplicationUser? user)
        {
            IList<string> roles = await userManager.GetRolesAsync(user!);

            if (roles.Any())
            {
                if (roles.Contains("Parent"))
                {
                    Parent? parent = this.repository
                        .AllReadOnly<Parent>()
                        .FirstOrDefault(p => p.UserId == user!.Id);

                    if (parent != null)
                    {
                        return $"{parent.FirstName} {parent.LastName}";
                    }
                    else
                    {
                        return string.Empty;
                    }
                }

                if (roles.Contains("CatringCompany"))
                {
                    CateringCompany? cateringCompany = this.repository
                        .AllReadOnly<CateringCompany>()
                        .FirstOrDefault(c => c.UserId == user!.Id);

                    if (cateringCompany != null)
                    {
                        return $"{cateringCompany.Name}";
                    }
                    else
                    {
                        return string.Empty;
                    }
                }

                if (roles.Contains("School"))
                {
                    School? school = this.repository
                        .AllReadOnly<School>()
                        .FirstOrDefault(c => c.UserId == user!.Id);

                    if (school != null)
                    {
                        return $"{school.Name}";
                    }
                    else
                    {
                        return string.Empty;
                    }
                }
            }
            return string.Empty;
        }
    }
}
