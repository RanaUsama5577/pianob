using BLL.AdminService;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace piano_pizza.Controllers
{
    public class MenuController : Controller
    {
        //Init ASP.NET identity store to handle user sign-in & sign-up 
        private readonly IAdminService admin;


        public MenuController( IAdminService adminService)
        {
            admin = adminService;
        }

        [Route("/{controller}/{BranchName}")]
        public IActionResult Index(string BranchName)
        {
            var catsAndProducts = admin.GetCategoriesAndProducts(BranchName);
            return View(catsAndProducts);
        }
    }
}
