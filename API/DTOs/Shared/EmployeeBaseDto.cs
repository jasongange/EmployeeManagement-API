namespace API.DTOs.Shared
{
    /// <summary>
    /// Represents the employee base DTO.
    /// </summary>
    public class EmployeeBaseDto
    {
        /// <summary>
        /// The employee number.
        /// </summary>
        public string EmployeeNumber { get; set; }

        /// <summary>
        /// The first name.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// The last name.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// The salary.
        /// </summary>
        public decimal Salary { get; set; }

        /// <summary>
        /// The department identifier.
        /// </summary>
        public string DepartmentId { get; set; }
    }
}
