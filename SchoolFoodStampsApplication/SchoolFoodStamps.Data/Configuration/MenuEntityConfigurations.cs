using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolFoodStamps.Data.Models;

namespace SchoolFoodStamps.Data.Configuration
{
    public class MenuEntityConfigurations : IEntityTypeConfiguration<Menu>
    {
        public void Configure(EntityTypeBuilder<Menu> builder)
        {
            builder.Property(m => m.CreatedOn)
                .HasDefaultValueSql("GETDATE()");

            builder
                .HasData(this.GenerateMenues());
        }

        private HashSet<Menu> GenerateMenues()
        {
            return new HashSet<Menu>
            {
                new Menu { Id = 1, DayOfWeek = CustomDayOfWeek.Monday, CreatedOn = DateTime.UtcNow, CateringCompanyId = Guid.Parse("EFD31B6C-2A3C-4989-824F-2387C9951234") },
                new Menu { Id = 2, DayOfWeek = CustomDayOfWeek.Tuesday, CreatedOn = DateTime.UtcNow, CateringCompanyId = Guid.Parse("EFD31B6C-2A3C-4989-824F-2387C9951234") },
                new Menu { Id = 3, DayOfWeek = CustomDayOfWeek.Wednesday, CreatedOn = DateTime.UtcNow, CateringCompanyId = Guid.Parse("EFD31B6C-2A3C-4989-824F-2387C9951234") },
                new Menu { Id = 4, DayOfWeek = CustomDayOfWeek.Thursday, CreatedOn = DateTime.UtcNow, CateringCompanyId = Guid.Parse("EFD31B6C-2A3C-4989-824F-2387C9951234") },
                new Menu { Id = 5, DayOfWeek = CustomDayOfWeek.Friday, CreatedOn = DateTime.UtcNow, CateringCompanyId = Guid.Parse("EFD31B6C-2A3C-4989-824F-2387C9951234") }
            };
        }
    }
}
