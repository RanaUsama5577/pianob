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
    public class OrderController : Controller
    {
        // GET: SuperAdmin/Order
        public ActionResult Detail()
        {
            return View();
        }
        public ActionResult Payment()
        {
            return View();
        }
    }
}