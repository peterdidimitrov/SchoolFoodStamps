using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace SchoolFoodStamps.Web.Controllers
{
    [Authorize]
    public class MenuController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Authorize(Roles = "CateringCompany")]
        public async Task<IActionResult> Add()
        {
            return View();
        }
    }
}
