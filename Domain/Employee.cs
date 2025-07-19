using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    public class Employee
    {
        public string Id { get; set; }

        public string EmployeeNumber { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public double Salary { get; set; }

        [ForeignKey("Department")]
        public string DepartmentId { get; set; }

        public Department Department { get; set; }
    }
}
