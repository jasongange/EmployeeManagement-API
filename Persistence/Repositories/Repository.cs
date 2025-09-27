using Microsoft.EntityFrameworkCore;

namespace Persistence.Repositories
{
    /// <summary>
    /// Manages repository.
    /// </summary>
    /// <seealso cref="IRepository" />
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly EmployeeDbContext context;
        private readonly DbSet<T> dbSet;

        /// <summary>
        /// Creates an instance of <see cref="Repository"/>
        /// </summary>
        /// <param name="context">The employee DB context.</param>
        public Repository(EmployeeDbContext context)
        {
            this.context = context;
            this.dbSet = context.Set<T>();
        }

        /// <summary>
        /// <seealso cref="IRepository.GetByIdAsync(string)"/>
        /// </summary>
        public async Task<T?> GetByIdAsync(string id) 
        { 
           return await dbSet.FindAsync(id); 
        }

        /// <summary>
        /// <seealso cref="IRepository.GetAll"/>
        /// </summary>
        public IQueryable<T> GetAll() 
        {
           return dbSet.AsQueryable();
        }

        /// <summary>
        /// <seealso cref="IRepository.CreateAsync(T)"/>
        /// </summary>
        public async Task<T> CreateAsync(T entity) 
        {
            await dbSet.AddAsync(entity);
            await context.SaveChangesAsync();

            return entity;
        }

        /// <summary>
        /// <seealso cref="IRepository.UpdateAsync(T)"/>
        /// </summary>
        public async Task<T> UpdateAsync(T entity)
        {
            context.Entry(entity).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return entity;
        }

        /// <summary>
        /// <seealso cref="IRepository.DeleteAsync(string)"/>
        /// </summary>
        public async Task DeleteAsync(string id) 
        {
            var entity = await GetByIdAsync(id);
            if (entity != null)
            {
                dbSet.Remove(entity);
                await context.SaveChangesAsync();
            }
        }

        /// <summary>
        /// <seealso cref="IRepository.SaveChangesAsync"/>
        /// </summary>
        public async Task SaveChangesAsync() 
        { 
            await context.SaveChangesAsync(); 
        }
    }
}
