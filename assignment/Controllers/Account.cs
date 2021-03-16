using assignment.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Security.Claims;

namespace assignment.Controllers
{
    [AllowAnonymous]
    public class Account : Controller
    {
        LoginForm form = new LoginForm();
        public IActionResult LoginForm()
        {
            return View();
        }
        [HttpPost]
        public ActionResult LoginForm(LoginForm loginForm) {
            if (ModelState.IsValid)
            {
                if(form.isMatch(loginForm.UserName, loginForm.Password))
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            TempData["Error"] = "Invalid  Username or password";
            return View("LoginForm");        
        }
    }
}
