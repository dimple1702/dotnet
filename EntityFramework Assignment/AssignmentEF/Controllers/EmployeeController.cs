using AssignmentEFBusiness.Interface;
using AssignmentEFEntities.Entities;
using Microsoft.AspNetCore.Mvc;

namespace AssignmentEFMain.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IBusinessLayer _businessLayer;
        public EmployeeController(IBusinessLayer businessLayer)
        {
            _businessLayer = businessLayer;
        }

        public IActionResult EmployeeList()
        {
            var list = _businessLayer.GetEmployees();
            return View(list);
        }

        public IActionResult AddEmployee()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddEmployee(EmployeeTable employee)
        {
            _businessLayer.InsertEmployee(employee);
            return RedirectToAction("EmployeeList");
        }

        public IActionResult ViewEmployee(long id)
        {
            EmployeeTable employee = _businessLayer.GetEmployeeById(id);
            return View(employee);
        }

        public IActionResult EditEmployee(long id)
        {
            EmployeeTable employee = _businessLayer.GetEmployeeById(id);
            return View(employee);
        }

        [HttpPost]
        public ActionResult EditEmployee(EmployeeTable employee)
        {
            _businessLayer.UpdateEmployee(employee);
            return RedirectToAction("EmployeeList");
        }

        public ActionResult DeleteEmployee(long id)
        {
            EmployeeTable employee = _businessLayer.GetEmployeeById(id);
            return View(employee);
        }

        [HttpPost]
        [ActionName("DeleteEmployee")]
        public ActionResult ConfirmDeleteCustomer(long id)
        {
            EmployeeTable employee = _businessLayer.GetEmployeeById(id);
            _businessLayer.DeleteEmployee(id);
            return RedirectToAction("EmployeeList");
        }

    }
}
