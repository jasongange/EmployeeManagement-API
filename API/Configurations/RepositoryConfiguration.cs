using Persistence.Repositories;
using Persistence.Repositories.Employee;

namespace API.Configurations
{
    /// <summary>
    /// The repository configuration.
    /// </summary>
    public static class RepositoryConfiguration
    {
        public static void RegisterRepositories(this IServiceCollection services)
        {
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            services.AddScoped<IDepartmentRepository, DepartmentRepository>();
        }
    }
}
