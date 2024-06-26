﻿using Microsoft.EntityFrameworkCore;
using SchoolFoodStamps.Data.Common;
using SchoolFoodStamps.Data.Models;
using SchoolFoodStamps.Services.Data.Interfaces;
using SchoolFoodStamps.Web.ViewModels.Allergen;
using SchoolFoodStamps.Web.ViewModels.Dish;

namespace SchoolFoodStamps.Services.Data
{
    public class DishService : IDishService
    {
        private readonly IRepository repository;

        public DishService(IRepository repository)
        {
            this.repository = repository;
        }

        public async Task CreateAsync(DishFormViewModel formModel)
        {
            Dish dish = new Dish
            {
                Name = formModel.Name,
                Description = formModel.Description,
                Weight = double.Parse(formModel.Weight),
                CateringCompanyId = Guid.Parse(formModel.CateringCompanyId)
            };

            await this.repository.AddAsync(dish);

            await this.repository.SaveChangesAsync();
        }

        public async Task<int> DeleteAsync(int id)
        {
            Dish? dish = await this.repository.GetByIdAsync<Dish>(id);

            dish!.Name = string.Empty;
            dish.Description = string.Empty;

            dish.IsActive = false;

            await this.repository.UpdateAsync(dish);

            return await this.repository.SaveChangesAsync();
        }

        public async Task<int> EditAsync(DishFormViewModel input, Dish dish)
        {
            dish.Name = input.Name;
            dish.Description = input.Description;
            dish.Weight = double.Parse(input.Weight);

            await this.repository.UpdateAsync(dish);

            return await this.repository.SaveChangesAsync();
        }

        public async Task<IEnumerable<DishViewModel>> GetAllAsync(string cateringCompanyId)
        {
            return await this.repository
                .AllReadOnly<Dish>()
                .Where(d => d.CateringCompanyId.ToString() == cateringCompanyId && d.IsActive == true)
                .Include(d => d.AllergensDishes)
                .Select(d => new DishViewModel
                {
                    Id = d.Id.ToString(),
                    Name = d.Name!,
                    Description = d.Description!,
                    Weight = d.Weight.ToString(),
                    Allergens = d.AllergensDishes
                        .Select(ad => new AllergenViewModel
                        {
                            Id = ad.Allergen.Id.ToString(),
                            Name = ad.Allergen.Name
                        })
                        .ToList()
                })
                .ToListAsync();
        }

        public async Task<Dish?> GetDishByIdAsync(int id)
        {
            return await this.repository
                .AllReadOnly<Dish>()
                .Include(d => d.DishesMenus)
                .Include(d => d.AllergensDishes)
                .Where(d => d.Id == id && d.IsActive == true)
                .Select(d => new Dish()
                {
                    Id = d.Id,
                    Name = d.Name,
                    Description = d.Description,
                    Weight = d.Weight,
                    CateringCompanyId = d.CateringCompanyId,
                    DishesMenus = d.DishesMenus,
                    AllergensDishes = d.AllergensDishes,
                    IsActive = d.IsActive
                })
                .FirstOrDefaultAsync();
        }
    }
}