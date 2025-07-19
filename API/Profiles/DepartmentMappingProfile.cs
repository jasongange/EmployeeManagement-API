using API.DTOs.Response;
using AutoMapper;
using Domain;

namespace API.Profiles
{
    public class DepartmentMappingProfile : Profile
    {
        public DepartmentMappingProfile()
        {
            CreateMap<Department, DepartmentResponseDto>();
        }
    }
}
