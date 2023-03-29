using Microsoft.AspNetCore.Mvc;
using Nkwanzi_Medical_center.Data;
using Nkwanzi_Medical_center.Models;
using Nkwanzi_Medical_center.Models.Domain;

namespace Nkwanzi_Medical_center.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly MVCDbContext mvcDbContext;

        public EmployeesController(MVCDbContext mvcDbContext)
        {
            this.mvcDbContext = mvcDbContext;
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Add(AddEmployeeViewModel addEmployeeResult)
        {
            var employee = new Employee
            {
                Id = Guid.NewGuid(),
                Name = addEmployeeResult.Name,
                Email = addEmployeeResult.Email,
                Salary = addEmployeeResult.Salary,
                Department = addEmployeeResult.Department,
                DateOfBirth = addEmployeeResult.DateOfBirth
            };

            await mvcDbContext.Employees.AddAsync(employee);
            await mvcDbContext.SaveChangesAsync();
            return RedirectToAction("Add");
        }
    }
}
