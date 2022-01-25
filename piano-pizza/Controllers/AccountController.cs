//using BLL.AdminService;
using BLL.AdminService;
using DAL;
using Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace piano_pizza.Controllers
{
    public class AccountController : Controller
    {
        //Init ASP.NET identity store to handle user sign-in & sign-up 
        private readonly IAdminService admin;

        public AccountController(IAdminService adminService) 
        {
            admin = adminService;
        }

        // GET: SuperAdmin/Login
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel LoginUser, string returnUrl)
        {
            var response = await admin.Login(LoginUser);
            if (response.Code == 201)
            {
                if (returnUrl != null)
                {
                    return Redirect(returnUrl);
                }
                else
                {
                    return Redirect("/SuperAdmin/Main/Index");
                }
            }
            else if (response.Code == 202)
            {
                if (returnUrl != null)
                {
                    return Redirect(returnUrl);
                }
                else
                {
                    return Redirect("/receptionist/Main/Index");
                }
            }
            else if (response.Code == 203)
            {
                if (returnUrl != null)
                {
                    return Redirect(returnUrl);
                }
                else
                {
                    return Redirect("/cook/Main/Index");
                }
            }
            else if (response.Code == 204)
            {
                if (returnUrl != null)
                {
                    return Redirect(returnUrl);
                }
                else
                {
                    return Redirect("/packer/Main/Index");
                }
            }
            else if (response.Code == 205)
            {
                if (returnUrl != null)
                {
                    return Redirect(returnUrl);
                }
                else
                {
                    return Redirect("/deliveryperson/Main/Index");
                }
            }
            else
            {
                ModelState.AddModelError("", response.ShortMessage);
                return View(LoginUser);
            }
        }

        public async Task<IActionResult> Logout()
        {
            var logout = await admin.Logout();
            if (logout.Code == 200)
            {
                return RedirectToAction("Login", "Account");
            }
            else
            {
                return RedirectToAction("Login", "Account");
            }
        }

        public ActionResult ForgotPassword()
        {
            return View();
        }

        public ActionResult AccessDenied()
        {
            return View();
        }
    }
}
