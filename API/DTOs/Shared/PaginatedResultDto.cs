namespace API.DTOs.Shared
{
    /// <summary>
    /// Represents the paginated result DTO.
    /// </summary>
    public class PaginatedResultDto<T>
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
