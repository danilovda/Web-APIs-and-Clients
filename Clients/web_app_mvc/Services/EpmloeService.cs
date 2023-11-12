using WebAppMVC.Extensions;
using WebAppMVC.Models;

namespace WebAppMVC.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly HttpClient _client;

        public EmployeeService(HttpClient client)
        {
            _client = client ?? throw new ArgumentNullException(nameof(client));
        }

        public async Task<Employee?> CreateEmployee(Employee employee)
        {
            var response = await _client.PostAsJson($"/api/employees", employee);

            if (response.IsSuccessStatusCode)
                return await response.ReadContentAs<Employee>();
            else
            {
                throw new Exception("Something went wrong when calling api.");
            }
        }        

        public async Task<IEnumerable<Employee>?> GetEmployees()
        {
            var response = await _client.GetAsync($"/api/employees");
            return await response.ReadContentAs<List<Employee>>();
        }
    }
}
