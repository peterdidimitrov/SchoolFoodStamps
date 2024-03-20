using SchoolFoodStamps.Data.Models;
using SchoolFoodStamps.Web.ViewModels.Student;

namespace SchoolFoodStamps.Services.Data.Interfaces
{
    public interface IStudentService
    {
        Task CreateAsync(StudentFormViewModel formModel);

        Task<IEnumerable<StudentViewModel>> GetAllStudentsAsync();

        List<ClassLetter> GetAllClassLetters();

        List<byte> GetAllClassNumbers();

        Task<IEnumerable<StudentViewModel>> GetAllStudentBySchoolAsync(string schoolId);

        Task<IEnumerable<StudentViewModel>> GetAllStudentByParentAsync(string parentId);

        Task<Student?> GetStudentByIdAsync(Guid studentId);
    }
}
