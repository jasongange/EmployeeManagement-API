using API.DTOs.Response;
using API.DTOs.Shared;
using AutoMapper;
using Domain;
using Persistence.Paging;

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
            CreateMap<PaginatedResult<Department>, PaginatedResultDto<DepartmentResponseDto>>();
        }
    }
}
