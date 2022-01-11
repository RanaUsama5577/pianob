using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace piano_pizza.Areas.SuperAdmin.Controllers
{
    [Area("SuperAdmin")]
    [Authorize(Roles = "SuperAdmin")]
    public class ProductController : Controller
    {
        // GET: SuperAdmin/Product
        public ActionResult Category()
        {
            return View();
        }
        public ActionResult AddProduct()
        {
            return View();
        }
        public ActionResult AddIngredients()
        {
            return View();
        }
        public ActionResult Detail()
        {
            return View();
        }
    }
}