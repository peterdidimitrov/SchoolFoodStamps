using Microsoft.AspNetCore.Mvc;

namespace SchoolFoodStamps.Web.Areas.Admin.Controllers
{
    public class HomeController : BaseAdministratorController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
