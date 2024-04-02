using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SchoolFoodStamps.Services.Data.Interfaces;
using SchoolFoodStamps.Web.ViewModels.Menu;

namespace SchoolFoodStamps.Web.Controllers
{
    [Authorize]
    public class MenuController : BaseController
    {
        private readonly ILogger<MenuController> logger;
        private readonly IMenuService menuService;

        public MenuController(IMenuService menuService, ILogger<MenuController> logger)
        {
            this.menuService = menuService;
            this.logger = logger;
        }

        [HttpGet]
        [Authorize(Roles = "CateringCompany, Parent")]
        public async Task<IActionResult> Index()
        {
            IEnumerable<MenuViewModel> menus = await this.menuService.GetAllAsync();

            return View(menus);
        }

        [HttpGet]
        [Authorize(Roles = "CateringCompany")]
        public async Task<IActionResult> Add()
        {
            return View();
        }
    }
}
