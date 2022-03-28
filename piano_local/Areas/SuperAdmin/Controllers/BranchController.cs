using BLL.AdminService;
using Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;

namespace piano_local.Areas.SuperAdmin.Controllers
{
    [Area("SuperAdmin")]
    [Authorize(Roles = "SuperAdmin")]
    public class BranchController : Controller
    {
        //Init ASP.NET identity store to handle user sign-in & sign-up 
        private readonly IAdminService admin;
        public BranchController(IAdminService adminService)
        {
            admin = adminService;
        }

        // GET: SuperAdmin/Branch
        public ActionResult AddBranch()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> AddBranch(BranchAddVms modal)
        {
            var pathToSave = Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot/Images");
            if (modal.Image != null)
            {
                if (modal.Image.Length > 0)
                {
                    var fileName = ContentDispositionHeaderValue.Parse(modal.Image.ContentDisposition).FileName.Trim('"');
                    var fullPath = Path.Combine(pathToSave, fileName);
                    var dbPath = "/Images/" + fileName;
                    using (var stream = new FileStream(fullPath, FileMode.Create))
                    {
                        await modal.Image.CopyToAsync(stream);
                    }
                    modal.ImageUrl = dbPath;
                    var s = admin.AddBranch(modal);
                    return Json(s);
                }
                else
                {
                    modal.ImageUrl = "";
                    var s = admin.AddBranch(modal);
                    return Json(s);
                }
            }
            else
            {
                modal.ImageUrl = "";
                var s = admin.AddBranch(modal);
                return Json(s);
            }
        }

        public ActionResult Details()
        {
            var res = admin.GetBranches();
            return View(res);
        }

        public IActionResult BlockEntity(int Id)
        {
            try
            {
                var s = admin.BlockBranch(Id);
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
                var s = admin.UnBlockBranch(Id);
                return Json(s);
            }
            catch (Exception ex)
            {
                throw new ValidationException(ex.GetBaseException().Message);
            }
        }
    }
}