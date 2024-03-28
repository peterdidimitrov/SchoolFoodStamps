using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SchoolFoodStamps.Data.Models;
using SchoolFoodStamps.Services.Data.Interfaces;
using SchoolFoodStamps.Web.ViewModels.Student;
using System.Security.Claims;
using static SchoolFoodStamps.Common.NotificationMessagesConstants;
using static SchoolFoodStamps.Common.EntityValidationConstants.Student;
using SchoolFoodStamps.Services.Data.Models.Students;
using System.Globalization;

namespace SchoolFoodStamps.Web.Controllers
{
    [Authorize]
    public class StudentController : BaseController
    {
        private readonly ISchoolService schoolService;
        private readonly ILogger<HomeController> logger;
        private readonly IStudentService studentService;
        private readonly IParentService parentService;

        public StudentController(ISchoolService schoolService, ILogger<HomeController> logger, IStudentService studentService, IParentService parentService)
        {
            this.schoolService = schoolService;
            this.logger = logger;
            this.studentService = studentService;
            this.parentService = parentService;
        }

        [HttpGet]
        [AutoValidateAntiforgeryToken]
        [Authorize(Roles = "Parent")]
        public async Task<IActionResult> Index()
        {
            string userRole = User.GetRole()!;


            IEnumerable<StudentViewModel> parentStudents;
            string? parentId = await parentService.GetParentIdAsync(User.GetId());

            if (parentId == null)
            {
                logger.LogWarning("Parent not found.");
                return Unauthorized();
            }

            parentStudents = await studentService.GetAllStudentByParentAsync(parentId);
            return View(parentStudents);
        }

        [HttpGet]
        [AutoValidateAntiforgeryToken]
        [Authorize(Roles = "School")]
        public async Task<IActionResult> AllStudentsBySchool([FromQuery] AllStudentsQueryModel queryModel)
        {
            string userRole = User.GetRole()!;

            AllStudentsFilteredAndPagedServiceModel schoolStudents;

            string? schoolId = await schoolService.GetSchoolIdAsync(User.GetId()!);

            if (schoolId == null)
            {
                logger.LogWarning("School not found.");
                return Unauthorized();
            }

            schoolStudents = await studentService.GetAllStudentBySchoolAsync(queryModel, schoolId);

            queryModel.Students = schoolStudents.Students;
            queryModel.TotalStudents = schoolStudents.TotalStudentsCount;

            return View(queryModel);
        }

        [HttpGet]
        [Authorize(Roles = "Parent")]
        public async Task<IActionResult> Add()
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
        [Authorize(Roles = "Parent")]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Add(StudentFormViewModel model)
        {
            string? parentId = await parentService.GetParentIdAsync(User.GetId()!);

            if (parentId == null)
            {
                logger.LogWarning("Parent not found.");
                model.ClassNumbers = studentService.GetAllClassNumbers();
                model.ClassLetters = studentService.GetAllClassLetters();
                model.Schools = await this.schoolService.GetAllSchoolsAsync();
                return View(model);
            }

            model.ParentId = parentId;

            bool schoolExists = await this.schoolService.ExistsByIdAsync(model.SchoolId);


            if (!schoolExists)
            {
                logger.LogWarning("School does not exist.");
                this.ModelState.AddModelError(nameof(model.SchoolId), "School does not exist.");
            }

            //TODO: Add validation for existing student with the same name, same birth date and class in the same school

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
                this.ModelState.AddModelError(string.Empty, "Unexpected error occurred while trying to add new student! Please try again or contact administrator.");

                model.ClassNumbers = studentService.GetAllClassNumbers();
                model.ClassLetters = studentService.GetAllClassLetters();
                model.Schools = await this.schoolService
                    .GetAllSchoolsAsync();

                return View(model);
            }

            this.TempData[SuccessMessage] = "Student added successfully.";

            return this.RedirectToAction("Index", "Student");
        }

        [HttpGet]
        [Authorize(Roles = "Parent")]
        public async Task<IActionResult> Edit(Guid id)
        {
            Student? student = await studentService.GetStudentByIdAsync(id);

            if (student == null)
            {
                logger.LogWarning("Student not found.");
                return BadRequest();
            }

            string? parentId = await parentService.GetParentIdAsync(User.GetId()!);

            if (parentId == null)
            {
                logger.LogWarning("Parent not found.");
                return Unauthorized();
            }

            if (student.ParentId != Guid.Parse(parentId))
            {
                logger.LogWarning("Unauthorized access.");
                return Unauthorized();
            }

            StudentFormViewModel formModel = new StudentFormViewModel()
            {
                FirstName = student.FirstName,
                LastName = student.LastName,
                DateOfBirth = student.DateOfBirth.ToString(DateOfBirthFormat, CultureInfo.InvariantCulture),
                ClassNumber = student.ClassNumber.ToString(),
                ClassLetter = student.ClassLetter.ToString(),
                SchoolId = student.SchoolId.ToString(),
                ClassNumbers = studentService.GetAllClassNumbers(),
                ClassLetters = studentService.GetAllClassLetters(),
                Schools = await this.schoolService.GetAllSchoolsAsync()
            };

            return View(formModel);
        }

        [HttpPost]
        [Authorize(Roles = "Parent")]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Edit(StudentFormViewModel model, Guid id)
        {
            Student? student = await studentService.GetStudentByIdAsync(id);

            if (student == null)
            {
                logger.LogWarning("Student not found.");
                return BadRequest();
            }

            string? parentId = await parentService.GetParentIdAsync(User.GetId()!);

            if (parentId == null)
            {
                logger.LogWarning("Parent not found.");
                return Unauthorized();
            }

            if (student.ParentId != Guid.Parse(parentId))
            {
                logger.LogWarning("Unauthorized access.");
                return Unauthorized();
            }

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
                await this.studentService.EditAsync(model, student);
                logger.LogInformation("Student edited successfully.");
            }
            catch (Exception)
            {
                this.ModelState.AddModelError(string.Empty, "Unexpected error occurred while trying to edit student! Please try again or contact administrator.");

                model.ClassNumbers = studentService.GetAllClassNumbers();
                model.ClassLetters = studentService.GetAllClassLetters();
                model.Schools = await this.schoolService
                    .GetAllSchoolsAsync();

                return View(model);
            }

            this.TempData[SuccessMessage] = "Student edited successfully.";

            return this.RedirectToAction("Index", "Student");
        }
    }
}
