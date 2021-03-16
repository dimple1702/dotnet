using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using vermadimple.Models;

namespace vermadimple.Repository
{
    public class EmployeeImpl : EmployeeRepository
    {
        private List<Employee> empList;
        private int Id = 1;

        public EmployeeImpl()
        {
            empList = new List<Employee>();
            Add(new Employee() { Name = "Dimple Verma", Age = "21", Gender = "Female", Dob = new DateTime(2000, 2, 17).ToLongDateString(), City = "Faridkot", Designation = "Developer" });
            Add(new Employee() { Name = "Jasmeet Kaur", Age = "22", Gender = "Female", Dob = new DateTime(1999, 10, 12).ToLongDateString(), City = "Muktsar", Designation = "Tester" });
            Add(new Employee() { Name = "Bhavish Singla", Age = "22", Gender = "Male", Dob = new DateTime(1999, 4, 24).ToLongDateString(), City = "Bathinda", Designation = "Designer" });
            Add(new Employee() { Name = "Hardeep Kaur", Age = "21", Gender = "Female", Dob = new DateTime(2000, 5, 17).ToLongDateString(), City = "Faridkot", Designation = "Tester" });
        }
        public Employee Add(Employee item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }
            item.Id = Id++;
            empList.Add(item);
            return item;
        }

        public bool Delete(int id)
        {
            empList.RemoveAll(p => p.Id == id);
            return true;
        }

        public Employee Get(int id)
        {
            return empList.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Employee> GetAllEmployee()
        {
            return empList;
        }

        public Employee Update(Employee item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }
            int index = empList.FindIndex(p => p.Id == item.Id);
            if (index == -1)
            {
                return null;
            }

            Employee employee = empList[index];
            employee.Name = item.Name;
            employee.Age = item.Age;
            employee.Gender = item.Gender;
            employee.Dob = item.Dob;
            employee.Designation = item.Designation;
            employee.City = employee.City;

            empList[index] = employee;

            Console.WriteLine(employee);

            return employee;
        }
    }
}