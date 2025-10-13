namespace Persistence.Paging
{
    /// <summary>
    /// Represents the paginated result.
    /// </summary>
    public class PaginatedResult<T>
    {
        /// <summary>
        /// The total count.
        /// </summary>
        public int TotalCount { get; set; }

        /// <summary>
        /// The list of paginated items.
        /// </summary>
        public List<T> Items { get; set; } = new List<T>();
    }
}
