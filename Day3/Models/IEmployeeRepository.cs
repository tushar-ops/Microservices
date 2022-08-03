using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication6.Models
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAllEmployees();
        Employee GetEmployeeByID(int id);
        void AddEmployee(Employee employee);
        void UpdateEmployee(Employee newObj);
        void DeleteEmployee(int id);
    }
}
