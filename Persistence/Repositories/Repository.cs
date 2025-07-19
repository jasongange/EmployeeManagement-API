using Microsoft.EntityFrameworkCore;

namespace Persistence.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly EmployeeDbContext context;
        private readonly DbSet<T> dbSet;

        public Repository(EmployeeDbContext context)
        {
            this.context = context;
            this.dbSet = context.Set<T>();
        }

        public async Task<T?> GetByIdAsync(string id) 
        { 
           return await dbSet.FindAsync(id); 
        }

        public IQueryable<T> GetAll() 
        {
           return dbSet.AsQueryable();
        }

        public async Task<T> CreateAsync(T entity) 
        {
            await dbSet.AddAsync(entity);
            await context.SaveChangesAsync();

            return entity;
        }

        public async Task<T> UpdateAsync(T entity)
        {
            context.Entry(entity).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return entity;
        }

        public async Task DeleteAsync(string id) 
        {
            var entity = await GetByIdAsync(id);
            if (entity != null)
            {
                dbSet.Remove(entity);
                await context.SaveChangesAsync();
            }
        }

        public async Task SaveChangesAsync() 
        { 
            await context.SaveChangesAsync(); 
        }
    }
}
