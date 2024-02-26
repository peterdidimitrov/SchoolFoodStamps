using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static SchoolFoodStamps.Common.EntityValidationConstants.School;

namespace SchoolFoodStamps.Data.Models
{
    [Comment("School table")]
    public class School
    {
        public School()
        {
            this.Id = Guid.NewGuid();
            this.Children = new HashSet<Child>();
        }

        [Key]
        [Comment("School identifier")]
        public Guid Id { get; set; }

        [Required]
        [Comment("School name")]
        [MaxLength(NameMaxLenght)]
        public string Name { get; set; } = string.Empty;

        [Comment("School address")]
        [MaxLength(AddressMaxLenght)]
        public string? Address { get; set; }

        [Comment("School phone number")]
        [MaxLength(PhoneNumberMaxLength)]
        public string? PhoneNumber { get; set; }

        [Required]
        public string IdentificationNumber { get; set; } = null!;

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

        public virtual ICollection<Child> Children { get; set; }
    }
}
