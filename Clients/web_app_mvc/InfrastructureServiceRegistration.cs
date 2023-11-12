using WebAppMVC.Services;

namespace WebAppMVC;

public static class InfrastructureServiceRegistration
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services,
                                                               IConfiguration configuration)
    {
        string clientApi = configuration["ApiSettings:EmploteeClientApi"]    
            ?? throw new NullReferenceException("ApiSettings:EmployeeClientApi is null");

        services.AddHttpClient<IEmployeeService, EmployeeService>(c =>
            c.BaseAddress = new Uri(clientApi));

        return services;
    }
}
