using BLL.AdminService;
using DAL;
using Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace piano_local.Controllers
{
    public class ProductController : Controller
    {
        //Init ASP.NET identity store to handle user sign-in & sign-up 
        private readonly IAdminService admin;
        //Init ASP.NET identity store to handle user sign-in & sign-up 
        private readonly UserManager<ApplicationUser> userManager1;

        public ProductController(IAdminService adminService, UserManager<ApplicationUser> userManager)
        {
            admin = adminService;
            this.userManager1 = userManager;
        }

        [Route("/Menu/{BranchName}/{CategoryName}/{Id}")]
        public IActionResult Index(int Id,string BranchName,string CategoryName)
        {
            var userId = userManager1.GetUserId(HttpContext.User)??"";
            var res = admin.ProductDetail(Id, BranchName, CategoryName, userId);
            return View(res);
        }

        [HttpPost]
        public IActionResult AddToCart([FromBody] AddToCart model)
        {
            var res = admin.AddToCart(model, userManager1.GetUserId(HttpContext.User));
            return Json(res);
        }
    }
}
