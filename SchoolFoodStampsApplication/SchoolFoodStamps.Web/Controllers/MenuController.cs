using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SchoolFoodStamps.Services.Data.Interfaces;
using SchoolFoodStamps.Web.ViewModels.Menu;
using System.Security.Claims;

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
            else if(role == "Parent")
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
        public async Task<IActionResult> Add()
        {
            return View();
        }
    }
}
