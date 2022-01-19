using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace piano_pizza.Areas.Cook.Controllers
{
    [Area("Cook")]
    public class AppContentController : Controller
    {
        // GET: Cook/AppContent
        public ActionResult PrivacyPolicy()
        {
            return View();
        }
        public ActionResult Cookies()
        {
            return View();
        }
    }
}