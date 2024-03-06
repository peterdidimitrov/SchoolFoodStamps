using System.ComponentModel.DataAnnotations;
using SchoolFoodStamps.Web.ViewModels.CateringCompany;
using static SchoolFoodStamps.Common.EntityValidationConstants.ErrorMessages;
using static SchoolFoodStamps.Common.EntityValidationConstants.School;

namespace SchoolFoodStamps.Web.ViewModels.School
{
    public class SchoolFormViewModel
    {
        public SchoolFormViewModel()
        {
            CateringCompanies = new HashSet<CateringCompanyViewModel>();
        }

        [Required(ErrorMessage = RequireErrorMessage)]
        [StringLength(NameMaxLength, MinimumLength = NameMinLength, ErrorMessage = ErrorMassageLength)]
        public string Name { get; set; } = string.Empty;

        [StringLength(AddressMaxLength, MinimumLength = AddressMinLength, ErrorMessage = ErrorMassageLength)]
        public string? Address { get; set; }

        [StringLength(PhoneNumberMaxLength, MinimumLength = PhoneNumberMinLength, ErrorMessage = ErrorMassageLength)]
        [Display(Name = "Phone")]
        [RegularExpression(@"^\+(?:[0-9]\s?){6,14}[0-9]$", ErrorMessage = PhoneNumberErrorMessage)]
        public string? PhoneNumber { get; set; }

        [Required(ErrorMessage = RequireErrorMessage)]
        [RegularExpression(@"^\d{9}$", ErrorMessage = IdentificationNumberErrorMessage)]
        [Display(Name = "Identification number")]
        public string IdentificationNumber { get; set; } = null!;

        public string UserId { get; set; } = string.Empty;

        [Required(ErrorMessage = RequireErrorMessage)]
        [Display(Name = "Catering company")]
        public string CateringCompanyId { get; set; } = string.Empty;

        public IEnumerable<CateringCompanyViewModel> CateringCompanies { get; set; }
    }
}
