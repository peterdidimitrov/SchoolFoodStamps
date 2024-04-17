using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using static SchoolFoodStamps.Common.GeneralApplicationConstants;
using static SchoolFoodStamps.Common.NotificationMessagesConstants;

namespace SchoolFoodStamps.Web.Controllers
{
    [Authorize]
    public class HomeController : BaseController
    {
        private readonly ILogger<HomeController> logger;
        private readonly SignInManager<ApplicationUser> signInManager;

        public HomeController(ILogger<HomeController> logger, SignInManager<ApplicationUser> signInManager)
        {
            this.logger = logger;
            this.signInManager = signInManager;
        }

        [AllowAnonymous]
        [HttpGet]
        public IActionResult Index()
        {
            if (this.User.IsInRole(AdministratorRoleName))
            {
                return this.RedirectToAction("Index", "Home", new { Area = AdminAreaName });
            }
            if (signInManager.IsSignedIn(User))
            {

                string userEmail = User.GetEmail();

                if (!string.IsNullOrEmpty(User.GetRole()))
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
        public IActionResult Customization()
        {
            string userEmail = User.GetEmail();

            if (User.GetRole() != null)
            {
                logger.LogInformation("User with email {0} is already customized.", userEmail);

                this.TempData[ErrorMessage] = "You already customized your profile.";
                return View(nameof(Index));
            }

            return View();
        }

        [HttpGet]
        public IActionResult RedirectToIdentityManage()
        {
            return Redirect("/Identity/Account/Manage");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error(int statusCode)
        {
            if (statusCode == 500)
            {
                return View("Error500");
            }

            if (statusCode == 404)
            {
                return View("Error404");
            }

            if (statusCode == 403)
            {
                return View("Error403");
            }

            if (statusCode == 401)
            {
                return View("Error401");
            }

            if (statusCode == 400)
            {
                return View("Error400");
            }

            return View();
        }
    }
}
