using SchoolFoodStamps.Web.ViewModels.FoodStamp;

namespace SchoolFoodStamps.Web.Areas.Admin.ViewModels
{
    public class AllFoodStampsViewModel
    {
        public IEnumerable<FoodStampViewModel> FoodStamps { get; set; }
    }
}
