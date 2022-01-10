using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace piano_pizza.Areas.Packer.Controllers
{
    public class OrderController : Controller
    {
        // GET: Packer/Order
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