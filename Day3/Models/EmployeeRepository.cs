using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication6.Models
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private EmployeeDBContext _context;
        
        public EmployeeRepository(EmployeeDBContext context)
        {
            _context = context;
        }
        public void AddEmployee(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
        }

        public void DeleteEmployee(int id)
        {
            Employee obj = _context.Employees.Find(id);
            _context.Employees.Remove(obj);
            _context.SaveChanges();
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _context.Employees.ToList();
        }

        public Employee GetEmployeeByID(int id)
        {
            return _context.Employees.Find(id);
        }

        public void UpdateEmployee(Employee newObj)
        {
            _context.Employees.Update(newObj);
            _context.SaveChanges();
        }
    }
}
