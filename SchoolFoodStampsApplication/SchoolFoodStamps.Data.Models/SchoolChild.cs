//using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations.Schema;

//namespace SchoolFoodStamps.Data.Models
//{
//    public class SchoolChild
//    {
//        [Required]
//        public Guid SchoolId { get; set; }

//        [ForeignKey(nameof(SchoolId))]
//        public School School { get; set; } = null!;

//        [Required]
//        public Guid ChildId { get; set; }

//        [ForeignKey(nameof(ChildId))]
//        public Child Child { get; set; } = null!;
//    }
//}
