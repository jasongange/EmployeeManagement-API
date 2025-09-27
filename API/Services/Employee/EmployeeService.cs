using API.DTOs.Request;
using API.DTOs.Response;
using AutoMapper;
using Persistence.Repositories.Employee;

namespace API.Services.Employee
{
    /// <summary>
    /// Manages repository.
    /// </summary>
    /// <seealso cref="IEmployeeService" />
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository employeeRepository;
        private readonly IMapper mapper;

        /// <summary>
        /// Creates an instance of <see cref="EmployeeService"/>
        /// </summary>
        /// <param name="employeeRepository">The employee repository.</param>
        /// <param name="mapper">The mapper.</param>
        public EmployeeService(IEmployeeRepository employeeRepository, IMapper mapper)
        {
            this.employeeRepository = employeeRepository;
            this.mapper = mapper;
        }

        /// <summary>
        /// <seealso cref="IEmployeeService.GetAllEmployeesAsync"/>
        /// </summary>
        public async Task<IEnumerable<EmployeeResponseDto>> GetAllEmployeesAsync()
        {
            var employees = employeeRepository.GetAll();
            var response = mapper.Map<IEnumerable<EmployeeResponseDto>>(employees);

            return response;
        }

        /// <summary>
        /// <seealso cref="IEmployeeService.GetEmployeeByIdAsync(string)"/>
        /// </summary>
        public async Task<EmployeeResponseDto> GetEmployeeByIdAsync(string id)
        {
            var employee = await employeeRepository.GetByIdAsync(id);
            var response = mapper.Map<EmployeeResponseDto>(employee);

            return response;
        }

        /// <summary>
        /// <seealso cref="IEmployeeService.CreateEmployeeAsync(EmployeeRequestDto)"/>
        /// </summary>
        public async Task<EmployeeResponseDto> CreateEmployeeAsync(EmployeeRequestDto request)  
        {
            var employee = mapper.Map<Domain.Employee>(request);
            employee.Id = Guid.NewGuid().ToString();
            var createdUser = await employeeRepository.CreateAsync(employee);
            var response = mapper.Map<EmployeeResponseDto>(createdUser);

            return response;
        }

        /// <summary>
        /// <seealso cref="IEmployeeService.UpdateEmployeeAsync(string, EmployeeRequestDto)"/>
        /// </summary>
        public async Task<EmployeeResponseDto?> UpdateEmployeeAsync(string id, EmployeeRequestDto request) 
        {
            var employee = await employeeRepository.GetByIdAsync(id);
            if (employee is null) { return null; }

            employee.EmployeeNumber = request.EmployeeNumber;
            employee.FirstName = request.FirstName;
            employee.LastName = request.LastName;
            employee.Salary = request.Salary;
            employee.DepartmentId = request.DepartmentId;

            var createdUser = await employeeRepository.UpdateAsync(employee);
            var response = mapper.Map<EmployeeResponseDto>(createdUser);

            return response;
        }

        /// <summary>
        /// <seealso cref="IEmployeeService.DeleteEmployeeAsync(string)"/>
        /// </summary>
        public Task DeleteEmployeeAsync(string id) => employeeRepository.DeleteAsync(id);
    }
}
