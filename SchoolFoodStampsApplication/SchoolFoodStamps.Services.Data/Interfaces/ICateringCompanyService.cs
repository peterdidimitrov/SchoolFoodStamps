using SchoolFoodStamps.Web.ViewModels.CateringCompany;

namespace SchoolFoodStamps.Services.Data.Interfaces
{
    public interface ICateringCompanyService
    {
        Task<IEnumerable<CateringCompanyViewModel>> GetAllCateringCompaniesAsync();

        Task<bool> ExistsByIdAsync(string Id);

        Task CreateAsync(CateringCompanyFormViewModel formModel);

        Task<bool> ExistsByIdentificationNumberAsync(string identificationNumber);

        Task<bool> ExistsByUserIdAsync(string userId);

        Task<CateringCompanyFormViewModel?> GetCateringCompanyByUserIdAsync(string userId);

        Task UpdateAsync(CateringCompanyFormViewModel formModel);

        Task<string?> GetCateringCompanyIdAsync(string userId);
    }
}
