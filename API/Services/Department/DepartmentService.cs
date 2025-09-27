using API.DTOs.Response;
using AutoMapper;
using Persistence.Repositories;

namespace API.Services.Department
{
    /// <summary>
    /// Manages department service.
    /// </summary>
    /// <seealso cref="IDepartmentService" />
    public class DepartmentService : IDepartmentService
    {
        private readonly IDepartmentRepository departmentRepository;
        private readonly IMapper mapper;

        /// <summary>
        /// Creates an instance of <see cref="DepartmentService"/>
        /// </summary>
        /// <param name="departmentRepository">The department repository.</param>
        /// <param name="mapper">The mapper.</param>
        public DepartmentService(IDepartmentRepository departmentRepository, IMapper mapper)
        {
            this.departmentRepository = departmentRepository;
            this.mapper = mapper;
        }

        /// <summary>
        /// <seealso cref="IDepartmentService.GetAllDepartmentsAsync"/>
        /// </summary
        public async Task<IEnumerable<DepartmentResponseDto>> GetAllDepartmentsAsync()
        {
            var departments = departmentRepository.GetAll();
            var response = mapper.Map<IEnumerable<DepartmentResponseDto>>(departments);

            return response;
        }
    }
}
