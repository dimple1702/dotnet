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

        List<Employee> IEmployeeDataAccess.GetEmployees()
        {
            return _employeeDbContext.Employee.ToList();
        }
    }
}
