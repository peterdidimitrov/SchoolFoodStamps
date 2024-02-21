using Microsoft.AspNetCore.Identity;

namespace SchoolFoodStamps.Data.Models
{
    public class Child
    {
        public Guid Id { get; set; }

        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public DateTime DateOfBirth { get; set; }

        public string UserId { get; set; } = string.Empty;

        public virtual IdentityUser User { get; set; } = null!;
    }
}