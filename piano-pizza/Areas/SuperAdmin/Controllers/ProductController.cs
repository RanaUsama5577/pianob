using BLL.AdminService;
using Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace piano_pizza.Areas.SuperAdmin.Controllers
{
    [Area("SuperAdmin")]
    [Authorize(Roles = "SuperAdmin")]
    public class ProductController : Controller
    {
        //Init ASP.NET identity store to handle user sign-in & sign-up 
        private readonly IAdminService admin;
        public ProductController(IAdminService adminService)
        {
            admin = adminService;
        }

        // GET: SuperAdmin/Product
        public ActionResult Category()
        {
            return View();
        }
        
        public ActionResult AddIngredients()
        {
            var products = admin.GetProducts();
            var cats = admin.GetCategories();
            var branches = admin.GetBranches();
            cats = cats.Where(p => p.Status == Entities.Enum.EntityStatus.Active).ToList();
            branches = branches.Where(p => p.Status == Entities.Enum.EntityStatus.Active).ToList();
            products = products.Where(p => p.Status == Entities.Enum.EntityStatus.Active).ToList();
            ViewBag.Branches = new SelectList(branches.ToList(), "Id", "Name");
            ViewBag.Categories = new SelectList(cats.ToList(), "Id", "Name", "selected", "BranchId");
            ViewBag.Products = new SelectList(products.ToList(), "Id", "Name", "selected", "CategoryId");
            return View();
        }

        [HttpPost]
        public ActionResult AddIngredients([FromBody] IngredientAddVms modal)
        {
            var res = admin.AddIngredients(modal);
            return Json(res);
        }

        public ActionResult Detail()
        {
            var res = admin.GetProducts();
            var cats = admin.GetCategories();
            var branches = admin.GetBranches();
            cats = cats.Where(p => p.Status == Entities.Enum.EntityStatus.Active).ToList();
            branches = branches.Where(p => p.Status == Entities.Enum.EntityStatus.Active).ToList();
            ViewBag.Branches = new SelectList(branches.ToList(), "Id", "Name");
            ViewBag.Categories = new SelectList(cats.ToList(), "Id", "Name", "selected", "BranchId");
            return View(res);
        }

        [HttpPost]
        public async Task<ActionResult> AddProduct(ProductDtos modal)
        {
            var pathToSave = Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot/Images");
            if (modal.Gallery != null)
            {
                modal.ImageUrls = new List<string>();
                foreach (var i in modal.Gallery)
                {
                    if (i.Length > 0)
                    {
                        var fileName2 = ContentDispositionHeaderValue.Parse(i.ContentDisposition).FileName.Trim('"');
                        var fullPath2 = Path.Combine(pathToSave, fileName2);
                        var dbPath2 = "/Images/" + fileName2;
                        using (var stream = new FileStream(fullPath2, FileMode.Create))
                        {
                            await i.CopyToAsync(stream);
                        }
                        modal.ImageUrls.Add(dbPath2);
                    }
                }
            }
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
                    modal.Logo = dbPath;
                    
                    var s = admin.AddProducts(modal);
                    return Json(s);
                }
                else
                {
                    modal.Logo = "";

                    var s = admin.AddProducts(modal);
                    return Json(s);
                }
            }
            else
            {
                modal.Logo = "";
                var s = admin.AddProducts(modal);
                return Json(s);
            }
        }
        public IActionResult BlockEntity(int Id)
        {
            var s = admin.BlockProduct(Id);
            return Json(s);
        }
        public IActionResult UnBlockEntity(int Id)
        {
            var s = admin.UnBlockProduct(Id);
            return Json(s);
        }
        public JsonResult DeleteProduct(int Id)
        {
            var s = admin.DeleteProduct(Id);
            return Json(s);
        }
        public JsonResult DeleteProductImage(int Id)
        {
            var s = admin.DeleteProductImage(Id);
            return Json(s);
        }
    }
}