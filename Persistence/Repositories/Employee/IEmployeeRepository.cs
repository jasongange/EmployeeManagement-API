using Persistence.Paging;

namespace Persistence.Repositories.Employee
{
    /// <summary>
    /// Manages the employee repository
    /// </summary>
    public interface IEmployeeRepository : IRepository<Domain.Employee>
    {
        /// <summary>
        /// Manages retrieving the paginated list of employees.
        /// </summary>
        /// <param name="skip">The paging skip.</param>
        /// <param name="limit">The paging limit.</param>
        Task<PaginatedResult<Domain.Employee>> GetPaginatedEmployeesAsync(int skip, int limit);
    }
}
