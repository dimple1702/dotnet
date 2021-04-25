using FoodAppBO.Interface;
using FoodAppEntity.Entities;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace FoodAppMain.Controllers
{
    public class AccountController : Controller
    {
        private readonly IFoodAppBusinessComponent _foodAppBusinessComponent;

        public AccountController(IFoodAppBusinessComponent foodAppBusinessComponent)
        {
            _foodAppBusinessComponent = foodAppBusinessComponent;
        }

        public IActionResult Login()
        {
            return View("Login");
        }


        [HttpPost]
        public async Task<IActionResult> Login(User user)
        {
            User userObj = _foodAppBusinessComponent.AuthenticateUser(user);
            if (ModelState.IsValid && userObj != null)
            {
                string UserRole = getRoleType((int)userObj.UserRole);
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Role , UserRole),
                    new Claim(ClaimTypes.Sid, userObj.UserId.ToString()),

                };

                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity)
                    , new AuthenticationProperties
                    {
                        IsPersistent = true
                    });
                return RedirectToAction("Index", "Home");

            }
            else
            {
                ViewBag.ErrorMessage = "User not found!!!";
                return View("Login");
            }
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme, new AuthenticationProperties());
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login");
        }

        public string getRoleType(int id)
        {
            switch (id)
            {
                case 0:
                    return "User";
                    break;
                case 1:
                    return "Admin";
                    break;
                default:
                    return "User";
                    break;
            }
        }

    }
}
