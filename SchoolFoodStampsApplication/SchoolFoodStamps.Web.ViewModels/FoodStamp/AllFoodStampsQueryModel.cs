using System.ComponentModel.DataAnnotations;
using static SchoolFoodStamps.Common.GeneralApplicationConstants;

namespace SchoolFoodStamps.Web.ViewModels.FoodStamp
{
    public class AllFoodStampsQueryModel
    {
        public AllFoodStampsQueryModel()
        {
            CurrentPage = DefaultPage;
            FoodStampsPerPage = EntitiesPerPage;

            FoodStamps = new HashSet<FoodStampViewModel>();
        }

        [Display(Name = "Student name")]
        public string StudentName { get; set; } = string.Empty;

        public string Status { get; set; } = string.Empty;

        [Display(Name = "Sort by")]
        public FoodStampSorting FoodStampSorting { get; set; }

        public int CurrentPage { get; set; }

        [Display(Name = "Pages")]
        public int FoodStampsPerPage { get; set; }

        public int TotalFoodStamps { get; set; }

        public IEnumerable<FoodStampViewModel> FoodStamps { get; set; }
    }
}
