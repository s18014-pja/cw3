using Microsoft.AspNetCore.Mvc;

namespace cw3.Controllers
{
    public class StudentsController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}