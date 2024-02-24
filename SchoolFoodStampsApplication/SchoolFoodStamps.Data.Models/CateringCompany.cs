using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolFoodStamps.Data.Models
{
    [Comment("Catering company table")]
    public class CateringCompany
    {
        public CateringCompany()
        {
            this.FoodStamps = new HashSet<FoodStamp>();
            this.Schools = new HashSet<School>();
        }

        [Key]
        [Comment("Catering company identifier")]
        public Guid Id { get; set; }

        [Required]
        [Comment("Catering company name")]
        public string Name { get; set; } = null!;

        [Required]
        [Comment("Catering company address")]
        public string? Address { get; set; }

        [Required]
        [Comment("Catering company Identification Number")]
        public string IdentificationNumber { get; set; } = null!;

        [Required]
        [Comment("User identifier")]
        public Guid UserId { get; set; }

        [ForeignKey(nameof(UserId))]
        public virtual ApplicationUser User { get; set; } = null!;

        public virtual ICollection<FoodStamp> FoodStamps { get; set; }

        public virtual ICollection<School> Schools { get; set; }
    }
}
