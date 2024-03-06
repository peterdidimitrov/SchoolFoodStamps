using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SchoolFoodStamps.Services.Data.Interfaces;
using SchoolFoodStamps.Web.ViewModels.School;
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
    }
}
