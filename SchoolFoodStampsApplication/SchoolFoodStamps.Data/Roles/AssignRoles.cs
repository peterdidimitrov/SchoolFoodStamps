using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;

namespace SchoolFoodStamps.Data.Roles
{
    public static class AssignRoles
    {
        public static async Task AssignRolesToUsers(IServiceProvider serviceProvider)
        {
            using (UserManager<ApplicationUser> userManager = serviceProvider.GetRequiredService<UserManager<ApplicationUser>>())
            {
                await SeedRoleToUser("dimitrichko_admin@org.bg", "Admin", userManager);
                await SeedRoleToUser("test@test.bg", "CateringCompany", userManager);
                await SeedRoleToUser("pesho@abv.bg", "CateringCompany", userManager);
                await SeedRoleToUser("patriarh.evtimi@abv.bg", "School", userManager);
                await SeedRoleToUser("hristo.botev@abv.bg", "School", userManager);
                await SeedRoleToUser("pesho@yahoo.com", "Parent", userManager);
                await SeedRoleToUser("gosho@yahoo.com", "Parent", userManager);
            }
            static async Task SeedRoleToUser(string email, string roleName, UserManager<ApplicationUser> userManager)
            {
                ApplicationUser existingUser = await userManager.FindByEmailAsync(email);
                
                if (existingUser == null)
                {
                    var newUser = new ApplicationUser
                    {
                        UserName = email,
                        Email = email
                    };

                    var result = await userManager.CreateAsync(newUser, "123456!");
                    if (result.Succeeded)
                    {
                        await userManager.AddToRoleAsync(newUser, roleName);
                    }
                }
                else
                {
                    await userManager.AddToRoleAsync(existingUser, roleName);
                }
            }
        }
    }
}
