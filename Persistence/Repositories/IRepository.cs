namespace Persistence.Repositories
{
    /// <summary>
    /// Manages the Repository
    /// </summary>
    public interface IRepository<T> where T : class
    {
        /// <summary>
        /// Retrieve by identifier
        /// </summary>
        /// <param name="id">The identifier.</param>
        Task<T?> GetByIdAsync(string id);

        /// <summary>
        /// Retrieve list of data
        /// </summary>
        IQueryable<T>GetAll();

        /// <summary>
        /// Executes the create
        /// </summary>
        /// <param name="entity">The entity.</param>
        Task<T> CreateAsync(T entity);

        /// <summary>
        /// Executes the update
        /// </summary>
        /// <param name="entity">The entity.</param>
        Task<T> UpdateAsync(T entity);

        /// <summary>
        /// Executes the delete
        /// </summary>
        /// <param name="id">The identifier.</param>
        Task DeleteAsync(string id);

        /// <summary>
        /// Executes the save changes
        /// </summary>
        Task SaveChangesAsync();
    }
}
