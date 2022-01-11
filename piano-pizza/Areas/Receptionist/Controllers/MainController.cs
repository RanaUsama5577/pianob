using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace piano_pizza.Areas.Receptionist.Controllers
{
    [Area("Receptionist")]
    public class MainController : Controller
    {
        // GET: Receptionist/Main
        public ActionResult Index()
        {
            return View();
        }
        
    }
}