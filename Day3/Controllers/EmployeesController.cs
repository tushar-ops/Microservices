using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication6.Models;

namespace WebApplication6.Controllers
{
    public class EmployeesController : Controller
    {
        private IEmployeeRepository _repo;

        public EmployeesController(IEmployeeRepository repo)
        {
            _repo = repo;
        }
        public IActionResult Index()
        {
            IEnumerable<Employee> empList = _repo.GetAllEmployees();
            return View(empList);
        }

        public IActionResult GetEmployeeById(int id)
        {
            Employee empObj = _repo.GetEmployeeByID(id);
            return View(empObj);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Employee empObj)
        {
            _repo.AddEmployee(empObj);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            Employee empObj = _repo.GetEmployeeByID(id);
            return View(empObj);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            Employee empObj = _repo.GetEmployeeByID(id);
            return View(empObj);
        }

        [HttpPost]
        public IActionResult Edit(Employee empObj)
        {
            _repo.UpdateEmployee(empObj);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            Employee empObj = _repo.GetEmployeeByID(id);
            return View(empObj);
        }

        [HttpPost]
        [ActionName("Delete")]
        public IActionResult DeleteConfirm(int id)
        {
            _repo.DeleteEmployee(id);
            return RedirectToAction("Index");
        }


    }
}
