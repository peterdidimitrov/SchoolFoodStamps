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
    public class ParentController : BaseController
    {
        private readonly ILogger<HomeController> logger;
        private readonly IParentService parentService;
        private readonly SignInManager<ApplicationUser> signInManager;

        public ParentController(IParentService parentService, ILogger<HomeController> logger, SignInManager<ApplicationUser> signInManager)
        {
            this.parentService = parentService;
            this.logger = logger;
            this.signInManager = signInManager;
        }
        
        [Authorize(Roles = "Parent")]
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddParent()
        {
            if (!string.IsNullOrEmpty(User.GetRole()))
            {
                logger.LogWarning("User already has a role.");
                return this.CustomizationError();
            }

            ParentFormViewModel formModel = new ParentFormViewModel();

            return View(formModel);
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> AddParent(ParentFormViewModel model)
        {
            string userId = User.GetId();

            bool hasAnyParentWithCurrentUserId = await parentService.ExistsByUserIdAsync(userId);

            if (hasAnyParentWithCurrentUserId)
            {
                logger.LogWarning("User with id {0} already registered as a parent.", userId);
                return this.CustomizationError();
            }

            if (!string.IsNullOrEmpty(User.GetRole()))
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
            this.TempData[SuccessMessage] = "You are created a profile successfully. Please sign in again.";

            return this.RedirectToAction("Index", "Home");
        }

        [HttpGet]
        [Authorize(Roles = "Parent")]
        public async Task<IActionResult> Edit()
        {
            string userId = User.GetId();

            ParentFormViewModel? model = await this.parentService.GetParentByUserIdAsync(userId);

            if (model == null)
            {
                logger.LogWarning("Pant not found.");
                this.ModelState.AddModelError(string.Empty, "Unexpected error occurred while trying to add new school! Please try again or contact administrator.");

                return BadRequest();
            }

            return View(model);
        }

        [HttpPost]
        [Authorize(Roles = "Parent")]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Edit(ParentFormViewModel formModel)
        {
            string userId = User.GetId();

            bool parentExists = await this.parentService.ExistsByUserIdAsync(userId);

            if (!parentExists)
            {
                logger.LogWarning("Parent not found.");
                this.ModelState.AddModelError(string.Empty, "Unexpected error occurred while trying to add new school! Please try again or contact administrator.");

                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                logger.LogWarning("Model state is not valid.");

                return View(formModel);
            }

            try
            {
                await this.parentService.UpdateAsync(formModel);
                logger.LogInformation("Parent updated successfully.");
                this.TempData[SuccessMessage] = "Personal info updated successfully.";
            }
            catch (Exception)
            {
                this.ModelState.AddModelError(string.Empty, "Unexpected error occurred while trying to add new school! Please try again or contact administrator.");

                return View(formModel);
            }

            return RedirectToAction("RedirectToIdentityManage", "Home");
        }
    }
}
