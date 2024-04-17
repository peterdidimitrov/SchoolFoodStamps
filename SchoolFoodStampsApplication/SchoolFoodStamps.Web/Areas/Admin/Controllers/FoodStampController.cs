using Microsoft.AspNetCore.Mvc;
using SchoolFoodStamps.Services.Data.Interfaces;
using SchoolFoodStamps.Services.Data.Models.FoodStamps;
using SchoolFoodStamps.Web.ViewModels.FoodStamp;

namespace SchoolFoodStamps.Web.Areas.Admin.Controllers
{
    public class FoodStampController : BaseAdministratorController
    {
        private readonly IFoodStampService foodStampService;
        private readonly IFoodStampStatusValidationService foodStampStatusValidationService;
        public FoodStampController(IFoodStampService foodStampService, IFoodStampStatusValidationService foodStampStatusValidationService)
        {
            this.foodStampService = foodStampService;
            this.foodStampStatusValidationService = foodStampStatusValidationService;
        }

        public async Task<IActionResult> Index([FromQuery] AllFoodStampsQueryAdminModel queryModel)
        {
            DateTime currentTime = DateTime.UtcNow;

            await foodStampStatusValidationService.ValidateFoodStampStatusesAsync(currentTime);

            AllFoodStampsFilteredAndPagedServiceModel foodStamps = await this.foodStampService.GetAllFoodStampsAsync(queryModel);

            queryModel.FoodStamps = foodStamps.FoodStamps;
            queryModel.TotalFoodStamps = foodStamps.TotalFoodStampsCount;

            return this.View(queryModel);
        }
    }
}
