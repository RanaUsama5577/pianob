using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace piano_pizza.Areas.Packer.Controllers
{
    public class MainController : Controller
    {
        // GET: Packer/Main
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult PackerProfile()
        {
            return View();
        }
        public ActionResult DeliveryPerson()
        {
            return View();
        }
    }
}