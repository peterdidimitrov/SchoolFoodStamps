using Microsoft.EntityFrameworkCore;
using SchoolFoodStamps.Data.Common;
using SchoolFoodStamps.Data.Models;
using SchoolFoodStamps.Services.Data.Interfaces;

namespace SchoolFoodStamps.Services.Data
{
    public class AllergenDishService : IAllergenDishService
    {
        private readonly IRepository repository;

        public AllergenDishService(IRepository repository)
        {
            this.repository = repository;
        }

        public async Task AddAllergenToDishAsync(Dish dish, Allergen allergen)
        {
            AllergenDish allergenDish = new AllergenDish
            {
                AllergenId = allergen.Id,
                DishId = dish.Id
            };

            dish.AllergensDishes.Add(allergenDish);
            allergen.AllergensDishes.Add(allergenDish);

            await this.repository.AddAsync(allergenDish);
            await this.repository.SaveChangesAsync();
        }

        public async Task<AllergenDish?> GetAllergenDishByDishIdAndAllergenIdAsync(int dishId, int allergenId)
        {
            return await this.repository.AllReadOnly<AllergenDish>().FirstOrDefaultAsync(x => x.DishId == dishId && x.AllergenId == allergenId);
        }

        public async Task RemoveAllergenFromDishAsync(Dish dish, Allergen allergen, AllergenDish allergenDish)
        {
            dish.AllergensDishes.Remove(allergenDish);
            allergen.AllergensDishes.Remove(allergenDish);

            this.repository.Delete(allergenDish);
            await this.repository.SaveChangesAsync();
        }
    }
}
