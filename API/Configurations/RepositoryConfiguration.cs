using Persistence.Repositories;
using Persistence.Repositories.User;

namespace API.Configurations
{
    public static class RepositoryConfiguration
    {
        public static void RegisterRepositories(this IServiceCollection services)
        {
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            services.AddScoped<IDepartmentRepository, DepartmentRepository>();
        }
    }
}
