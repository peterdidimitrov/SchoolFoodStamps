namespace SchoolMealVouchers.Data.Models;

using System.ComponentModel.DataAnnotations.Schema;

public class VoucherParent
{
    [ForeignKey(nameof(Parent))]
    public Guid ParentId { get; set; }
    public Parent Parent { get; set; } = null!;

    [ForeignKey(nameof(Voucher))]
    public Guid VoucherId { get; set; }
    public Voucher Voucher { get; set; } = null!;
}

