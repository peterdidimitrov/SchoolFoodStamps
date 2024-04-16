namespace SchoolFoodStamps.Services.Data.Interfaces
{
    public interface IFoodStampStatusValidationService
    {
        Task ValidateFoodStampStatusesAsync(DateTime currentTime);
    }
}
