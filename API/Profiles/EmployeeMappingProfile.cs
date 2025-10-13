using API.DTOs.Request;
using API.DTOs.Response;
using API.DTOs.Shared;
using AutoMapper;
using Domain;
using Persistence.Paging;

namespace UserManagementAPI.Profiles
{
    /// <summary>
    /// The employee mapper profile
    /// </summary>
    /// <seealso cref="Profile" />
    public class EmployeeMappingProfile : Profile
    {
        public EmployeeMappingProfile()
        {
            CreateMap<Employee, EmployeeResponseDto>()
                .ForMember(dest => dest.Department, opt => opt.MapFrom(src => src.Department.Name));
            CreateMap<EmployeeRequestDto, Employee>();
            CreateMap<PaginatedResult<Employee>, PaginatedResultDto<EmployeeResponseDto>>();
        }
    }
}
