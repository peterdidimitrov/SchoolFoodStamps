using System.ComponentModel.DataAnnotations;
using static SchoolFoodStamps.Common.EntityValidationConstants.ErrorMessages;
using static SchoolFoodStamps.Common.EntityValidationConstants.Parent;

namespace SchoolFoodStamps.Web.ViewModels.Parent
{
    public class ParentFormViewModel
    {
        [Required(ErrorMessage = RequireErrorMessage)]
        [StringLength(FirstNameMaxLength, MinimumLength = FirstNameMinLength, ErrorMessage = ErrorMassageLength)]
        public string FirstName { get; set; } = string.Empty;

        [Required(ErrorMessage = RequireErrorMessage)]
        [StringLength(LastNameMaxLength, MinimumLength = LastNameMinLength, ErrorMessage = ErrorMassageLength)]
        public string LastName { get; set; } = string.Empty;

        [StringLength(AddressMaxLength, MinimumLength = AddressMinLength, ErrorMessage = ErrorMassageLength)]
        public string? Address { get; set; }

        [StringLength(PhoneNumberMaxLength, MinimumLength = PhoneNumberMinLength, ErrorMessage = ErrorMassageLength)]
        [Display(Name = "Phone")]
        [RegularExpression(@"^\+(?:[0-9]\s?){6,14}[0-9]$", ErrorMessage = PhoneNumberErrorMessage)]
        public string? PhoneNumber { get; set; }

        public string UserId { get; set; } = string.Empty;
    }
}
