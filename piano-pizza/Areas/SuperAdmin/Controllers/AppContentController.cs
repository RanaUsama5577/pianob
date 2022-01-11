using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace piano_pizza.Areas.SuperAdmin.Controllers
{
    [Area("SuperAdmin")]
    [Authorize(Roles ="SuperAdmin")]
    public class AppContentController : Controller
    {
        // GET: SuperAdmin/AppContent
        public ActionResult PrivacyPolicy()
        {
            return View();
        }
        public ActionResult CookiePolicy()
        {
            return View();
        }
    }
}