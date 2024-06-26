﻿using SchoolFoodStamps.Data.Models;
using SchoolFoodStamps.Web.ViewModels.School;

namespace SchoolFoodStamps.Services.Data.Interfaces
{
    public interface ISchoolService
    {
        Task CreateAsync(SchoolFormViewModel formModel);

        Task<bool> ExistsByIdentificationNumberAsync(string identificationNumber);

        Task<bool> ExistsByUserIdAsync(string userId);

        Task<IEnumerable<SchoolViewModel>> GetAllSchoolsAsync();

        Task<bool> ExistsByIdAsync(string Id);

        Task<string?> GetSchoolIdAsync(string userId);

        Task<SchoolFormViewModel?> GetSchoolByUserIdAsync(string userId);

        Task UpdateAsync(SchoolFormViewModel formModel);

        Task<IEnumerable<SchoolViewModel>> GetAllSchoolsByCateringCompanyIdAsync(string cateringId);
    }
}