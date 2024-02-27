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
                Id = Guid.Parse("26264ACB-32DD-44CB-A5E3-5E707E37F61F"), 
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
                Id = Guid.Parse("6136E95F-8387-4023-B476-EA5DDFFBC61E"), 
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
