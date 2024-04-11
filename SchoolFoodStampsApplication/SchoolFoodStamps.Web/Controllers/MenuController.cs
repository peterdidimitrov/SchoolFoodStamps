using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SchoolFoodStamps.Data.Models;
using SchoolFoodStamps.Services.Data.Interfaces;
using SchoolFoodStamps.Web.ViewModels.Menu;
using SchoolFoodStamps.Web.ViewModels.DishMenu;
using System.Security.Claims;
using static SchoolFoodStamps.Common.NotificationMessagesConstants;
using SchoolFoodStamps.Web.ViewModels.Dish;
using SchoolFoodStamps.Web.ViewModels.Parent;

namespace SchoolFoodStamps.Web.Controllers
{
    [Authorize]
    public class MenuController : BaseController
    {
        private readonly ILogger<MenuController> logger;
        private readonly ICateringCompanyService cateringCompanyService;
        private readonly IMenuService menuService;
        private readonly IDishService dishService;
        private readonly IDishMenuService dishMenuService;
        private readonly ISchoolService schoolService;
        private readonly IStudentService studentService;
        private readonly IParentService parentService;

        public MenuController(IMenuService menuService, ILogger<MenuController> logger, ICateringCompanyService cateringCompanyService, IDishService dishService, IDishMenuService dishMenuService, ISchoolService schoolService, IStudentService studentService, IParentService parentService)
        {
            this.menuService = menuService;
            this.logger = logger;
            this.cateringCompanyService = cateringCompanyService;
            this.dishService = dishService;
            this.dishMenuService = dishMenuService;
            this.schoolService = schoolService;
            this.studentService = studentService;
            this.parentService = parentService;
        }

        [HttpGet]
        [Authorize(Roles = "CateringCompany, Parent")]
        public async Task<IActionResult> Index(string searchId)
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
                Guid studentId;
                Student? student;

                if (Guid.TryParse(searchId, out studentId))
                {
                    student = await studentService.GetStudentByIdAsync(studentId);

                    if (student == null)
                    {
                        logger.LogError("Student not found.");
                        return BadRequest();
                    }
                }
                else
                {
                    logger.LogError("Invalid student id.");
                    TempData[ErrorMessage] = "Choose a student!";
                    return RedirectToAction(nameof(Index), "FoodStamp");
                }

                cateringCompanyId = await cateringCompanyService.GetCateringCompanyIdBySchoolIdAsync(student.SchoolId.ToString());

                if (cateringCompanyId == null)
                {
                    logger.LogError("Catering company not found.");
                    return BadRequest();
                }
            }

            IEnumerable<MenuViewModel> menus = await this.menuService.GetAllAsync(cateringCompanyId);

            if (User.GetRole() == "Parent")
            {
                foreach (MenuViewModel menu in menus)
                {
                    menu.SearchId = searchId;
                }
            }

