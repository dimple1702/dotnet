using System;
using System.Collections.Generic;
using TestApplicationBO.Interface;
using TestApplicationDO.Interface;
using TestApplicationEntities.Entities;

namespace TestApplicationBO
{
    public class EmployeeBusinessAccess : IEmployeeBusinessAccess
    {
        private readonly IEmployeeDataAccess _employeeDataAcess;

        public EmployeeBusinessAccess(IEmployeeDataAccess employeeDataAccess)
        {
            _employeeDataAcess = employeeDataAccess;
        }

        List<Employee> IEmployeeBusinessAccess.GetEmployees()
        {
            return _employeeDataAcess.GetEmployees();
        }
    }
}
