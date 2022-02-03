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
using System.IO;

namespace piano_pizza.Areas.Driver.Controllers
{
    [Area("Driver")]
    [Authorize(Roles = "Driver")]
    public class OrdersController : Controller
    {
        //Init ASP.NET identity store to handle user sign-in & sign-up 
        private readonly IAdminService admin;
        //Init ASP.NET identity store to handle user sign-in & sign-up 
        private readonly UserManager<ApplicationUser> userManager1;
        public OrdersController(IAdminService adminService, UserManager<ApplicationUser> userManager)
        {
            admin = adminService;
            this.userManager1 = userManager;
        }
        public ActionResult GetProducts(int Id)
        {
            var products = admin.GetOrderProducts(Id);
            ResponseDto responseDto = new ResponseDto
            {
                ShortMessage = "success",
                Code = 200,
                Result = products,
            };
            return Json(responseDto);
        }
        public ActionResult CompletedOrder()
        {
            var orders = admin.StaffCompletedOrders(userManager1.GetUserId(HttpContext.User));
            return View(orders);
        }

    }
}