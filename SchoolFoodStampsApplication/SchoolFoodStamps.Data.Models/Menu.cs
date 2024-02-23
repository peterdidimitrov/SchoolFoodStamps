using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static SchoolFoodStamps.Common.EntityValidationConstants.Menu;
namespace SchoolFoodStamps.Data.Models
{
    [Comment("Menu table")]
    public class Menu
    {
        public Menu()
        {
            this.Dishes = new HashSet<Dish>();
        
        }

        [Key]
        [Comment("Menu identifier")]
        public int Id { get; set; }

        [Required]
        [Comment("Menu day of week")]
        public DayOfWeek DayOfWeek { get; set; }

        [Comment("Menu date of creation")]
        public DateTime DateOfCreation { get; set; }

        [Comment("Menu date of modify")]
        public DateTime DateOfModify { get; set; }

        public virtual ICollection<Dish> Dishes { get; set; }
    }
}