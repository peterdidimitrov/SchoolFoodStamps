using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static SchoolFoodStamps.Common.EntityValidationConstants.Dish;

namespace SchoolFoodStamps.Data.Models
{
    [Comment("Dish table")]
    public class Dish
    {
        public Dish()
        {
            this.AllergensDishes = new HashSet<AllergenDish>();
            this.DishesMenus = new HashSet<DishMenu>();
            this.IsActive = true;
        }

        [Key]
        [Comment("Dish identifier")]
        public int Id { get; set; }

        [Comment("Dish name")]
        [MaxLength(NameMaxLength)]
        public string? Name { get; set; }

        [Comment("Dish description")]
        [MaxLength(DescriptionMaxLength)]
        public string? Description { get; set; }

        [Required]
        [Comment("Dish weight")]
        public double Weight { get; set; }

        [Required]
        [Comment("Is active")]
        public bool IsActive { get; set; }

        [Required]
        [Comment("Catering company identifier")]
        public Guid CateringCompanyId { get; set; }

        [ForeignKey(nameof(CateringCompanyId))]
        public virtual CateringCompany Company { get; set; } = null!;

        public virtual ICollection<AllergenDish> AllergensDishes { get; set; }

        public virtual ICollection<DishMenu> DishesMenus { get; set; }
    }
}