//using BLL.AdminService;
using BLL.AdminService;
using DAL;
using Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace piano_local.Areas.SuperAdmin.Controllers
{
    [Area("SuperAdmin")]
    [Authorize(Roles = "SuperAdmin")]
    public class CategoryController : Controller
    {

        //Init ASP.NET identity store to handle user sign-in & sign-up 
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly RoleManager<IdentityRole> role;
        //Init ASP.NET identity store to handle user sign-in & sign-up 
        private readonly IAdminService admin;

        public CategoryController(RoleManager<IdentityRole> roleManager, UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, IAdminService adminService)
        {
            admin = adminService;
            this.signInManager = signInManager;
            this.role = roleManager;
            this.userManager = userManager;
        }

        public IActionResult Index()
        {
            var res = admin.GetCategories();
            var s = admin.GetBranches();
            ViewBag.Branches = new SelectList(s.ToList(), "Id", "Name");
            return View(res);
        }
        public IActionResult AddCategory(CategoryAddVms modal)
        {
            var res = admin.AddOrUpdateCategory(modal);
            return Json(res);
        }
        public IActionResult BlockEntity(int Id)
        {
            try
            {
                var s = admin.BlockCategory(Id);
                return Json(s);
            }
            catch (Exception ex)
            {
                throw new ValidationException(ex.GetBaseException().Message);
            }
        }
        public IActionResult UnBlockEntity(int Id)
        {
            try
            {
                var s = admin.UnBlockCategory(Id);
                return Json(s);
            }
            catch (Exception ex)
            {
                throw new ValidationException(ex.GetBaseException().Message);
            }
        }
    }
}
