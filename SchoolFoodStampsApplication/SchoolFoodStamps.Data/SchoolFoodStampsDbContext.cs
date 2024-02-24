using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Migrations;
using SchoolFoodStamps.Data.Models;

namespace SchoolFoodStamps.Data
{
    public class SchoolFoodStampsDbContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
    {
        public SchoolFoodStampsDbContext(DbContextOptions<SchoolFoodStampsDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<School>()
            .HasOne(s => s.Company)
            .WithMany(c => c.Schools)
            .HasForeignKey(sc => sc.CateringCompanyId)
            .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Child>()
            .HasOne(c => c.Parent)
            .WithMany(s => s.Children)
            .HasForeignKey(c => c.ParentId)
            .OnDelete(DeleteBehavior.NoAction);
            
            modelBuilder.Entity<Child>()
            .HasOne(c => c.School)
            .WithMany(s => s.Children)
            .HasForeignKey(c => c.SchoolId)
            .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<FoodStamp>()
            .HasOne(c => c.Parent)
            .WithMany(s => s.FoodStamps)
            .HasForeignKey(c => c.ParentId)
            .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<FoodStamp>()
            .HasOne(c => c.Child)
            .WithMany(s => s.FoodStamps)
            .HasForeignKey(c => c.ChildId)
            .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<FoodStamp>()
            .HasOne(c => c.CateringCompany)
            .WithMany(s => s.FoodStamps)
            .HasForeignKey(c => c.CateringCompanyId)
            .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Dish>()
            .HasOne(c => c.Menu)
            .WithMany(s => s.Dishes)
            .HasForeignKey(c => c.MenuId)
            .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<FoodStamp>()
            .HasOne(c => c.Menu)
            .WithMany()
            .HasForeignKey(c => c.MenuId)
            .OnDelete(DeleteBehavior.NoAction);

            //modelBuilder
            //    .Entity<FoodStampStatus>()
            //    .HasData(new FoodStampStatus()
            //    {
            //        Id = 1,
            //        Name = "Valid"
            //    },
            //    new FoodStampStatus()
            //    {
            //        Id = 2,
            //        Name = "Used"
            //    },
            //    new FoodStampStatus()
            //    {
            //        Id = 3,
            //        Name = "Expired"
            //    },
            //    new FoodStampStatus()
            //    {
            //        Id = 4,
            //        Name = "Renewed"
            //    });

            base.OnModelCreating(modelBuilder);
        }

        public virtual DbSet<CateringCompany> CateringCompanies { get; set; } = null!;

        public virtual DbSet<Child> Children { get; set; } = null!;

        public virtual DbSet<Dish> Dishes { get; set; } = null!;

        public virtual DbSet<FoodStamp> FoodStamps { get; set; } = null!;

        public virtual DbSet<Menu> Menus { get; set; } = null!;

        public virtual DbSet<Parent> Parents { get; set; } = null!;

        public virtual DbSet<School> Schools { get; set; } = null!;

        public virtual DbSet<Allergen> Allergens { get; set; } = null!;
    }
}
