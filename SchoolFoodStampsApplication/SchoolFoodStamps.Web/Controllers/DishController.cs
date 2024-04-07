﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SchoolFoodStamps.Data.Models;
using SchoolFoodStamps.Services.Data.Interfaces;
using SchoolFoodStamps.Web.ViewModels.Allergen;
using SchoolFoodStamps.Web.ViewModels.Dish;
using System.Security.Claims;
using static SchoolFoodStamps.Common.NotificationMessagesConstants;

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

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Add(DishFormViewModel formModel)
        {

            string? cateringCompanyId = await cateringCompanyService.GetCateringCompanyIdAsync(User.GetId());

            if (cateringCompanyId == null)
            {
                logger.LogError("Catering company not found.");
                return BadRequest();
            }

            formModel.CateringCompanyId = cateringCompanyId;

            if (!ModelState.IsValid)
            {
                formModel.Allergens = await this.allergenService.GetAllAsync();
                return View(formModel);
            }
            
            try
            {
                await this.dishService.CreateAsync(formModel);
                logger.LogInformation("Dish created.");

            }
            catch (Exception)
            {
                this.ModelState.AddModelError(string.Empty, "Unexpected error occurred while trying to add new dish! Please try again or contact administrator.");
                formModel.Allergens = await this.allergenService.GetAllAsync();
                return View(formModel);
            }

            this.TempData[SuccessMessage] = "Dish created successfully.";

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Edit(string id)
        {
            Dish? dish = await this.dishService.GetDishByIdAsync(int.Parse(id));

            if (dish == null)
            {
                logger.LogError("Dish not found.");
                return BadRequest();
            }

            string? cateringCompanyId = await cateringCompanyService.GetCateringCompanyIdAsync(User.GetId());

            if (cateringCompanyId == null)
            {
                logger.LogError("Catering company not found.");
                return BadRequest();
            }

            if (dish.CateringCompanyId.ToString() != cateringCompanyId)
            {
                logger.LogWarning("Unauthorized access.");
                return Unauthorized();
            }

            DishFormViewModel dishFormViewModel = new DishFormViewModel()
            {
                Name = dish.Name,
                Description = dish.Description,
                Weight = dish.Weight.ToString()
            };

            return View(dishFormViewModel);
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Edit(DishFormViewModel formModel, int id)
        {
            Dish? dish = await this.dishService.GetDishByIdAsync(id);

            if (dish == null)
            {
                logger.LogError("Dish not found.");
                return BadRequest();
            }

            string? cateringCompanyId = await cateringCompanyService.GetCateringCompanyIdAsync(User.GetId());

            if (cateringCompanyId == null)
            {
                logger.LogError("Catering company not found.");
                return BadRequest();
            }

            if (dish.CateringCompanyId.ToString() != cateringCompanyId)
            {
                logger.LogWarning("Unauthorized access.");
                return Unauthorized();
            }

            if (!ModelState.IsValid)
            {
                logger.LogWarning("Model state is not valid.");
                return View(formModel);
            }

            try
            {
                await this.dishService.EditAsync(formModel, dish);
                logger.LogInformation("Dish updated successfully.");
            }
            catch (Exception)
            {
                this.ModelState.AddModelError(string.Empty, "Unexpected error occurred while trying to update dish! Please try again or contact administrator.");
                return View(formModel);
            }

            this.TempData[SuccessMessage] = "Dish updated successfully.";

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> AddAllergenToDish(string id)
        {
            Dish? dish = await this.dishService.GetDishByIdAsync(int.Parse(id));

            if (dish == null)
            {
                logger.LogError("Dish not found.");
                return BadRequest();
            }

            IEnumerable<AllergenViewModel> allergens = await this.allergenService.GetAllAsync();

            if (allergens == null)
            {
                logger.LogError("Allergens not found.");
                return BadRequest();
            }

            AddAllergenToDishFormModel addAllergenToDishFormModel = new AddAllergenToDishFormModel()
            {
                Allergens = allergens
            };

            return View(addAllergenToDishFormModel);
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> AddAllergenToDish(AddAllergenToDishFormModel formModel, string id)
        {
            Dish? dish = await this.dishService.GetDishByIdAsync(int.Parse(id));

            if (dish == null)
            {
                logger.LogError("Dish not found.");
                return BadRequest();
            }

            string? cateringCompanyId = await cateringCompanyService.GetCateringCompanyIdAsync(User.GetId());

            if (cateringCompanyId == null)
            {
                logger.LogError("Catering company not found.");
                return BadRequest();
            }

            if (dish.CateringCompanyId.ToString() != cateringCompanyId)
            {
                logger.LogWarning("Unauthorized access.");
                return Unauthorized();
            }

            Allergen? allergen = await this.allergenService.GetByIdAsync(formModel.AllergenId);

            if (allergen == null)
            {
                logger.LogError("Allergen not found.");
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                logger.LogWarning("Model state is not valid.");
                formModel.Allergens = await this.allergenService.GetAllAsync();
                return View(formModel);
            }

            try
            {
                await this.dishService.AddAllergenToDishAsync(dish, allergen);
                logger.LogInformation("Allergen added to dish successfully.");
            }
            catch (Exception)
            {
                this.ModelState.AddModelError(string.Empty, "Unexpected error occurred while trying to add allergen to dish! Please try again or contact administrator.");
                formModel.Allergens = await this.allergenService.GetAllAsync();
                return View(formModel);
            }

            this.TempData[SuccessMessage] = "Dish updated successfully.";

            return RedirectToAction(nameof(Index));
        }

        //[HttpPost]
        //[AutoValidateAntiforgeryToken]
        //public async Task<IActionResult> Delete(string id)
        //{
        //    if (string.IsNullOrWhiteSpace(id))
        //    {
        //        logger.LogError("Dish id is null or empty.");
        //        return BadRequest();
        //    }

        //    try
        //    {
        //        await this.dishService.DeleteAsync(int.Parse(id));
        //        logger.LogInformation("Dish deleted.");
        //    }
        //    catch (Exception)
        //    {
        //        this.TempData[ErrorMessage] = "Unexpected error occurred while trying to delete dish! Please try again or contact administrator.";
        //    }

        //    this.TempData[SuccessMessage] = "Dish deleted successfully.";

        //    return RedirectToAction(nameof(Index));
        //}
    }
}