            return View(menus);
        }

        [HttpGet]
        [Authorize(Roles = "CateringCompany")]
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
        [Authorize(Roles = "Parent")]
        public async Task<IActionResult> Details(string id)
        {
            ParentFormViewModel? parent = await parentService.GetParentByUserIdAsync(User.GetId());

            if (parent == null)
            {
                logger.LogError("Parent not found.");
                return BadRequest();
            }

            string[] ids = id.Split(" ");
            string menuId = ids[0];
            string studentId = ids[1];
            string cateringCompanyId = ids[2];

            Menu? menu = await this.menuService.GetMenuByIdAsync(int.Parse(menuId));

            if (menu == null)
            {
                logger.LogError("Menu not found.");
                return BadRequest();
            }

            CateringCompany? cateringCompany = await cateringCompanyService.GetCateringCompanyByIdAsync(cateringCompanyId);

            if (cateringCompany == null)
            {
                logger.LogError("Catering company not found.");
                return BadRequest();
            }

            if (!cateringCompany.Menus.Where(m => m.IsActive == true).Any(m => m.Id == menu.Id))
            {
                logger.LogWarning("Unauthorized access.");
                return Unauthorized();
            }

            Student? student = await studentService.GetStudentByIdAsync(Guid.Parse(studentId));

            if (student == null)
            {
                logger.LogError("Student not found.");
                return BadRequest();
            }

            if (!cateringCompany.Schools.Any(s => s.Id == student.SchoolId))
            {
                logger.LogWarning("Unauthorized access.");
                return Unauthorized();
            }

            try
            {
                MenuViewModel? model = await this.menuService.GetMenuDetailsByIdAsync(int.Parse(menuId));

                if (model == null)
                {
                    this.TempData[ErrorMessage] = "Unexpected error occurred while trying to get menu details! Please try again or contact administrator.";
                    return RedirectToAction(nameof(Index));
                }

                model.SearchId = studentId;


                return View(model);
            }
            catch (Exception)
            {
                this.TempData[ErrorMessage] = "Unexpected error occurred while trying to get dishes! Please try again or contact administrator.";

                return RedirectToAction(nameof(Index));
            }
        }

        [HttpGet]
        [Authorize(Roles = "CateringCompany")]
        public async Task<IActionResult> Edit(string id)
        {
            CateringCompany? cateringCompany = await cateringCompanyService.GetCateringCompanyByUserIdAsync(User.GetId());

            if (cateringCompany == null)
            {
                logger.LogError("Catering company not found.");
                return BadRequest();
            }

            Menu? menu = await this.menuService.GetMenuByIdAsync(int.Parse(id));

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
        [Authorize(Roles = "CateringCompany")]
        public async Task<IActionResult> Edit(MenuFormViewModel model, string id)
        {
            CateringCompany? cateringCompany = await cateringCompanyService.GetCateringCompanyByUserIdAsync(User.GetId());

            if (cateringCompany == null)
            {
                logger.LogError("Catering company not found.");
                return BadRequest();
            }

            Menu? menu = await this.menuService.GetMenuByIdAsync(int.Parse(id));

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
        [Authorize(Roles = "CateringCompany")]
        public async Task<IActionResult> Delete(string id)
        {
            CateringCompany? cateringCompany = await cateringCompanyService.GetCateringCompanyByUserIdAsync(User.GetId());

            if (cateringCompany == null)
            {
                logger.LogError("Catering company not found.");
                return BadRequest();
            }

            Menu? menu = await this.menuService.GetMenuByIdAsync(int.Parse(id));

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
        [Authorize(Roles = "CateringCompany")]
        public async Task<IActionResult> DeletePost(MenuDeleteViewModel model)
        {
            CateringCompany? cateringCompany = await cateringCompanyService.GetCateringCompanyByUserIdAsync(User.GetId());

            if (cateringCompany == null)
            {
                logger.LogError("Catering company not found.");
                return BadRequest();
            }

            Menu? menu = await this.menuService.GetMenuByIdAsync(int.Parse(model.Id));

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

        [HttpGet]
        [Authorize(Roles = "CateringCompany")]
        public async Task<IActionResult> AddDishToMenu(string id)
        {
            CateringCompany? cateringCompany = await cateringCompanyService.GetCateringCompanyByUserIdAsync(User.GetId());

            if (cateringCompany == null)
            {
                logger.LogError("Catering company not found.");
                return BadRequest();
            }

            Menu? menu = await this.menuService.GetMenuByIdAsync(int.Parse(id));

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

            if (menu.DishesMenus.Count() >= 3)
            {
                this.TempData[ErrorMessage] = $"You can't add more than {menu.DishesMenus.Count()} dishes to menu!";
                return RedirectToAction(nameof(Index));
            }

            IEnumerable<DishViewModel> dishes = await this.dishService.GetAllAsync(cateringCompany.Id.ToString());

            if (dishes == null)
            {
                this.TempData[ErrorMessage] = "Unexpected error occurred while trying to get dishes! Please try again or contact administrator.";

                return RedirectToAction(nameof(Index));
            }

            if (dishes.Count() == 0)
            {
                this.TempData[ErrorMessage] = "You don't have any dishes added! Please add some dishes first.";

                return RedirectToAction(nameof(Index), "Dish");
            }

            AddDishToMenuFormModel model = new AddDishToMenuFormModel()
            {
                Dishes = dishes
            };

            return View(model);
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        [Authorize(Roles = "CateringCompany")]
        public async Task<IActionResult> AddDishToMenu(AddDishToMenuFormModel model, string id)
        {
            CateringCompany? cateringCompany = await cateringCompanyService.GetCateringCompanyByUserIdAsync(User.GetId());

            if (cateringCompany == null)
            {
                logger.LogError("Catering company not found.");
                return BadRequest();
            }

            Menu? menu = await this.menuService.GetMenuByIdAsync(int.Parse(id));

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

            Dish? dish = await this.dishService.GetDishByIdAsync(int.Parse(model.DishId));

            if (dish == null)
            {
                logger.LogError("Dish not found.");
                return BadRequest();
            }

            DishMenu? dishMenu = await this.dishMenuService.GetDishMenuByMenuIdAndDishIdAsync(int.Parse(model.DishId), int.Parse(id));

            if (dishMenu != null)
            {
                if (dishMenu.MenuId == menu.Id && dishMenu.DishId == dish.Id)
                {
                    this.TempData[ErrorMessage] = "Dish is already added to menu!";
                    model.Dishes = await this.dishService.GetAllAsync(cateringCompany.Id.ToString());
                    return View(model);
                }
            }

            if (!ModelState.IsValid)
            {
                logger.LogWarning("Invalid model state.");
                model.Dishes = await this.dishService.GetAllAsync(cateringCompany.Id.ToString());
                return View(model);
            }

            try
            {
                await this.dishMenuService.AddDishToMenuAsync(dish, menu);
            }
            catch (Exception)
            {
                this.TempData[ErrorMessage] = "Unexpected error occurred while trying to add dish to menu! Please try again or contact administrator.";
                model.Dishes = await this.dishService.GetAllAsync(cateringCompany.Id.ToString());
                return View(model);
            }

            this.TempData[SuccessMessage] = "Dish added to menu successfully!";

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        [Authorize(Roles = "CateringCompany")]
        public async Task<IActionResult> RemoveDishFromMenu(string id)
        {
            string[] ids = id.Split(" ");
            string menuId = ids[0];
            string dishId = ids[1];

            CateringCompany? cateringCompany = await cateringCompanyService.GetCateringCompanyByUserIdAsync(User.GetId());

            if (cateringCompany == null)
            {
                logger.LogError("Catering company not found.");
                return BadRequest();
            }

            Menu? menu = await this.menuService.GetMenuByIdAsync(int.Parse(menuId));

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

            Dish? dish = await this.dishService.GetDishByIdAsync(int.Parse(dishId));

            if (dish == null)
            {
                logger.LogError("Dish not found.");
                return BadRequest();
            }

            DishMenuViewModel model = new DishMenuViewModel()
            {
                MenuId = menuId,
                DishId = dishId,
                MenuDayOfWeek = menu.DayOfWeek.ToString(),
                DishName = dish.Name!
            };

            return View(model);
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        [Authorize(Roles = "CateringCompany")]
        public async Task<IActionResult> RemoveDishFromMenuPost(DishMenuViewModel model)
        {
            CateringCompany? cateringCompany = await cateringCompanyService.GetCateringCompanyByUserIdAsync(User.GetId());

            if (cateringCompany == null)
            {
                logger.LogError("Catering company not found.");
                return BadRequest();
            }

            Menu? menu = await this.menuService.GetMenuByIdAsync(int.Parse(model.MenuId));

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

            Dish? dish = await this.dishService.GetDishByIdAsync(int.Parse(model.DishId));

            if (dish == null)
            {
                logger.LogError("Dish not found.");
                return BadRequest();
            }

            DishMenu? dishMenu = await this.dishMenuService.GetDishMenuByMenuIdAndDishIdAsync(int.Parse(model.DishId), int.Parse(model.MenuId));

            if (dishMenu == null)
            {
                logger.LogError("DishMenu not found.");
                return BadRequest();
            }

            try
            {
                await this.dishMenuService.RemoveDishFromMenuAsync(dish, menu, dishMenu);
            }
            catch (Exception)
            {
                this.TempData[ErrorMessage] = "Unexpected error occurred while trying to remove dish from menu! Please try again or contact administrator.";

                return View(model);
            }

            this.TempData[SuccessMessage] = "Dish removed from menu successfully!";

            return RedirectToAction(nameof(Index));
        }
    }
}
