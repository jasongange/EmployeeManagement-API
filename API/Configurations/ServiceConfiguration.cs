using API.Services.Department;
using API.Services.Employee;

namespace API.Configurations
{
    /// <summary>
    /// The service configuration.
    /// </summary>
    public static class ServiceConfiguration
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IEmployeeService, EmployeeService>();
            services.AddScoped<IDepartmentService, DepartmentService>();
        }
    }
}
