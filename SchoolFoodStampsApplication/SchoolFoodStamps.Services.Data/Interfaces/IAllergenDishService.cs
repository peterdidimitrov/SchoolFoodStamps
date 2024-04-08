using SchoolFoodStamps.Data.Models;

namespace SchoolFoodStamps.Services.Data.Interfaces
{
    public interface IAllergenDishService
    {
        Task AddAllergenToDishAsync(Dish dish, Allergen allergen);

        Task RemoveAllergenFromDishAsync(Dish dish, Allergen allergen, AllergenDish allergenDish);

        Task<AllergenDish?> GetAllergenDishByDishIdAndAllergenIdAsync(int dishId, int allergenId);
    }
}
