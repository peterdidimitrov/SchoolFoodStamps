using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SchoolFoodStamps.Data.Models;
using SchoolFoodStamps.Services.Data.Interfaces;
using SchoolFoodStamps.Web.ViewModels.Menu;
using System.Security.Claims;
using static SchoolFoodStamps.Common.NotificationMessagesConstants;

namespace SchoolFoodStamps.Web.Controllers
{
    [Authorize]
    public class MenuController : BaseController
    {
        private readonly ILogger<MenuController> logger;
        private readonly ICateringCompanyService cateringCompanyService;
        private readonly IMenuService menuService;

        public MenuController(IMenuService menuService, ILogger<MenuController> logger, ICateringCompanyService cateringCompanyService)
        {
            this.menuService = menuService;
            this.logger = logger;
            this.cateringCompanyService = cateringCompanyService;
        }

        [HttpGet]
        [Authorize(Roles = "CateringCompany, Parent")]
        public async Task<IActionResult> Index(string schoolId)
        {
            string role = User.GetRole();
            string? cateringCompanyId = string.Empty;

            if (role == "CateringCompany")
            {
                cateringCompanyId = await cateringCompanyService.GetCateringCompanyIdAsync(User.GetId());

                if (cateringCompanyId == null)
                {
                    logger.LogError("Catering company not found.");
                    return BadRequest();
                }
            }
            else if (role == "Parent")
            {
                cateringCompanyId = await cateringCompanyService.GetCateringCompanyIdBySchoolIdAsync(schoolId);

                if (cateringCompanyId == null)
                {
                    logger.LogError("Catering company not found.");
                    return BadRequest();
                }
            }

            IEnumerable<MenuViewModel> menus = await this.menuService.GetAllAsync(cateringCompanyId);

            return View(menus);
        }

        [HttpGet]
        [Authorize(Roles = "CateringCompany")]
        public IActionResult Add()
        {
            MenuFormViewModel model = new MenuFormViewModel()
            {
                DayOfWeek = string.Empty
            };

            return View(model);
        }

        [HttpPost]
        [Authorize(Roles = "CateringCompany")]
        public async Task<IActionResult> Add(MenuFormViewModel model)
        {
            CateringCompany? cateringCompany = await cateringCompanyService.GetCateringCompanyByUserIdAsync(User.GetId());

            if (cateringCompany == null)
            {
                logger.LogError("Catering company not found.");
                return BadRequest();
            }

            model.CateringCompanyId = cateringCompany.Id.ToString();

            if (cateringCompany.Menus.Any(m => m.DayOfWeek.ToString() == model.DayOfWeek))
            {
                this.TempData[ErrorMessage] = $"Menu for {model.DayOfWeek} is already added!";
                return View(model);
            }

            if (!ModelState.IsValid)
            {
                logger.LogWarning("Invalid model state.");
                return View(model);
            }

            try
            {
                await this.menuService.CreateAsync(model);
            }
            catch (Exception)
            {
                this.TempData[ErrorMessage] = "Unexpected error occurred while trying to add new dish! Please try again or contact administrator.";

                return View(model);
            }

            this.TempData[SuccessMessage] = "Menu added successfully!";

            return RedirectToAction(nameof(Index));
        }
    }
}
