using API.DTOs.Response;
using API.DTOs.Shared;
using API.Services.Department;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    /// <summary>
    /// The web endpoints for managing the department
    /// </summary>
    /// <seealso cref="ControllerBase" />
    [ApiController]
    [Route("[controller]")]
    public class DepartmentsController : ControllerBase
    {
        private readonly IDepartmentService departmentService;

        /// <summary>
        /// Initializes a new instance of the <see cref="DepartmentsController" /> class.
        /// </summary>
        /// <param name="departmentService">The department service.</param>
        public DepartmentsController(IDepartmentService departmentService)
        {
            this.departmentService = departmentService;
        }

        /// <summary>
        /// Gets the departments.
        /// </summary>
        [HttpGet("GetDepartments")]
        public async Task<IEnumerable<DepartmentResponseDto>> GetAllDepartmentsAsync()
        {
            return await departmentService.GetAllDepartmentsAsync();
        }

        /// <summary>
        /// Gets the paginated result of employees.
        /// </summary>
        [HttpGet("GetPaginatedDepartments")]
        public async Task<PaginatedResultDto<DepartmentResponseDto>> GetPaginatedDepartmentsAsync(int skip, int limit)
        {
            return await departmentService.GetPaginatedDepartmentsAsync(skip, limit);
        }
    }
}
