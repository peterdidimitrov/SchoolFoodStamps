﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        public DateTime? DateOfBirth { get; set; }

        [Required]
        [Comment("Child class")]
        public int ClassNumber { get; set; }

        [Required]
        [Comment("Child class")]
        public char ClassLetter { get; set; }

        [Required]
        [Comment("User identifier")]
        public Guid ParentId { get; set; }

        [ForeignKey(nameof(ParentId))]
        public virtual Parent Parent { get; set; } = null!;

        [Required]
        [Comment("School identifier")]
        public Guid SchoolId { get; set; }

        [ForeignKey(nameof(SchoolId))]
        public virtual School School { get; set; } = null!;
    }
}