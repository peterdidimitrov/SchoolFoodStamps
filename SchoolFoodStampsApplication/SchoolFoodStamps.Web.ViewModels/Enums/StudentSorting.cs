using System.ComponentModel.DataAnnotations;

public enum StudentSorting
{
    Name = 0,
    Class = 1,
    [Display(Name = "Has food stamps")]
    HasFoodStamps = 2,
    School = 3
}