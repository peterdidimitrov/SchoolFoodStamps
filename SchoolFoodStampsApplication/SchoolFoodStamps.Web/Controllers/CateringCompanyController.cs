using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SchoolFoodStamps.Services.Data;
using SchoolFoodStamps.Services.Data.Interfaces;
using SchoolFoodStamps.Web.ViewModels.CateringCompany;
using SchoolFoodStamps.Web.ViewModels.School;
using System.Security.Claims;
using static SchoolFoodStamps.Common.NotificationMessagesConstants;

namespace SchoolFoodStamps.Web.Controllers
{
    [Authorize]
    public class CateringCompanyController : Controller
    {
        private readonly ILogger<HomeController> logger;
        private readonly ICateringCompanyService cateringCompanyService;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IUserService userService;

        public CateringCompanyController(ICateringCompanyService _cateringCompanyService, UserManager<ApplicationUser> _userManager, ILogger<HomeController> _logger, IUserService _userService)
        {
            this.cateringCompanyService = _cateringCompanyService;
            this.userManager = _userManager;
            this.logger = _logger;
            this.userService = _userService;
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

            CateringCompanyFormViewModel formModel = new CateringCompanyFormViewModel();

            return View(formModel);
        }

        [HttpPost]
        public async Task<IActionResult> Add(CateringCompanyFormViewModel model)
        {
            ApplicationUser? currentUser = await userManager.GetUserAsync(User);
            string? userEmail = await userManager.GetEmailAsync(currentUser);

            bool hasAnyCateringCompanyWithCurrentUserId = await cateringCompanyService.ExistsByUserIdAsync(currentUser.Id.ToString());

            if (hasAnyCateringCompanyWithCurrentUserId)
            {
                logger.LogWarning("User with id {0} already registered as a catering company.", currentUser.Id);
                return this.CustomizationError();
            }

            bool hasAnyRole = await userService.UserHasAnyRoleAsync(userEmail);

            if (hasAnyRole)
            {
                logger.LogWarning("User already has a role.");
                return this.CustomizationError();
            }

            bool cateringCompanyExists = await this.cateringCompanyService.ExistsByIdentificationNumberAsync(model.IdentificationNumber);

            if (cateringCompanyExists)
            {
                logger.LogWarning("Catering company exists.");
                this.ModelState.AddModelError(nameof(model.IdentificationNumber), "Catering company with this identification number already exists.");
            }

            if (!ModelState.IsValid)
            {
                logger.LogWarning("Model state is not valid.");
                return View(model);
            }

            try
            {
                string userId = GetUserId();
                model.UserId = userId;
                await this.cateringCompanyService.CreateAsync(model);
                logger.LogInformation("Catering company created successfully.");
            }
            catch (Exception)
            {
                this.ModelState.AddModelError(string.Empty, "Unexpected error occurred while trying to add new school! Please try again or contact administrator.");

                return View(model);
            }

            this.TempData[SuccessMessage] = "Catering company added successfully.";

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
