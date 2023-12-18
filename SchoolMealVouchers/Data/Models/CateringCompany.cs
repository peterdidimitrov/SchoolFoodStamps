namespace SchoolMealVouchers.Data.Models;

using SchoolMealVouchers.Data.Constances;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class CateringCompany
{
    public CateringCompany()
    {
        this.Schools = new HashSet<School>();
    }
    [Key]
    public Guid Id { get; set; }

    [Required]
    [MaxLength(ConstancesForCateringCompany.CompanyNameMaxLength)]
    public string CompanyName { get; set; } = null!;

    [Required]
    public string CompanyRegistrationNumber { get; set;} = null!;

    [ForeignKey(nameof(User))]
    public Guid UserId { get; set; }
    public virtual User User { get; set; } = null!;

    public virtual ICollection<School> Schools { get; set; }
}
