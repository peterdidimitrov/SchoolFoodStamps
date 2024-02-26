using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolFoodStamps.Data.Models;

namespace SchoolFoodStamps.Data.Configuration
{
    public class SchoolEntityConfigurations : IEntityTypeConfiguration<School>
    {
        public void Configure(EntityTypeBuilder<School> builder)
        {
            builder
            .HasOne(s => s.Company)
            .WithMany(c => c.Schools)
            .HasForeignKey(sc => sc.CateringCompanyId)
            .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
