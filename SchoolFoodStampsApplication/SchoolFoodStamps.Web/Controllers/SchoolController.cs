using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SchoolFoodStamps.Services.Data.Interfaces;
using SchoolFoodStamps.Web.ViewModels.School;
using System.Security.Claims;
using static SchoolFoodStamps.Common.NotificationMessagesConstants;

namespace SchoolFoodStamps.Web.Controllers
{
    [Authorize]
    public class SchoolController : BaseController
    {
        private readonly ILogger<HomeController> logger;
        private readonly ICateringCompanyService cateringCompanyService;
        private readonly ISchoolService schoolService;
        private readonly SignInManager<ApplicationUser> signInManager;

        public SchoolController(ICateringCompanyService cateringCompanyService, ISchoolService schoolService, ILogger<HomeController> logger, SignInManager<ApplicationUser> signInManager)
        {
            this.cateringCompanyService = cateringCompanyService;
            this.schoolService = schoolService;
            this.logger = logger;
            this.signInManager = signInManager;
        }

        [Authorize(Roles = "School")]
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> AddSchool()
        {
            if (!string.IsNullOrEmpty(User.GetRole()))
            {
                logger.LogWarning("User already has a role.");
                return this.CustomizationError();
            }

            SchoolFormViewModel formModel = new SchoolFormViewModel()
            {
                CateringCompanies = await this.cateringCompanyService.GetAllCateringCompaniesAsync()
            };

            return View(formModel);
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> AddSchool(SchoolFormViewModel model)
        {
            string? userId = User.GetId();

            if (userId == null)
            {
                logger.LogWarning("User is not found. The user's ID is null.");
                return this.CustomizationError();
            }

            bool hasAnySchoolWithCurrentUserId = await schoolService.ExistsByUserIdAsync(userId);

            if (hasAnySchoolWithCurrentUserId)
            {
                logger.LogWarning("User with id {0} already registered as a school.", userId);
                return this.CustomizationError();
            }

            if (!string.IsNullOrEmpty(User.GetRole()))
            {
                logger.LogWarning("User already has a role.");
                return this.CustomizationError();
            }

            bool schoolExists = await this.schoolService.ExistsByIdentificationNumberAsync(model.IdentificationNumber);

            if (schoolExists)
            {
                logger.LogWarning("School exists.");
                this.ModelState.AddModelError(nameof(model.IdentificationNumber), "School with this identification number already exists.");
            }

            bool companyExists = await this.cateringCompanyService
                .ExistsByIdAsync(model.CateringCompanyId);

            if (!companyExists)
            {
                logger.LogWarning("Catering company does not exist.");
                this.ModelState.AddModelError(nameof(model.CateringCompanyId), "Catering company does not exist.");
            }

            if (!ModelState.IsValid)
            {
                logger.LogWarning("Model state is not valid.");
                model.CateringCompanies = await this.cateringCompanyService
                    .GetAllCateringCompaniesAsync();
                return View(model);
            }

            try
            {
                model.UserId = userId;
                await this.schoolService.CreateAsync(model);
                logger.LogInformation("School created successfully.");
            }
            catch (Exception)
            {
                this.ModelState.AddModelError(string.Empty, "Unexpected error occurred while trying to add new school! Please try again or contact administrator.");

                model.CateringCompanies = await this.cateringCompanyService
                    .GetAllCateringCompaniesAsync();

                return View(model);
            }

            await signInManager.SignOutAsync();

            logger.LogInformation("User logged out.");
            this.TempData[SuccessMessage] = "You are created a profile successfully. Please sign in again.";

            return this.RedirectToAction("Index", "Home");
        }
    }
}
