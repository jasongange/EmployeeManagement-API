using API.DTOs.Request;
using API.DTOs.Response;

namespace API.Services.Employee
{
    public interface IEmployeeService
    {
        Task<IEnumerable<EmployeeResponseDto>> GetAllEmployeesAsync();
        Task<EmployeeResponseDto> GetEmployeeByIdAsync(string id);
        Task<EmployeeResponseDto> CreateEmployeeAsync(EmployeeRequestDto employee);
        Task<EmployeeResponseDto> UpdateEmployeeAsync(string id, EmployeeRequestDto employee);
        Task DeleteEmployeeAsync(string id);
    }
}
