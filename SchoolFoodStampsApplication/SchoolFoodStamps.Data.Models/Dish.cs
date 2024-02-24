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
            this.Allergens = new HashSet<Allergen>();
        }

        [Key]
        [Comment("Dish identifier")]
        public int Id { get; set; }

        [Required]
        [Comment("Dish name")]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [Comment("Dish description")]
        [MaxLength(DescriptionMaxLength)]
        public string Description { get; set; } = string.Empty;

        [Required]
        [Comment("Dish weight")]
        public double Weight { get; set; }

        [Required]
        [Comment("Menu identifier")]
        public int MenuId { get; set; }

        [ForeignKey(nameof(MenuId))]
        public virtual Menu Menu { get; set; } = null!;

        public virtual ICollection<Allergen> Allergens { get; set; }
    }
}