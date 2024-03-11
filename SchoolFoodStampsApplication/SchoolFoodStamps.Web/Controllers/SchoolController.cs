using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SchoolFoodStamps.Services.Data.Interfaces;
using SchoolFoodStamps.Web.ViewModels.School;
using System.Security.Claims;
using static SchoolFoodStamps.Common.NotificationMessagesConstants;
using static SchoolFoodStamps.Common.HashHelper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace SchoolFoodStamps.Web.Controllers
{
    [Authorize]
    public class SchoolController : Controller
    {
        private readonly ICateringCompanyService cateringCompanyService;
        private readonly ISchoolService schoolService;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly RoleManager<IdentityRole<Guid>> roleManager;

        public SchoolController(ICateringCompanyService _cateringCompanyService, ISchoolService _schoolService, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole<Guid>> roleManager)
        {
            this.cateringCompanyService = _cateringCompanyService;
            this.schoolService = _schoolService;
            this.userManager = userManager;
            this.roleManager = roleManager;
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
               return this.CustomizationError();
            }

            SchoolFormViewModel formModel = new SchoolFormViewModel()
            {
                CateringCompanies = await this.cateringCompanyService.GetAllCateringCompaniesAsync()
            };

            return View(formModel);
        }

        [HttpPost]
        public async Task<IActionResult> Add(SchoolFormViewModel model)
        {
            ApplicationUser? currentUser = await userManager.GetUserAsync(User);
            string? userEmail = await userManager.GetEmailAsync(currentUser);

            bool hasAnyRole = await UserHasAnyRoleAsync(userManager, roleManager, userEmail, RolesForCheck());

            if (hasAnyRole)
            {
                return this.CustomizationError();
            }

            bool schoolExists = await this.schoolService.ExistsByIdentificationNumberAsync(model.IdentificationNumber);

            if (schoolExists)
            {
                this.ModelState.AddModelError(nameof(model.IdentificationNumber), "School with this identification number already exists.");
            }
            model.CateringCompanyId = ReverseHashedStringToId(model.CateringCompanyId);
            bool companyExists = await this.cateringCompanyService
                .ExistsByIdAsync(model.CateringCompanyId);

            if (!companyExists)
            {
                this.ModelState.AddModelError(nameof(model.CateringCompanyId), "Catering company does not exist.");
            }

            if (!ModelState.IsValid)
            {
                model.CateringCompanies = await this.cateringCompanyService
                    .GetAllCateringCompaniesAsync();
                return View(model);
            }

            try
            {
                string userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                model.UserId = userId;
                await this.schoolService.CreateAsync(model);
            }
            catch (Exception)
            {
                this.ModelState.AddModelError(string.Empty, "Unexpected error occurred while trying to add new school! Please try again or contact administrator.");

                model.CateringCompanies = await this.cateringCompanyService
                    .GetAllCateringCompaniesAsync();

                return View(model);
            }

            this.TempData[SuccessMessage] = "School added successfully.";

            return this.RedirectToAction(nameof(Index));
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
    }
}
