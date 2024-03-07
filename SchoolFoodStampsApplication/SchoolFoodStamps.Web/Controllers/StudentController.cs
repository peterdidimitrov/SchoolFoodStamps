using Microsoft.AspNetCore.Mvc;

namespace SchoolFoodStamps.Web.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
