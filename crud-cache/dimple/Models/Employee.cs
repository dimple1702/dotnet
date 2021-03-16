using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dimple.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime Dob { get; set; }
        public string Gender { get; set; }
        public string Designation { get; set; }
        public string City { get; set; }
    }

    public static class EmployeeData
    {
        public static List<Employee> employeeData;
        static EmployeeData()
        {
            employeeData = new List<Employee>();
            employeeData.Add(new Employee() { Id = 1, Name = "Dimple Verma", Age = 21, Gender = "Female", Dob = new DateTime(2000, 2, 17), City = "Faridkot", Designation = "Developer" });
            employeeData.Add(new Employee() { Id = 2, Name = "Jasmeet Kaur", Age = 22, Gender = "Female", Dob = new DateTime(1999, 10, 12), City = "Muktsar", Designation = "Tester" }); 
            employeeData.Add(new Employee() { Id = 3, Name = "Bhavish Singla", Age = 22, Gender = "Male", Dob = new DateTime(1999, 4, 24), City = "Bathinda", Designation = "Designer" }); 
            employeeData.Add(new Employee() { Id = 4, Name = "Hardeep Kaur", Age = 21, Gender = "Female", Dob = new DateTime(2000, 5, 17), City = "Faridkot", Designation = "Tester" }); 
        }

        public static List<Employee> GetEmployees()
        {
            return employeeData;
        }

        public static bool AddEmployee(Employee employee)
        { 
            if (employeeData.Any(item => item.Id == employee.Id))
            {
                return false;
            }
            employeeData.Add(employee);
            return true;
        } 
    }
}


