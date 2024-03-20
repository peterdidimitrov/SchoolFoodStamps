using Microsoft.AspNetCore.Mvc;
using static SchoolFoodStamps.Common.NotificationMessagesConstants;

namespace SchoolFoodStamps.Web.Controllers
{
    public class BaseController : Controller
    {
        public IActionResult CustomizationError()
        {
            this.TempData[ErrorMessage] = "You already customized your profile.";
            return this.RedirectToAction(nameof(Index));
        }
    }
}
