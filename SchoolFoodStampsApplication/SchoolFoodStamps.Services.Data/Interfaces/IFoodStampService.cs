using SchoolFoodStamps.Data.Models;
using SchoolFoodStamps.Services.Data.Models.FoodStamps;
using SchoolFoodStamps.Web.ViewModels.FoodStamp;
using SchoolFoodStamps.Web.ViewModels.School;
using SchoolFoodStamps.Web.ViewModels.Student;

namespace SchoolFoodStamps.Services.Data.Interfaces
{
    public interface IFoodStampService
    {
        Task<AllFoodStampsFilteredAndPagedServiceModel> GetAllFoodStampsByStudentIdAsync(AllFoodStampsQueryModel<StudentViewModel> queryModel, string studentId);

        Task<AllFoodStampsFilteredAndPagedServiceModel> GetAllFoodStampsByParentIdAsync(AllFoodStampsQueryModel<StudentViewModel> queryModel, string parentId);

        Task<AllFoodStampsFilteredAndPagedServiceModel> GetAllFoodStampsByCateringCompanyIdAsync(AllFoodStampsQueryModel<SchoolViewModel> queryModel, string cateringCompanyId);

        Task BuyFoodStampAsync(int menuId, Guid studentId, Guid parentId, Guid cateringCompanyId, Guid schoolId);

        Task<FoodStamp?> GetFoodStampByIdAsync(string foodStampId);

        Task<DateTime> GenerateExpiryDate(int menuId, DateTime startDate, bool isRenew);

        Task<int> UpdateFoodStampAsync(FoodStamp foodStamp, FoodStampFormViewModel model);
    }
}
