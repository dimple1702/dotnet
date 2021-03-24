using AssignmentEFEntities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentEFBusiness.Interface
{
    public interface IBusinessLayer
    {
        List<EmployeeTable> GetEmployees();
        EmployeeTable GetEmployeeById(long Id);
        int InsertEmployee(EmployeeTable employee);
        int UpdateEmployee(EmployeeTable employee);
        int DeleteEmployee(long employeeId);
    }
}
