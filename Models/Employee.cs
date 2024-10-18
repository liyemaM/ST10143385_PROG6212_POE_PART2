using System.ComponentModel.DataAnnotations;

namespace PROG4.Models
{
    public class Employee
    {

        public int EmployeeId { get; set; }

        public string EmpName { get; set; }

        public decimal Salary { get; set; }
    }
}
