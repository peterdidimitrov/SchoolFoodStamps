using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Security.Cryptography;
using static System.Net.Mime.MediaTypeNames;

namespace SchoolFoodStamps.Data.Configuration
{
    public class ApplicationUserEntityCofigurations : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder
                .HasData(this.GenerateUsers());
        }
        private ApplicationUser[] GenerateUsers()
        {
            ICollection<ApplicationUser> users = new HashSet<ApplicationUser>
            {
                new ApplicationUser { Id = Guid.NewGuid(), UserName = "test@test.bg", NormalizedUserName = "TEST@TEST.BG", Email = "test@test.bg", NormalizedEmail = "TEST@TEST.BG", PasswordHash = HashPassword("123456"), SecurityStamp = GenerateSecurityStamp() },
                new ApplicationUser { Id = Guid.NewGuid(), UserName = "pesho@abv.bg", NormalizedUserName = "PESHO@ABV.BG", Email = "pesho@abv.bg", NormalizedEmail = "PESHO@ABV.BG", PasswordHash = HashPassword("123456"), SecurityStamp = GenerateSecurityStamp() }
            };

            return users.ToArray();
        }

        // Method to hash a password
        public static string HashPassword(string password)
        {
            // Generate a random salt
            byte[] salt = new byte[16];
            using (RandomNumberGenerator rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            }

            // Create the Rfc2898DeriveBytes object with the password and salt
            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 10000);

            // Get the hash value
            byte[] hash = pbkdf2.GetBytes(20);

            // Combine the salt and hash
            byte[] hashBytes = new byte[36];
            Array.Copy(salt, 0, hashBytes, 0, 16);
            Array.Copy(hash, 0, hashBytes, 16, 20);

            // Convert the combined bytes to a string
            string hashedPassword = Convert.ToBase64String(hashBytes);

            return hashedPassword;
        }

        // Method to generate a security stamp
        public static string GenerateSecurityStamp()
        {
            // Generate a unique security stamp
            return Guid.NewGuid().ToString().ToUpper();
        }
    }
}
