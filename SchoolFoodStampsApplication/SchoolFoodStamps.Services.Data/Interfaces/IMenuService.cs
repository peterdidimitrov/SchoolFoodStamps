using SchoolFoodStamps.Data.Models;
using SchoolFoodStamps.Web.ViewModels.Menu;

namespace SchoolFoodStamps.Services.Data.Interfaces
{
    public interface IMenuService
    {
        Task CreateAsync(MenuFormViewModel menu);

        Task<bool> ExistsByIdAsync(int id);

        Task<int> EditAsync(MenuFormViewModel menu);

        Task<int> DeleteAsync(int id);

        Task<Menu?> GetMenuByIdAsync(int id);

        Task<IEnumerable<MenuViewModel>> GetAllAsync(string cateringCompanyId);

        Task<Menu?> GetMenuByCateringCompanyIdAndDayOfWeekAsync(string cateringCompanyId, CustomDayOfWeek day);

        Task<MenuViewModel?> GetMenuDetailsByIdAsync(int id);
    }
}
