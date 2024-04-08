using Microsoft.EntityFrameworkCore;
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

            CateringCompany? cateringCompany = await repository.GetByIdAsync<CateringCompany>(Guid.Parse(formModel.CateringCompanyId));
            cateringCompany!.Dishes.Add(dish);

            await this.repository.SaveChangesAsync();
        }

        public Task<int> DeleteAsync(int id)
        {
            throw new NotImplementedException();
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

        public Task<IEnumerable<DishViewModel>> GetAllByCateringCompanyAsync(string cateringCompanyId)
        {
            throw new NotImplementedException();
        }

        public async Task<Dish?> GetDishByIdAsync(int id)
        {
            return await this.repository.GetByIdAsync<Dish>(id);
        }
    }
}