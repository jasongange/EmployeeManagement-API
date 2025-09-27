using Microsoft.EntityFrameworkCore;

namespace Persistence.Repositories.Employee
{
    /// <summary>
    /// Manages employee repository.
    /// </summary>
    /// <seealso cref="IEmployeeRepository" />
    public class EmployeeRepository : Repository<Domain.Employee>, IEmployeeRepository
    {
        public EmployeeRepository(EmployeeDbContext context)
            : base(context) { }

        /// <summary>
        /// Manages retrieving the employees.
        /// </summary>
        public IQueryable<Domain.Employee> GetAll()
        {
            return context.Employee.Include(d => d.Department).AsQueryable();
        }
    }
}
