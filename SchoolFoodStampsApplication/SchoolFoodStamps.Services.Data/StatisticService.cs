using Microsoft.EntityFrameworkCore;
using SchoolFoodStamps.Data.Common;
using SchoolFoodStamps.Data.Models;
using SchoolFoodStamps.Services.Data.Interfaces;
using SchoolFoodStamps.Services.Data.Models.Statistics;

namespace SchoolFoodStamps.Services.Data
{
    public class StatisticService : IStatisticService
    {
        private readonly IRepository repository;

        public StatisticService(IRepository repository)
        {
            this.repository = repository;
        }

        public async Task<StatisticsServiceModel> GetStatisticsAsync()
        {
            int totalFoodStamps = await this.repository.AllReadOnly<FoodStamp>().CountAsync();
            int totalStudents = await this.repository.AllReadOnly<Student>().CountAsync();
            int totalStudentsWithFoodStamps = await this.repository.AllReadOnly<Student>().Where(s => s.FoodStamps.Any()).CountAsync();
            int totalSchools = await this.repository.AllReadOnly<School>().CountAsync();
            int totalCateringCompanies = await this.repository.AllReadOnly<CateringCompany>().CountAsync();
            int totalUsers = await this.repository.AllReadOnly<ApplicationUser>().CountAsync();

            return new StatisticsServiceModel
            {
                TotalFoodStamps = totalFoodStamps,
                TotalStudents = totalStudents,
                TotalStudentsWithFoodStamps = totalStudentsWithFoodStamps,
                TotalSchools = totalSchools,
                TotalCateringCompanies = totalCateringCompanies,
                TotalUsers = totalUsers
            };
        }
    }
}
