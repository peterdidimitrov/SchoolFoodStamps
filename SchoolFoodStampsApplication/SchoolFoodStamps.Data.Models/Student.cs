using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static SchoolFoodStamps.Common.EntityValidationConstants.Student;

namespace SchoolFoodStamps.Data.Models
{
    [Comment("Child table")]
    public class Student
    {
        public Student()
        {
            this.Id = Guid.NewGuid();
            this.FoodStamps = new HashSet<FoodStamp>();
            this.IsActive = true;
        }

        [Key]
        [Comment("Student identifier")]
        public Guid Id { get; set; }

        [Comment("Student first name")]
        [MaxLength(FirstNameMaxLength)]
        public string? FirstName { get; set; }

        [Comment("Student last name")]
        [MaxLength(LastNameMaxLength)]
        public string? LastName { get; set; }

        [Comment("Student date of birth")]
        public DateTime? DateOfBirth { get; set; }

        [Required]
        [Comment("Student class number in school")]
        public byte ClassNumber { get; set; }

        [Required]
        [Comment("Student class letter in school")]
        public char ClassLetter { get; set; }

        [Required]
        [Comment("Is active")]
        public bool IsActive { get; set; }

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