﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BLL.AdminService;
using Entities;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using JsonResult = Microsoft.AspNetCore.Mvc.JsonResult;
using DAL;
using Microsoft.AspNetCore.Identity;


namespace piano_pizza.Areas.Receptionist.Controllers
{
    [Area("Receptionist")]
    [Authorize(Roles="Receptionist")]
    public class MainController : Controller
    {
        //Init ASP.NET identity store to handle user sign-in & sign-up 
        private readonly IAdminService admin;
        //Init ASP.NET identity store to handle user sign-in & sign-up 
        private readonly UserManager<ApplicationUser> userManager1;

        public MainController(IAdminService adminService, UserManager<ApplicationUser> userManager)
        {
            admin = adminService;
            this.userManager1 = userManager;
        }
        // GET: Receptionist/Main
        public ActionResult Index()
        {
            var res = admin.DashboardStats(userManager1.GetUserId(HttpContext.User));
            return View(res);
        }
        public ActionResult ReceptionistProfile()
        {
            return View();
        }
    }
}