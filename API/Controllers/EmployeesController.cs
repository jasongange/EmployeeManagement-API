using API.DTOs.Request;
using API.DTOs.Response;
using API.Services.Employee;
using Microsoft.AspNetCore.Mvc;

namespace UserManagementAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeService employeeService;

        public EmployeesController(IEmployeeService employeeService)
        {
            this.employeeService = employeeService;
        }

        [HttpGet]
        public async Task<IEnumerable<EmployeeResponseDto>> GetAllEmployeesAsync()
        {
            return await employeeService.GetAllEmployeesAsync();
        }

        [HttpGet("{id}")]
        public async Task<EmployeeResponseDto> GetEmployeeByIdAsync(string id)
        {
            return await employeeService.GetEmployeeByIdAsync(id);
        }

        [HttpPost]
        public async Task<IActionResult> CreateEmployeeAsync(EmployeeRequestDto request)
        {
            var result = await employeeService.CreateEmployeeAsync(request);
            return Ok(result);
        }

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

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmployeeAsync(string id)
        {
            await employeeService.DeleteEmployeeAsync(id);
            return NoContent();
        }
    }
}
