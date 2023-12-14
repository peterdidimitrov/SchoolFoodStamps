namespace SchoolMealVouchers.Data.Models;

using SchoolMealVouchers.Data.Models.Enums;
using System.ComponentModel.DataAnnotations;

public class User
{
    [Key]
    public Guid Id { get; set; }

    [Required]
    public string UserName { get; set; } = null!;

    [Required]
    public string Email { get; set; } = null!;

    [Required]
    public string Password { get; set; } = null!;

    [Required]
    public UserType UserType { get; set; }

    public virtual Parent Parent { get; set; } = null!;
    public virtual School School { get; set; } = null!;
    public virtual CateringCompany CateringCompany { get; set; } = null!;
}
