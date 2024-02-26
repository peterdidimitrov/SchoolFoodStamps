using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SchoolFoodStamps.Web.ViewModels.Home;
using System.Diagnostics;

namespace SchoolFoodStamps.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> logger;
        private readonly SignInManager<ApplicationUser> signInManager;

        public HomeController(ILogger<HomeController> _logger, SignInManager<ApplicationUser>  _signInManager)
        {
            this.logger = _logger;
            this.signInManager = _signInManager;
        }

        public IActionResult Index()
        {
            //if (signInManager.IsSignedIn(User))
            //{
            //    return RedirectToAction("Index", "Dashboard");
            //}

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
