namespace SchoolMealVouchers.Data.Models;

using System.ComponentModel.DataAnnotations;

public class Voucher
{
    [Key]
    public Guid Id { get; set; }

    [Required]
    public DateTime Date { get; set; }

    [Required]
    public decimal Price { get; set; }
}
