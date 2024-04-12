using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SchoolFoodStamps.Data.Models;
using SchoolFoodStamps.Services.Data.Interfaces;
using SchoolFoodStamps.Services.Data.Models.FoodStamps;
using SchoolFoodStamps.Web.ViewModels.FoodStamp;
using SchoolFoodStamps.Web.ViewModels.School;
using SchoolFoodStamps.Web.ViewModels.Student;
using System.Security.Claims;
using static SchoolFoodStamps.Common.NotificationMessagesConstants;

namespace SchoolFoodStamps.Web.Controllers
{
    [Authorize]
    public class FoodStampController : BaseController
    {
        private readonly IFoodStampService foodStampService;
        private readonly IStudentService studentService;
        private readonly ISchoolService schoolService;
        private readonly IParentService parentService;
        private readonly ICateringCompanyService cateringCompanyService;
        private readonly ILogger<HomeController> logger;

        public FoodStampController(IFoodStampService foodStampService, ILogger<HomeController> logger, ISchoolService schoolService, IStudentService studentService, IParentService parentService, ICateringCompanyService cateringCompanyService)
        {
            this.foodStampService = foodStampService;
            this.logger = logger;
            this.schoolService = schoolService;
            this.studentService = studentService;
            this.parentService = parentService;
            this.cateringCompanyService = cateringCompanyService;
        }

        [HttpGet]
        [AutoValidateAntiforgeryToken]
        [Authorize(Roles = "Parent")]
        public async Task<IActionResult> Index([FromQuery] AllFoodStampsQueryModel<StudentViewModel> queryModel)
        {
            string? parentId = await parentService.GetParentIdAsync(User.GetId()!);

            if (parentId == null)
            {
                logger.LogWarning("Parent not found.");
                return Unauthorized();
            }

            IEnumerable<StudentViewModel> students = await studentService.GetAllStudentsByParentIdAsync(parentId);

            if (!students.Any())
            {
                logger.LogWarning("Students not found.");
                this.TempData[InformationMessage] = "You should add student before access this section! Please register your first one!";
                return RedirectToAction("Index", "Student");
            }

            AllFoodStampsFilteredAndPagedServiceModel studentFoodStamps = await foodStampService.GetAllFoodStampsByParentIdAsync(queryModel, parentId);

            queryModel.FoodStamps = studentFoodStamps.FoodStamps;
            queryModel.TotalFoodStamps = studentFoodStamps.TotalFoodStampsCount;
            queryModel.Filter = students;

            return View(queryModel);
        }

        [HttpGet]
        [AutoValidateAntiforgeryToken]
        [Authorize(Roles = "School")]
        public async Task<IActionResult> AllFoodStampsByStudent([FromQuery] AllFoodStampsQueryModel<StudentViewModel> queryModel, string id)
        {
            string? schoolId = await schoolService.GetSchoolIdAsync(User.GetId()!);

            if (schoolId == null)
            {
                logger.LogWarning("School not found.");
                return Unauthorized();
            }

            Student? student = await studentService.GetStudentByIdAsync(Guid.Parse(id));

            if (student == null)
            {
                logger.LogWarning("Student not found.");
                return BadRequest();
            }

            if (student.SchoolId != Guid.Parse(schoolId))
            {
                logger.LogWarning("Student not found in this school.");
                return BadRequest();
            }

            AllFoodStampsFilteredAndPagedServiceModel studentFoodStamps = await foodStampService.GetAllFoodStampsByStudentIdAsync(queryModel, id);

            queryModel.FoodStamps = studentFoodStamps.FoodStamps;
            queryModel.TotalFoodStamps = studentFoodStamps.TotalFoodStampsCount;
            queryModel.StudentName = student.FirstName + " " + student.LastName;

            return View(queryModel);
        }

        [HttpGet]
        [AutoValidateAntiforgeryToken]
        [Authorize(Roles = "CateringCompany")]
        public async Task<IActionResult> AllFoodStampsBySchool([FromQuery] AllFoodStampsQueryModel<SchoolViewModel> queryModel)
        {
            string? cateringCompany = await cateringCompanyService.GetCateringCompanyIdAsync(User.GetId()!);

            if (cateringCompany == null)
            {
                logger.LogWarning("Catering company not found.");
                return Unauthorized();
            }

            IEnumerable<SchoolViewModel> schools = await schoolService.GetAllSchoolsByCateringCompanyIdAsync(cateringCompany);

            if (!schools.Any())
            {
                logger.LogWarning("Schools not found.");
                this.TempData[InformationMessage] = "Currently no schools are using your services.";
                return RedirectToAction("Index", "Home");
            }

            AllFoodStampsFilteredAndPagedServiceModel foodStamps = await foodStampService.GetAllFoodStampsByCateringCompanyIdAsync(queryModel, cateringCompany);

            queryModel.FoodStamps = foodStamps.FoodStamps;
            queryModel.TotalFoodStamps = foodStamps.TotalFoodStampsCount;
            queryModel.Filter = schools;

            return View(queryModel);
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        [Authorize(Roles = "Parent")]
        public async Task<IActionResult> Buy(string id)
        {
            string[] ids = id.Split(" ");
            string menuId = ids[0];
            string studentId = ids[1];
            string cateringId = ids[2];

            string? parentId = await parentService.GetParentIdAsync(User.GetId()!);

            if (parentId == null)
            {
                logger.LogWarning("Parent not found.");
                return Unauthorized();
            }

            Student? student = await studentService.GetStudentByIdAsync(Guid.Parse(studentId));

            if (student == null)
            {
                logger.LogWarning("Student not found.");
                return BadRequest();
            }

            if (student.ParentId != Guid.Parse(parentId))
            {
                logger.LogWarning("Student not found in this parent.");
                return BadRequest();
            }

            if (DateTime.UtcNow.Hour > 16)
            {
                this.TempData[ErrorMessage] = "You can buy food stamps only until 16:00!";
                return RedirectToAction("Index");
            }

            try
            {
                await foodStampService.BuyFoodStampAsync(int.Parse(menuId), Guid.Parse(studentId), Guid.Parse(parentId), Guid.Parse(cateringId), student.SchoolId);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error while buying food stamp.");
                this.TempData[ErrorMessage] = "Error while buying food stamp.";
                return RedirectToAction("Index");
            }

            this.TempData[SuccessMessage] = "Food stamp bought successfully!";
            return RedirectToAction("Index");
        }
    }
}
