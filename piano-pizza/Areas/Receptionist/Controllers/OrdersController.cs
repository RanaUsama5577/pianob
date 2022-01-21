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

namespace piano_pizza.Areas.Receptionist.Controllers
{
    [Area("Receptionist")]
    [Authorize(Roles = "Receptionist")]
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
        // GET: Receptionist/Orders
        public ActionResult Detail()
        {
            var orders = admin.GetOrderdetails(userManager1.GetUserId(HttpContext.User));
            return View(orders);
        }
       
        public ActionResult PlaceOrder()
        {
            var products = admin.GetProducts();
            var cats = admin.GetCategories();
            var ingrednients = admin.GetIngredient();
            cats = cats.Where(p => p.Status == Entities.Enum.EntityStatus.Active).ToList();
            products = products.Where(p => p.Status == Entities.Enum.EntityStatus.Active).ToList();
            ViewBag.Categories = new SelectList(cats.ToList(), "Id", "Name");
            ViewBag.Products = products.ToList();
            ViewBag.Ingredients = ingrednients;
            return View();
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
        

        [HttpPost]
        public async Task<ActionResult> PlaceOrder([FromBody] SaveOrderData modal)
        {
            var save = admin.SaveOrder(modal, userManager1.GetUserId(HttpContext.User));
            return Json(save);
        }
    }
}