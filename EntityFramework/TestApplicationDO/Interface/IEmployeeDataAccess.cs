using System;
using System.Collections.Generic;
using System.Text;
using TestApplicationEntities.Entities;

namespace TestApplicationDO.Interface
{
    public interface IEmployeeDataAccess
    {
        List<Employee> GetEmployees();
        Employee GetEmployeeById(long Id);
        long InsertEmployee(Employee employee);
    }
}
