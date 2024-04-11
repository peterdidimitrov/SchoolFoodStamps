using static SchoolFoodStamps.Common.GeneralApplicationConstants;

namespace SchoolFoodStamps.Web.ViewModels.FoodStamp
{
    public class FoodStampFormViewModel
    {
        public FoodStampFormViewModel()
        {
            this.Dates = new HashSet<DateTime>();
            this.Price = FoodStampPrice;
        }
        public string Id { get; set; } = string.Empty;

        public decimal Price { get; set; }

        public DateTime IssueDate { get; set; }

        public string ExpiryDate { get; set; } = string.Empty;

        public string MenuId { get; set; } = string.Empty;

        public string StudentId { get; set; } = string.Empty;

        public string ParentId { get; set; } = string.Empty;

        public string CateringCompanyId { get; set; } = string.Empty;

        public string SchoolId { get; set; } = string.Empty;

        public IEnumerable<DateTime> Dates { get; set; }
    }
}
