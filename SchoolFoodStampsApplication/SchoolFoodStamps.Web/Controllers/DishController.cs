using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SchoolFoodStamps.Services.Data.Interfaces;
using SchoolFoodStamps.Web.ViewModels.Dish;
using System.Security.Claims;

namespace SchoolFoodStamps.Web.Controllers
{
    [Authorize(Roles = "CateringCompany")]
    public class DishController : BaseController
    {
        private readonly ILogger<MenuController> logger;
        private readonly ICateringCompanyService cateringCompanyService;
        private readonly IDishService dishService;
        private readonly IAllergenService allergenService;

        public DishController(ILogger<MenuController> logger, ICateringCompanyService cateringCompanyService, IDishService dishService, IAllergenService allergenService)
        {
            this.logger = logger;
            this.cateringCompanyService = cateringCompanyService;
            this.dishService = dishService;
            this.allergenService = allergenService;
        }

        public async Task<IActionResult> Index()
        {
            string? cateringCompanyId = await cateringCompanyService.GetCateringCompanyIdAsync(User.GetId());

            if (cateringCompanyId == null)
            {
                logger.LogError("Catering company not found.");
                return BadRequest();
            }

            IEnumerable<DishViewModel> dishes = await this.dishService.GetAllAsync(cateringCompanyId);

            return View(dishes);
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            DishFormViewModel dishFormViewModel = new DishFormViewModel()
            {
                Allergens = await this.allergenService.GetAllAsync()
            };

            return View(dishFormViewModel);
        }   
    }
}
