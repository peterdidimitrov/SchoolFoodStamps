//using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations.Schema;

//namespace SchoolFoodStamps.Data.Models
//{
//    public class ParentChild
//    {
//        [Required]
//        public Guid ParentId { get; set; }

//        [ForeignKey(nameof(ParentId))]
//        public Parent Parent { get; set; } = null!;

//        [Required]
//        public Guid ChildId { get; set; }

//        [ForeignKey(nameof(ChildId))]
//        public Child Child { get; set; } = null!;
//    }
//}
