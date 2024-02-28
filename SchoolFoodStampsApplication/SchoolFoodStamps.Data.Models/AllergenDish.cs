using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolFoodStamps.Data.Models
{
    public class AllergenDish
    {
        [Required]
        public int AllergenId { get; set; }

        [ForeignKey(nameof(AllergenId))]
        public Allergen Allergen { get; set; } = null!;

        [Required]
        public int DishId { get; set; }

        [ForeignKey(nameof(DishId))]
        public Dish Dish { get; set; } = null!;
    }
}
