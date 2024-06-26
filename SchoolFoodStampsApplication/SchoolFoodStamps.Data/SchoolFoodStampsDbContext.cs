﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SchoolFoodStamps.Data.Models;
using System.Reflection;

namespace SchoolFoodStamps.Data
{
    public class SchoolFoodStampsDbContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
    {
        public SchoolFoodStampsDbContext(DbContextOptions<SchoolFoodStampsDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CateringCompany> CateringCompanies { get; set; } = null!;

        public virtual DbSet<Student> Students { get; set; } = null!;

        public virtual DbSet<Dish> Dishes { get; set; } = null!;

        public virtual DbSet<FoodStamp> FoodStamps { get; set; } = null!;

        public virtual DbSet<Menu> Menus { get; set; } = null!;

        public virtual DbSet<Parent> Parents { get; set; } = null!;

        public virtual DbSet<School> Schools { get; set; } = null!;

        public virtual DbSet<Allergen> Allergens { get; set; } = null!;

        public virtual DbSet<AllergenDish> AllergenDishes { get; set; } = null!;

        public virtual DbSet<DishMenu> DishMenus { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Assembly configAssembly = Assembly.GetAssembly(typeof(SchoolFoodStampsDbContext)) ?? 
                                      Assembly.GetExecutingAssembly();
            modelBuilder.ApplyConfigurationsFromAssembly(configAssembly);

            base.OnModelCreating(modelBuilder);
        }
    }
}
