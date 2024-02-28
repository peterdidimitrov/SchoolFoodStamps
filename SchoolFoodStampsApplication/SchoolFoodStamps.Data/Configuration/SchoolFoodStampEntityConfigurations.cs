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
                .Property(fs => fs.CreatedOn)
                .HasDefaultValue(DateTime.UtcNow);

            builder
            .HasOne(fs => fs.Parent)
            .WithMany(p => p.FoodStamps)
            .HasForeignKey(fs => fs.ParentId)
            .OnDelete(DeleteBehavior.NoAction);

            builder
            .HasOne(fs => fs.Child)
            .WithMany(c => c.FoodStamps)
            .HasForeignKey(fs => fs.ChildId)
            .OnDelete(DeleteBehavior.NoAction);

            builder
            .HasOne(fs => fs.CateringCompany)
            .WithMany(c => c.FoodStamps)
            .HasForeignKey(fs => fs.CateringCompanyId)
            .OnDelete(DeleteBehavior.NoAction);

            builder
            .HasOne(fs => fs.Menu)
            .WithMany()
            .HasForeignKey(fs => fs.MenuId)
            .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
