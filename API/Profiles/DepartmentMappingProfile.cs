using API.DTOs.Response;
using AutoMapper;
using Domain;

namespace API.Profiles
{
    /// <summary>
    /// The department mapper profile
    /// </summary>
    /// <seealso cref="Profile" />
    public class DepartmentMappingProfile : Profile
    {
        public DepartmentMappingProfile()
        {
            CreateMap<Department, DepartmentResponseDto>();
        }
    }
}
