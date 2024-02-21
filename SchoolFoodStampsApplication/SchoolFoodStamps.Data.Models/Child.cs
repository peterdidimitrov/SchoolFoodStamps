using Microsoft.AspNetCore.Identity;

namespace SchoolFoodStamps.Data.Models
{
    public class Child
    {
        public Guid Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string UserId { get; set; }

        public virtual IdentityUser User { get; set; }
    }
}