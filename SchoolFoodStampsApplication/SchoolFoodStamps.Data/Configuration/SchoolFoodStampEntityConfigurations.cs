using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolFoodStamps.Data.Models;

namespace SchoolFoodStamps.Data.Configuration
{
    public class SchoolFoodStampEntityConfigurations : IEntityTypeConfiguration<School>, IEntityTypeConfiguration<Child>, IEntityTypeConfiguration<FoodStamp>, IEntityTypeConfiguration<Dish>
    {
        public void Configure(EntityTypeBuilder<School> builder)
        {
            builder
            .HasOne(s => s.Company)
            .WithMany(c => c.Schools)
            .HasForeignKey(sc => sc.CateringCompanyId)
            .OnDelete(DeleteBehavior.NoAction);
        }

        public void Configure(EntityTypeBuilder<Child> builder)
        {
            builder
            .HasOne(c => c.Parent)
            .WithMany(s => s.Children)
            .HasForeignKey(c => c.ParentId)
            .OnDelete(DeleteBehavior.NoAction);

            builder
            .HasOne(c => c.School)
            .WithMany(s => s.Children)
            .HasForeignKey(c => c.SchoolId)
            .OnDelete(DeleteBehavior.NoAction);
        }

        public void Configure(EntityTypeBuilder<FoodStamp> builder)
        {
            builder
            .HasOne(c => c.Parent)
            .WithMany(s => s.FoodStamps)
            .HasForeignKey(c => c.ParentId)
            .OnDelete(DeleteBehavior.NoAction);

            builder
            .HasOne(c => c.Child)
            .WithMany(s => s.FoodStamps)
            .HasForeignKey(c => c.ChildId)
            .OnDelete(DeleteBehavior.NoAction);

            builder
            .HasOne(c => c.CateringCompany)
            .WithMany(s => s.FoodStamps)
            .HasForeignKey(c => c.CateringCompanyId)
            .OnDelete(DeleteBehavior.NoAction);

            builder
            .HasOne(c => c.Menu)
            .WithMany()
            .HasForeignKey(c => c.MenuId)
            .OnDelete(DeleteBehavior.NoAction);
        }

        public void Configure(EntityTypeBuilder<Dish> builder)
        {
            builder
            .HasOne(c => c.Menu)
            .WithMany(s => s.Dishes)
            .HasForeignKey(c => c.MenuId)
            .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
