using System.ComponentModel.DataAnnotations;
using System.Globalization;
using static SchoolFoodStamps.Common.EntityValidationConstants.FoodStamp;

namespace SchoolFoodStamps.Web.Attributes
{
    public class IsBefore : ValidationAttribute
    {
        private readonly string DateTimeFormat = DateFormat;
        private readonly DateTime date;

        public IsBefore(string dateInput)
        {
            date = DateTime.ParseExact(dateInput, DateTimeFormat, CultureInfo.InvariantCulture);
        }

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)

        {
            if (value != null && (DateTime)value >= date)
            {
                return new ValidationResult(ErrorMessage);
            }

            return ValidationResult.Success;
        }
    }
}
