using SchoolFoodStamps.Data;
using SchoolFoodStamps.Data.Models;

namespace SchoolFoodStamps.Services.Tests
{
    public static class DataBaseSeeder
    {
        public static List<ApplicationUser> Users = null!;
        public static List<CateringCompany> Companies = null!;
        public static List<School> Schools = null!;

        public static void SeedDataBase(SchoolFoodStampsDbContext dbContext)
        {

            Users = new List<ApplicationUser>()
            {
                new ApplicationUser()
            {
                Id = Guid.Parse("AE67ADEF-86A9-4C12-AFFB-457F91A3EE8E"),
                UserName = "dimitrichko_admin@org.bg",
                NormalizedUserName = "DIMITRICHKO_ADMIN@ORG.BG",
                Email = "dimitrichko_admin@org.bg",
                NormalizedEmail = "DIMITRICHKO_ADMIN@ORG.BG"
            },
                new ApplicationUser()
            {
                Id = Guid.Parse("FEC4E958-BF56-4247-A6C8-51FAE40D852D"),
                UserName = "test@test.bg",
                NormalizedUserName = "TEST@TEST.BG",
                Email = "test@test.bg",
                NormalizedEmail = "TEST@TEST.BG"
            },
                new ApplicationUser
            {
                Id = Guid.Parse("97C32DF3-7A02-49A9-871B-0B27C4C37CB5"),
                UserName = "pesho@abv.bg",
                NormalizedUserName = "PESHO@ABV.BG",
                Email = "pesho@abv.bg",
                NormalizedEmail = "PESHO@ABV.BG"
            },
                new ApplicationUser
            {
                Id = Guid.Parse("7A40A6C8-B237-4C18-8272-4C8D21C4B5D0"),
                UserName = "patriarh.evtimi@abv.bg",
                NormalizedUserName = "PATRIARH.EVTIMI@ABV.BG",
                Email = "patriarh.evtimi@abv.bg",
                NormalizedEmail = "PATRIARH.EVTIMI@ABV.BG"
            },
                new ApplicationUser
            {
                Id = Guid.Parse("D35E9B04-D31B-40F6-8D0D-DA225A969421"),
                UserName = "hristo.botev@abv.bg",
                NormalizedUserName = "HRISTO.BOTEV@ABV.BG",
                Email = "hristo.botev@abv.bg",
                NormalizedEmail = "HRISTO.BOTEV@ABV.BG"
            },
                new ApplicationUser
            {
                Id = Guid.Parse("F4E56355-18AE-42A7-B082-25A2CF382D3D"),
                UserName = "pesho@yahoo.com",
                NormalizedUserName = "PESHO@YAHOO.COM",
                Email = "pesho@yahoo.com",
                NormalizedEmail = "PESHO@YAHOO.COM"
            },
                new ApplicationUser
            {
                Id = Guid.Parse("4AA8654E-1465-4839-814C-A62A69D532E9"),
                UserName = "gosho@yahoo.com",
                NormalizedUserName = "GOSHO@YAHOO.COM",
                Email = "gosho@yahoo.com",
                NormalizedEmail = "GOSHO@YAHOO.COM"
            }
        };

            Companies = new List<CateringCompany>()
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
            Schools = new List<School>()
            {
                new School()
                {
                    Id = Guid.Parse("E3AF4B8E-8F07-4962-838E-670BD305758F"),
                    Name = "41 OU Patriarh Evtimii",
                    Address = "bul. Hristo Botev 41",
                    IdentificationNumber = "121756886",
                    CateringCompanyId = Guid.Parse("EFD31B6C-2A3C-4989-824F-2387C9951234"),
                    UserId = Guid.Parse("7A40A6C8-B237-4C18-8272-4C8D21C4B5D0")
                },
                new School()
                {
                    Id = Guid.Parse("6CD00C11-B0CB-428A-9143-DF5743105A92"),
                    Name = "51 SOU Hristo  Botev",
                    Address = "bul. Al. Stamboliiski 33",
                    IdentificationNumber = "121756787",
                    CateringCompanyId = Guid.Parse("8E91E660-535C-4F3A-B2FB-CC4E28682345"),
                    UserId = Guid.Parse("D35E9B04-D31B-40F6-8D0D-DA225A969421")
                },
            };

            dbContext.Users.AddRange(Users);
            dbContext.CateringCompanies.AddRange(Companies);
            dbContext.Schools.AddRange(Schools);
            dbContext.SaveChanges();
        }
    }
}
