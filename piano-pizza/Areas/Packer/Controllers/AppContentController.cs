using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace piano_pizza.Areas.Packer.Controllers
{
    public class AppContentController : Controller
    {
        // GET: Packer/AppContent
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