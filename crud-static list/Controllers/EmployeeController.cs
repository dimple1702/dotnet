using System.Web.Mvc;
using vermadimple.Models;
using vermadimple.Repository;

namespace vermadimple.Controllers
{
    public class EmployeeController : Controller
    {
        readonly EmployeeRepository employeeRepository;
        public EmployeeController(EmployeeRepository repository)
        {
            this.employeeRepository = repository;
        }

        public ActionResult List()
        {
            var list = employeeRepository.GetAllEmployee();
            return View(list);
        }

        public ActionResult Edit(int Id)
        {
            Employee employee = employeeRepository.Get(Id);
            return View(employee);
        }

        [HttpPost]
        public ActionResult Edit(Employee employee) {
            Employee emp = employeeRepository.Update(employee);
            if(emp == null)
            {
                return HttpNotFound();
            }
            else
            {
                var list = employeeRepository.GetAllEmployee();
                return View("List", list);
            }
        }

        public ActionResult Delete()
        {
            return View();   
        }
    }
}