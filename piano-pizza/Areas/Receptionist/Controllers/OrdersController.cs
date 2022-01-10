using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace piano_pizza.Areas.Receptionist.Controllers
{
    public class OrdersController : Controller
    {
        // GET: Receptionist/Orders
        public ActionResult Detail()
        {
            return View();
        }
       
        public ActionResult ProductsDetail()
        {
            return View();
        }

        public ActionResult PlaceOrder()
        {
            return View();
        }
        public ActionResult Payment()
        {
            return View();
        }
    }
}