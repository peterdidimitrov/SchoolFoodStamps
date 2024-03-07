using SchoolFoodStamps.Web.ViewModels.CateringCompany;
using SchoolFoodStamps.Web.ViewModels.Student;

namespace SchoolFoodStamps.Services.Data.Interfaces
{
    public interface IStudent
    {
        Task CreateAsync(StudentFormViewModel formModel);
        Task<IEnumerable<StudentFormViewModel>> GetAllStudentsAsync();
    }
}
