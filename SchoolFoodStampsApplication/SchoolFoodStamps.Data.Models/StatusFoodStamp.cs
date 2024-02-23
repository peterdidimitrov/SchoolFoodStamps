//using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations.Schema;

//namespace SchoolFoodStamps.Data.Models
//{
//    public class StatusFoodStamp
//    {
//        [Required]
//        public int FoodStampStatusId { get; set; }

//        [ForeignKey(nameof(FoodStampStatusId))]
//        public FoodStampStatus Status { get; set; } = null!;

//        [Required]
//        public Guid FoodStampId { get; set; }

//        [ForeignKey(nameof(FoodStampId))]
//        public FoodStamp FoodStamp { get; set; } = null!;
//    }
//}
