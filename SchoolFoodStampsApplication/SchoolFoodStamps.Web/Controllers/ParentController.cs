using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SchoolFoodStamps.Services.Data.Interfaces;
using SchoolFoodStamps.Web.ViewModels.Parent;
using System.Security.Claims;
using static SchoolFoodStamps.Common.NotificationMessagesConstants;

namespace SchoolFoodStamps.Web.Controllers
{
    [Authorize]
    public class ParentController : Controller
    {
        private readonly ILogger<HomeController> logger;
        private readonly IParentService parentService;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly RoleManager<IdentityRole<Guid>> roleManager;
        private readonly IUserService userService;
        private readonly SignInManager<ApplicationUser> signInManager;

        public ParentController(IParentService _parentService, UserManager<ApplicationUser> _userManager, RoleManager<IdentityRole<Guid>> _roleManager, ILogger<HomeController> _logger, IUserService _userService, SignInManager<ApplicationUser> _signInManager)
        {
            this.parentService = _parentService;
            this.userManager = _userManager;
            this.roleManager = _roleManager;
            this.logger = _logger;
            this.userService = _userService;
            this.signInManager = _signInManager;
        }
        
        [Authorize(Roles = "Parent")]
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> AddParent()
        {
            bool hasAnyRole = await userService.UserHasAnyRoleAsync(User.GetEmail()!);

            if (hasAnyRole)
            {
                logger.LogWarning("User already has a role.");
                return this.CustomizationError();
            }

            ParentFormViewModel formModel = new ParentFormViewModel();

            return View(formModel);
        }

        [HttpPost]
        public async Task<IActionResult> AddParent(ParentFormViewModel model)
        {
            string? userId = User.GetId();

            if (userId == null)
            {
                logger.LogWarning("User is not found. The user's ID is null.");
                return this.CustomizationError();
            }

            bool hasAnyParentWithCurrentUserId = await parentService.ExistsByUserIdAsync(userId);

            if (hasAnyParentWithCurrentUserId)
            {
                logger.LogWarning("User with id {0} already registered as a parent.", userId);
                return this.CustomizationError();
            }

            bool hasAnyRole = await userService.UserHasAnyRoleAsync(User.GetEmail()!);

            if (hasAnyRole)
            {
                logger.LogWarning("User already has a role.");
                return this.CustomizationError();
            }

            if (!ModelState.IsValid)
            {
                logger.LogWarning("Model state is not valid.");
                return View(model);
            }

            try
            {
                model.UserId = userId;
                await this.parentService.CreateAsync(model);
                logger.LogInformation("Parent created successfully.");
            }
            catch (Exception)
            {
                this.ModelState.AddModelError(string.Empty, "Unexpected error occurred while trying to add new parent! Please try again or contact administrator.");

                return View(model);
            }

            await signInManager.SignOutAsync();

            logger.LogInformation("User logged out.");
            this.TempData[InformationMessage] = "You are created a profile successfully. Please sign in again.";

            return this.RedirectToAction("Index", "Home");
        }

        private IActionResult CustomizationError()
        {
            this.TempData[ErrorMessage] = "You already customized your profile.";
            return this.RedirectToAction(nameof(Index));
        }
    }
}
