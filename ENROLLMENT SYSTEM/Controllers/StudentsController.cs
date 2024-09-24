using Microsoft.AspNetCore.Mvc;
namespace ENROLLMENT_SYSTEM.Controllers
{
    public class StudentsController : Controller
    {
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
    }
}
