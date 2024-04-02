﻿using Microsoft.EntityFrameworkCore;
using SchoolFoodStamps.Data.Common;
using SchoolFoodStamps.Data.Models;
using SchoolFoodStamps.Services.Data.Interfaces;
using SchoolFoodStamps.Web.ViewModels.Dish;
using SchoolFoodStamps.Web.ViewModels.Menu;

namespace SchoolFoodStamps.Services.Data
{
    public class MenuService : IMenuService
    {
        private readonly IRepository repository;

        public MenuService(IRepository repository)
        {
            this.repository = repository;
        }

        public Task<int> CreateAsync(MenuFormViewModel input)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> EditAsync(MenuFormViewModel input)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<MenuViewModel>> GetAllAsync()
        {
            return await this.repository
                .AllReadOnly<Menu>()
                .Include(m => m.DishesMenus)
                .Select(m => new MenuViewModel
                {
                    Id = m.Id,
                    DayOfWeek = m.DayOfWeek.ToString(),
                    CateringCompanyId = m.CateringCompanyId.ToString(),
                    Dishes = m.DishesMenus
                    .Where(dm => dm.MenuId == m.Id)
                    .Select(dm => new DishViewModel
                    {
                        Id = dm.Dish.Id.ToString(),
                        Name = dm.Dish.Name,
                        Description = dm.Dish.Description,
                        Allergens = dm.Dish.AllergensDishes
                        .Select(ad => ad.Allergen.Name)
                        .ToList()
                    }).ToList()
                })
                .ToListAsync();
        }

        public Task<IEnumerable<MenuViewModel>> GetAllByCateringCompanyAsync(string cateringCompanyId)
        {
            throw new NotImplementedException();
        }

        public Task<MenuViewModel> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
