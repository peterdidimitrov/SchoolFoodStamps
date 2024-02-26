using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static SchoolFoodStamps.Common.EntityValidationConstants.Parent;

namespace SchoolFoodStamps.Data.Models
{
    [Comment("Parent table")]
    public class Parent
    {
        public Parent()
        {
            this.Children = new HashSet<Child>();
            this.FoodStamps = new HashSet<FoodStamp>();
        }

        [Key]
        [Comment("Parent identifier")]
        public Guid Id { get; set; }

        [Required]
        [Comment("Parent first name")]
        [MaxLength(FirstNameMaxLenght)]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        [Comment("Parent last name")]
        [MaxLength(LastNameMaxLenght)]
        public string LastName { get; set; } = string.Empty;

        [Comment("Parent address")]
        [MaxLength(AddressMaxLength)]
        public string? Address { get; set; }

        [Comment("Parent phone number")]
        [MaxLength(PhoneNumberMaxLength)]
        public string? PhoneNumber { get; set; }

        [Required]
        [Comment("User identifier")]
        public Guid UserId { get; set; }

        [ForeignKey(nameof(UserId))]
        public virtual ApplicationUser User { get; set; } = null!;

        public virtual ICollection<Child> Children { get; set; }

        public virtual ICollection<FoodStamp> FoodStamps { get; set; }
    }
}