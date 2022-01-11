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

namespace piano_pizza.Areas.SuperAdmin.Controllers
{
    [Area("SuperAdmin")]
    [Authorize(Roles = "SuperAdmin")]
    public class StaffController : Controller
    {
        //Init ASP.NET identity store to handle user sign-in & sign-up 
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly RoleManager<IdentityRole> role;
        //Init ASP.NET identity store to handle user sign-in & sign-up 
        private readonly IAdminService admin;

        public StaffController(RoleManager<IdentityRole> roleManager, UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, IAdminService adminService)
        {
            admin = adminService;
            this.signInManager = signInManager;
            this.role = roleManager;
            this.userManager = userManager;
        }

        // GET: SuperAdmin/Staff
        public ActionResult AddReceptionist()
        {
            return View();
        }
        public ActionResult ReceptionistDetails()
        {
            var users = admin.GetUsers(Entities.Enum.UserType.Receptionist);
            return View(users);
        }
        public ActionResult AddCook()
        {
            return View();
        }
        public ActionResult CookDetails()
        {
            var users = admin.GetUsers(Entities.Enum.UserType.Cook);
            return View(users);
        }
        public ActionResult AddPacker()
        {
            return View();
        }
        public ActionResult PackerDetails()
        {
            var users = admin.GetUsers(Entities.Enum.UserType.Packer);
            return View(users);
        }
        public ActionResult AddDriver()
        {
            return View();
        }
        public ActionResult DriverDetails()
        {
            var users = admin.GetUsers(Entities.Enum.UserType.Driver);
            return View(users);
        }
    }
}