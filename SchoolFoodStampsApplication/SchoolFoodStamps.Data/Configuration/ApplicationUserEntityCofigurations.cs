using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SchoolFoodStamps.Data.Configuration
{
    public class ApplicationUserEntityCofigurations : IEntityTypeConfiguration<ApplicationUser>
    {

        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
                builder.HasData(this.GenerateUsers());
        }
        private HashSet<ApplicationUser> GenerateUsers()
        {
            // Create a password hasher
            var hasher = new PasswordHasher<ApplicationUser>();

            // Create a collection of users
            ICollection<ApplicationUser> users = new HashSet<ApplicationUser>();

            // Create zero user. The user is ADMIN.
            ApplicationUser userZero = new ApplicationUser()
            {
                Id = Guid.Parse("AE67ADEF-86A9-4C12-AFFB-457F91A3EE8E"),
                UserName = "dimitrichko_admin@org.bg",
                NormalizedUserName = "DIMITRICHKO_ADMIN@ORG.BG",
                Email = "dimitrichko_admin@org.bg",
                NormalizedEmail = "DIMITRICHKO_ADMIN@ORG.BG"
            };

            userZero.PasswordHash = hasher.HashPassword(userZero, "Dimitrichko!2#");
            userZero.SecurityStamp = GenerateSecurityStamp();
            users.Add(userZero);

            // Create first user. The user is CATERING COMPANY.
            ApplicationUser userOne = new ApplicationUser() 
            {
                Id = Guid.Parse("FEC4E958-BF56-4247-A6C8-51FAE40D852D"), 
                UserName = "test@test.bg", 
                NormalizedUserName = "TEST@TEST.BG", 
                Email = "test@test.bg", 
                NormalizedEmail = "TEST@TEST.BG" 
            };

            userOne.PasswordHash = hasher.HashPassword(userOne, "123456");
            userOne.SecurityStamp = GenerateSecurityStamp();
            users.Add(userOne);

            // Create second user. The user is CATERING COMPANY.
            ApplicationUser userTwo = new ApplicationUser 
            { 
                Id = Guid.Parse("97C32DF3-7A02-49A9-871B-0B27C4C37CB5"),
                UserName = "pesho@abv.bg", 
                NormalizedUserName = "PESHO@ABV.BG", 
                Email = "pesho@abv.bg", 
                NormalizedEmail = "PESHO@ABV.BG"
            };
            
            userTwo.PasswordHash = hasher.HashPassword(userTwo, "123456"); 
            userTwo.SecurityStamp = GenerateSecurityStamp(); 
            users.Add(userTwo);

            // Create third user. The user is SCHOOL.
            ApplicationUser userThree = new ApplicationUser
            {
                Id = Guid.Parse("7A40A6C8-B237-4C18-8272-4C8D21C4B5D0"),
                UserName = "patriarh.evtimi@abv.bg",
                NormalizedUserName = "PATRIARH.EVTIMI@ABV.BG",
                Email = "patriarh.evtimi@abv.bg",
                NormalizedEmail = "PATRIARH.EVTIMI@ABV.BG"
            };

            userThree.PasswordHash = hasher.HashPassword(userThree, "123456");
            userThree.SecurityStamp = GenerateSecurityStamp();
            users.Add(userThree);

            // Create fourth user. The user is SCHOOL.
            ApplicationUser userFour = new ApplicationUser
            {
                Id = Guid.Parse("D35E9B04-D31B-40F6-8D0D-DA225A969421"),
                UserName = "hristo.botev@abv.bg",
                NormalizedUserName = "HRISTO.BOTEV@ABV.BG",
                Email = "hristo.botev@abv.bg",
                NormalizedEmail = "HRISTO.BOTEV@ABV.BG"
            };

            userFour.PasswordHash = hasher.HashPassword(userFour, "123456");
            userFour.SecurityStamp = GenerateSecurityStamp();
            users.Add(userFour);

            // Create fifth user. The user is PARENT.
            ApplicationUser userFive = new ApplicationUser
            {
                Id = Guid.Parse("F4E56355-18AE-42A7-B082-25A2CF382D3D"),
                UserName = "pesho@yahoo.com",
                NormalizedUserName = "PESHO@YAHOO.COM",
                Email = "pesho@yahoo.com",
                NormalizedEmail = "PESHO@YAHOO.COM"
            };

            userFive.PasswordHash = hasher.HashPassword(userFive, "123456");
            userFive.SecurityStamp = GenerateSecurityStamp();
            users.Add(userFive);

            // Create sixth user. The user is PARENT.
            ApplicationUser userSix = new ApplicationUser
            {
                Id = Guid.Parse("4AA8654E-1465-4839-814C-A62A69D532E9"),
                UserName = "gosho@yahoo.com",
                NormalizedUserName = "GOSHO@YAHOO.COM",
                Email = "gosho@yahoo.com",
                NormalizedEmail = "GOSHO@YAHOO.COM"
            };

            userSix.PasswordHash = hasher.HashPassword(userSix, "123456");
            userSix.SecurityStamp = GenerateSecurityStamp();
            users.Add(userSix);

            return users.ToHashSet();
        }

        // Method to generate a security stamp
        public static string GenerateSecurityStamp()
        {
            // Generate a unique security stamp
            return Guid.NewGuid().ToString().ToUpper();
        }
    }
}
