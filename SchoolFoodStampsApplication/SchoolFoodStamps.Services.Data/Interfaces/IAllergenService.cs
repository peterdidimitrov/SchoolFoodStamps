using SchoolFoodStamps.Data.Models;
using SchoolFoodStamps.Web.ViewModels.Allergen;

namespace SchoolFoodStamps.Services.Data.Interfaces
{
    public interface IAllergenService
    {
        Task<IEnumerable<AllergenViewModel>> GetAllAsync();

        Task<Allergen?> GetByIdAsync(string id);
    }
}
