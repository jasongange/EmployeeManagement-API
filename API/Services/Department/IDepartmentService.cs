using API.DTOs.Response;

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
    }
}
