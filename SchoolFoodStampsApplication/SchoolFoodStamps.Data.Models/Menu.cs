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
        //[MaxLength(DayOfWeekMaxLength)]
        public DayOfWeek DayOfWeek { get; set; }

        public DateTime DateOfCreation { get; set; }

        public DateTime DateOfModify { get; set; }

        public virtual ICollection<Dish> Dishes { get; set; }
    }
}