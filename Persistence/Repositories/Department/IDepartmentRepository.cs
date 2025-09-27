using Domain;
using Persistence.Paging;

namespace Persistence.Repositories
{
    /// <summary>
    /// Manages the department repository
    /// </summary>
    public interface IDepartmentRepository : IRepository<Department>
    {
        /// <summary>
        /// Manages retrieving the paginated list of departments.
        /// </summary>
        /// <param name="skip">The paging skip.</param>
        /// <param name="limit">The paging limit.</param>
        Task<PaginatedResult<Department>> GetPaginatedDepartmentsAsync(int skip, int limit);
    }
}
