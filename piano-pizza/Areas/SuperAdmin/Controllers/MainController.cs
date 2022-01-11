using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace piano_pizza.Areas.SuperAdmin.Controllers
{
    [Area("SuperAdmin")]
    [Authorize(Roles = "SuperAdmin")]
    public class MainController : Controller
    {
        // GET: SuperAdmin/Main
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AdminProfile()
        {
            return View();
        }
        public ActionResult Queries()
        {
            return View();
        }
        public ActionResult Ratings()
        {
            return View();
        }
    }
}