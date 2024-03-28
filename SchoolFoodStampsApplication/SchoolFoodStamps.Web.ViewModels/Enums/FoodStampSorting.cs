using System.ComponentModel.DataAnnotations;

public enum FoodStampSorting
{
    [Display(Name = "Issue date")]
    IssueDate = 0,
    [Display(Name = "Expiry date")]
    ExpiryDate = 1,
    [Display(Name = "Renewed date")]
    RenewedDate = 2
}