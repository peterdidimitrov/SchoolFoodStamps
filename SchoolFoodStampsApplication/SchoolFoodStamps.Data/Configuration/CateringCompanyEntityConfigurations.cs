using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolFoodStamps.Data.Models;

namespace SchoolFoodStamps.Data.Configuration
{
    public class CateringCompanyEntityConfigurations : IEntityTypeConfiguration<CateringCompany>
    {
        public void Configure(EntityTypeBuilder<CateringCompany> builder)
        {
            builder
                .HasData(this.GenerateCateringCompanies());
        }

        private HashSet<CateringCompany> GenerateCateringCompanies()
        {
            return new HashSet<CateringCompany>
            {
                new CateringCompany 
                { 
                    Id = Guid.Parse("EFD31B6C-2A3C-4989-824F-2387C9951234"), 
                    Name = "ET SAM-DPD", 
                    Address = null,
                    IdentificationNumber = "121756888", 
                    UserId = Guid.Parse("FEC4E958-BF56-4247-A6C8-51FAE40D852D") 
                },
                new CateringCompany 
                { 
                    Id = Guid.Parse("8E91E660-535C-4F3A-B2FB-CC4E28682345"), 
                    Name = "HealtyFoodForChildren",
                    Address = null,
                    IdentificationNumber = "121756889", 
                    UserId = Guid.Parse("97C32DF3-7A02-49A9-871B-0B27C4C37CB5") 
                }
            };
        }
    }
}
