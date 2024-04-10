using SchoolFoodStamps.Data.Models;

namespace SchoolFoodStamps.Services.Data.Interfaces
{
    public interface IDishMenuService
    {
        Task AddDishToMenuAsync(Dish dish, Menu menu);

        Task RemoveDishFromMenuAsync(Dish dish, Menu menu, DishMenu dishMenu);

        Task<DishMenu?> GetDishMenuByMenuIdAndDishIdAsync(int dishId, int menuId);
    }
}
