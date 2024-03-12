using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SchoolFoodStamps.Services.Data.Interfaces;
using SchoolFoodStamps.Web.ViewModels.Home;
using System.Diagnostics;
using static SchoolFoodStamps.Common.NotificationMessagesConstants;

namespace SchoolFoodStamps.Web.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> logger;
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly RoleManager<IdentityRole<Guid>> roleManager;
        private readonly IUserService userService;

        public HomeController(ILogger<HomeController> _logger, SignInManager<ApplicationUser> _signInManager, UserManager<ApplicationUser> _userManager, RoleManager<IdentityRole<Guid>> _roleManager, IUserService _userService)
        {
            this.logger = _logger;
            this.signInManager = _signInManager;
            this.userManager = _userManager;
            this.roleManager = _roleManager;
            this.userService = _userService;
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            if (signInManager.IsSignedIn(User))
            {
                ApplicationUser? currentUser = await userManager.GetUserAsync(User);
                string? userEmail = await userManager.GetEmailAsync(currentUser);

                bool hasAnyRole = await userService.UserHasAnyRoleAsync(userEmail);

                if (hasAnyRole)
                {
                    logger.LogInformation("User with email {0} is already customized.", userEmail);
                    return View();
                }

                logger.LogInformation("User with email {0} is not customized yet.", userEmail);

                this.TempData[InformationMessage] = "You should customize your account profile. Please choose the role.";
                return View(nameof(Customization));
            }

            return View();
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> Customization()
        {
            if (!signInManager.IsSignedIn(User))
            {
                return View(nameof(Index));
            }

            ApplicationUser? currentUser = await userManager.GetUserAsync(User);
            string? userEmail = await userManager.GetEmailAsync(currentUser);

            bool hasAnyRole = await userService.UserHasAnyRoleAsync(userEmail);

            if (hasAnyRole)
            {
                logger.LogInformation("User with email {0} is already customized.", userEmail);

                this.TempData[ErrorMessage] = "You already customized your profile.";
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
