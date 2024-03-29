namespace SchoolFoodStamps.Web.ViewModels.FoodStamp
{
    public class FoodStampViewModel
    {
        public string Id { get; set; } = string.Empty;

        public decimal Price { get; set; }

        public string IssueDate { get; set; } = string.Empty;

        public string ExpiryDate { get; set; } = string.Empty;

        public string RenewedDate { get; set; } = string.Empty;

        public string Status { get; set; } = string.Empty;

        public string Menu { get; set; } = string.Empty;

        public string StudentId { get; set; } = string.Empty;

        public string StudentName { get; set; } = string.Empty;

        public int MenuId { get; set; }
    }
}