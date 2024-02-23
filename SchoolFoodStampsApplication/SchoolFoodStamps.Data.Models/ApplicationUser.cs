//using Microsoft.AspNetCore.Identity;
//using Microsoft.EntityFrameworkCore;
//using SchoolFoodStamps.Data.Models;
//using System.ComponentModel.DataAnnotations;
//using static SchoolFoodStamps.Common.EntityValidationConstants.ApplicationUser;

//public class ApplicationUser : IdentityUser
//{
//    [Required]
//    [Comment("User first name")]
//    [MaxLength(FirstNameMaxLenght)]
//    public string FirstName { get; set; } = string.Empty;

//    [Required]
//    [Comment("User last name")]
//    [MaxLength(LastNameMaxLenght)]
//    public string LastName { get; set; } = string.Empty;

//    public School School { get; set; } = null!;
//}