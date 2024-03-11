using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SchoolFoodStamps.Web.ViewModels.Home;
using System.Diagnostics;
using static SchoolFoodStamps.Common.NotificationMessagesConstants;

namespace SchoolFoodStamps.Web.Controllers
{
    [Authorize(Roles = "Admin, CateringCompany, Parent, School")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> logger;
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly RoleManager<IdentityRole<Guid>> roleManager;

        public HomeController(ILogger<HomeController> _logger, SignInManager<ApplicationUser> _signInManager, UserManager<ApplicationUser> _userManager, RoleManager<IdentityRole<Guid>> _roleManager)
        {
            this.logger = _logger;
            this.signInManager = _signInManager;
            this.userManager = _userManager;
            this.roleManager = _roleManager;
        }

        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            if (signInManager.IsSignedIn(User))
            {
                ApplicationUser? currentUser = await userManager.GetUserAsync(User);
                string? userEmail = await userManager.GetEmailAsync(currentUser);

                bool hasAnyRole = await UserHasAnyRoleAsync(userManager, roleManager, userEmail, RolesForCheck());

                if (hasAnyRole)
                {
                    return View();
                }

                this.TempData[InformationMessage] = "You should customize your account profile. Please choose the role.";
                return View(nameof(Customization));
            }


            return View();
        }

        [AllowAnonymous]
        public async Task<IActionResult> Customization()
        {
            if (!signInManager.IsSignedIn(User))
            {
                return View(nameof(Index));
            }

            ApplicationUser? currentUser = await userManager.GetUserAsync(User);
            string? userEmail = await userManager.GetEmailAsync(currentUser);

            bool hasAnyRole = await UserHasAnyRoleAsync(userManager, roleManager, userEmail, RolesForCheck());

            if (hasAnyRole)
            {
                this.TempData[ErrorMessage] = "You already customize your account profile.";
                return View(nameof(Index));
            }

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        private async Task<bool> UserHasAnyRoleAsync(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole<Guid>> roleManager, string userEmail, params string[] rolesToCheck)
        {
            IList<string>? userRoles = await userManager.GetRolesAsync(await userManager.FindByEmailAsync(userEmail));
            IList<string>? roles = await roleManager.Roles.Select(r => r.Name).ToListAsync();

            return userRoles.Any(role => rolesToCheck.Contains(role));
        }


        private string[] RolesForCheck()
        {
            return new string[] { "School", "Parent", "CateringCompany" };
        }
    }
}
