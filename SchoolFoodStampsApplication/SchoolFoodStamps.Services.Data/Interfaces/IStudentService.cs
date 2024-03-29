using SchoolFoodStamps.Data.Models;
using SchoolFoodStamps.Services.Data.Models.Students;
using SchoolFoodStamps.Web.ViewModels.Student;

namespace SchoolFoodStamps.Services.Data.Interfaces
{
    public interface IStudentService
    {
        Task CreateAsync(StudentFormViewModel formModel);

        Task<IEnumerable<StudentViewModel>> GetAllStudentsAsync();

        List<ClassLetter> GetAllClassLetters();

        List<byte> GetAllClassNumbers();

        Task<AllStudentsFilteredAndPagedServiceModel> GetAllStudentBySchoolAsync(AllStudentsQueryModel queryModel, string schoolId);

        Task<IEnumerable<StudentViewModel>> GetAllStudentByParentAsync(string parentId);

        Task<Student?> GetStudentByIdAsync(Guid studentId);

        Task EditAsync (StudentFormViewModel formModel, Student student);

        Task<IEnumerable<StudentViewModel>> GetAllStudentsByParentIdAsync(string parentId);
    }
}
