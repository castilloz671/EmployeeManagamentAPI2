using System.ComponentModel.DataAnnotations;

namespace EmployeeManagamentAPI2.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [Required]
        [StringLength(100)]
        public string LastName { get; set; }
     
        [StringLength(10)]
        public string Phone { get; set; }

        [StringLength(100)]
        public string Address { get; set; }

        [StringLength(50)]
        public string Position { get; set; }

        [StringLength(50)]
        public string Office { get; set; }

        [DataType(DataType.Currency)]
        public decimal Salary { get; set; }

        public decimal ARS => Salary * 0.0304M;

        public decimal AFP => Salary * 0.0287M;

        public decimal SalaryNeto => Salary - ARS - AFP;
    }
}
