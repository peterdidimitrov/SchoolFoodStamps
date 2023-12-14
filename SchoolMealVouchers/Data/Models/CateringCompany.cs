namespace SchoolMealVouchers.Data.Models;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class CateringCompany
{
    public CateringCompany()
    {
        this.BoughtVouchers = new HashSet<VoucherParent>();
    }
    [Key]
    public Guid Id { get; set; }

    [Required]
    public string CompanyName { get; set; } = null!;

    [Required]
    public string CompanyRegistrationNumber { get; set;} = null!;


    [ForeignKey(nameof(User))]
    public Guid UserId { get; set; }
    public virtual User User { get; set; } = null!;

    public virtual School School { get; set; } = null!;

    public virtual ICollection<VoucherParent> BoughtVouchers { get; set; }
}
