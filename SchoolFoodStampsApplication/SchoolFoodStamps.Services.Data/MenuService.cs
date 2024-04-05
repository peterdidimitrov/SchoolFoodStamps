using Microsoft.EntityFrameworkCore;
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

        public async Task CreateAsync(MenuFormViewModel formModel)
        {
            Menu menu = new Menu
            {
                DayOfWeek = (CustomDayOfWeek)Enum.Parse(typeof(CustomDayOfWeek), formModel.DayOfWeek),
                CateringCompanyId = Guid.Parse(formModel.CateringCompanyId)
            };

            await this.repository.AddAsync(menu);

            foreach (DishViewModel dish in formModel.Dishes)
            {
                DishMenu dishesMenus = new DishMenu
                {
                    DishId = int.Parse(dish.Id),
                    MenuId = menu.Id
                };

                await this.repository.AddAsync(dishesMenus);
            }

            await this.repository.SaveChangesAsync();

        }

        public Task<int> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> EditAsync(MenuFormViewModel input)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<MenuViewModel>> GetAllAsync(string cateringCompanyId)
        {
            return await this.repository
                .AllReadOnly<Menu>()
                .Where(m => m.CateringCompanyId.ToString() == cateringCompanyId)
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
                        Weight = dm.Dish.Weight.ToString(),
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
