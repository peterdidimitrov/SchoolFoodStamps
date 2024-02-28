﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static SchoolFoodStamps.Common.EntityValidationConstants.Dish;

namespace SchoolFoodStamps.Data.Models
{
    [Comment("Dish table")]
    public class Dish
    {
        public Dish()
        {
            this.AllergensDishes = new HashSet<AllergenDish>();
            this.DishesMenus = new HashSet<DishMenu>();
        }

        [Key]
        [Comment("Dish identifier")]
        public int Id { get; set; }

        [Required]
        [Comment("Dish name")]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [Comment("Dish description")]
        [MaxLength(DescriptionMaxLength)]
        public string Description { get; set; } = string.Empty;

        [Required]
        [Comment("Dish weight")]
        public double Weight { get; set; }

        [Required]
        [Comment("Catering company identifier")]
        public Guid CateringCompanyId { get; set; }

        [ForeignKey(nameof(CateringCompanyId))]
        public virtual CateringCompany Company { get; set; } = null!;

        public virtual ICollection<AllergenDish> AllergensDishes { get; set; }

        public virtual ICollection<DishMenu> DishesMenus { get; set; }
    }
}