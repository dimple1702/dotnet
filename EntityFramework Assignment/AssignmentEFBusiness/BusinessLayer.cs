using AssignmentEFBusiness.Interface;
using AssignmentEFData.Interface;
using AssignmentEFEntities.Entities;
using System;
using System.Collections.Generic;

namespace AssignmentEFBusiness
{
    public class BusinessLayer : IBusinessLayer
    {
        private readonly IDataLayer _dataLayer;

        public BusinessLayer(IDataLayer dataLayer)
        {
            _dataLayer = dataLayer;
        }

        public int DeleteEmployee(long employeeId)
        {
            return _dataLayer.DeleteEmployee(employeeId);
        }

        public EmployeeTable GetEmployeeById(long Id)
        {
            return _dataLayer.GetEmployeeById(Id);
        }

        public List<EmployeeTable> GetEmployees()
        {
            return _dataLayer.GetEmployees();
        }

        public int InsertEmployee(EmployeeTable employee)
        {
            return _dataLayer.InsertEmployee(employee);
        }

        public int UpdateEmployee(EmployeeTable employee)
        {
            return _dataLayer.UpdateEmployee(employee);
        }
    }
}
