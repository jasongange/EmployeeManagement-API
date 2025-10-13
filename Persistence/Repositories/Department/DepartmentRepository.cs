using Domain;
using Microsoft.EntityFrameworkCore;
using Persistence.Paging;

namespace Persistence.Repositories
{
    /// <summary>
    /// Manages department repository.
    /// </summary>
    /// <seealso cref="IDepartmentRepository" />
    public class DepartmentRepository : Repository<Department>, IDepartmentRepository
    {
        public DepartmentRepository(EmployeeDbContext context)
            : base(context) { }

        /// <summary>
        /// <seealso cref="IDepartmentRepository.GetPaginatedDepartmentsAsync(int, int)"/>
        /// </summary>
        public async Task<PaginatedResult<Department>> GetPaginatedDepartmentsAsync(int skip, int limit)
        {
            var departments = GetAll();
            var totalCount = departments.Count();

            var items = await departments
                .Skip(skip)
                .Take(limit)
                .ToListAsync();

            return new PaginatedResult<Department>
            {
                TotalCount = totalCount,
                Items = items
            };
        }
    }
}
