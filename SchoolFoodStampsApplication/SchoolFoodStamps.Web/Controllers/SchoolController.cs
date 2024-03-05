using Microsoft.AspNetCore.Mvc;

namespace SchoolFoodStamps.Web.Controllers
{
    public class SchoolController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
