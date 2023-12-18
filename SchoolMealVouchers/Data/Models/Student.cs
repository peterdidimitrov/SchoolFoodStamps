namespace SchoolMealVouchers.Data.Models;

using SchoolMealVouchers.Data.Constances;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Student
{
    [Key]
    public Guid Id { get; set; }

    [Required]
    [MaxLength(ConstancesForStudent.StudentNameMaxLength)]
    public string StudentName { get; set; } = null!;

    [Required]
    public string StudentClass { get; set; } = null!;

    public string? StudentCardNumber { get; set; }

    [ForeignKey(nameof(Parent))]
    public Guid ParentId { get; set; }
    public virtual Parent Parent { get; set; } = null!;

    [ForeignKey(nameof(School))]
    public Guid SchoolId { get; set; }
    public virtual School School { get; set; } = null!;
}
