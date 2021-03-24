using AssignmentEFEntities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentEFData.Interface
{
    public interface IDataLayer
    {
        List<EmployeeTable> GetEmployees();
        EmployeeTable GetEmployeeById(long Id);
        int InsertEmployee(EmployeeTable employee);
        int UpdateEmployee(EmployeeTable employee);
        int DeleteEmployee(long employeeId);
    }
}
