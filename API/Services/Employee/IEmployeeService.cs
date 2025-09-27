using API.DTOs.Request;
using API.DTOs.Response;
using API.DTOs.Shared;

namespace API.Services.Employee
{
    /// <summary>
    /// Manages the employee service
    /// </summary>
    public interface IEmployeeService
    {
        /// <summary>
        /// Retrieve employee by identifier
        /// </summary>
        /// <param name="id">The identifier.</param>
        Task<EmployeeResponseDto> GetEmployeeByIdAsync(string id);

        /// <summary>
        /// Create employee
        /// </summary>
        /// <param name="employee">The employee.</param>
        Task<EmployeeResponseDto> CreateEmployeeAsync(EmployeeRequestDto employee);

        /// <summary>
        /// Update employee
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="employee">The employee.</param>
        Task<EmployeeResponseDto> UpdateEmployeeAsync(string id, EmployeeRequestDto employee);

        /// <summary>
        /// Delete employee
        /// </summary>
        /// <param name="id">The identifier.</param>
        Task DeleteEmployeeAsync(string id);

        /// <summary>
        /// Retrieving paginated result of employees
        /// </summary>
        /// <param name="skip">The paging skip.</param>
        /// <param name="limit">The paging limit.</param>
        Task<PaginatedResultDto<EmployeeResponseDto>> GetPaginatedEmployeesAsync(int skip, int limit);
    }
}
