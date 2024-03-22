namespace SchoolFoodStamps.Common
{
    public static class GeneralApplicationConstants
    {
        public const int ReleaseYear = 2023;
        public const decimal FoodStampPrice = 5.00m;
        public const string DateFormat = "dd/MM/yyyy HH:mm";
        public const string IdentificationNumberRegex = @"^\d{9}$";
        public const string PhoneNumberRegex = @"^\+(?:[0-9]\s?){6,14}[0-9]$";

        public const int DefaultPage = 1;
        public const int EntitiesPerPage = 1;
    }
}
