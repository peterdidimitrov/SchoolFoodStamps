using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SchoolFoodStamps.Services.Data;
using SchoolFoodStamps.Services.Data.Interfaces;
using SchoolFoodStamps.Web.ViewModels.Parent;
using SchoolFoodStamps.Web.ViewModels.School;
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

        public ParentController(IParentService _parentService, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole<Guid>> roleManager, ILogger<HomeController> logger, IUserService userService)
        {
            this.parentService = _parentService;
            this.userManager = userManager;
            this.roleManager = roleManager;
            this.logger = logger;
            this.userService = userService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return this.RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            ApplicationUser? currentUser = await userManager.GetUserAsync(User);
            string? userEmail = await userManager.GetEmailAsync(currentUser);

            bool hasAnyRole = await userService.UserHasAnyRoleAsync(userEmail);

            if (hasAnyRole)
            {
                logger.LogWarning("User already has a role.");
                return this.CustomizationError();
            }

            ParentFormViewModel formModel = new ParentFormViewModel();

            return View(formModel);
        }

        [HttpPost]
        public async Task<IActionResult> Add(ParentFormViewModel model)
        {
            ApplicationUser? currentUser = await userManager.GetUserAsync(User);
            string? userEmail = await userManager.GetEmailAsync(currentUser);

            bool hasAnyParentWithCurrentUserId = await parentService.ExistsByUserIdAsync(currentUser.Id.ToString());

            if (hasAnyParentWithCurrentUserId)
            {
                logger.LogWarning("User with id {0} already registered as a parent.", currentUser.Id);
                return this.CustomizationError();
            }

            bool hasAnyRole = await userService.UserHasAnyRoleAsync(userEmail);

            if (hasAnyRole)
            {
                logger.LogWarning("User already has a role.");
                return this.CustomizationError();
            }

            try
            {
                string userId = GetUserId();
                model.UserId = userId;
                await this.parentService.CreateAsync(model);
                logger.LogInformation("Parent created successfully.");
            }
            catch (Exception)
            {
                this.ModelState.AddModelError(string.Empty, "Unexpected error occurred while trying to add new parent! Please try again or contact administrator.");

                return View(model);
            }

            this.TempData[SuccessMessage] = "Parent added successfully.";

            return this.RedirectToAction(nameof(Index));
        }

        private IActionResult CustomizationError()
        {
            this.TempData[ErrorMessage] = "You already customized your profile.";
            return this.RedirectToAction(nameof(Index));
        }
        private string GetUserId()
        {
            return User.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? string.Empty;
        }
    }
}
