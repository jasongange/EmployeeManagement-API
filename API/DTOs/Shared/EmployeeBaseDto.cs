namespace API.DTOs.Shared
{
    public class EmployeeBaseDto
    {
        public string EmployeeNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Salary { get; set; }
        public string DepartmentId { get; set; }
    }
}
