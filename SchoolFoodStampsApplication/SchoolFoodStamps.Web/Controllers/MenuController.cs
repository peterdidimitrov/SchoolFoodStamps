using Microsoft.AspNetCore.Mvc;

namespace SchoolFoodStamps.Web.Controllers
{
    public class MenuController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
