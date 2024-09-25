using ENROLLMENT_SYSTEM.Data;
using ENROLLMENT_SYSTEM.Models;
using Microsoft.AspNetCore.Mvc;
namespace ENROLLMENT_SYSTEM.Controllers
{
    public class StudentsController : Controller
    {
        private readonly ApplicationDbContext dbContext;

        public StudentsController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(AddStudentViewModel viewModel) 
        {

            return View();
        }
    }
}
