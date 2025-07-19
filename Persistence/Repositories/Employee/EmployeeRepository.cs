using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Repositories.User
{
    public class EmployeeRepository : Repository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(EmployeeDbContext context)
            : base(context) { }

        public IQueryable<Employee> GetAll()
        {
            return context.Employee.Include(d => d.Department).AsQueryable();
        }
    }
}
