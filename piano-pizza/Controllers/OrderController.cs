using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace piano_pizza.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Cart()
        {
            return View();
        }
        public IActionResult History()
        {
            return View();
        }
        public IActionResult MyOrder()
        {
            return View();
        }
        public IActionResult HistoryOrderDetails()
        {
            return View();
        }
        public IActionResult MyOrderDetails()
        {
            return View();
        }
    }
}
