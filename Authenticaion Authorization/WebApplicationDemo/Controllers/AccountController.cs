using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using WebApplicationDemo.Models;
using Microsoft.AspNetCore.Authorization;

namespace WebApplicationDemo.Controllers
{
    [AllowAnonymous]
    public class AccountController : Controller
    {
        public IActionResult Login() // hardcoded to login because cookie wale mein pehla is always login 
        {
            var user = HttpContext.AuthenticateAsync(CookieAuthenticationDefaults.AuthenticationScheme).Result;
            if(user.Succeeded)
            {
                return RedirectToAction("Index", "Home");
            }
            return View("Index",new LoginViewModel());
        }


        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel loginViewModel)
        {
            if(ModelState.IsValid)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name , loginViewModel.UserName),
                    new Claim(ClaimTypes.Role , "Admin")
                };

                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity)
                    , new AuthenticationProperties
                    {
                        IsPersistent = loginViewModel.RememberMe 
                    });

                return RedirectToAction("Index", "Home");
            }
            TempData["Error"] = "Invalid  Username or password";
            return View("Index");
        }


        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction(nameof(Login));
        }
    }


   
} 
