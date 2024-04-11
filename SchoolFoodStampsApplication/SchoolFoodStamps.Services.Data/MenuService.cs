using Microsoft.EntityFrameworkCore;
using SchoolFoodStamps.Data.Common;
using SchoolFoodStamps.Data.Models;
using SchoolFoodStamps.Services.Data.Interfaces;
using SchoolFoodStamps.Web.ViewModels.Allergen;
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

            await this.repository.SaveChangesAsync();
        }

        public async Task<int> DeleteAsync(int id)
        {
            Menu? menu = await this.repository.GetByIdAsync<Menu>(id);

            menu!.IsActive = false;
            menu.DateOfModify = DateTime.UtcNow;

            await this.repository.UpdateAsync(menu);

            return await this.repository.SaveChangesAsync();
        }

        public async Task<int> EditAsync(MenuFormViewModel input)
        {
            Menu? menu = await this.repository.GetByIdAsync<Menu>(int.Parse(input.Id));

            menu!.DayOfWeek = (CustomDayOfWeek)Enum.Parse(typeof(CustomDayOfWeek), input.DayOfWeek);
            menu.DateOfModify = DateTime.UtcNow;

            await this.repository.UpdateAsync(menu);

            return await this.repository.SaveChangesAsync();
        }

        public async Task<bool> ExistsByIdAsync(int id)
        {
            return await this.repository
                .AllReadOnly<Menu>()
                .AnyAsync(m => m.Id == id);
        }

        public async Task<IEnumerable<MenuViewModel>> GetAllAsync(string cateringCompanyId)
        {
            return await this.repository
                .AllReadOnly<Menu>()
                .Where(m => m.CateringCompanyId.ToString() == cateringCompanyId && m.IsActive == true)
                .Include(m => m.DishesMenus)
                .OrderBy(m => m.DayOfWeek)
                .Select(m => new MenuViewModel
                {
                    Id = m.Id,
                    DayOfWeek = m.DayOfWeek.ToString(),
                    CateringCompanyId = m.CateringCompanyId.ToString(),
                    Dishes = m.DishesMenus
                    .Where(dm => dm.MenuId == m.Id && dm.Dish.IsActive == true)
                    .Select(dm => new DishViewModel
                    {
                        Id = dm.Dish.Id.ToString(),
                        Name = dm.Dish.Name!,
                        Description = dm.Dish.Description!,
                        Weight = dm.Dish.Weight.ToString(),
                        Allergens = dm.Dish.AllergensDishes
                            .Select(ad => new AllergenViewModel
                            {
                                Id = ad.Allergen.Id.ToString(),
                                Name = ad.Allergen.Name
                            })
                        .ToList()
                    }).ToList()
                })
                .ToListAsync();
        }

        public async Task<Menu?> GetMenuByIdAsync(int id)
        {
            return await this.repository
                .AllReadOnly<Menu>()
                .Include(m => m.DishesMenus)
                .Where(m => m.Id == id && m.IsActive == true)
                .Select(d => new Menu()
                {
                    Id = d.Id,
                    DayOfWeek = d.DayOfWeek,
                    CreatedOn = d.CreatedOn,
                    DateOfModify = d.DateOfModify,
                    IsActive = d.IsActive,
                    CateringCompanyId = d.CateringCompanyId,
                    DishesMenus = d.DishesMenus
                })
                .FirstOrDefaultAsync();
        }

        public async Task<MenuViewModel?> GetMenuDetailsByIdAsync(int id)
        {
            return await this.repository
                .AllReadOnly<Menu>()
                .Where(m => m.Id == id && m.IsActive == true)
                .Include(m => m.DishesMenus)
                .Select(m => new MenuViewModel
                {
                    Id = m.Id,
                    DayOfWeek = m.DayOfWeek.ToString(),
                    CateringCompanyId = m.CateringCompanyId.ToString(),
                    Dishes = m.DishesMenus
                    .Where(dm => dm.MenuId == m.Id && dm.Dish.IsActive == true)
                    .Select(dm => new DishViewModel
                    {
                        Id = dm.Dish.Id.ToString(),
                        Name = dm.Dish.Name!,
                        Description = dm.Dish.Description!,
                        Weight = dm.Dish.Weight.ToString(),
                        Allergens = dm.Dish.AllergensDishes
                            .Select(ad => new AllergenViewModel
                            {
                                Id = ad.Allergen.Id.ToString(),
                                Name = ad.Allergen.Name
                            })
                        .ToList()
                    }).ToList()
                })
                .FirstOrDefaultAsync();
        }
    }
}
