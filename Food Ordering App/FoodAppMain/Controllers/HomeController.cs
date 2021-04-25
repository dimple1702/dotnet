using FoodAppBO.Interface;
using FoodAppEntity.CustomModel;
using FoodAppEntity.Entities;
using FoodAppMain.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace FoodAppMain.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IFoodAppBusinessComponent _foodAppBusinessComponent;

        public HomeController(ILogger<HomeController> logger, IFoodAppBusinessComponent foodAppBusinessComponent)
        {
            _logger = logger;
            _foodAppBusinessComponent = foodAppBusinessComponent;
        }

        public async Task<IActionResult> Index()
        {
            ViewBag.Selected = "Index";
            return View();
        }


        [Authorize]
        public IActionResult About()
        {
            ViewBag.Selected = "About";
            var user = HttpContext.AuthenticateAsync(CookieAuthenticationDefaults.AuthenticationScheme).Result;
            var temp1 = user.Principal.Claims.FirstOrDefault(x => x.Type == "Id");
            return View();
        }


        [Authorize]
        public IActionResult Contact()
        {
            ViewBag.Selected = "Contact";
            return View();
        }


        [Authorize]
        public IActionResult Gallery()
        {
            ViewBag.Selected = "Gallery";
            return View();
        }


        [Authorize]
        public IActionResult Menu(int PageNumber = 1)
        {
            ViewBag.Selected = "Menu";
            List<Menu> menu = _foodAppBusinessComponent.GetMenuList();
            ViewBag.TotalPages = Math.Ceiling(menu.Count() / 8.0);
            ViewBag.PageNumber = PageNumber;

            menu = _foodAppBusinessComponent.Pagination(PageNumber, 8, menu);

            return View(menu);
        }


        [Authorize]
        public IActionResult OrderHistory()
        {
            ViewBag.Selected = "Menu";
            var user = HttpContext.AuthenticateAsync(CookieAuthenticationDefaults.AuthenticationScheme).Result;
            var temp1 = user.Principal.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Sid).Value;
            var list = _foodAppBusinessComponent.ShowOrderHistory(Convert.ToInt64(temp1));
            return View(list);
        }


        [Authorize]
        public IActionResult OrderView(long menuId)
        {
            ViewBag.Selected = "Menu";
            List<OrderCategoryModel> menu = _foodAppBusinessComponent.GetMenuItemById(menuId);
            return View(menu);
        }


        [Authorize]
        public IActionResult PaymentSuccessful(PaymentDetails details)
        {
            ViewBag.Selected = "Reservation";
            var user = HttpContext.AuthenticateAsync(CookieAuthenticationDefaults.AuthenticationScheme).Result;
            var temp1 = user.Principal.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Sid).Value;
            details.UserId = Convert.ToInt64(temp1);
            _foodAppBusinessComponent.AddPaymentDetails(details);
            return View();
        }


        [Authorize]
        public IActionResult PayOrder(long menuId)
        {
            ViewBag.Selected = "Menu";
            Menu menu = _foodAppBusinessComponent.GetFoodItemById(menuId);
            ViewBag.Amount = menu.Price;
            var list = _foodAppBusinessComponent.GetPaymentMethodList();
            return View();
        }


        [Authorize]
        public IActionResult Reservation()
        {
            ViewBag.Selected = "Reservation";
            ReservationDetails details = new ReservationDetails();
            return View(details);
        }


        [Authorize]
        public IActionResult TableReservationSuccess(ReservationDetails details)
        {
            ViewBag.Selected = "Reservation";
            _foodAppBusinessComponent.AddTableReservation(details);
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        
    }
}
