using BLL.AdminService;
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
    public class MainController : Controller
    {
        //Init ASP.NET identity store to handle user sign-in & sign-up 
        private readonly IAdminService admin;

        public MainController(IAdminService adminService)
        {
            admin = adminService;
        }
        // GET: SuperAdmin/Main
        public ActionResult Index()
        {
            var res = admin.DashboardStats();
            return View(res);
        }
        public ActionResult AdminProfile()
        {
            return View();
        }
        public ActionResult Queries()
        {
            return View();
        }
        public ActionResult Ratings()
        {
            return View();
        }
    }
}