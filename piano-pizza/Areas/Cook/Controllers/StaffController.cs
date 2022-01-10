using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace piano_pizza.Areas.Cook.Controllers
{
    public class StaffController : Controller
    {
        // GET: Cook/Staff
       
        public ActionResult PackersDetail()
        {
            return View();
        }
    }
}