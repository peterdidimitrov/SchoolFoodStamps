using Microsoft.AspNetCore.Identity;

/// <summary>
/// This is custom ApplicationUser class that inherits from IdentityUser<Guid> class.
/// You can add your custom properties to this class.
/// </summary>
public class ApplicationUser : IdentityUser<Guid>
{
}