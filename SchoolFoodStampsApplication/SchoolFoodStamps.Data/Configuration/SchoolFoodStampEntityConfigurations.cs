using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolFoodStamps.Data.Models;

namespace SchoolFoodStamps.Data.Configuration
{
    public class SchoolFoodStampEntityConfigurations :  IEntityTypeConfiguration<FoodStamp>
    {
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
    }
}
