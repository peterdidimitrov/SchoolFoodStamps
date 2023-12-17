namespace SchoolMealVouchers.Data.Models;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Voucher
{
    [Key]
    public Guid Id { get; set; }

    [Required]
    public DateTime Date { get; set; }
}
