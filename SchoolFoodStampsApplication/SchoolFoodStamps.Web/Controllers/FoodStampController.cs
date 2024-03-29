using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SchoolFoodStamps.Data.Models;
using SchoolFoodStamps.Services.Data.Interfaces;
using SchoolFoodStamps.Services.Data.Models.FoodStamps;
using SchoolFoodStamps.Web.ViewModels.FoodStamp;
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
        private readonly ILogger<HomeController> logger;

        public FoodStampController(IFoodStampService foodStampService, ILogger<HomeController> logger, ISchoolService schoolService, IStudentService studentService, IParentService parentService)
        {
            this.foodStampService = foodStampService;
            this.logger = logger;
            this.schoolService = schoolService;
            this.studentService = studentService;
            this.parentService = parentService;
        }

        [HttpGet]
        [AutoValidateAntiforgeryToken]
        [Authorize(Roles = "Parent")]
        public async Task<IActionResult> Index([FromQuery] AllFoodStampsQueryModel queryModel)
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
            queryModel.Students = students;

            return View(queryModel);
        }

        [HttpGet]
        [AutoValidateAntiforgeryToken]
        [Authorize(Roles = "School")]
        public async Task<IActionResult> AllFoodStampsByStudent([FromQuery] AllFoodStampsQueryModel queryModel, string id)
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
    }
}
