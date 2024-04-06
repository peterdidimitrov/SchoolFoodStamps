using SchoolFoodStamps.Web.ViewModels.Dish;

namespace SchoolFoodStamps.Services.Data.Interfaces
{
    public interface IDishService
    {
        Task CreateAsync(DishFormViewModel input);

        Task<int> EditAsync(DishFormViewModel input);

        Task<int> DeleteAsync(int id);

        Task<DishViewModel> GetByIdAsync(int id);

        Task<IEnumerable<DishViewModel>> GetAllAsync(string cateringCompanyId);

        Task<IEnumerable<DishViewModel>> GetAllByCateringCompanyAsync(string cateringCompanyId);
    }
}
