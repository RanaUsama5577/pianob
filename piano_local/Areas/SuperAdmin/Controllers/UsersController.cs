//using BLL.AdminService;
using BLL.AdminService;
using DAL;
using Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace piano_local.Areas.SuperAdmin.Controllers
{
    [Area("SuperAdmin")]
    [Authorize(Roles = "SuperAdmin")]
    public class UsersController : Controller
    {
        //Init ASP.NET identity store to handle user sign-in & sign-up 
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly RoleManager<IdentityRole> role;
        //Init ASP.NET identity store to handle user sign-in & sign-up 
        private readonly IAdminService admin;

        public UsersController(RoleManager<IdentityRole> roleManager, UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, IAdminService adminService)
        {
            admin = adminService;
            this.signInManager = signInManager;
            this.role = roleManager;
            this.userManager = userManager;
        }

        // GET: SuperAdmin/Users
        public ActionResult Detail()
        {
            var users = admin.GetUsers(Entities.Enum.UserType.User);
            return View(users);
        }
        public IActionResult BlockUser(string Id)
        {
            try
            {
                var s = admin.BlockUser(Id);
                return Json(s);
            }
            catch (Exception ex)
            {
                throw new ValidationException(ex.GetBaseException().Message);
            }
        }
        public IActionResult UnBlockUser(string Id)
        {
            try
            {
                var s = admin.UnBlockUser(Id);
                return Json(s);
            }
            catch (Exception ex)
            {
                throw new ValidationException(ex.GetBaseException().Message);
            }
        }
        public IActionResult LeftUser(string Id)
        {
            try
            {
                var s = admin.LeftUser(Id);
                return Json(s);
            }
            catch (Exception ex)
            {
                throw new ValidationException(ex.GetBaseException().Message);
            }
        }
        public IActionResult DeleteUser(string Id)
        {
            try
            {
                var s = admin.DeleteUser(Id);
                return Json(s);
            }
            catch (Exception ex)
            {
                throw new ValidationException(ex.GetBaseException().Message);
            }
        }
    }
}


