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
            //modelBuilder.Entity<SchoolChild>(e => e.HasKey(sc => new
            //{
            //    sc.SchoolId,
            //    sc.ChildId
            //}));

            //modelBuilder.Entity<SchoolCatering>(e => e.HasKey(sc => new
            //{
            //    sc.SchoolId,
            //    sc.CateringCompanyId
            //}));

            //modelBuilder.Entity<ParentChild>(e => e.HasKey(pc => new
            //{
            //    pc.ParentId,
            //    pc.ChildId
            //}));

            //modelBuilder.Entity<ParentFoodStamp>(e => e.HasKey(pf => new
            //{
            //    pf.ParentId,
            //    pf.FoodStampId
            //}));

            //modelBuilder.Entity<CompanyFoodStamp>(e => e.HasKey(cf => new
            //{
            //    cf.CateringCompanyId,
            //    cf.FoodStampId
            //}));

            //modelBuilder.Entity<DishMenu>(e => e.HasKey(dm => new
            //{
            //    dm.DishId,
            //    dm.MenuId
            //}));

            //modelBuilder.Entity<StatusFoodStamp>(e => e.HasKey(sf => new
            //{
            //    sf.FoodStampId,
            //    sf.FoodStampStatusId
            //}));

            modelBuilder.Entity<School>()
            .HasOne(s => s.Company)
            .WithMany(c => c.Schools)
            .HasForeignKey(sc => sc.CateringCompanyId)
            .OnDelete(DeleteBehavior.NoAction);

            //modelBuilder.Entity<Child>()
            //.HasOne(c => c.School)
            //.WithMany(s => s.Children)
            //.HasForeignKey(c => c.SchoolId)
            //.OnDelete(DeleteBehavior.NoAction);

            //modelBuilder.Entity<SchoolCatering>()
            //.HasOne(sc => sc.Company)
            //.WithMany(c => c.Schools)
            //.HasForeignKey(sc => sc.)
            //.OnDelete(DeleteBehavior.NoAction);

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

        //public virtual DbSet<FoodStamp> FoodStamps { get; set; } = null!;
        
        //public virtual DbSet<FoodStampStatus> FoodStampStatuses { get; set; } = null!;
        
        //public virtual DbSet<Menu> Menus { get; set; } = null!;
        
        //public virtual DbSet<Dish> Dishes { get; set; } = null!;

        //public virtual DbSet<Child> Children { get; set; } = null!;

        public virtual DbSet<Parent> Parents { get; set; } = null!;

        public virtual DbSet<School> Schools { get; set; } = null!;

        public virtual DbSet<CateringCompany> CateringCompanies { get; set; } = null!;

        //public virtual DbSet<ParentChild> ParentChildren { get; set; } = null!;

        //public virtual DbSet<ParentFoodStamp> ParentFoodStamps { get; set; } = null!;

        //public virtual DbSet<DishMenu> DishMenus { get; set; } = null!;

        //public virtual DbSet<StatusFoodStamp> StatusFoodStamps { get; set; } = null!;

        //public virtual DbSet<CompanyFoodStamp> CateringFoodStamps { get; set; } = null!;

        //public virtual DbSet<SchoolCatering> SchoolCaterings { get; set; } = null!;

        //public virtual DbSet<SchoolChild> SchoolChildren { get; set; } = null!;
    }
}
