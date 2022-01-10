using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace piano_pizza.Areas.Receptionist.Controllers
{
    public class StaffController : Controller
    {
        // GET: Receptionist/Staff
        public ActionResult Cook()
        {
            return View();
        }
        public ActionResult AddCook()
        {
            return View();
        }

        public ActionResult Packer()
        {
            return View();
        }
        public ActionResult AddPacker()
        {
            return View();
        }
    }
}