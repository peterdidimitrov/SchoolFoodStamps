using Microsoft.EntityFrameworkCore;
using SchoolFoodStamps.Data.Common;
using SchoolFoodStamps.Data.Models;
using SchoolFoodStamps.Services.Data.Interfaces;
using SchoolFoodStamps.Web.ViewModels.Allergen;

namespace SchoolFoodStamps.Services.Data
{
    public class AllergenService : IAllergenService
    {
        private readonly IRepository repository;

        public AllergenService(IRepository repository)
        {
            this.repository = repository;
        }
        public async Task<IEnumerable<AllergenViewModel>> GetAllAsync()
        {
            return await this.repository
                .AllReadOnly<Allergen>()
                .Select(a => new AllergenViewModel
                {
                    Id = a.Id.ToString(),
                    Name = a.Name,
                })
                .ToListAsync();
        }
    }
}
