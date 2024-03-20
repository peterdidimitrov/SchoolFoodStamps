﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SchoolFoodStamps.Services.Data.Interfaces;
using SchoolFoodStamps.Web.ViewModels.CateringCompany;
using System.Security.Claims;
using static SchoolFoodStamps.Common.NotificationMessagesConstants;

namespace SchoolFoodStamps.Web.Controllers
{
    [Authorize]
    public class CateringCompanyController : BaseController
    {
        private readonly ILogger<HomeController> logger;
        private readonly ICateringCompanyService cateringCompanyService;
        private readonly SignInManager<ApplicationUser> signInManager;

        public CateringCompanyController(ICateringCompanyService cateringCompanyService, ILogger<HomeController> logger, SignInManager<ApplicationUser> signInManager)
        {
            this.cateringCompanyService = cateringCompanyService;
            this.logger = logger;
            this.signInManager = signInManager;
        }

        [Authorize(Roles = "CateringCompany")]
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddCatering()
        {
            if (!string.IsNullOrEmpty(User.GetRole()))
            {
                logger.LogWarning("User already has a role.");
                return this.CustomizationError();
            }

            CateringCompanyFormViewModel formModel = new CateringCompanyFormViewModel();

            return View(formModel);
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> AddCatering(CateringCompanyFormViewModel model)
        {
            string userId = User.GetId();

            bool hasAnyCateringCompanyWithCurrentUserId = await cateringCompanyService.ExistsByUserIdAsync(userId);

            if (hasAnyCateringCompanyWithCurrentUserId)
            {
                logger.LogWarning("User with id {0} already registered as a catering company.", userId);
                return this.CustomizationError();
            }

            if (!string.IsNullOrEmpty(User.GetRole()))
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
                model.UserId = userId;
                await this.cateringCompanyService.CreateAsync(model);
                logger.LogInformation("Catering company created successfully.");
            }
            catch (Exception)
            {
                this.ModelState.AddModelError(string.Empty, "Unexpected error occurred while trying to add new catering company! Please try again or contact administrator.");

                return View(model);
            }

            await signInManager.SignOutAsync();

            logger.LogInformation("User logged out.");
            this.TempData[SuccessMessage] = "You are created a profile successfully. Please sign in again.";

            return this.RedirectToAction("Index", "Home");
        }
    }
}
