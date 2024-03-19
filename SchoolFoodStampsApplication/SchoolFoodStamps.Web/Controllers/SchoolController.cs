﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SchoolFoodStamps.Services.Data.Interfaces;
using SchoolFoodStamps.Web.ViewModels.School;
using System.Security.Claims;
using static SchoolFoodStamps.Common.HashHelper;
using static SchoolFoodStamps.Common.NotificationMessagesConstants;

namespace SchoolFoodStamps.Web.Controllers
{
    [Authorize]
    public class SchoolController : Controller
    {
        private readonly ILogger<HomeController> logger;
        private readonly ICateringCompanyService cateringCompanyService;
        private readonly ISchoolService schoolService;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IUserService userService;
        private readonly SignInManager<ApplicationUser> signInManager;

        public SchoolController(ICateringCompanyService _cateringCompanyService, ISchoolService _schoolService, UserManager<ApplicationUser> _userManager, ILogger<HomeController> _logger, IUserService _userService, SignInManager<ApplicationUser> _signInManager)
        {
            this.cateringCompanyService = _cateringCompanyService;
            this.schoolService = _schoolService;
            this.userManager = _userManager;
            this.logger = _logger;
            this.userService = _userService;
            this.signInManager = _signInManager;
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
            bool hasAnyRole = await userService.UserHasAnyRoleAsync(User.GetEmail()!);

            if (hasAnyRole)
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

            bool hasAnyRole = await userService.UserHasAnyRoleAsync(User.GetEmail()!);

            if (hasAnyRole)
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

            logger.LogInformation("Catering company id: {0}", model.CateringCompanyId);

            model.CateringCompanyId = ReverseHashedStringToId(model.CateringCompanyId);

            logger.LogInformation("Catering company id: {0}", model.CateringCompanyId);

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
            this.TempData[InformationMessage] = "You are created a profile successfully. Please sign in again.";

            return this.RedirectToAction("Index", "Home");
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
