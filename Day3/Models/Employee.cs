using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication6.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string EName { get; set; }
        public string Gender { get; set; }
        public float Salary { get; set; }
        public string Address { get; set; }

    }
    public class EmployeeDBContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public EmployeeDBContext(DbContextOptions<EmployeeDBContext> options): base(options)
        {

        }
    }
}
