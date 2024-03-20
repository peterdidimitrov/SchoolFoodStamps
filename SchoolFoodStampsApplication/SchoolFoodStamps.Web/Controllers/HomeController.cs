using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SchoolFoodStamps.Services.Data.Interfaces;
using SchoolFoodStamps.Web.ViewModels.Home;
using System.Diagnostics;
using System.Security.Claims;
using static SchoolFoodStamps.Common.NotificationMessagesConstants;

namespace SchoolFoodStamps.Web.Controllers
{
    [Authorize]
    public class HomeController : BaseController
    {
        private readonly ILogger<HomeController> logger;
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly RoleManager<IdentityRole<Guid>> roleManager;
        private readonly IUserService userService;

        public HomeController(ILogger<HomeController> logger, SignInManager<ApplicationUser> signInManager, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole<Guid>> roleManager, IUserService userService)
        {
            this.logger = logger;
            this.signInManager = signInManager;
            this.userManager = userManager;
            this.roleManager = roleManager;
            this.userService = userService;
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            if (signInManager.IsSignedIn(User))
            {
                string? userEmail = User.GetEmail()!;

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

        [HttpGet]
        public async Task<IActionResult> Customization()
        {
            string? userEmail = User.GetEmail()!;

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
