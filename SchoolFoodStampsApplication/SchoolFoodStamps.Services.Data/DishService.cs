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
        public async Task CreateAsync(DishFormViewModel formMorel)
        {
            Dish dish = new Dish
            {
                Name = formMorel.Name,
                Description = formMorel.Description,
                Weight = double.Parse(formMorel.Weight),
                CateringCompanyId = Guid.Parse(formMorel.CateringCompanyId),
            };

            await this.repository.AddAsync(dish);

            foreach (AllergenViewModel allergen in formMorel.Allergens)
            {
                AllergenDish dishAllergen = new AllergenDish
                {
                    DishId = dish.Id,
                    AllergenId = int.Parse(allergen.Id),
                };

                await this.repository.AddAsync(dishAllergen);
            }

            await this.repository.SaveChangesAsync();
        }

        public Task<int> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> EditAsync(DishFormViewModel input)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<DishViewModel>> GetAllAsync(string cateringCompanyId)
        {
            return await this.repository
                .AllReadOnly<Dish>()
                .Where(d => d.CateringCompanyId.ToString() == cateringCompanyId)
                .Include(d => d.AllergensDishes)
                .Select(d => new DishViewModel
                {
                    Id = d.Id.ToString(),
                    Name = d.Name,
                    Description = d.Description,
                    Weight = d.Weight.ToString(),
                    Allergens = d.AllergensDishes
                        .Select(ad => ad.Allergen.Name)
                        .ToList()
                })
                .ToListAsync();
        }

        public Task<IEnumerable<DishViewModel>> GetAllByCateringCompanyAsync(string cateringCompanyId)
        {
            throw new NotImplementedException();
        }

        public Task<DishViewModel> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
