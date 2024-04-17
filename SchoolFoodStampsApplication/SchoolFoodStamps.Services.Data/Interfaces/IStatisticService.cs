using SchoolFoodStamps.Services.Data.Models.Statistics;

namespace SchoolFoodStamps.Services.Data.Interfaces
{
    public interface IStatisticService
    {
        Task<StatisticsServiceModel> GetStatisticsAsync();
    }
}
