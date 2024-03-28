using System.ComponentModel.DataAnnotations;
using static SchoolFoodStamps.Common.GeneralApplicationConstants;

namespace SchoolFoodStamps.Web.ViewModels.Student
{
    public class AllStudentsQueryModel
    {
        public AllStudentsQueryModel()
        {
            CurrentPage = DefaultPage;
            StudentsPerPage = EntitiesPerPage;

            ClassLetters = new HashSet<ClassLetter>();
            ClassNumbers = new HashSet<byte>();
            Students = new HashSet<StudentViewModel>();
        }

        [Display(Name = "Name")]
        public string? Name { get; set; }

        [Display(Name = "Class number")]
        public string? ClassNumber { get; set; }

        [Display(Name = "Class letter")]
        public string? ClassLetter { get; set; }

        [Display(Name = "Sort by")]
        public StudentSorting StudentSorting { get; set; }

        public int CurrentPage { get; set; }

        [Display(Name = "Pages")]
        public int StudentsPerPage { get; set; }

        public int TotalStudents { get; set; }

        public IEnumerable<ClassLetter> ClassLetters { get; set; }

        public IEnumerable<byte> ClassNumbers { get; set; }

        public IEnumerable<StudentViewModel> Students { get; set; }
    }
}
