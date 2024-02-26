using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static SchoolFoodStamps.Common.EntityValidationConstants.Child;

namespace SchoolFoodStamps.Data.Models
{
    [Comment("Child table")]
    public class Child
    {
        public Child()
        {
            this.Id = Guid.NewGuid();
            this.FoodStamps = new HashSet<FoodStamp>();
        }

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
        public DateTime? DateOfBirth { get; set; }

        [Required]
        [Comment("Child class number in school")]
        public byte ClassNumber { get; set; }

        [Required]
        [Comment("Child class letter in school")]
        public char ClassLetter { get; set; }

        [Required]
        [Comment("Parent identifier")]
        public Guid ParentId { get; set; }

        [ForeignKey(nameof(ParentId))]
        public virtual Parent Parent { get; set; } = null!;

        [Required]
        [Comment("School identifier")]
        public Guid SchoolId { get; set; }

        [ForeignKey(nameof(SchoolId))]
        public virtual School School { get; set; } = null!;

        public virtual ICollection<FoodStamp> FoodStamps { get; set; }
    }
}