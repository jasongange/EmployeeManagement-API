using API.DTOs.Response;
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
        [HttpGet]
        public async Task<IEnumerable<DepartmentResponseDto>> GetAllDepartmentsAsync()
        {
            return await departmentService.GetAllDepartmentsAsync();
        }
    }
}
