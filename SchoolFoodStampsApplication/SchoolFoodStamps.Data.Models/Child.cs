using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static SchoolFoodStamps.Common.EntityValidationConstants.Child;

namespace SchoolFoodStamps.Data.Models
{
    [Comment("Child table")]
    public class Child
    {
        [Key]
        [Comment("Child identifier")]
        public Guid Id { get; set; }

        [Required]
        [Comment("Child first name")]
        [MaxLength(FirstNameMaxLenght)]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        [Comment("Child last name")]
        [MaxLength(LastNameMaxLenght)]
        public string LastName { get; set; } = string.Empty;

        [Required]
        [Comment("Child date of birth")]
        public DateTime DateOfBirth { get; set; }

        [Required]
        [Comment("User identifier")]
        public string UserId { get; set; } = string.Empty;

        public virtual IdentityUser User { get; set; } = null!;
    }
}