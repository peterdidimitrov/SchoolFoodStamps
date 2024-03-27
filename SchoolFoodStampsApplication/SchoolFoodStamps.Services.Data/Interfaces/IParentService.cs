using SchoolFoodStamps.Web.ViewModels.CateringCompany;
using SchoolFoodStamps.Web.ViewModels.Parent;

namespace SchoolFoodStamps.Services.Data.Interfaces
{
    public interface IParentService
    {
        Task CreateAsync(ParentFormViewModel formModel);

        Task<bool> ExistsByUserIdAsync(string userId);

        Task<string?> GetParentIdAsync(string userId);

        Task<ParentFormViewModel?> GetParentByUserIdAsync(string userId);

        Task UpdateAsync(ParentFormViewModel formModel);
    }
}
