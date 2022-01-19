using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace piano_pizza.Areas.Cook.Controllers
{
    [Area("Cook")]
    public class MainController : Controller
    {
        // GET: Cook/Main
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult CookProfile()
        {
            return View();
        }
    }
}