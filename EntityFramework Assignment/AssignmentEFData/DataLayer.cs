using AssignmentEFData.Interface;
using AssignmentEFEntities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AssignmentEFData
{
    public class DataLayer : IDataLayer
    {
        private readonly EmployeeDbContext _employeeDbContext;

        public DataLayer(EmployeeDbContext employeeDbContext)
        {
            _employeeDbContext = employeeDbContext;
        }

        public int DeleteEmployee(long employeeId)
        {
            var Obj = _employeeDbContext.EmployeeTable.FirstOrDefault(x => x.Id == employeeId);
            _employeeDbContext.EmployeeTable.Remove(Obj);
            return _employeeDbContext.SaveChanges();
        }

        public EmployeeTable GetEmployeeById(long Id)
        {
            return _employeeDbContext.EmployeeTable.FirstOrDefault(e => e.Id == Id);
        }

        public List<EmployeeTable> GetEmployees()
        {
            return _employeeDbContext.EmployeeTable.ToList();
        }

        public int InsertEmployee(EmployeeTable employee)
        {
            _employeeDbContext.EmployeeTable.Add(employee);
            
            return _employeeDbContext.SaveChanges();
        }

        public int UpdateEmployee(EmployeeTable employee)
        {
            var empObj = _employeeDbContext.EmployeeTable.FirstOrDefault(x => x.Id == employee.Id);
            empObj.Name = employee.Name;
            empObj.Age = employee.Age;
            _employeeDbContext.EmployeeTable.Update(empObj);
            return _employeeDbContext.SaveChanges();
        }
    }
}
