using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static SchoolFoodStamps.Common.EntityValidationConstants.School;

namespace SchoolFoodStamps.Data.Models
{
    [Index(nameof(IdentificationNumber), IsUnique = true)]
    [Comment("School table")]
    public class School
    {
        public School()
        {
            this.Id = Guid.NewGuid();
            this.Students = new HashSet<Student>();
        }

        [Key]
        [Comment("School identifier")]
        public Guid Id { get; set; }

        [Required]
        [Comment("School name")]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = string.Empty;

        [Comment("School address")]
        [MaxLength(AddressMaxLength)]
        public string? Address { get; set; }

        [Required]
        [Comment("Catering company Identification Number")]
        [MaxLength(IdentificationNumberMaxLength)]
        public string IdentificationNumber { get; set; } = string.Empty;

        [Required]
        [Comment("Catering company identifier")]
        public Guid CateringCompanyId { get; set; }

        [ForeignKey(nameof(CateringCompanyId))]
        public virtual CateringCompany Company { get; set; } = null!;

        [Required]
        [Comment("User identifier")]
        public Guid UserId { get; set; }

        [ForeignKey(nameof(UserId))]
        public virtual ApplicationUser User { get; set; } = null!;

        public virtual ICollection<Student> Students { get; set; }
    }
}
