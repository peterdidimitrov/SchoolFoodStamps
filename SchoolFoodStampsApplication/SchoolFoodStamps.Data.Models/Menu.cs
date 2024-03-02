using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolFoodStamps.Data.Models
{
    [Comment("Menu table")]
    public class Menu
    {
        public Menu()
        {
            this.DishesMenus = new HashSet<DishMenu>();
        }

        [Key]
        [Comment("Menu identifier")]
        public int Id { get; set; }

        [Required]
        [Comment("Menu day of week")]
        public DayOfWeek DayOfWeek { get; set; }

        [Required]
        [Comment("Menu date of creation")]
        public DateTime CreatedOn { get; set; }

        [Comment("Menu date of modify")]
        public DateTime? DateOfModify { get; set; }

        [Required]
        [Comment("Catering company identifier")]
        public Guid CateringCompanyId { get; set; }

        [ForeignKey(nameof(CateringCompanyId))]
        public virtual CateringCompany Company { get; set; } = null!;

        public virtual ICollection<DishMenu> DishesMenus { get; set; }
    }
}