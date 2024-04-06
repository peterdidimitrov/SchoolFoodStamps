using SchoolFoodStamps.Data.Models;
using SchoolFoodStamps.Web.ViewModels.Dish;

namespace SchoolFoodStamps.Services.Data.Interfaces
{
    public interface IDishService
    {
        Task CreateAsync(DishFormViewModel input);

        Task<int> EditAsync(DishFormViewModel input, Dish dish);

        Task<int> DeleteAsync(int id);

        Task<Dish?> GetDishByIdAsync(int id);

        Task<IEnumerable<DishViewModel>> GetAllAsync(string cateringCompanyId);

        Task<IEnumerable<DishViewModel>> GetAllByCateringCompanyAsync(string cateringCompanyId);
    }
}
