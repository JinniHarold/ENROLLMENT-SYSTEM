using Microsoft.AspNetCore.Mvc;

namespace ENROLLMENT_SYSTEM.Controllers
{
    public class StudentsController : Controller
    {
        public IActionResult StudentInfo()
        {
            return View();
        }
    }
}
