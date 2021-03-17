using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TestApplicationBO.Interface;
using TestApplicationMain.Models;

namespace TestApplicationMain.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IEmployeeBusinessAccess _employeeBusinessAccess;

        public HomeController(ILogger<HomeController> logger, IEmployeeBusinessAccess employeeBusinessAccess)
        {
            _logger = logger;
            _employeeBusinessAccess = employeeBusinessAccess;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            var list = _employeeBusinessAccess.GetEmployees();
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
