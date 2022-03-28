using BLL.AdminService;
using Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace piano_local.Areas.SuperAdmin.Controllers
{
    [Area("SuperAdmin")]
    [Authorize(Roles ="SuperAdmin")]
    public class AppContentController : Controller
    {
        //Init ASP.NET identity store to handle user sign-in & sign-up 
        private readonly IAdminService admin;
        public AppContentController(IAdminService adminService)
        {
            admin = adminService;
        }

        // GET: SuperAdmin/AppContent
        public ActionResult PrivacyPolicy()
        {
            var appinfo = admin.GetAppInfo();
            return View(appinfo);
        }
        public JsonResult GetPrivacyPolicy()
        {
            var content = admin.GetPrivacyPolicy();
            return Json(content);
        }

        [HttpPost]
        public async Task<JsonResult> SaveAboutApplication([FromForm] aboutappVms modal)
        {
            var s = admin.SaveAboutAppInfo(modal);
            return Json(s);
        }

        [HttpPost]
        public JsonResult UpdatePrivacyPolicy([FromBody] contentVms modal)
        {
            var content22 = admin.UpdatePrivacyPolicy(modal);
            return Json(content22);
        }
        public ActionResult CookiePolicy()
        {
            return View();
        }

        public JsonResult GetCookiePolicy()
        {
            var content = admin.GetCookiePolicy();
            return Json(content);
        }

        [HttpPost]
        public JsonResult UpdateCookiePolicy([FromBody] contentVms modal)
        {
            var content22 = admin.UpdateCookiePolicy(modal);
            return Json(content22);
        }
    }
}