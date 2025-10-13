using API.DTOs.Request;
using API.DTOs.Response;
using API.DTOs.Shared;
using API.Services.Employee;
using Microsoft.AspNetCore.Mvc;
//test

namespace API.Controllers
{
    /// <summary>
    /// The web endpoints for managing the employee
    /// </summary>
    /// <seealso cref="ControllerBase" />
    [ApiController]
    [Route("[controller]")]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeService employeeService;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeesController" /> class.
        /// </summary>
        /// <param name="employeeService">The employee service.</param>
        public EmployeesController(IEmployeeService employeeService)
        {
            this.employeeService = employeeService;
        }

        /// <summary>
        /// Gets the paginated result of employees.
        /// </summary>
        [HttpGet("GetPaginatedEmployees")]
        public async Task<PaginatedResultDto<EmployeeResponseDto>> GetPaginatedEmployeesAsync(int skip, int limit)
        {
            return await employeeService.GetPaginatedEmployeesAsync(skip, limit);
        }

        /// <summary>
        /// Gets the employee by identifier.
        /// </summary>
        /// <param name="id">The identifier of the employee.</param>
        [HttpGet("{id}")]
        public async Task<EmployeeResponseDto> GetEmployeeByIdAsync(string id)
        {
            return await employeeService.GetEmployeeByIdAsync(id);
        }

        /// <summary>
        /// Creates the employee.
        /// </summary>
        /// <param name="request">The employee request DTO.</param>
        [HttpPost]
        public async Task<IActionResult> CreateEmployeeAsync(EmployeeRequestDto request)
        {
            var result = await employeeService.CreateEmployeeAsync(request);
            return Ok(result);
        }

        /// <summary>
        /// Updates the employee.
        /// </summary>
        /// <param name="id">The identifier of the employee.</param>
        /// <param name="request">The employee request DTO.</param>
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateEmployeeAsync(string id, EmployeeRequestDto request)
        {
            var result = await employeeService.UpdateEmployeeAsync(id, request);
            if (result is null) 
            {
                return BadRequest();
            }

            return Ok(result);
        }

        /// <summary>
        /// Deletes the employee.
        /// </summary>
        /// <param name="id">The identifier of the employee.</param>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmployeeAsync(string id)
        {
            await employeeService.DeleteEmployeeAsync(id);
            return NoContent();
        }
    }
}
