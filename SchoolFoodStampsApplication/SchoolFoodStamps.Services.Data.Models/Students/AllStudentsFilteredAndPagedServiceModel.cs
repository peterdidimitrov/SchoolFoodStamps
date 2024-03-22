using SchoolFoodStamps.Web.ViewModels.Student;

namespace SchoolFoodStamps.Services.Data.Models.Students
{
    public class AllStudentsFilteredAndPagedServiceModel
    {
        public AllStudentsFilteredAndPagedServiceModel()
        {
            Students = new HashSet<StudentViewModel>();
        }

        public int TotalStudentsCount { get; set; }

        public IEnumerable<StudentViewModel> Students { get; set; }
    }
}
