using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BLL.AdminService;
using Entities;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using JsonResult = Microsoft.AspNetCore.Mvc.JsonResult;
using DAL;
using Microsoft.AspNetCore.Identity;
using System.IO;

namespace piano_local.Areas.Driver.Controllers
{
    [Area("Driver")]
    [Authorize (Roles = "Driver")]
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
        // GET: Receptionist/Main
        public ActionResult Index()
        {
            ViewBag.currentime = DateTime.Now;
            var res = admin.GetStaffOrderdetails(userManager1.GetUserId(HttpContext.User));
            return View(res);
        }

        public ActionResult GetProducts(int Id)
        {
            var products = admin.GetOrderProducts(Id);
            ResponseDto responseDto = new ResponseDto
            {
                ShortMessage = "success",
                Code = 200,
                Result = products,
            };
            return Json(responseDto);
        }
        
        public ActionResult StartOrder(int Id)
        {
            var res = admin.StartDeliveringOrder(userManager1.GetUserId(HttpContext.User), Id);
            return Json(res);
        }

        public ActionResult MarkOrderAsDelivered(int Id)
        {
            var res = admin.MarkOrderAsDelivered(Id, userManager1.GetUserId(HttpContext.User));
            return Json(res);
        }

        public ActionResult DriverProfile()
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