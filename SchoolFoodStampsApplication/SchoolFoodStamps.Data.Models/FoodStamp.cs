﻿using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolFoodStamps.Data.Models
{
    [Comment("Food stamp table")]
    public class FoodStamp
    {
        [Key]
        [Comment("Food stamp identifier")]
        public Guid Id { get; set; }

        [Required]
        [Comment("Food stamp price")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

        [Required]
        [Comment("Food stamp issue date")]
        public DateTime IssueDate { get; set; }

        [Required]
        [Comment("Food stamp use date")]
        public DateTime UseDate { get; set; }

        [Required]
        [Comment("Food stamp expiry date")]
        public DateTime ExpiryDate { get; set; }

        [Required]
        [Comment("Food stamp status identifier")]
        public int StatusId { get; set; }

        [ForeignKey(nameof(StatusId))]
        public virtual FoodStampStatus Status { get; set; } = null!;

        [Required]
        [Comment("Child identifier")]
        public Guid ChildId { get; set; }

        [ForeignKey(nameof(ChildId))]
        public virtual Child Child { get; set; } = null!;

        [Required]
        [Comment("Menu identifier")]
        public int MenuId { get; set; }

        [ForeignKey(nameof(MenuId))]
        public virtual Menu Menu { get; set; } = null!;

        [Required]
        [Comment("User identifier")]
        public string UserId { get; set; } = string.Empty;

        [ForeignKey(nameof(UserId))]
        public virtual IdentityUser User { get; set; } = null!;
    }
}
