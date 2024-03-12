using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SchoolFoodStamps.Services.Data.Interfaces;
using SchoolFoodStamps.Web.ViewModels.Parent;
using System.Security.Claims;
using static SchoolFoodStamps.Common.NotificationMessagesConstants;

namespace SchoolFoodStamps.Web.Controllers
{
    [Authorize]
    public class ParentController : Controller
    {
        private readonly ILogger<HomeController> logger;
        private readonly IParentService parentService;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly RoleManager<IdentityRole<Guid>> roleManager;

        public ParentController(IParentService _parentService, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole<Guid>> roleManager, ILogger<HomeController> logger)
        {
            this.parentService = _parentService;
            this.userManager = userManager;
            this.roleManager = roleManager;
            this.logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return this.RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            ApplicationUser? currentUser = await userManager.GetUserAsync(User);
            string? userEmail = await userManager.GetEmailAsync(currentUser);

            bool hasAnyRole = await UserHasAnyRoleAsync(userManager, roleManager, userEmail, RolesForCheck());

            if (hasAnyRole)
            {
                logger.LogWarning("User already has a role.");
                return this.CustomizationError();
            }

            ParentFormViewModel formModel = new ParentFormViewModel();

            return View(formModel);
        }

        private async Task<bool> UserHasAnyRoleAsync(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole<Guid>> roleManager, string userEmail, params string[] rolesToCheck)
        {
            IList<string>? userRoles = await userManager.GetRolesAsync(await userManager.FindByEmailAsync(userEmail));
            IList<string>? roles = await roleManager.Roles.Select(r => r.Name).ToListAsync();

            return userRoles.Any(role => rolesToCheck.Contains(role));
        }

        private IActionResult CustomizationError()
        {
            this.TempData[ErrorMessage] = "You already customize your account profile.";
            return this.RedirectToAction(nameof(Index));
        }

        private string[] RolesForCheck()
        {
            return new string[] { "School", "Parent", "CateringCompany" };
        }
        private string GetUserId()
        {
            return User.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? string.Empty;
        }
    }
}
