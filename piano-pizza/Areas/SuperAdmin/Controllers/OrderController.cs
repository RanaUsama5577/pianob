using Microsoft.AspNetCore.Authorization;
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
using Microsoft.AspNetCore.Mvc.Rendering;

namespace piano_pizza.Areas.SuperAdmin.Controllers
{
    [Area("SuperAdmin")]
    [Authorize(Roles = "SuperAdmin")]
    public class OrderController : Controller
    {
        //Init ASP.NET identity store to handle user sign-in & sign-up 
        private readonly IAdminService admin;
        //Init ASP.NET identity store to handle user sign-in & sign-up 
        private readonly UserManager<ApplicationUser> userManager1;

        public OrderController(IAdminService adminService, UserManager<ApplicationUser> userManager)
        {
            admin = adminService;
            this.userManager1 = userManager;
        }
        // GET: SuperAdmin/Order
        public ActionResult Detail()
        {
            var orders = admin.GetOrderdetails(userManager1.GetUserId(HttpContext.User));
            orders = orders.Where(p => p.Status == Entities.Enum.OrderStatus.Delivered).OrderByDescending(p=>p.UpdatedAt).ToList();
            return View(orders);
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
        public ActionResult UserReports(int Id)
        {
            var orders = admin.GetOrderStaffReports(Id);
            ResponseDto responseDto = new ResponseDto
            {
                ShortMessage = "success",
                Code = 200,
                Result = orders,
            };
            return Json(responseDto);
        }
        

    }
}