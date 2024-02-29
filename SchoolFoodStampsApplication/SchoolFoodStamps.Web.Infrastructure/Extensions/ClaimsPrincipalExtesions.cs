using System.Security.Claims;

namespace SchoolFoodStamps.Web.Infrastructure.Extensions
{
    public static class ClaimsPrincipalExtesions
    {
        public static string? GetId(this ClaimsPrincipal user)
            => user.FindFirstValue(ClaimTypes.NameIdentifier);
    }
}
