using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SchoolFoodStamps.Data.Models;
using SchoolFoodStamps.Services.Data.Interfaces;
using SchoolFoodStamps.Web.ViewModels.Menu;
using System.Security.Claims;
using static SchoolFoodStamps.Common.NotificationMessagesConstants;

namespace SchoolFoodStamps.Web.Controllers
{
    [Authorize(Roles = "CateringCompany")]
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
        public async Task<IActionResult> Add()
        {
            CateringCompany? cateringCompany = await cateringCompanyService.GetCateringCompanyByUserIdAsync(User.GetId());

            if (cateringCompany == null)
            {
                logger.LogError("Catering company not found.");
                return BadRequest();
            }

            if (cateringCompany.Menus.Where(m => m.IsActive == true).Count() >= 5)
            {
                this.TempData[ErrorMessage] = $"You can't add more than {cateringCompany.Menus.Count} menus!";
                return RedirectToAction(nameof(Index));
            }

            MenuFormViewModel model = new MenuFormViewModel()
            {
                DayOfWeek = string.Empty
            };

            return View(model);
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Add(MenuFormViewModel model)
        {
            CateringCompany? cateringCompany = await cateringCompanyService.GetCateringCompanyByUserIdAsync(User.GetId());

            if (cateringCompany == null)
            {
                logger.LogError("Catering company not found.");
                return BadRequest();
            }

            model.CateringCompanyId = cateringCompany.Id.ToString();

            if (cateringCompany.Menus.Where(m => m.IsActive == true).Any(m => m.DayOfWeek.ToString() == model.DayOfWeek))
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

        [HttpGet]
        public async Task<IActionResult> Edit(string id)
        {
            CateringCompany? cateringCompany = await cateringCompanyService.GetCateringCompanyByUserIdAsync(User.GetId());

            if (cateringCompany == null)
            {
                logger.LogError("Catering company not found.");
                return BadRequest();
            }

            Menu? menu = await this.menuService.GetByIdAsync(int.Parse(id));

            if (menu == null)
            {
                logger.LogError("Menu not found.");
                return BadRequest();
            }

            if (menu.CateringCompanyId != cateringCompany.Id)
            {
                logger.LogWarning("Unauthorized access.");
                return Unauthorized();
            }

            MenuFormViewModel model = new MenuFormViewModel()
            {
                Id = menu.Id.ToString(),
                DayOfWeek = menu.DayOfWeek.ToString()
            };

            return View(model);
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Edit(MenuFormViewModel model, string id)
        {
            CateringCompany? cateringCompany = await cateringCompanyService.GetCateringCompanyByUserIdAsync(User.GetId());

            if (cateringCompany == null)
            {
                logger.LogError("Catering company not found.");
                return BadRequest();
            }

            Menu? menu = await this.menuService.GetByIdAsync(int.Parse(id));

            if (menu == null)
            {
                logger.LogError("Menu not found.");
                return BadRequest();
            }

            if (menu.CateringCompanyId != cateringCompany.Id)
            {
                logger.LogWarning("Unauthorized access.");
                return Unauthorized();
            }

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
                await this.menuService.EditAsync(model);
            }
            catch (Exception)
            {
                this.TempData[ErrorMessage] = "Unexpected error occurred while trying to edit menu! Please try again or contact administrator.";

                return View(model);
            }

            this.TempData[SuccessMessage] = "Menu edited successfully!";

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Delete(string id)
        {
            CateringCompany? cateringCompany = await cateringCompanyService.GetCateringCompanyByUserIdAsync(User.GetId());

            if (cateringCompany == null)
            {
                logger.LogError("Catering company not found.");
                return BadRequest();
            }

            Menu? menu = await this.menuService.GetByIdAsync(int.Parse(id));

            if (menu == null)
            {
                logger.LogError("Menu not found.");
                return BadRequest();
            }

            if (menu.CateringCompanyId != cateringCompany.Id)
            {
                logger.LogWarning("Unauthorized access.");
                return Unauthorized();
            }

            MenuDeleteViewModel model = new MenuDeleteViewModel()
            {
                Id = menu.Id.ToString(),
                DayOfWeek = menu.DayOfWeek.ToString()
            };

            return View(model);
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> DeletePost(MenuDeleteViewModel model)
        {
            CateringCompany? cateringCompany = await cateringCompanyService.GetCateringCompanyByUserIdAsync(User.GetId());

            if (cateringCompany == null)
            {
                logger.LogError("Catering company not found.");
                return BadRequest();
            }

            Menu? menu = await this.menuService.GetByIdAsync(int.Parse(model.Id));

            if (menu == null)
            {
                logger.LogError("Menu not found.");
                return BadRequest();
            }

            if (menu.CateringCompanyId != cateringCompany.Id)
            {
                logger.LogWarning("Unauthorized access.");
                return Unauthorized();
            }

            try
            {
                await this.menuService.DeleteAsync(int.Parse(model.Id));
            }
            catch (Exception)
            {
                this.TempData[ErrorMessage] = "Unexpected error occurred while trying to delete menu! Please try again or contact administrator.";

                return View(model);
            }

            this.TempData[SuccessMessage] = "Menu deleted successfully!";

            return RedirectToAction(nameof(Index));
        }
    }
}
