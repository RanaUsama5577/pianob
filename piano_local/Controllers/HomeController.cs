using BLL.AdminService;
using Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using piano_local.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace piano_local.Controllers
{
    public class HomeController : Controller
    {
        //Init ASP.NET identity store to handle user sign-in & sign-up 
        private readonly IAdminService admin;

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, IAdminService adminService)
        {
            _logger = logger;
            admin = adminService;
        }

        public IActionResult Index()
        {
            var s = admin.GetBranches();
            s = s.Where(p => p.Status == Entities.Enum.EntityStatus.Active).ToList();
            return View(s);
        }

        public PartialViewResult headerPartial()
        {
            var s = admin.GetBranches();
            s = s.Where(p => p.Status == Entities.Enum.EntityStatus.Active).ToList();
            return PartialView(s);
        }

        public PartialViewResult footerPartial()
        {
            var s = admin.GetBranches();
            s = s.Where(p => p.Status == Entities.Enum.EntityStatus.Active).ToList();
            return PartialView(s);
        }

        public JsonResult GetAppInfo()
        {
            var appInfo = admin.GetAppInfo();
            return Json(appInfo);
        }

        public string CultureManagement(string culture)
        {
            Response.Cookies.Append(CookieRequestCultureProvider.DefaultCookieName, CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions
                {
                    Expires = DateTimeOffset.Now.AddDays(30)
                });
            return culture;
        }
    }
}
