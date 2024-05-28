using EmployeeManagamentAPI2.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagamentAPI2.Data
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options) { }

        public DbSet<Employee> Employees { get; set; }
    }
}
