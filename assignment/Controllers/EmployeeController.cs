using assignment.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Caching;

namespace assignment.Controllers
{
    public class EmployeeController : Controller
    {
        ObjectCache cache = MemoryCache.Default;
        List<Employee> employees;

        public EmployeeController()
        {
            employees = cache["employees"] as List<Employee>;
            if (employees == null)
            {
                employees = new List<Employee>();
            }
        }
        public void SaveCache()
        {
            cache["employees"] = employees;
        }

        public IActionResult EmployeeList()
        {
            if(employees.Count == 0)
            {
                ViewData["Error"] = "Not Found!! The Employee list is initially empty(As Cache memory is used)";
                return View(employees);
            }

            return View(employees);
        }

        public ActionResult AddEmployee()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddEmployee(Employee emp)
        {
            emp.Id = Guid.NewGuid().ToString();
            employees.Add(emp);
            SaveCache();

            return RedirectToAction("EmployeeList");
        }

        public IActionResult ViewEmployee(string id)
        {
            Employee employee = employees.FirstOrDefault(c => c.Id == id);
            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);
        }

        public IActionResult EditEmployee(string id)
        {
            Employee employee = employees.FirstOrDefault(c => c.Id == id);
            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);
        }

        [HttpPost]
        public ActionResult EditEmployee(Employee emp, string id)
        {
            Employee editedEmployee = employees.FirstOrDefault(c => c.Id == id);
            if (emp == null)
            {
                return NotFound();
            }
            else
            {
                editedEmployee.Name = emp.Name;
                editedEmployee.Age = emp.Age;
                editedEmployee.Gender = emp.Gender;
                editedEmployee.Dob = emp.Dob;
                editedEmployee.City = emp.City;
                editedEmployee.Designation = emp.Designation;
                SaveCache();

                return RedirectToAction("ViewEmployee");
            }
        }

        public ActionResult DeleteEmployee(string id)
        {
            Employee employee = employees.FirstOrDefault(c => c.Id == id);
            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);
        }

        [HttpPost]
        [ActionName("DeleteEmployee")]
        public ActionResult ConfirmDeleteCustomer(string id)
        {
            Employee employee = employees.FirstOrDefault(c => c.Id == id);
            if (employee == null)
            {
                return NotFound();
            }
            else
            {
                employees.Remove(employee);
                return RedirectToAction("EmployeeList");
            }
        }

    }
}
