using API.DTOs.Request;
using API.DTOs.Response;
using AutoMapper;
using Domain;

namespace UserManagementAPI.Profiles
{
    public class EmployeeMappingProfile : Profile
    {
        public EmployeeMappingProfile()
        {
            CreateMap<Employee, EmployeeResponseDto>()
                .ForMember(dest => dest.Department, opt => opt.MapFrom(src => src.Department.Name));
            CreateMap<EmployeeRequestDto, Employee>();
        }
    }
}
