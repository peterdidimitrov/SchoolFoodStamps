using System.ComponentModel.DataAnnotations;
using static SchoolFoodStamps.Common.GeneralApplicationConstants;

namespace SchoolFoodStamps.Web.ViewModels.FoodStamp
{
    public class AllFoodStampsQueryAdminModel
    {
        public AllFoodStampsQueryAdminModel()
        {
            CurrentPage = DefaultPage;
            FoodStampsPerPage = EntitiesPerPage;

            FoodStamps = new List<FoodStampViewModel>();
        }

        [Display(Name = "User name")]
        public string SearchString { get; set; } = string.Empty;

        public string Status { get; set; } = string.Empty;

        [Display(Name = "Sort by")]
        public FoodStampSorting FoodStampSorting { get; set; }

        public int CurrentPage { get; set; }

        [Display(Name = "Per page by")]
        public int FoodStampsPerPage { get; set; }

        public int TotalFoodStamps { get; set; }

        public IEnumerable<FoodStampViewModel> FoodStamps { get; set; }
    }
}
