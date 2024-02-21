using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SchoolFoodStamps.Data.Models;

namespace SchoolFoodStamps.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<AdBuyer>(e => e.HasKey(ep => new
            //{
            //    ep.AdId,
            //    ep.BuyerId
            //}));

            //modelBuilder.Entity<AdBuyer>()
            //.HasOne(ab => ab.Buyer)
            //.WithMany()
            //.HasForeignKey(ab => ab.BuyerId)
            //.OnDelete(DeleteBehavior.NoAction);

            modelBuilder
                .Entity<FoodStampStatus>()
                .HasData(new FoodStampStatus()
                {
                    Id = 1,
                    Name = "Valid"
                },
                new FoodStampStatus()
                {
                    Id = 2,
                    Name = "Used"
                },
                new FoodStampStatus()
                {
                    Id = 3,
                    Name = "Expired"
                },
                new FoodStampStatus()
                {
                    Id = 4,
                    Name = "Renewed"
                });

            base.OnModelCreating(modelBuilder);
        }

        public virtual DbSet<FoodStamp> FoodStamps { get; set; } = null!;
        
        public virtual DbSet<FoodStampStatus> FoodStampStatuses { get; set; } = null!;
        
        public virtual DbSet<Menu> Menus { get; set; } = null!;
        
        public virtual DbSet<Dish> Dishes { get; set; } = null!;

        public virtual DbSet<Child> Children { get; set; } = null!;
    }
}
