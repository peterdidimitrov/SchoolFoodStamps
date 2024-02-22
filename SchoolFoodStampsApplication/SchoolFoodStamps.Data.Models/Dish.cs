using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static SchoolFoodStamps.Common.EntityValidationConstants.Dish;

namespace SchoolFoodStamps.Data.Models
{
    [Comment("Dish table")]
    public class Dish
    {
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
        public int Weight { get; set; }

        [Required]
        [Comment("Menu identifier")]
        public int MenuId { get; set; }

        public virtual Menu Menu { get; set; } = null!;
    }
}