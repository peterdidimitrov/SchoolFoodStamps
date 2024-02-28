using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static SchoolFoodStamps.Common.EntityValidationConstants.CateringCompany;

namespace SchoolFoodStamps.Data.Models
{
    [Comment("Catering company table")]
    public class CateringCompany
    {
        public CateringCompany()
        {
            this.Id = Guid.NewGuid();
            this.FoodStamps = new HashSet<FoodStamp>();
            this.Schools = new HashSet<School>();
            this.Menus = new HashSet<Menu>();
            this.Dishes = new HashSet<Dish>();
        }

        [Key]
        [Comment("Catering company identifier")]
        public Guid Id { get; set; }

        [Required]
        [Comment("Catering company name")]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = null!;

        [Comment("Catering company address")]
        [MaxLength(AddressMaxLength)]
        public string? Address { get; set; }

        [Comment("Catering company phone number")]
        [MaxLength(PhoneNumberMaxLength)]
        public string? PhoneNumber { get; set; }

        [Required]
        [Comment("Catering company Identification Number")]
        [MaxLength(IdentificationNumberMaxLength)]
        public string IdentificationNumber { get; set; } = null!;

        [Required]
        [Comment("User identifier")]
        public Guid UserId { get; set; }

        [ForeignKey(nameof(UserId))]
        public virtual ApplicationUser User { get; set; } = null!;

        public virtual ICollection<FoodStamp> FoodStamps { get; set; }

        public virtual ICollection<School> Schools { get; set; }

        public virtual ICollection<Menu> Menus { get; set; }

        public virtual ICollection<Dish> Dishes { get; set; }
    }
}
