using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Configurations
{
    /// <summary>
    /// The DbContext configuration.
    /// </summary>
    public static class DbContextConfiguration
    {
        public static void RegisterDbContext(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<EmployeeDbContext>(options =>
                options.UseSqlServer(connectionString));
        }
    }
}
