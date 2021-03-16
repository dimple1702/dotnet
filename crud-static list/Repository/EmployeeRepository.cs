using System;
using System.Collections.Generic;
using vermadimple.Models;

namespace vermadimple.Repository
{
    public interface EmployeeRepository
    {
        IEnumerable<Employee> GetAllEmployee();
        Employee Get(int id);
        Employee Add(Employee item);
        Employee Update(Employee item);
        bool Delete(int id);
    }
}
