namespace SchoolMealVouchers.Data.Models;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Voucher
{
    [Key]
    public Guid Id { get; set; }

    [Required]
    public DateTime Date { get; set; }

    //[ForeignKey(nameof(User))]
    //public Guid UserId { get; set; }
    //public virtual User User { get; set; } = null!;

    [ForeignKey(nameof(Shcool))]
    public Guid ShcoolId { get; set; }
    public virtual School Shcool { get; set; } = null!;
}
