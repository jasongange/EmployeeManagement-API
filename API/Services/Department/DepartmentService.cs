using API.DTOs.Response;
using AutoMapper;
using Persistence.Repositories;

namespace UserManagementAPI.Services
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IDepartmentRepository departmentRepository;
        private readonly IMapper mapper;

        public DepartmentService(IDepartmentRepository departmentRepository, IMapper mapper)
        {
            this.departmentRepository = departmentRepository;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<DepartmentResponseDto>> GetAllDepartmentsAsync()
        {
            var departments = departmentRepository.GetAll();
            var response = mapper.Map<IEnumerable<DepartmentResponseDto>>(departments);

            return response;
        }
    }
}
