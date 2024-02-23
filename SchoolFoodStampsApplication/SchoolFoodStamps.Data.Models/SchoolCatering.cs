//using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations.Schema;

//namespace SchoolFoodStamps.Data.Models
//{
//    public class SchoolCatering
//    {
//        [Required]
//        public Guid SchoolId { get; set; }

//        [ForeignKey(nameof(SchoolId))]
//        public School School { get; set; } = null!;

//        [Required]
//        public Guid CateringCompanyId { get; set; }

//        [ForeignKey(nameof(CateringCompanyId))]
//        public CateringCompany Company { get; set; } = null!;
//    }
//}
