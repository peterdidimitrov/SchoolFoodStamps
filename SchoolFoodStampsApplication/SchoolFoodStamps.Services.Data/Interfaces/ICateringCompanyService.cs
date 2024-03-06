using SchoolFoodStamps.Web.ViewModels.CateringCompany;

namespace SchoolFoodStamps.Services.Data.Interfaces
{
    public interface ICateringCompanyService
    {
        Task<IEnumerable<CateringCompanyViewModel>> GetAllCateringCompaniesAsync();
    }
}
