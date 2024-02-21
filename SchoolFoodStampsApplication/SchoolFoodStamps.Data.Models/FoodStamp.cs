using Microsoft.AspNetCore.Identity;

namespace SchoolFoodStamps.Data.Models
{
    public class FoodStamp
    {
        public Guid Id { get; set; }

        public decimal Price { get; set; }

        public DateTime IssueDate { get; set; }

        public DateTime ForDate { get; set; }

        public DateTime ExpiryDate { get; set; }

        public int StatusId { get; set; }

        public virtual FoodStampStatus Status { get; set; } = null!;

        public Guid ChildId { get; set; }

        public virtual Child Child { get; set; } = null!;

        public int MenuId { get; set; }

        public virtual Menu Menu { get; set; } = null!;

        public string UserId { get; set; } = string.Empty;

        public virtual IdentityUser User { get; set; } = null!;
    }
}
