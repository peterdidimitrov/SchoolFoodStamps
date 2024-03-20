namespace System.Security.Claims
{
    public static class ClaimsPrincipalExtensions
    {
        public static string GetId(this ClaimsPrincipal user)
            => user.FindFirstValue(ClaimTypes.NameIdentifier);

        public static string GetEmail(this ClaimsPrincipal user)
            => user.FindFirstValue(ClaimTypes.Email);

        public static string GetRole(this ClaimsPrincipal user)
            => user.FindFirstValue(ClaimTypes.Role);
    }
}
