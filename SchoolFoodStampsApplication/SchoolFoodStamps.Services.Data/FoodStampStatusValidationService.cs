using Microsoft.Extensions.Hosting;
using SchoolFoodStamps.Data.Models;
using SchoolFoodStamps.Services.Data.Interfaces;
using SchoolFoodStamps.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace SchoolFoodStamps.Services.Data
{
    public class FoodStampStatusValidationService : BackgroundService, IFoodStampStatusValidationService
    {
        private readonly IFoodStampService _foodStampService;
        private readonly IRepository repository;

        public FoodStampStatusValidationService(IFoodStampService foodStampService, IRepository repository)
        {
            _foodStampService = foodStampService;
            this.repository = repository;
        }

        public async Task ValidateFoodStampStatusesAsync()
        {
            var expiredFoodStamps = await repository
                .All<FoodStamp>()
                .Where(fs => fs.Status == FoodStampStatus.Valid && fs.ExpiryDate < DateTime.UtcNow)
                .ToListAsync();

            foreach (var foodStamp in expiredFoodStamps)
            {
                foodStamp.Status = FoodStampStatus.Expired;
                await repository.UpdateAsync(foodStamp);
            }

            await repository.SaveChangesAsync();
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                var currentTime = DateTime.UtcNow;

                if (currentTime.Hour >= 16 && currentTime.Minute >= 00)
                {
                    await ValidateFoodStampStatusesAsync();
                }

                await Task.Delay(TimeSpan.FromMinutes(1), stoppingToken);
            }
        }
    }
}
