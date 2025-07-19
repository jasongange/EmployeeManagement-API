using Domain;

namespace Persistence.Repositories
{
    public class DepartmentRepository : Repository<Department>, IDepartmentRepository
    {
        public DepartmentRepository(EmployeeDbContext context)
            : base(context) { }
    }
}
