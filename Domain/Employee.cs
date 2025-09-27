using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    /// <summary>
    /// The employee.
    /// </summary>
    public class Employee
    {
        /// <summary>
        /// The identifier.
        /// </summary>
        public string Id { get; set; }

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
        [ForeignKey("Department")]
        public string DepartmentId { get; set; }

        /// <summary>
        /// The department.
        /// </summary>
        public Department Department { get; set; }
    }
}
