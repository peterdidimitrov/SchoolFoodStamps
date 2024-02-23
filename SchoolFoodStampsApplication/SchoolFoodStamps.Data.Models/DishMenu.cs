//using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations.Schema;

//namespace SchoolFoodStamps.Data.Models
//{
//    public class DishMenu
//    {
//        [Required]
//        public int DishId { get; set; }

//        [ForeignKey(nameof(DishId))]
//        public Dish Dish { get; set; } = null!;

//        [Required]
//        public int MenuId { get; set; }

//        [ForeignKey(nameof(MenuId))]
//        public Menu Menu { get; set; } = null!;
//    }
//}
