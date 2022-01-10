using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace piano_pizza.Areas.SuperAdmin.Controllers
{
    [Area("SuperAdmin")]
    public class BranchController : Controller
    {
        // GET: SuperAdmin/Branch
        public ActionResult AddBranch()
        {
            return View();
        }
        public ActionResult Details()
        {
            return View();
        }
    }
}