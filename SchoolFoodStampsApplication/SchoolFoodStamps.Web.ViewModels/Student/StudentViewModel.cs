using System.ComponentModel.DataAnnotations;

namespace SchoolFoodStamps.Web.ViewModels.Student
{
    public class StudentViewModel
    {
        public string Id { get; set; } = string.Empty;

        [Display(Name = "Name")]
        public string Name { get; set; } = string.Empty;

        [Display(Name = "School")]
        public string SchoolName { get; set; } = string.Empty;
         
        [Display(Name = "Class")]
        public string StudentClass { get; set; } = string.Empty;
    }
}
