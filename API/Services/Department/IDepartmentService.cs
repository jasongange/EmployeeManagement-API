using API.DTOs.Response;
using Domain;

namespace UserManagementAPI.Services
{
    public interface IDepartmentService
    {
        Task<IEnumerable<DepartmentResponseDto>> GetAllDepartmentsAsync();
    }
}
