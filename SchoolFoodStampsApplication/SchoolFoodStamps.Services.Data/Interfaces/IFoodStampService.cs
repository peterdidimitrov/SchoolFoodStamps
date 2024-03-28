using SchoolFoodStamps.Services.Data.Models.FoodStamps;
using SchoolFoodStamps.Web.ViewModels.FoodStamp;

namespace SchoolFoodStamps.Services.Data.Interfaces
{
    public interface IFoodStampService
    {
        Task<AllFoodStampsFilteredAndPagedServiceModel> GetAllFoodStampsByStudentAsync(AllFoodStampsQueryModel queryModel, string studentId);
    }
}
