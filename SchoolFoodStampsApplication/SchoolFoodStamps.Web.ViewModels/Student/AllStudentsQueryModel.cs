using System.ComponentModel.DataAnnotations;

namespace SchoolFoodStamps.Web.ViewModels.Student
{
    public class AllStudentsQueryModel
    {
        public AllStudentsQueryModel()
        {
            ClassLetters = new HashSet<ClassLetter>();
            ClassNumbers = new HashSet<byte>();
            Students = new HashSet<StudentViewModel>();
        }

        [Display(Name = "Search by name")]
        public string? Name { get; set; }

        //[Display(Name = "Search by class number")]
        //public string? ClassNumber { get; set; }

        [Display(Name = "Search by class letter")]
        public string? ClassLetter { get; set; }

        [Display(Name = "Sort Students By")]
        public StudentSorting StudentSorting { get; set; }

        public int CurrentPage { get; set; }

        [Display(Name = "Show Students On Page")]
        public int StudentsPerPage { get; set; }

        public int TotalStudents { get; set; }

        public IEnumerable<ClassLetter> ClassLetters { get; set; }

        public IEnumerable<byte> ClassNumbers { get; set; }

        public IEnumerable<StudentViewModel> Students { get; set; }
    }
}
