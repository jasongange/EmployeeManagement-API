using API.DTOs.Response;
using Microsoft.AspNetCore.Mvc;
using UserManagementAPI.Services;

namespace UserManagementAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DepartmentsController : ControllerBase
    {
        private readonly IDepartmentService departmentService;

        public DepartmentsController(IDepartmentService departmentService)
        {
            this.departmentService = departmentService;
        }

        [HttpGet]
        public async Task<IEnumerable<DepartmentResponseDto>> GetAllDepartmentsAsync()
        {
            return await departmentService.GetAllDepartmentsAsync();
        }
    }
}
