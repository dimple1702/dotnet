using System.Collections.Generic;
using System.Linq;
using TestApplicationDO.Interface;
using TestApplicationEntities.Entities;

namespace TestApplicationDO
{
    public class EmployeeDataAccess : IEmployeeDataAccess
    {
        private readonly EmployeeDbContext _employeeDbContext;

        public EmployeeDataAccess(EmployeeDbContext employeeDbContext)
        {
            _employeeDbContext = employeeDbContext;
        }

        public List<Employee> GetEmployees()
        {
            return _employeeDbContext.Employee.ToList();
        }

        public Employee GetEmployeeById(long Id)
        {
            return _employeeDbContext.Employee.FirstOrDefault(e => e.Id == Id);
        }

        public long InsertEmployee(Employee employee)
        {
            _employeeDataAcess.Employee.Add(employee);
        }
    }
}
