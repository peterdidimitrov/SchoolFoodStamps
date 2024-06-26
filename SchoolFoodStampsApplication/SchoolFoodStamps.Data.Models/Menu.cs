﻿using Microsoft.EntityFrameworkCore;
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
            this.CreatedOn = DateTime.UtcNow;
            this.IsActive = true;
        }

        [Key]
        [Comment("Menu identifier")]
        public int Id { get; set; }

        [Required]
        [Comment("Menu day of week")]
        public CustomDayOfWeek DayOfWeek { get; set; }

        [Required]
        [Comment("Menu date of creation")]
        public DateTime CreatedOn { get; set; }

        [Comment("Menu date of modify")]
        public DateTime? DateOfModify { get; set; }

        [Required]
        [Comment("Is active")]
        public bool IsActive { get; set; }

        [Required]
        [Comment("Catering company identifier")]
        public Guid CateringCompanyId { get; set; }

        [ForeignKey(nameof(CateringCompanyId))]
        public virtual CateringCompany Company { get; set; } = null!;

        public virtual ICollection<DishMenu> DishesMenus { get; set; }
    }
}