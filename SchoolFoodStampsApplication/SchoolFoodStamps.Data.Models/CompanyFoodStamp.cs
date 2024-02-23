//using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations.Schema;

//namespace SchoolFoodStamps.Data.Models
//{
//    public class CompanyFoodStamp
//    {
//        [Required]
//        public Guid CateringCompanyId { get; set; }

//        [ForeignKey(nameof(CateringCompanyId))]
//        public CateringCompany Company { get; set; } = null!;
        
//        [Required]
//        public Guid FoodStampId { get; set; }

//        [ForeignKey(nameof(FoodStampId))]
//        public FoodStamp FoodStamp { get; set; } = null!;
//    }
//}
