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
                // Get the current time
                var currentTime = DateTime.UtcNow;

                // Check if it's the end of the day
                if (currentTime.Hour == 23 && currentTime.Minute == 59)
                {
                    // Execute food stamp status validation
                    await ValidateFoodStampStatusesAsync();
                }

                // Delay for one minute
                await Task.Delay(TimeSpan.FromMinutes(1), stoppingToken);
            }
        }
    }
}
