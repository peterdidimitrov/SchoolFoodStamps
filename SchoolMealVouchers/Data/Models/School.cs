namespace SchoolMealVouchers.Data.Models;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class School
{
    public School()
    {
        this.Students = new HashSet<Student>();
    }

    [Key]
    public Guid Id { get; set; }

    [Required]
    public string SchoolName { get; set; } = null!;

    [Required]
    public string SchoolAddress { get; set; } = null!;

    [Required]
    public string SchoolPhoneNumber { get; set; } = null!;


    [ForeignKey(nameof(User))]
    public Guid UserId { get; set; }
    public virtual User User { get; set; } = null!;

    public virtual ICollection<Student> Students { get; set; }
}
