using BLL.AdminService;
using Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace piano_pizza.Controllers
{
    public class ProductController : Controller
    {
        //Init ASP.NET identity store to handle user sign-in & sign-up 
        private readonly IAdminService admin;

        public ProductController(IAdminService adminService)
        {
            admin = adminService;
        }

        [Route("/Menu/{BranchName}/{CategoryName}/{Id}")]
        public IActionResult Index(int Id,string BranchName,string CategoryName)
        {
            var res = admin.ProductDetail(Id, BranchName, CategoryName);
            return View(res);
        }

        [HttpPost]
        public IActionResult AddToCart([FromBody] AddToCart model)
        {
            return Json(model);
        }
    }
}
