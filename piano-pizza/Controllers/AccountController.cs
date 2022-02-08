﻿//using BLL.AdminService;
using BLL.AdminService;
using DAL;
using Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Abstractions;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace piano_pizza.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAdminService admin;
        private readonly HttpContext _context;
        private readonly ICompositeViewEngine _viewEngine;
        private readonly ITempDataProvider _tempDataProvider;
        //Init ASP.NET identity store to handle user sign-in & sign-up 
        private readonly UserManager<ApplicationUser> userManager1;
        public AccountController(IAdminService adminService, ITempDataProvider tempDataProvider, ICompositeViewEngine viewEngine, IHttpContextAccessor accessor, UserManager<ApplicationUser> userManager)
        {
            admin = adminService;
            _context = accessor.HttpContext;
            _viewEngine = viewEngine;
            this.userManager1 = userManager;
            _tempDataProvider = tempDataProvider;
        }

        // GET: SuperAdmin/Login
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel LoginUser, string returnUrl)
        {
            var response = await admin.Login(LoginUser);
            if (response.Code == 201)
            {
                if (returnUrl != null)
                {
                    return Redirect(returnUrl);
                }
                else
                {
                    return Redirect("/SuperAdmin/Main/Index");
                }
            }
            else if (response.Code == 202)
            {
                if (returnUrl != null)
                {
                    return Redirect(returnUrl);
                }
                else
                {
                    return Redirect("/receptionist/Main/Index");
                }
            }
            else if (response.Code == 203)
            {
                if (returnUrl != null)
                {
                    return Redirect(returnUrl);
                }
                else
                {
                    return Redirect("/cook/Main/Index");
                }
            }
            else if (response.Code == 204)
            {
                if (returnUrl != null)
                {
                    return Redirect(returnUrl);
                }
                else
                {
                    return Redirect("/packerStaff/Main/Index");
                }
            }
            else if (response.Code == 205)
            {
                if (returnUrl != null)
                {
                    return Redirect(returnUrl);
                }
                else
                {
                    return Redirect("/Driver/Main/Index");
                }
            }
            else if (response.Code == 206)
            {
                if (returnUrl != null)
                {
                    return Redirect(returnUrl);
                }
                else
                {
                    return Redirect("/Home/Index");
                }
            }
            else
            {
                ModelState.AddModelError("", response.ShortMessage);
                return View(LoginUser);
            }
        }

        // GET: SuperAdmin/Signin
        public ActionResult Signin()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<JsonResult> Signin(LoginViewModel LoginUser, string returnUrl)
        {
            var response = await admin.Login(LoginUser);
            if (response.Code != 400 && response.Code != 501)
            {
                if (returnUrl != null)
                {
                    ResponseDto responseDto = new ResponseDto
                    {
                        Code = 200,
                        ShortMessage = returnUrl,
                        Result = null,
                    };
                    return Json(responseDto);
                }
                else
                {
                    ResponseDto responseDto = new ResponseDto
                    {
                        Code = 200,
                        ShortMessage = "/Home/Index",
                        Result = null,
                    };
                    return Json(responseDto);
                }
            }
            else
            {
                ModelState.AddModelError("", response.ShortMessage);
                ResponseDto responseDto = new ResponseDto
                {
                    Code = 400,
                    ShortMessage = response.ShortMessage,
                    Result = LoginUser,
                };
                return Json(responseDto);
            }
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<JsonResult> Signup(LoginViewModel LoginUser, string returnUrl)
        {
            var response = await admin.Register(LoginUser);
            if (response.Code != 400 && response.Code != 501 && response.Code != 402)
            {
                if (returnUrl != null)
                {
                    ResponseDto responseDto = new ResponseDto
                    {
                        Code = 200,
                        ShortMessage = returnUrl,
                        Result = null,
                    };
                    return Json(responseDto);
                }
                else
                {
                    ResponseDto responseDto = new ResponseDto
                    {
                        Code = 200,
                        ShortMessage = "/Home/Index",
                        Result = null,
                    };
                    return Json(responseDto);
                }
            }
            else if (response.Code == 400 || response.Code == 501)
            {
                ModelState.AddModelError("", response.ShortMessage);
                ResponseDto responseDto = new ResponseDto
                {
                    Code = 400,
                    ShortMessage = response.ShortMessage,
                    Result = response.Result,
                };
                return Json(responseDto);
            }
            else
            {
                ModelState.AddModelError("", response.ShortMessage);
                ResponseDto responseDto = new ResponseDto
                {
                    Code = 402,
                    ShortMessage = response.ShortMessage,
                    Result = response.Result,
                };
                return Json(responseDto);
            }
        }

        public async Task<IActionResult> Logout()
        {
            var logout = await admin.Logout();
            if (logout.Code == 200)
            {
                return RedirectToAction("Login", "Account");
            }
            else
            {
                return RedirectToAction("Login", "Account");
            }
        }

        public async Task<IActionResult> LogoutUser()
        {
            var logout = await admin.Logout();
            if (logout.Code == 200)
            {
                return RedirectToAction("Signin", "Account");
            }
            else
            {
                return RedirectToAction("Signin", "Account");
            }
        }

        public ActionResult MyProfile()
        {
            return View();
        }

        public IActionResult ForgotPassword(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            if (TempData["Message"] != null)
            {
                ViewBag.Message = TempData["Message"].ToString();
            }
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ForgotPassword(ForgotPasswordVMS Forgot)
        {
            var response = await admin.ForgotPassword(Forgot);
            if (response.Code == 200)
            {
                ForgotPasswordLink link = new ForgotPasswordLink();
                var callbackUrl = "https://localhost:44393/Account/ResetPassword?Email=" + Forgot.Email + "&Code=" + response.ShortMessage;
                link.Link = callbackUrl;
                var data = await RenderToString("PartialForgotPassword", link);
                var s = SendVerificationLinkEmail(Forgot.Email, data);
                response.ShortMessage = s;
                TempData["Message"] = "s";
                return RedirectToAction("ForgotPassword", "Account");
            }
            else
            {
                ModelState.AddModelError("", response.ShortMessage);
                ViewBag.Message = response.ShortMessage;
                return View(Forgot);
            }
        }

        internal string SendVerificationLinkEmail(string email, string link)
        {
            var fromEmail = new MailAddress("usamabusiness7861@gmail.com", "Password Reset Link");
            var toEmail = new MailAddress(email);
            var password = "1Q_2w3e4r";
            SmtpClient smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromEmail.Address, password),
            };
            var m = new MailMessage(fromEmail, toEmail)
            {

                Subject = "Email Check",
                Body = link,
                IsBodyHtml = true
            };
            try
            {
                smtp.Send(m);
                return "We have sent you a email please check";
            }
            catch (Exception e)
            {
                var dd = "Message not sent retry" + e.Message;
                return dd;
            }
        }

        public async Task<string> RenderToString(string viewName, object model)
        {
            var controller = string.Empty;
            viewName = viewName?.TrimStart(new char[] { '/' });
            Regex rex = new Regex(@"^(\w+)\/(.*)$");
            Match match = rex.Match(viewName);
            if (match.Success)
            {
                controller = match.Groups[1].Value;
                viewName = match.Groups[2].Value;
            }

            var routeData = new RouteData();
            routeData.Values.Add("Api", controller);
            var actionContext = new ActionContext(_context, routeData, new ActionDescriptor());

            var viewResult = _viewEngine.FindView(actionContext, viewName, false);

            if (viewResult.View == null)
            {
                Console.WriteLine($"Searched the following locations: {string.Join(", ", viewResult.SearchedLocations)} for folder \"{controller}\" and view \"{viewName}\"");
                throw new ArgumentNullException($"{viewName} does not match any available view");
            }

            var viewDictionary = new ViewDataDictionary(new EmptyModelMetadataProvider(), new ModelStateDictionary())
            {
                Model = model
            };

            using (var sw = new StringWriter())
            {
                var viewContext = new ViewContext(
                    actionContext,
                    viewResult.View,
                    viewDictionary,
                    new TempDataDictionary(_context, _tempDataProvider),
                    sw,
                    new HtmlHelperOptions()
                );
                viewContext.RouteData = _context.GetRouteData();

                await viewResult.View.RenderAsync(viewContext);
                return sw.ToString();
            }
        }

        public IActionResult ResetPassword(string Email, string Code)
        {
            ViewBag.Email = Email;
            ViewBag.Code = Code;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ResetPassword(ResetPasswordVMS modal)
        {
            var s = await admin.ResetPassword(modal);
            if (s.Code == 200)
            {
                return Redirect("/Account/SuccessResetPassword");
            }
            else
            {
                List<string> vs = (List<string>)s.Result;
                foreach (var q in vs)
                {
                    ModelState.AddModelError("", q);
                    ViewBag.Message = q;
                }
                ViewBag.Email = modal.Email;
                ViewBag.Code = modal.Code;
                return View(modal);
            }
        }

        public IActionResult SuccessResetPassword()
        {
            return View();
        }

        public ActionResult AccessDenied()
        {
            return View();
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
