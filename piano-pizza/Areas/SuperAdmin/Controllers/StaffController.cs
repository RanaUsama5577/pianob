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
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using static Entities.Enum;

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
        public ActionResult AddStaff(UserType type)
        {
            var s = admin.GetBranches();
            ViewBag.Type = type;
            if(type== UserType.Receptionist)
            {
                ViewBag.CancelString = "/SuperAdmin/Staff/ReceptionistDetails";
            }
            else if (type == UserType.Cook)
            {
                ViewBag.CancelString = "/SuperAdmin/Staff/CookDetails";
            }
            else if (type == UserType.Packer)
            {
                ViewBag.CancelString = "/SuperAdmin/Staff/PackerDetails";
            }
            else if (type == UserType.Driver)
            {
                ViewBag.CancelString = "/SuperAdmin/Staff/DriverDetails";
            }
            ViewBag.Branches = new SelectList(s.ToList(), "Id", "Name");
            if (TempData["Message"] != null)
            {
                ViewBag.Message = TempData["Message"].ToString();
                TempData.Remove("Message");
            }
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> AddStaff(AddStaffDtos modal)
        {
            var s = admin.GetBranches();
            ViewBag.Branches = new SelectList(s.ToList(), "Id", "Name");
            var pathToSave = Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot/Images");
            if (modal.ImageFile != null)
            {
                if (modal.ImageFile.Length > 0)
                {
                    var fileName = ContentDispositionHeaderValue.Parse(modal.ImageFile.ContentDisposition).FileName.Trim('"');
                    var fullPath = Path.Combine(pathToSave, fileName);
                    var dbPath = "/Images/" + fileName;
                    using (var stream = new FileStream(fullPath, FileMode.Create))
                    {
                        await modal.ImageFile.CopyToAsync(stream);
                    }
                    modal.ImageUrl = dbPath;
                    var send = await admin.AddStaff(modal);
                    if (send.Code == 200)
                    {
                        TempData["Message"] = "Success";
                        return Redirect("/SuperAdmin/Staff/AddStaff?type=" + (int)modal.Role);
                    }
                    else
                    {
                        TempData["Message"] = send.ShortMessage;
                        return Redirect("/SuperAdmin/Staff/AddStaff?type=" + (int)modal.Role);
                    }
                }
                else
                {
                    TempData["Message"] = "Image file is null";
                    return Redirect("/SuperAdmin/Staff/AddStaff?type=" + (int)modal.Role);
                }
            }
            else
            {
                ViewBag.Message = "Error";
                ModelState.AddModelError("", "Image is not selected");
                return View(modal);
            }
        }
        public ActionResult ReceptionistDetails()
        {
            var users = admin.GetUsers(Entities.Enum.UserType.Receptionist);
            return View(users);
        }
        public ActionResult AddCook()
        {
            var s = admin.GetBranches();
            ViewBag.Branches = new SelectList(s.ToList(), "Id", "Name");
            if (TempData["Message"] != null)
            {
                ViewBag.Message = "Success";
                //TempData.Remove("Message");
            }
            return View();
        }
        public ActionResult CookDetails()
        {
            var users = admin.GetUsers(Entities.Enum.UserType.Cook);
            return View(users);
        }
        public ActionResult AddPacker()
        {
            var s = admin.GetBranches();
            ViewBag.Branches = new SelectList(s.ToList(), "Id", "Name");
            if (TempData["Message"] != null)
            {
                ViewBag.Message = "Success";
                TempData.Remove("Message");
            }
            return View();
        }
        public ActionResult PackerDetails()
        {
            var users = admin.GetUsers(Entities.Enum.UserType.Packer);
            return View(users);
        }
        public ActionResult AddDriver()
        {
            var s = admin.GetBranches();
            ViewBag.Branches = new SelectList(s.ToList(), "Id", "Name");
            if (TempData["Message"] != null)
            {
                ViewBag.Message = "Success";
                TempData.Remove("Message");
            }
            return View();
        }
        public ActionResult DriverDetails()
        {
            var users = admin.GetUsers(Entities.Enum.UserType.Driver);
            return View(users);
        }
    }
}