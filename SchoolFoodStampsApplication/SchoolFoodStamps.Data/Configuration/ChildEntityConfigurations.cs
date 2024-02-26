using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolFoodStamps.Data.Models;

namespace SchoolFoodStamps.Data.Configuration
{
    public class ChildEntityConfigurations : IEntityTypeConfiguration<Child>
    {
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
    }
}
