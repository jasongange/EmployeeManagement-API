using API.DTOs.Shared;

namespace API.DTOs.Response
{
    public class EmployeeResponseDto : EmployeeBaseDto
    {
        public string Id { get; set; }
        public string Department { get; set; }
    }
}
