using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SchoolMealVouchers.Data.Models;

public class Parent
{
    public Parent()
    {
        this.Students = new HashSet<Student>();
        //this.BoughtVouchers = new HashSet<Voucher>();
        this.VoucherParents = new HashSet<VoucherParent>();
    }
    [Key]
    public Guid Id { get; set; }

    [Required]
    public string ParentName { get; set; } = null!;

    [Required]
    public string ParentAddress { get; set; } = null!;

    [Required]
    public string ParentPhoneNumber { get; set; } = null!;


    [ForeignKey(nameof(User))]
    public Guid UserId { get; set; }
    public User User { get; set; } = null!;

    public virtual ICollection<Student> Students { get; set; }
    //public virtual ICollection<Voucher> BoughtVouchers { get; set; }
    public virtual ICollection<VoucherParent> VoucherParents { get; set; }
}
