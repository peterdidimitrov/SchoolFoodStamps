﻿using System.ComponentModel.DataAnnotations;
using static SchoolFoodStamps.Common.EntityValidationConstants.ErrorMessages;
using static SchoolFoodStamps.Common.EntityValidationConstants.CateringCompany;
using static SchoolFoodStamps.Common.GeneralApplicationConstants;

namespace SchoolFoodStamps.Web.ViewModels.CateringCompany
{
    public class CateringCompanyFormViewModel
    {
        public string Id { get; set; } = string.Empty;

        [Required(ErrorMessage = RequireErrorMessage)]
        [StringLength(NameMaxLength, MinimumLength = NameMinLength, ErrorMessage = ErrorMassageLength)]
        public string Name { get; set; } = string.Empty;

        [StringLength(AddressMaxLength, MinimumLength = AddressMinLength, ErrorMessage = ErrorMassageLength)]
        public string? Address { get; set; }

        [StringLength(PhoneNumberMaxLength, MinimumLength = PhoneNumberMinLength, ErrorMessage = ErrorMassageLength)]
        [Display(Name = "Phone")]
        [RegularExpression(PhoneNumberRegex, ErrorMessage = PhoneNumberErrorMessage)]
        public string? PhoneNumber { get; set; }

        [Required(ErrorMessage = RequireErrorMessage)]
        [RegularExpression(IdentificationNumberRegex, ErrorMessage = IdentificationNumberErrorMessage)]
        [Display(Name = "Identification number")]
        public string IdentificationNumber { get; set; } = null!;

        public string UserId { get; set; } = string.Empty;
    }
}
