namespace SchoolMealVouchers.Data.Models;

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using SchoolMealVouchers.Data.Constances;

public class Parent
{
    public Parent()
    {
        this.Students = new HashSet<Student>();
        this.VoucherParents = new HashSet<VoucherParent>();
    }
    [Key]
    public Guid Id { get; set; }

    [Required]
    [MaxLength(ConstancesForParent.ParentNameMaxLength)]
    public string ParentName { get; set; } = null!;

    [Required]
    public string ParentAddress { get; set; } = null!;

    [Required]
    public string ParentPhoneNumber { get; set; } = null!;

    public decimal Money { get; set; }


    [ForeignKey(nameof(User))]
    public Guid UserId { get; set; }
    public User User { get; set; } = null!;

    public virtual ICollection<Student> Students { get; set; }
    public virtual ICollection<VoucherParent> VoucherParents { get; set; }
}
