using BLL.AdminService;
using DAL;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace piano_pizza.Areas.Driver.Controllers
{
    //[Area("Driver")]
    [Authorize(Roles = "Driver")]
    public class SettingsController : Controller
    {
        //Init ASP.NET identity store to handle user sign-in & sign-up 
        private readonly IAdminService admin;
        //Init ASP.NET identity store to handle user sign-in & sign-up 
        private readonly UserManager<ApplicationUser> userManager1;

        public SettingsController(IAdminService adminService, UserManager<ApplicationUser> userManager)
        {
            admin = adminService;
            this.userManager1 = userManager;
        }
        // GET: SuperAdmin/Main
        public JsonResult GetNotifications()
        {
            var res = admin.GetNotifications(userManager1.GetUserId(HttpContext.User));
            return Json(res);
        }

        public IActionResult ReadNotification(int Id)
        {
            var res = admin.ReadSingleNotification(Id, userManager1.GetUserId(HttpContext.User));
            return Json(res);
        }

        public IActionResult ReadAllNotification()
        {
            var res = admin.GetAndReadAllNotifications(userManager1.GetUserId(HttpContext.User));
            return Json(res);
        }

        public IActionResult UpdateFcm(string Fcm)
        {
            var res = admin.UpdateFcm(Fcm, userManager1.GetUserId(HttpContext.User));
            return Json(res);
        }
    }
}
