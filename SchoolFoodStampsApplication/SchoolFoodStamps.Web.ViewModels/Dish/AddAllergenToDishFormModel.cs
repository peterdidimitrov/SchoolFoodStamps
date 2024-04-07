using SchoolFoodStamps.Web.ViewModels.Allergen;

namespace SchoolFoodStamps.Web.ViewModels.Dish
{
    public class AddAllergenToDishFormModel
    {
        public AddAllergenToDishFormModel()
        {
            this.Allergens = new List<AllergenViewModel>();
        }

        public string AllergenId { get; set; } = null!;

        public IEnumerable<AllergenViewModel> Allergens { get; set; }
    }
}
