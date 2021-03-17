using System;
using System.Collections.Generic;
using System.Text;
using TestApplicationEntities.Entities;

namespace TestApplicationBO.Interface
{
    public interface IEmployeeBusinessAccess    
    {
        List<Employee> GetEmployees();
    }
}
