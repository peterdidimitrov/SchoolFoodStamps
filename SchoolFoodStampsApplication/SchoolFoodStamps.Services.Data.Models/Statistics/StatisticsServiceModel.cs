using System.ComponentModel.DataAnnotations;

namespace SchoolFoodStamps.Services.Data.Models.Statistics
{
    public class StatisticsServiceModel
    {
        [Display(Name = "Total Food Stamps")]
        public int TotalFoodStamps { get; set; }

        [Display(Name = "Total Students")]
        public int TotalStudents { get; set; }

        [Display(Name = "Total Students with Food Stamps")]
        public int TotalStudentsWithFoodStamps { get; set; }

        [Display(Name = "Total Schools")]
        public int TotalSchools { get; set; }

        [Display(Name = "Total Catering Companies")]
        public int TotalCateringCompanies { get; set; }

        [Display(Name = "Total Users")]
        public int TotalUsers { get; set; }
    }
}
