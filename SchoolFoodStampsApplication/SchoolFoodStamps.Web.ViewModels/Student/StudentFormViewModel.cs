﻿using SchoolFoodStamps.Web.ViewModels.School;
using System.ComponentModel.DataAnnotations;
using static SchoolFoodStamps.Common.EntityValidationConstants.ErrorMessages;
using static SchoolFoodStamps.Common.EntityValidationConstants.Student;

namespace SchoolFoodStamps.Web.ViewModels.Student
{
    public class StudentFormViewModel
    {
        public StudentFormViewModel()
        {
            Schools = new HashSet<SchoolViewModel>();
            ClassLetters = new HashSet<ClassLetter>();
            ClassNumbers = new HashSet<byte>();
        }

        [Required(ErrorMessage = RequireErrorMessage)]
        [StringLength(FirstNameMaxLength, MinimumLength = FirstNameMinLength, ErrorMessage = ErrorMassageLength)]
        [Display(Name = "First name")]
        public string FirstName { get; set; } = string.Empty;

        [Required(ErrorMessage = RequireErrorMessage)]
        [StringLength(LastNameMaxLength, MinimumLength = LastNameMinLength, ErrorMessage = ErrorMassageLength)]
        [Display(Name = "Last name")]
        public string LastName { get; set; } = string.Empty;

        [Required(ErrorMessage = RequireErrorMessage)]
        [Display(Name = "Date of birth")]
        [RegularExpression(DateOfBirthRegex, ErrorMessage = DateOfBirthErrorMessage)]
        public string DateOfBirth { get; set; } = string.Empty;

        [Required(ErrorMessage = RequireErrorMessage)]
        [Range(ClassNumberMinValue, ClassNumberMaxValue, ErrorMessage = ClassNumberErrorMessage)]
        [Display(Name = "Class number")]
        public string ClassNumber { get; set; } = string.Empty;

        [Required(ErrorMessage = RequireErrorMessage)]
        [Display(Name = "Class letter")]
        public string ClassLetter { get; set; } = string.Empty;

        public string ParentId { get; set; } = string.Empty;

        [Required(ErrorMessage = RequireErrorMessage)]
        [Display(Name = "School")]
        public string SchoolId { get; set; } = string.Empty;

        public IEnumerable<ClassLetter> ClassLetters { get; set; }

        public IEnumerable<byte> ClassNumbers { get; set; }

        public IEnumerable<SchoolViewModel> Schools { get; set; }
    }
}
