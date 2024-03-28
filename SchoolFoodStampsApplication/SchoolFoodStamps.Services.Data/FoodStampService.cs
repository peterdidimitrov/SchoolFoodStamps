﻿using Microsoft.EntityFrameworkCore;
using SchoolFoodStamps.Data.Common;
using SchoolFoodStamps.Data.Models;
using SchoolFoodStamps.Services.Data.Interfaces;
using SchoolFoodStamps.Services.Data.Models.FoodStamps;
using SchoolFoodStamps.Web.ViewModels.FoodStamp;
using System.Globalization;
using static SchoolFoodStamps.Common.GeneralApplicationConstants;

namespace SchoolFoodStamps.Services.Data
{
    public class FoodStampService : IFoodStampService
    {
        public IRepository repository { get; set; }

        public FoodStampService(IRepository repository)
        {
            this.repository = repository;
        }
        public async Task<AllFoodStampsFilteredAndPagedServiceModel> GetAllFoodStampsByStudentAsync(AllFoodStampsQueryModel queryModel, string studentId)
        {
            IQueryable<FoodStamp> foodStampQuery = repository
                .AllReadOnly<FoodStamp>()
                .Where(s => s.StudentId == Guid.Parse(studentId))
                .AsQueryable();

            foodStampQuery = queryModel.Status switch
            {
                "Valid" => foodStampQuery
                    .Where(fs => fs.Status == FoodStampStatus.Valid),
                "Used" => foodStampQuery
                    .Where(fs => fs.Status == FoodStampStatus.Used),
                "Renewed" => foodStampQuery
                    .Where(fs => fs.Status == FoodStampStatus.Renewed),
                "Expired" => foodStampQuery
                    .Where(fs => fs.Status == FoodStampStatus.Expired),
                _ => foodStampQuery
            };

            foodStampQuery = queryModel.FoodStampSorting switch
            {
                FoodStampSorting.IssueDate => foodStampQuery
                    .OrderBy(s => s.IssueDate),
                FoodStampSorting.ExpiryDate => foodStampQuery
                    .OrderBy(s => s.ExpiryDate),
                FoodStampSorting.RenewedDate => foodStampQuery
                    .OrderBy(s => s.RenewedDate),
                _ => foodStampQuery
                    .OrderBy(s => s.IssueDate)
            };

            IEnumerable<FoodStampViewModel> allFoodStamps = await foodStampQuery
                .Skip((queryModel.CurrentPage - 1) * queryModel.FoodStampsPerPage)
                .Take(queryModel.FoodStampsPerPage)
                .Select(fs => new FoodStampViewModel
                {
                    Id = fs.Id.ToString(),
                    Price = fs.Price,
                    IssueDate = fs.IssueDate.ToString(DateFormat, CultureInfo.InvariantCulture),
                    ExpiryDate = fs.ExpiryDate.ToString(DateFormat, CultureInfo.InvariantCulture),
                    RenewedDate = fs.RenewedDate.HasValue ? fs.RenewedDate.Value.ToString(DateFormat, CultureInfo.InvariantCulture) : null!,
                    Status = fs.Status.ToString()
                })
                .ToListAsync();

            int totalFoodstamps = await foodStampQuery.CountAsync();

            return new AllFoodStampsFilteredAndPagedServiceModel()
            {
                TotalFoodStampsCount = totalFoodstamps,
                FoodStamps = allFoodStamps
            };
        }
    }
}
