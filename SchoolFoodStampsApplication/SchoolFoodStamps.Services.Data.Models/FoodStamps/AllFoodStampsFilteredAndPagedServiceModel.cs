using SchoolFoodStamps.Web.ViewModels.FoodStamp;

namespace SchoolFoodStamps.Services.Data.Models.FoodStamps
{
    public class AllFoodStampsFilteredAndPagedServiceModel
    {
        public AllFoodStampsFilteredAndPagedServiceModel()
        {
            FoodStamps = new HashSet<FoodStampViewModel>();
        }

        public int TotalFoodStampsCount { get; set; }

        public IEnumerable<FoodStampViewModel> FoodStamps { get; set; }
    }
}
