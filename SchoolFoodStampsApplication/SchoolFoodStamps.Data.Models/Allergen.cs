using System.ComponentModel.DataAnnotations;
using static SchoolFoodStamps.Common.EntityValidationConstants.Allergen;

namespace SchoolFoodStamps.Data.Models
{
    public class Allergen
    {
        public Allergen()
        {
            this.AllergensDishes = new HashSet<AllergenDish>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = string.Empty;

        public virtual ICollection<AllergenDish> AllergensDishes { get; set; }
    }
}