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
                new Menu { Id = 1, DayOfWeek = DayOfWeek.Monday, CreatedOn = DateTime.UtcNow, CateringCompanyId = Guid.Parse("EFD31B6C-2A3C-4989-824F-2387C9951234") },
                new Menu { Id = 2, DayOfWeek = DayOfWeek.Tuesday, CreatedOn = DateTime.UtcNow, CateringCompanyId = Guid.Parse("EFD31B6C-2A3C-4989-824F-2387C9951234") },
                new Menu { Id = 3, DayOfWeek = DayOfWeek.Wednesday, CreatedOn = DateTime.UtcNow, CateringCompanyId = Guid.Parse("EFD31B6C-2A3C-4989-824F-2387C9951234") },
                new Menu { Id = 4, DayOfWeek = DayOfWeek.Thursday, CreatedOn = DateTime.UtcNow, CateringCompanyId = Guid.Parse("EFD31B6C-2A3C-4989-824F-2387C9951234") },
                new Menu { Id = 5, DayOfWeek = DayOfWeek.Friday, CreatedOn = DateTime.UtcNow, CateringCompanyId = Guid.Parse("EFD31B6C-2A3C-4989-824F-2387C9951234") },
                new Menu { Id = 6, DayOfWeek = DayOfWeek.Saturday, CreatedOn = DateTime.UtcNow, CateringCompanyId = Guid.Parse("EFD31B6C-2A3C-4989-824F-2387C9951234") },
                new Menu { Id = 7, DayOfWeek = DayOfWeek.Sunday, CreatedOn = DateTime.UtcNow, CateringCompanyId = Guid.Parse("EFD31B6C-2A3C-4989-824F-2387C9951234") }
            };
        }
    }
}
