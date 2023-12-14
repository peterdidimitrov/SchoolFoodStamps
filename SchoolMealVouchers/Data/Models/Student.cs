namespace SchoolMealVouchers.Data.Models;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Student
{
    [Key]
    public Guid Id { get; set; }

    [Required]
    public string StudentName { get; set; } = null!;

    [Required]
    public string StudentClass { get; set; } = null!;

    public string? StudentCardNumber { get; set; }

    //public Guid ShcoolId { get; set; }
    //public virtual School School { get; set; } = null!;

    [ForeignKey(nameof(Parent))]
    public Guid ParentId { get; set; }
    public virtual Parent Parent { get; set; } = null!;
}
