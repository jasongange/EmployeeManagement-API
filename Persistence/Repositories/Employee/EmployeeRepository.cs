using Microsoft.EntityFrameworkCore;
using Persistence.Paging;

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

        /// <summary>
        /// <seealso cref="IEmployeeRepository.GetPaginatedEmployeesAsync(int, int)"/>
        /// </summary>
        public async Task<PaginatedResult<Domain.Employee>> GetPaginatedEmployeesAsync(int skip, int limit)
        {
            var employees = GetAll();
            var totalCount = employees.Count();

            var items = await employees
                .Skip(skip)
                .Take(limit)
                .ToListAsync();

            return new PaginatedResult<Domain.Employee>
            {
                TotalCount = totalCount,
                Items = items
            };
        }
    }
}
