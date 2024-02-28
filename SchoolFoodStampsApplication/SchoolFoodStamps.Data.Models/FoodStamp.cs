using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolFoodStamps.Data.Models
{
    [Comment("Food stamp table")]
    public class FoodStamp
    {
        public FoodStamp()
        {
            this.Id = Guid.NewGuid();
        }

        [Key]
        [Comment("Food stamp identifier")]
        public Guid Id { get; set; }

        [Required]
        [Comment("Food stamp price")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

        [Required]
        [Comment("Food stamp date of creation")]
        public DateTime CreatedOn { get; set; }

        [Required]
        [Comment("Food stamp issue date")]
        public DateTime IssueDate { get; set; }

        [Required]
        [Comment("Food stamp use date")]
        public DateTime UseDate { get; set; }

        [Required]
        [Comment("Food stamp expiry date")]
        public DateTime ExpiryDate { get; set; }

        [Required]
        [Comment("Food stamp status")]
        public FoodStampStatus Status { get; set; }

        [Required]
        [Comment("Child identifier")]
        public Guid ChildId { get; set; }

        [ForeignKey(nameof(ChildId))]
        public virtual Child Child { get; set; } = null!;

        [Required]
        [Comment("Menu identifier")]
        public int MenuId { get; set; }

        [ForeignKey(nameof(MenuId))]
        public virtual Menu Menu { get; set; } = null!;

        [Required]
        [Comment("Parent identifier")]
        public Guid ParentId { get; set; }

        [ForeignKey(nameof(ParentId))]
        public virtual Parent Parent { get; set; } = null!;

        [Required]
        [Comment("Catering identifier")]
        public Guid CateringCompanyId { get; set; }

        [ForeignKey(nameof(CateringCompanyId))]
        public virtual CateringCompany CateringCompany { get; set; } = null!;
    }
}
