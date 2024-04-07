using SchoolFoodStamps.Web.ViewModels.Allergen;

namespace SchoolFoodStamps.Web.ViewModels.Dish
{
    public class DishViewModel
    {
        public DishViewModel()
        {
            Allergens = new HashSet<AllergenViewModel>();
        }
        public string Id { get; set; } = string.Empty;

        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public string Weight { get; set; } = string.Empty;

        public string CateringCompanyId { get; set; } = string.Empty;

        public IEnumerable<AllergenViewModel> Allergens { get; set; }
    }
}
