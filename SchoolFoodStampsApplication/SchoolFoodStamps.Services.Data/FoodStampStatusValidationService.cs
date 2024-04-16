using Microsoft.EntityFrameworkCore;
using SchoolFoodStamps.Data.Common;
using SchoolFoodStamps.Data.Models;
using SchoolFoodStamps.Services.Data.Interfaces;

namespace SchoolFoodStamps.Services.Data
{
    public class FoodStampStatusValidationService : IFoodStampStatusValidationService
    {
        private readonly IFoodStampService foodStampService;
        private readonly IRepository repository;

        public FoodStampStatusValidationService(IFoodStampService foodStampService, IRepository repository)
        {
            this.foodStampService = foodStampService;
            this.repository = repository;
        }

        public async Task ValidateFoodStampStatusesAsync(DateTime currentTime)
        {
            if (currentTime.Hour >= 16 && currentTime.Minute >= 00)
            {
                List<FoodStamp> expiredFoodStamps = await repository
                .All<FoodStamp>()
                .Where(fs => fs.Status == FoodStampStatus.Valid && fs.ExpiryDate < currentTime)
                .ToListAsync();

                foreach (var foodStamp in expiredFoodStamps)
                {
                    foodStamp.Status = FoodStampStatus.Expired;
                    await repository.UpdateAsync(foodStamp);
                }

                await repository.SaveChangesAsync();
            }
        }
    }
}
