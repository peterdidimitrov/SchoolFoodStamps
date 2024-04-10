using SchoolFoodStamps.Data.Models;
using SchoolFoodStamps.Web.ViewModels.Menu;

namespace SchoolFoodStamps.Services.Data.Interfaces
{
    public interface IMenuService
    {
        Task CreateAsync(MenuFormViewModel menu);

        Task<int> EditAsync(MenuFormViewModel menu);

        Task<int> DeleteAsync(int id);

        Task<Menu?> GetMenuByIdAsync(int id);

        Task<IEnumerable<MenuViewModel>> GetAllAsync(string cateringCompanyId);

        Task<IEnumerable<MenuViewModel>> GetAllByCateringCompanyAsync(string cateringCompanyId);
    }
}
