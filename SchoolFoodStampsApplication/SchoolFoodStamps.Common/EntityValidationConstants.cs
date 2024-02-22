namespace SchoolFoodStamps.Common
{
    public static class EntityValidationConstants
    {
        public static class FoodStamp
        {
            public const string DateFormat = "dddd, dd MMMM yyyy";
        }

        public static class Status
        {
            public const int NameMaxLength = 100;
            public const int NameMinLength = 3;
        }

        public static class Menu
        {
            public const int DayOfWeekMaxLength = 9;
            public const int DayOfWeekMinLength = 6;
            public const string DateFormat = "MM/dd/yyyy hh:mm tt";
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
        public static class Child
        {
            public const int FirstNameMaxLenght = 100;
            public const int FirstNameMinLenght = 2;

            public const int LastNameMaxLenght = 100;
            public const int LastNameMinLenght = 2;
        }

        public static class ErrorMessages
        {
            public const string RequireErrorMessage = "The field {0} is required.";
            public const string ErrorMassageLength = "The field {0} must be between {2} and {1} characters long.";
            public const string ErrorMassageOnlyNumbers = "Please enter only hole or floating poit numbers.";
        }
       
    }
}
