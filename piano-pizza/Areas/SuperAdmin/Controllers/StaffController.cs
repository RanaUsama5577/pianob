using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace piano_pizza.Areas.SuperAdmin.Controllers
{
    [Area("SuperAdmin")]
    public class StaffController : Controller
    {
        // GET: SuperAdmin/Staff
        public ActionResult AddReceptionist()
        {
            return View();
        }
        public ActionResult ReceptionistDetails()
        {
            return View();
        }
        public ActionResult AddCook()
        {
            return View();
        }
        public ActionResult CookDetails()
        {
            return View();
        }
        public ActionResult AddPacker()
        {
            return View();
        }
        public ActionResult PackerDetails()
        {
            return View();
        }
    }
}