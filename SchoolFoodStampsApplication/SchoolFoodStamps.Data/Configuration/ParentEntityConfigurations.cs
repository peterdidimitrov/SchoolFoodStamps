using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolFoodStamps.Data.Models;

namespace SchoolFoodStamps.Data.Configuration
{
    public class ParentEntityConfigurations : IEntityTypeConfiguration<Parent>
    {
        public void Configure(EntityTypeBuilder<Parent> builder)
        {
            builder.HasData(this.GenerateParents());
        }

        private HashSet<Parent> GenerateParents()
        {
            return new HashSet<Parent>()
            {
                new Parent()
                {
                    Id = Guid.Parse("63281334-434E-4327-B1B7-84B32A9D3D82"),
                    FirstName = "Petar",
                    LastName = "Ivanov",
                    Address = "Sofia, Bulgaria",
                    UserId = Guid.Parse("F4E56355-18AE-42A7-B082-25A2CF382D3D")
                },
                    new Parent()
                    {
                    Id = Guid.Parse("FEC4E958-BF56-4247-A6C8-51FAE40D852D"),
                    FirstName = "Georgi",
                    LastName = "Petrov",
                    Address = "Stara Zagora, Bulgaria",
                    UserId = Guid.Parse("4AA8654E-1465-4839-814C-A62A69D532E9")
                },
            };
        }

        public static string GenerateSecurityStamp()
        {
            // Generate a unique security stamp
            return Guid.NewGuid().ToString().ToUpper();
        }
    }
}
