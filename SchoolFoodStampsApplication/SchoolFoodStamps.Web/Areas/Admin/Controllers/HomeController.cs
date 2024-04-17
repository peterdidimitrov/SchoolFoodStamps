using Microsoft.AspNetCore.Mvc;
using SchoolFoodStamps.Services.Data.Interfaces;
using SchoolFoodStamps.Services.Data.Models.Statistics;

namespace SchoolFoodStamps.Web.Areas.Admin.Controllers
{
    public class HomeController : BaseAdministratorController
    {
        private readonly IStatisticService statisticsService;

        public HomeController(IStatisticService statisticsService)
        {
            this.statisticsService = statisticsService;
        }
        public async Task<IActionResult> Index()
        {
            StatisticsServiceModel statistics = await this.statisticsService.GetStatisticsAsync();
            return View(statistics);
        }
    }
}
