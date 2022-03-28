using BLL.AdminService;
using Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using JsonResult = Microsoft.AspNetCore.Mvc.JsonResult;
using DAL;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Http;

namespace piano_local.Areas.SuperAdmin.Controllers
{
    [Area("SuperAdmin")]
    [Authorize(Roles = "SuperAdmin")]
    public class MainController : Controller
    {
        //Init ASP.NET identity store to handle user sign-in & sign-up 
        private readonly IAdminService admin;
        //Init ASP.NET identity store to handle user sign-in & sign-up 
        private readonly UserManager<ApplicationUser> userManager1;

        public MainController(IAdminService adminService, UserManager<ApplicationUser> userManager)
        {
            admin = adminService;
            this.userManager1 = userManager;
        }
        // GET: SuperAdmin/Main
        public ActionResult Index()
        {
            var res = admin.DashboardStats(userManager1.GetUserId(HttpContext.User));
            return View(res);
        }
        public ActionResult AdminProfile()
        {
            return View();
        }
        public ActionResult Queries()
        {
            var contactus = admin.GetContactUs();
            return View(contactus);
        }
        public ActionResult ResolveQuery(int Id)
        {
            var query = admin.ResolveQuery(Id);
            return Json(query);
        }
        public ActionResult Ratings()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> UpdateProfileImage(UpdateProfileImage modal)
        {
            var pathToSave = Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot/Images");
            if (modal.file.Length > 0)
            {
                var fileName = ContentDispositionHeaderValue.Parse(modal.file.ContentDisposition).FileName.Trim('"');
                var fullPath = Path.Combine(pathToSave, fileName);
                var dbPath = "/Images/" + fileName;
                using (var stream = new FileStream(fullPath, FileMode.Create))
                {
                    await modal.file.CopyToAsync(stream);
                }
                string imageUrl = dbPath;
                var user = admin.UpdateProfileImage(imageUrl, userManager1.GetUserId(HttpContext.User));
                ProfileDtos profile = new ProfileDtos
                {
                    FullName = user.FullName,
                    Email = user.Email,
                    ProfileImageUrl = user.ProfileImageUrl,
                };
                return JsonResponse(200, "success", profile);
            }
            else
            {
                return JsonResponse(400, "error", null);
            }

        }

        public IActionResult UpdateProfile(string Name)
        {
            var user = admin.UpdateProfile(Name, userManager1.GetUserId(HttpContext.User));
            ProfileDtos profile = new ProfileDtos
            {
                FullName = user.FullName,
                Email = user.Email,
                ProfileImageUrl = user.ProfileImageUrl,
            };
            return JsonResponse(200, "success", profile);
        }

        // POST: /Manage/ChangePassword
        [HttpPost]
        public async Task<JsonResult> ChangePassword(UpdatePasswordVms model)
        {
            try
            {
                var response = await admin.ChangePassword(model, userManager1.GetUserId(HttpContext.User));
                return Json(response);
            }
            catch (Exception ex)
            {
                return JsonResponse(501, ex.GetBaseException().Message, null);
            }
        }

        public IActionResult GetProfile()
        {
            var user = admin.getLoginUser(userManager1.GetUserId(HttpContext.User));
            ProfileDtos profile = new ProfileDtos
            {
                FullName = user.FullName,
                Email = user.Email,
                ProfileImageUrl = user.ProfileImageUrl,
            };
            return JsonResponse(200, "success", profile);
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

        internal JsonResult JsonResponse(int errorCode, string message, object responseData)
        {
            ResponseDto response = new ResponseDto
            {
                Code = errorCode,
                ShortMessage = message,
                Result = responseData,
            };
            return Json(response);
        }
    }
}