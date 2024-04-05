using SchoolFoodStamps.Web.ViewModels.Menu;

namespace SchoolFoodStamps.Services.Data.Interfaces
{
    public interface IMenuService
    {
        Task CreateAsync(MenuFormViewModel input);

        Task<int> EditAsync(MenuFormViewModel input);

        Task<int> DeleteAsync(int id);

        Task<MenuViewModel> GetByIdAsync(int id);

        Task<IEnumerable<MenuViewModel>> GetAllAsync(string cateringCompanyId);

        Task<IEnumerable<MenuViewModel>> GetAllByCateringCompanyAsync(string cateringCompanyId);
    }
}
