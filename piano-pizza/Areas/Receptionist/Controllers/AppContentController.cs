using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace piano_pizza.Areas.Receptionist.Controllers
{
    public class AppContentController : Controller
    {
        // GET: Receptionist/AppContent
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