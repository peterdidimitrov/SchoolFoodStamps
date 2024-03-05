using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SchoolFoodStamps.Web.Infrastructure.Extensions;
using SchoolFoodStamps.Web.ViewModels.Home;
using System.Diagnostics;

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
                var currentUser = await userManager.GetUserAsync(User);
                var userEmail = await userManager.GetEmailAsync(currentUser);

                IList<string> userRoles = await userManager.GetRolesAsync(await userManager.FindByEmailAsync(userEmail));

                IList<IdentityRole<Guid>> roles = await roleManager.Roles.ToListAsync();

                foreach (string role in userRoles)
                {
                    if (roles.Any(r => r.Name == role))
                    {
                        return View();
                    }
                }

                return View(nameof(Customization));
            }

            return View();
        }

        [AllowAnonymous]
        public IActionResult Customization()
        {
            if (!signInManager.IsSignedIn(User))
            {
                return View(nameof(Index));
            }

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
