using Microsoft.EntityFrameworkCore;
using SchoolFoodStamps.Data;
using SchoolFoodStamps.Services.Data.Interfaces;
using SchoolFoodStamps.Web.ViewModels.CateringCompany;

namespace SchoolFoodStamps.Services.Data
{
    public class CateringCompanyService : ICateringCompanyService
    {
        private readonly SchoolFoodStampsDbContext dbContext;
        public CateringCompanyService(SchoolFoodStampsDbContext _dbContext)
        {
            this.dbContext = _dbContext;
        }
        public async Task<IEnumerable<CateringCompanyViewModel>> GetAllCateringCompaniesAsync()
        {
            return await dbContext
               .CateringCompanies
               .AsNoTracking()
               .OrderBy(c => c.Name)
               .Select(c => new CateringCompanyViewModel()
               {
                   Id = c.Id.ToString(),
                   Name = c.Name
               })
               .ToListAsync();
        }
    }
}
