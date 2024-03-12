namespace SchoolFoodStamps.Services.Data.Interfaces
{
    public interface IUserService
    {
        Task<bool> UserHasAnyRoleAsync(string userEmail);
    }
}
