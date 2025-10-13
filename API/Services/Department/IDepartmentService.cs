using API.DTOs.Response;
using API.DTOs.Shared;

namespace API.Services.Department
{
    /// <summary>
    /// Manages the department service
    /// </summary>
    public interface IDepartmentService
    {
        /// <summary>
        /// Retrieving all of the departments
        /// </summary>
        Task<IEnumerable<DepartmentResponseDto>> GetAllDepartmentsAsync();

        /// <summary>
        /// Retrieving paginated result of departments
        /// </summary>
        /// <param name="skip">The paging skip.</param>
        /// <param name="limit">The paging limit.</param>
        Task<PaginatedResultDto<DepartmentResponseDto>> GetPaginatedDepartmentsAsync(int skip, int limit);
    }
}
