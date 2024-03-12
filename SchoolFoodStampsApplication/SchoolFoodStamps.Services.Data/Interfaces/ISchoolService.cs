using SchoolFoodStamps.Web.ViewModels.School;

namespace SchoolFoodStamps.Services.Data.Interfaces
{
    public interface ISchoolService
    {
        Task CreateAsync(SchoolFormViewModel formModel);

        Task<bool> ExistsByIdentificationNumberAsync(string identificationNumber);
    }
}
