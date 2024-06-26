﻿using System.ComponentModel.DataAnnotations;
using static SchoolFoodStamps.Common.EntityValidationConstants.ErrorMessages;
using static SchoolFoodStamps.Common.EntityValidationConstants.Parent;
using static SchoolFoodStamps.Common.GeneralApplicationConstants;

namespace SchoolFoodStamps.Web.ViewModels.Parent
{
    public class ParentFormViewModel
    {
        public string Id { get; set; } = string.Empty;

        [Required(ErrorMessage = RequireErrorMessage)]
        [StringLength(FirstNameMaxLength, MinimumLength = FirstNameMinLength, ErrorMessage = ErrorMassageLength)]
        [Display(Name = "First name")]
        public string FirstName { get; set; } = string.Empty;

        [Required(ErrorMessage = RequireErrorMessage)]
        [StringLength(LastNameMaxLength, MinimumLength = LastNameMinLength, ErrorMessage = ErrorMassageLength)]
        [Display(Name = "Last name")]
        public string LastName { get; set; } = string.Empty;

        [StringLength(AddressMaxLength, MinimumLength = AddressMinLength, ErrorMessage = ErrorMassageLength)]
        public string? Address { get; set; }

        [StringLength(PhoneNumberMaxLength, MinimumLength = PhoneNumberMinLength, ErrorMessage = ErrorMassageLength)]
        [Display(Name = "Phone")]
        [RegularExpression(PhoneNumberRegex, ErrorMessage = PhoneNumberErrorMessage)]
        public string? PhoneNumber { get; set; }

        public string UserId { get; set; } = string.Empty;
    }
}
