using API.DTOs.Request;
using API.DTOs.Response;

namespace API.Services.Employee
{
    /// <summary>
    /// Manages the employee service
    /// </summary>
    public interface IEmployeeService
    {
        /// <summary>
        /// Retrieving all of the employees
        /// </summary>
        Task<IEnumerable<EmployeeResponseDto>> GetAllEmployeesAsync();

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
    }
}
