using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace piano_pizza.Areas.Receptionist.Controllers
{
    public class UsersController : Controller
    {
        // GET: Receptionist/Users
        public ActionResult Detail()
        {
            return View();
        }
        public ActionResult ReceptionistProfile()
        {
            return View();
        }
    }
}