using Microsoft.AspNetCore.Mvc;

namespace Nkwanzi_Medical_center.Controllers
{
    public class EmployeesController : Controller
    {
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
    }
}
