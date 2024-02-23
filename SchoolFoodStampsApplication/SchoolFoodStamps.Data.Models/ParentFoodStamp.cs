//using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations.Schema;

//namespace SchoolFoodStamps.Data.Models
//{
//    public class ParentFoodStamp
//    {
//        [Required]
//        public Guid ParentId { get; set; }

//        [ForeignKey(nameof(ParentId))]
//        public Parent Parent { get; set; } = null!;

//        [Required]
//        public Guid FoodStampId { get; set; }

//        [ForeignKey(nameof(FoodStampId))]
//        public FoodStamp FoodStamp { get; set; } = null!;
//    }
//}
