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

            builder
                .HasData(this.GenerateSchools());
        }

        private HashSet<School> GenerateSchools()
        {
            return new HashSet<School>
            {
                new School() 
                { 
                    Id = Guid.Parse("E3AF4B8E-8F07-4962-838E-670BD305758F"),
                    Name = "41 OU Patriarh Evtimii",
                    Address = "bul. Hristo Botev 41",
                    PhoneNumber = "02 987 6543",
                    IdentificationNumber = "121756886",
                    CateringCompanyId = Guid.Parse("EFD31B6C-2A3C-4989-824F-2387C9951234"),
                    UserId = Guid.Parse("7A40A6C8-B237-4C18-8272-4C8D21C4B5D0")
                },
                new School()
                {
                    Id = Guid.Parse("6CD00C11-B0CB-428A-9143-DF5743105A92"),
                    Name = "51 SOU Hristo  Botev",
                    Address = "bul. Al. Stamboliiski 33",
                    PhoneNumber = "02 987 4243",
                    IdentificationNumber = "121756787",
                    CateringCompanyId = Guid.Parse("8E91E660-535C-4F3A-B2FB-CC4E28682345"),
                    UserId = Guid.Parse("D35E9B04-D31B-40F6-8D0D-DA225A969421")
                },
            };
        }
    }
}