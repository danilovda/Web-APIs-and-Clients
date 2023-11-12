using WebAppMVC.Models;

namespace WebAppMVC.Services
{
    public interface IEmployeeService
    {
        Task<IEnumerable<Employee>?> GetEmployees();
        Task<Employee?> CreateEmployee(Employee employee);
    }
}
