using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SchoolFoodStamps.Services.Data.Interfaces;
using SchoolFoodStamps.Web.ViewModels.School;
using System.Security.Claims;
using static SchoolFoodStamps.Common.NotificationMessagesConstants;

namespace SchoolFoodStamps.Web.Controllers
{
    [Authorize]
    public class SchoolController : Controller
    {
        private readonly ICateringCompanyService cateringCompanyService;
        private readonly ISchoolService schoolService;

        public SchoolController(ICateringCompanyService _cateringCompanyService, ISchoolService _schoolService)
        {
            this.cateringCompanyService = _cateringCompanyService;
            this.schoolService = _schoolService;

        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            bool isOnRole = (User.IsInRole("School") || User.IsInRole("Parent") || User.IsInRole("CateringCompany"));

            if (isOnRole)
            {
                this.TempData[ErrorMessage] = "You already customize your account profile";
                return this.RedirectToAction("Index", "Home");
            }

            SchoolFormViewModel formModel = new SchoolFormViewModel()
            {
                CateringCompanies = await this.cateringCompanyService.GetAllCateringCompaniesAsync()
            };

            return View(formModel);
        }

        [HttpPost]
        public async Task<IActionResult> Add(SchoolFormViewModel model)
        {
            bool isOnRole = (User.IsInRole("School") || User.IsInRole("Parent") || User.IsInRole("CateringCompany"));

            if (isOnRole)
            {
                this.TempData[ErrorMessage] = "You already customize your account profile";
                return this.RedirectToAction("Index", "Home");
            }

            bool companyExists = await this.cateringCompanyService
                .ExistsByIdAsync(model.CateringCompanyId);

            if (!companyExists)
            {
                this.ModelState.AddModelError(nameof(model.CateringCompanyId), "Catering company does not exist");
            }

            if (!ModelState.IsValid)
            {
                model.CateringCompanies = await this.cateringCompanyService
                    .GetAllCateringCompaniesAsync();
                return View(model);
            }

            try
            {
                string userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                model.UserId = userId;
                await this.schoolService.CreateAsync(model);
            }
            catch (Exception)
            {
                this.ModelState.AddModelError(string.Empty, "Unexpected error  occurred while trying to add new school! Please try again or contact administrator");

                model.CateringCompanies = await this.cateringCompanyService
                    .GetAllCateringCompaniesAsync();

                return View(model);
            }

            this.TempData[SuccessMessage] = "School added successfully";

            return this.RedirectToAction("Index", "Home");
        }
    }
}
