using Microsoft.EntityFrameworkCore;
using SchoolFoodStamps.Data.Common;
using SchoolFoodStamps.Data.Models;
using SchoolFoodStamps.Services.Data.Interfaces;

namespace SchoolFoodStamps.Services.Data
{
    public class DishMenuService : IDishMenuService
    {
        private readonly IRepository repository;

        public DishMenuService(IRepository repository)
        {
            this.repository = repository;
        }

        public async Task AddDishToMenuAsync(Dish dish, Menu menu)
        {
            DishMenu dishMenu = new DishMenu
            {
                DishId = dish.Id,
                MenuId = menu.Id
            };

            dish.DishesMenus.Add(dishMenu);
            menu.DishesMenus.Add(dishMenu);

            await this.repository.AddAsync(dishMenu);
            await repository.SaveChangesAsync();
        }

        public async Task<DishMenu?> GetDishMenuByMenuIdAndDishIdAsync(int dishId, int menuId)
        {
            return await this.repository.AllReadOnly<DishMenu>().FirstOrDefaultAsync(x => x.DishId == dishId && x.MenuId == menuId);
        }

        public async Task RemoveDishFromMenuAsync(Dish dish, Menu menu, DishMenu dishMenu)
        {
            dish.DishesMenus.Remove(dishMenu);
            menu.DishesMenus.Remove(dishMenu);

            this.repository.Delete(dishMenu);
            await this.repository.SaveChangesAsync();
        }
    }
}
