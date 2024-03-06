using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;

namespace SchoolFoodStamps.Data.Roles
{
    public static class InsertRoles
    {
        public static async Task AddRoles(IServiceProvider serviceProvider)
        {
            using (RoleManager<IdentityRole<Guid>> roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole<Guid>>>())
            {
                string[] roles = new[] { "Admin", "CateringCompany", "School", "Parent" };

                foreach (var role in roles)
                {
                    if (!await roleManager.RoleExistsAsync(role))
                        await roleManager.CreateAsync(new IdentityRole<Guid>(role));
                }
            }
        }
    }
}
