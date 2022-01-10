using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace piano_pizza.Areas.SuperAdmin.Controllers
{
    [Area("SuperAdmin")]
    public class UsersController : Controller
    {
        // GET: SuperAdmin/Users
        public ActionResult Detail()
        {
            return View();
        }
    }
}