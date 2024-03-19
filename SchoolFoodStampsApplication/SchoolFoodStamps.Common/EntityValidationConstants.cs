namespace SchoolFoodStamps.Common
{
    public static class EntityValidationConstants
    {   
        public static class CateringCompany
        {
            public const int NameMaxLength = 100;
            public const int NameMinLength = 2;

            public const int AddressMaxLength = 100;
            public const int AddressMinLength = 5;

            public const int PhoneNumberMaxLength = 20;
            public const int PhoneNumberMinLength = 9;

            public const int IdentificationNumberMaxLength = 20;
            public const int IdentificationNumberMinLength = 9;
        }

        public static class Dish
        {
            public const int NameMaxLength = 100;
            public const int NameMinLength = 2;

            public const int DescriptionMaxLength = 500;
            public const int DescriptionMinLength = 10;
        }

        public static class Allergen
        {
            public const int NameMaxLength = 100;
            public const int NameMinLength = 3;
        }

        public static class Parent
        {
            public const int FirstNameMaxLength = 100;
            public const int FirstNameMinLength = 2;

            public const int LastNameMaxLength = 100;
            public const int LastNameMinLength = 2;

            public const int AddressMaxLength = 100;
            public const int AddressMinLength = 5;

            public const int PhoneNumberMaxLength = 20;
            public const int PhoneNumberMinLength = 9;
        }

        public static class Student
        {
            public const int FirstNameMaxLength = 100;
            public const int FirstNameMinLength = 2;

            public const int LastNameMaxLength = 100;
            public const int LastNameMinLength = 2;

            public const int ClassNumberMinValue = 1;
            public const int ClassNumberMaxValue = 12;

            public const string DateOfBirthFormat = "dd/MM/yyyy";

            public const string DateOfBirthRegex = @"^(0[1-9]|[12][0-9]|3[01])/(0[1-9]|1[0-2])/\d{4}$";
        }

        public static class School
        {
            public const int NameMaxLength = 100;
            public const int NameMinLength = 2;

            public const int AddressMaxLength = 100;
            public const int AddressMinLength = 5;

            public const int PhoneNumberMaxLength = 20;
            public const int PhoneNumberMinLength = 9;
        }

        public static class ErrorMessages
        {
            public const string RequireErrorMessage = "The field {0} is required.";
            public const string ErrorMassageLength = "The field {0} must be between {2} and {1} characters long.";
            public const string ErrorMassageOnlyNumbers = "Please enter only hole or floating point numbers.";
            public const string IdentificationNumberErrorMessage = "The Identification Number must be exactly 9 digits long.";
            public const string PhoneNumberErrorMessage = "The Phone Number must be in the format +359 123 456 789.";
            public const string ClassNumberErrorMessage = "The Class Number must be between 1 and 12.";
            public const string DateOfBirthErrorMessage = "The Date of Birth must be in the format dd/MM/yyyy.";
            public const string UnexpectedErrorMessage = "Unexpected error occurred while trying to add new {0}! Please try again or contact administrator.";
        }
    }
}
