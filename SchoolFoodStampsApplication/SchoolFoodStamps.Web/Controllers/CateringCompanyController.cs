using Microsoft.AspNetCore.Mvc;

namespace SchoolFoodStamps.Web.Controllers
{
    public class CateringCompanyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
