using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace piano_pizza.Areas.Cook.Controllers
{
    [Area("Cook")]
    public class OrdersController : Controller
    {
        // GET: Cook/Orders
        public ActionResult AssignOrders()
        {
            return View();
        }
        public ActionResult CompletedOrder()
        {
            return View();
        }

    }
}