using SchoolFoodStamps.Web.ViewModels.Allergen;
using System.ComponentModel.DataAnnotations;
using static SchoolFoodStamps.Common.EntityValidationConstants.ErrorMessages;
using static SchoolFoodStamps.Common.EntityValidationConstants.Dish;

namespace SchoolFoodStamps.Web.ViewModels.Dish
{
    public class DishFormViewModel
    {
        public DishFormViewModel()
        {
            this.Allergens = new HashSet<AllergenViewModel>();
        }

        [Required(ErrorMessage = RequireErrorMessage)]
        [StringLength(NameMaxLength, MinimumLength = NameMinLength, ErrorMessage = ErrorMassageLength)]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = RequireErrorMessage)]
        [StringLength(DescriptionMaxLength, MinimumLength = DescriptionMinLength, ErrorMessage = ErrorMassageLength)]
        public string Description { get; set; } = string.Empty;

        [Required(ErrorMessage = RequireErrorMessage)]
        public string Weight { get; set; } = string.Empty;

        public string CateringCompanyId { get; set; } = string.Empty;

        //[Required(ErrorMessage = RequireErrorMessage)]
        //[Display(Name = "Allergen")]
        //public string AllergenId { get; set; } = string.Empty;

        public IEnumerable<AllergenViewModel> Allergens { get; set; }
    }
}
