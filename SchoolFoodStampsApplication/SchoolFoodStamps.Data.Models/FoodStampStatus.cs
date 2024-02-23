//using Microsoft.EntityFrameworkCore;
//using System.ComponentModel.DataAnnotations;
//using static SchoolFoodStamps.Common.EntityValidationConstants.Status;

//namespace SchoolFoodStamps.Data.Models
//{
//    [Comment("Food stamp status table")]
//    public class FoodStampStatus
//    {
//        public FoodStampStatus()
//        {
//            this.FoodStamps = new HashSet<FoodStamp>();
//        }

//        [Key]
//        [Comment("Food stamp status identifier")]
//        public int Id { get; set; }

//        [Required]
//        [Comment("Food stamp status name")]
//        [MaxLength(NameMaxLength)]
//        public string Name { get; set; } = string.Empty;

//        public ICollection<FoodStamp> FoodStamps { get; set; }
//    }
//}