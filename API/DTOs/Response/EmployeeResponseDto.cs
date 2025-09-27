using API.DTOs.Shared;

namespace API.DTOs.Response
{
    /// <summary>
    /// Represents the employee response DTO.
    /// </summary>
    public class EmployeeResponseDto : EmployeeBaseDto
    {
        /// <summary>
        /// The identifier.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// The department.
        /// </summary>
        public string Department { get; set; }
    }
}
