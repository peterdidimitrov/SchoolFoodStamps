using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SchoolFoodStamps.Services.Data.Interfaces;
using SchoolFoodStamps.Web.ViewModels.Student;
using static SchoolFoodStamps.Common.HashHelper;
using static SchoolFoodStamps.Common.NotificationMessagesConstants;

namespace SchoolFoodStamps.Web.Controllers
{
    [Authorize(Roles = "Parent")]
    public class StudentController : Controller
    {
        private readonly ISchoolService schoolService;
        private readonly ILogger<HomeController> logger;
        private readonly IStudentService studentService;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IParentService parentService;

        public StudentController(ISchoolService _schoolService, ILogger<HomeController> _logger, IStudentService _studentService, UserManager<ApplicationUser> _userManager, IParentService _parentService)
        {
            this.schoolService = _schoolService;
            this.logger = _logger;
            this.studentService = _studentService;
            this.userManager = _userManager;
            this.parentService = _parentService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            ApplicationUser? currentUser = await userManager.GetUserAsync(User);

            if (currentUser == null)
            {
                logger.LogWarning("User not found.");
                return View();
            }

            string? parentId = await parentService.GetParentIdAsync(currentUser.Id.ToString());

            if (parentId == null)
            {
                logger.LogWarning("Parent not found.");
                return View();
            }

            IEnumerable<StudentViewModel> students = await studentService.GetAllStudentByParentAsync(parentId);
            return View(students);
        }

        [HttpGet]
        public async Task<IActionResult> AddStudent()
        {
            StudentFormViewModel formModel = new StudentFormViewModel()
            {
                ClassNumbers = studentService.GetAllClassNumbers(),
                ClassLetters = studentService.GetAllClassLetters(),
                Schools = await this.schoolService.GetAllSchoolsAsync()
            };

            return View(formModel);
        }

        [HttpPost]
        public async Task<IActionResult> AddStudent(StudentFormViewModel model)
        {
            ApplicationUser? currentUser = await userManager.GetUserAsync(User);

            if (currentUser == null)
            {
                logger.LogWarning("User not found.");
                model.ClassNumbers = studentService.GetAllClassNumbers();
                model.ClassLetters = studentService.GetAllClassLetters();
                model.Schools = await this.schoolService.GetAllSchoolsAsync();
                return View(model);
            }

            string? parentId = await parentService.GetParentIdAsync(currentUser.Id.ToString());

            if (parentId == null)
            {
                logger.LogWarning("Parent not found.");
                model.ClassNumbers = studentService.GetAllClassNumbers();
                model.ClassLetters = studentService.GetAllClassLetters();
                model.Schools = await this.schoolService.GetAllSchoolsAsync();
                return View(model);
            }

            model.ParentId = parentId;

            logger.LogInformation("School id: {0}", model.SchoolId);

            model.SchoolId = ReverseHashedStringToId(model.SchoolId);

            logger.LogInformation("School id: {0}", model.SchoolId);

            bool schoolExists = await this.schoolService.ExistsByIdAsync(model.SchoolId);


            if (!schoolExists)
            {
                logger.LogWarning("School does not exist.");
                this.ModelState.AddModelError(nameof(model.SchoolId), "School does not exist.");
            }

            if (!ModelState.IsValid)
            {
                logger.LogWarning("Model state is not valid.");
                model.ClassNumbers = studentService.GetAllClassNumbers();
                model.ClassLetters = studentService.GetAllClassLetters();
                model.Schools = await this.schoolService.GetAllSchoolsAsync();
                return View(model);
            }

            try
            {
                await this.studentService.CreateAsync(model);
                logger.LogInformation("Student created successfully.");
            }
            catch (Exception)
            {
                this.ModelState.AddModelError(string.Empty, "Unexpected error occurred while trying to add new school! Please try again or contact administrator.");

                model.ClassNumbers = studentService.GetAllClassNumbers();
                model.ClassLetters = studentService.GetAllClassLetters();
                model.Schools = await this.schoolService
                    .GetAllSchoolsAsync();

                return View(model);
            }

            this.TempData[SuccessMessage] = "Student added successfully.";

            return this.RedirectToAction("Index", "Student");
        }
    }
}
