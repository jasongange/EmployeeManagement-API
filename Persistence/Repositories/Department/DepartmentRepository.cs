using Domain;

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
    }
}
