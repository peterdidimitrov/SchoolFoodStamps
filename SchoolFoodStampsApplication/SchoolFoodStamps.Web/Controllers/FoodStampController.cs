using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SchoolFoodStamps.Data.Models;
using SchoolFoodStamps.Services.Data.Interfaces;
using SchoolFoodStamps.Services.Data.Models.FoodStamps;
using SchoolFoodStamps.Web.ViewModels.FoodStamp;
using System.Security.Claims;

namespace SchoolFoodStamps.Web.Controllers
{
    [Authorize]
    public class FoodStampController : BaseController
    {
        private readonly IFoodStampService foodStampService;
        private readonly IStudentService studentService;
        private readonly ISchoolService schoolService;
        private readonly ILogger<HomeController> logger;

        public FoodStampController(IFoodStampService foodStampService, ILogger<HomeController> logger, ISchoolService schoolService, IStudentService studentService)
        {
            this.foodStampService = foodStampService;
            this.logger = logger;
            this.schoolService = schoolService;
            this.studentService = studentService;
        }

        public IActionResult Index()
        {
            return View();
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

            AllFoodStampsFilteredAndPagedServiceModel studentFoodStamps = await foodStampService.GetAllFoodStampsByStudentAsync(queryModel, id);

            queryModel.FoodStamps = studentFoodStamps.FoodStamps;
            queryModel.TotalFoodStamps = studentFoodStamps.TotalFoodStampsCount;
            queryModel.StudentName = student.FirstName + " " + student.LastName;

            return View(queryModel);
        }
    }
}
