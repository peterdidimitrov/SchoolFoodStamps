using Microsoft.EntityFrameworkCore;
using SchoolFoodStamps.Data.Common;
using SchoolFoodStamps.Data.Models;
using SchoolFoodStamps.Services.Data.Interfaces;
using SchoolFoodStamps.Services.Data.Models.FoodStamps;
using SchoolFoodStamps.Web.ViewModels.FoodStamp;
using SchoolFoodStamps.Web.ViewModels.School;
using SchoolFoodStamps.Web.ViewModels.Student;
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
        public async Task<AllFoodStampsFilteredAndPagedServiceModel> GetAllFoodStampsByStudentIdAsync(AllFoodStampsQueryModel<StudentViewModel> queryModel, string studentId)
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

        public async Task<AllFoodStampsFilteredAndPagedServiceModel> GetAllFoodStampsByParentIdAsync(AllFoodStampsQueryModel<StudentViewModel> queryModel, string parentId)
        {
            IQueryable<FoodStamp> foodStampQuery = repository
                .AllReadOnly<FoodStamp>()
                .Where(s => s.ParentId == Guid.Parse(parentId))
                .AsQueryable();

            if (!string.IsNullOrWhiteSpace(queryModel.SearchId))
            {
                foodStampQuery = foodStampQuery
                    .Where(fs => fs.StudentId == Guid.Parse(queryModel.SearchId));
            }


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
                FoodStampSorting.StudentName => foodStampQuery
                    .OrderBy(s => s.Student.FirstName)
                    .ThenBy(s => s.Student.LastName),
                _ => foodStampQuery
                    .OrderBy(s => s.IssueDate)
            };

            IEnumerable<FoodStampViewModel> allFoodStamps = await foodStampQuery
                .Skip((queryModel.CurrentPage - 1) * queryModel.FoodStampsPerPage)
                .Take(queryModel.FoodStampsPerPage)
                .Select(fs => new FoodStampViewModel
                {
                    Id = fs.Id.ToString(),
                    IssueDate = fs.IssueDate.ToString(DateFormat, CultureInfo.InvariantCulture),
                    ExpiryDate = fs.ExpiryDate.ToString(DateFormat, CultureInfo.InvariantCulture),
                    RenewedDate = fs.RenewedDate.HasValue ? fs.RenewedDate.Value.ToString(DateFormat, CultureInfo.InvariantCulture) : null!,
                    Status = fs.Status.ToString(),
                    StudentName = fs.Student.FirstName + " " + fs.Student.LastName
                })
                .ToListAsync();

            int totalFoodstamps = await foodStampQuery.CountAsync();

            return new AllFoodStampsFilteredAndPagedServiceModel()
            {
                TotalFoodStampsCount = totalFoodstamps,
                FoodStamps = allFoodStamps
            };
        }

        public async Task<AllFoodStampsFilteredAndPagedServiceModel> GetAllFoodStampsByCateringCompanyIdAsync(AllFoodStampsQueryModel<SchoolViewModel> queryModel, string cateringCompanyId)
        {
            IQueryable<FoodStamp> foodStampQuery = repository
            .AllReadOnly<FoodStamp>()
                .Where(s => s.CateringCompanyId == Guid.Parse(cateringCompanyId))
                .AsQueryable();

            if (!string.IsNullOrWhiteSpace(queryModel.SearchId))
            {
                foodStampQuery = foodStampQuery
                    .Where(fs => fs.SchoolId == Guid.Parse(queryModel.SearchId));
            }


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

        public async Task BuyFoodStampAsync(int menuId, Guid studentId, Guid parentId, Guid cateringCompanyId, Guid schoolId)
        {

            DateTime startDate = DateTime.Now.Date;
            DateTime expiryDate = await GenerateExpiryDate(menuId, startDate, false);

            FoodStamp newFoodStamp = new FoodStamp
            {
                StudentId = studentId,
                ParentId = parentId,
                CateringCompanyId = cateringCompanyId,
                SchoolId = schoolId,
                MenuId = menuId,
                IssueDate = DateTime.UtcNow,
                ExpiryDate = expiryDate,
                Status = FoodStampStatus.Valid
            };

            await repository.AddAsync(newFoodStamp);
            await repository.SaveChangesAsync();
        }

        public async Task<DateTime> GenerateExpiryDate(int menuId, DateTime startDate, bool isRenew)
        {
            Menu? menu = await repository.AllReadOnly<Menu>().FirstOrDefaultAsync(m => m.Id == menuId);
            DayOfWeek menuDayOfWeek = (DayOfWeek)menu!.DayOfWeek;
            DateTime expiryDate = new DateTime();
            DayOfWeek day = startDate.DayOfWeek;

            if (isRenew)
            {
                while (true)
                {
                    startDate = startDate.AddDays(1);
                    if (startDate.DayOfWeek == DayOfWeek.Saturday || startDate.DayOfWeek == DayOfWeek.Sunday)
                    {
                        continue;
                    }

                    expiryDate = startDate.AddHours(16);
                    break;
                }
            }
            else
            {
                while (true)
                {
                    startDate = startDate.AddDays(1);
                    if (startDate.DayOfWeek == DayOfWeek.Saturday || startDate.DayOfWeek == DayOfWeek.Sunday)
                    {
                        continue;
                    }

                    if (startDate.DayOfWeek == menuDayOfWeek)
                    {
                        expiryDate = startDate.AddHours(16);
                        break;
                    }
                }
            }

            return expiryDate;
        }

        public async Task<FoodStamp?> GetFoodStampByIdAsync(string foodStampId)
        {
            return await repository.AllReadOnly<FoodStamp>()
                .FirstOrDefaultAsync(fs => fs.Id == Guid.Parse(foodStampId));
        }

        public async Task<int> UpdateFoodStampAsync(FoodStamp foodStamp, FoodStampFormViewModel model)
        {
            foodStamp.ExpiryDate = DateTime.ParseExact(model.ExpiryDate, DateFormat, CultureInfo.InvariantCulture);
            foodStamp.RenewedDate = model.RenewedDate != null ? DateTime.ParseExact(model.RenewedDate, DateFormat, CultureInfo.InvariantCulture) : null;
            foodStamp.Status = (FoodStampStatus)Enum.Parse(typeof(FoodStampStatus), model.Status);
            foodStamp.MenuId = int.Parse(model.MenuId);

            await repository.UpdateAsync(foodStamp);
            return await repository.SaveChangesAsync();
        }
    }
}
