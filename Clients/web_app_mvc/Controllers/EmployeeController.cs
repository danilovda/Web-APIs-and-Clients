using Microsoft.AspNetCore.Mvc;
using WebAppMVC.Models;
using WebAppMVC.Services;

namespace WebAppMVC.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService ?? throw new ArgumentNullException(nameof(employeeService));
        }

        public async Task<IActionResult> List()
        {
            var list = await _employeeService.GetEmployees();

            if (list is null) return NotFound();

            return View(list);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Employee employee)
        {
            if (!ModelState.IsValid) return BadRequest();

            await _employeeService.CreateEmployee(employee);

            return RedirectToAction(nameof(EmployeeController.List), nameof(EmployeeController).Replace("Controller", ""), null);
        }
    }
}
