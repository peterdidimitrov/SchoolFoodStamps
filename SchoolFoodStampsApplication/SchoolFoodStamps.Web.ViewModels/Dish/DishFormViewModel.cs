using System.ComponentModel.DataAnnotations;

namespace SchoolFoodStamps.Web.ViewModels.Dish
{
    public class DishFormViewModel
    {
        public DishFormViewModel()
        {
            this.Allergens = new HashSet<string>();
        }
        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public string Description { get; set; } = string.Empty;

        [Required]
        public string Weight { get; set; } = string.Empty;

        [Required]
        public string CateringCompanyId { get; set; } = string.Empty;

        public ICollection<string> Allergens { get; set; }
    }
}
