using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace SchoolFoodStamps.Services.Data.Interfaces
{
    public class UserService : IUserService
    {
        private readonly RoleManager<IdentityRole<Guid>> roleManager;
        private readonly UserManager<ApplicationUser> userManager;

        public UserService(RoleManager<IdentityRole<Guid>> _roleManager, UserManager<ApplicationUser> userManager)
        {
            roleManager = _roleManager;
            this.userManager = userManager;

        }
        public async Task<bool> UserHasAnyRoleAsync(string userEmail)
        {
            IList<string>? userRoles = await userManager.GetRolesAsync(await userManager.FindByEmailAsync(userEmail));
            IList<string> rolesToCheck = await RolesForCheck();

            return userRoles.Any(role => rolesToCheck.Contains(role));
        }

        private async Task<List<string>> RolesForCheck()
        {
            return await roleManager.Roles.Select(r => r.Name).ToListAsync();
        }
    }
}
