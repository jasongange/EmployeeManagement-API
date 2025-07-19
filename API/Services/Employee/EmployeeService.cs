using API.DTOs.Request;
using API.DTOs.Response;
using AutoMapper;
using Persistence.Repositories.User;

namespace API.Services.Employee
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository employeeRepository;
        private readonly IMapper mapper;

        public EmployeeService(IEmployeeRepository employeeRepository, IMapper mapper)
        {
            this.employeeRepository = employeeRepository;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<EmployeeResponseDto>> GetAllEmployeesAsync()
        {
            var users = employeeRepository.GetAll();
            var response = mapper.Map<IEnumerable<EmployeeResponseDto>>(users);

            return response;
        }

        public async Task<EmployeeResponseDto> GetEmployeeByIdAsync(string id)
        {
            var user = await employeeRepository.GetByIdAsync(id);
            var response = mapper.Map<EmployeeResponseDto>(user);

            return response;
        }

        public async Task<EmployeeResponseDto> CreateEmployeeAsync(EmployeeRequestDto request)  
        {
            var user = mapper.Map<Domain.Employee>(request);
            user.Id = Guid.NewGuid().ToString();
            var createdUser = await employeeRepository.CreateAsync(user);
            var response = mapper.Map<EmployeeResponseDto>(createdUser);

            return response;
        }

        public async Task<EmployeeResponseDto?> UpdateEmployeeAsync(string id, EmployeeRequestDto request) 
        {
            var user = await employeeRepository.GetByIdAsync(id);
            if (user is null) { return null; }

            user.EmployeeNumber = request.EmployeeNumber;
            user.FirstName = request.FirstName;
            user.LastName = request.LastName;
            user.Salary = request.Salary;
            user.DepartmentId = request.DepartmentId;

            var createdUser = await employeeRepository.UpdateAsync(user);
            var response = mapper.Map<EmployeeResponseDto>(createdUser);

            return response;
        } 

        public Task DeleteEmployeeAsync(string id) => employeeRepository.DeleteAsync(id);
    }
}
