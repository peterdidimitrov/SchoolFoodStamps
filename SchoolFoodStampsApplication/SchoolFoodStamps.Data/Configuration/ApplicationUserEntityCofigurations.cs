using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SchoolFoodStamps.Data.Configuration
{
    public class ApplicationUserEntityCofigurations : IEntityTypeConfiguration<ApplicationUser>
    {

        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
                // If no users exist, seed the data
                builder.HasData(this.GenerateUsers());
        }
        private ApplicationUser[] GenerateUsers()
        {
            var hasher = new PasswordHasher<ApplicationUser>();
            ICollection<ApplicationUser> users = new HashSet<ApplicationUser>();

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

            return users.ToArray();
        }

        // Method to generate a security stamp
        public static string GenerateSecurityStamp()
        {
            // Generate a unique security stamp
            return Guid.NewGuid().ToString().ToUpper();
        }
    }
}
