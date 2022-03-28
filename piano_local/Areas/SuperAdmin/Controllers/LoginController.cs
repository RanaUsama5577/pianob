using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace piano_local.Areas.SuperAdmin.Controllers
{
    [Area("SuperAdmin")]
    public class LoginController : Controller
    {
        // GET: SuperAdmin/Login
        public ActionResult SignIn()
        {
            return View();
        }
        public ActionResult ForgotPassword()
        {
            return View();
        }
    }
}