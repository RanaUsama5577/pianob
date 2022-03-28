using BLL.AdminService;
using DAL;
using Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Stripe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace piano_local.Controllers
{
    [Authorize]
    public class OrderController : Controller
    {
        //Init ASP.NET identity store to handle user sign-in & sign-up 
        private readonly IAdminService admin;
        //Init ASP.NET identity store to handle user sign-in & sign-up 
        private readonly UserManager<ApplicationUser> userManager1;

        public OrderController(IAdminService adminService, UserManager<ApplicationUser> userManager)
        {
            admin = adminService;
            this.userManager1 = userManager;
        }

        public IActionResult Index()
        {
            var s = admin.GetAppInfo();
            ViewBag.DeliveryCharges = s.DeliveryCharges;
            ViewBag.ServiceCharges = s.ServiceCharges;
            var res = admin.MyCarts(userManager1.GetUserId(HttpContext.User));
            ViewBag.TotalPrice = res.Sum(p => p.Price);
            return View(res);
        }

        public IActionResult Cart()
        {
            var s = admin.GetAppInfo();
            ViewBag.DeliveryCharges = s.DeliveryCharges;
            ViewBag.ServiceCharges = s.ServiceCharges;
            var res = admin.MyCarts(userManager1.GetUserId(HttpContext.User));
            return View(res);
        }
        public async Task<JsonResult> RemoveFromCart(int Id)
        {
            var res = admin.RemoveFromCart(Id);
            return Json(res);
        }

        public async Task<JsonResult> UpdateCart([FromBody] UpdateCart model)
        {
            var res = admin.UpdateCart(model, userManager1.GetUserId(HttpContext.User));
            return Json(res);
        }

        public async Task<JsonResult> ShowCarts(int Id)
        {
            var res = admin.GetCart(Id);
            return Json(res);
        }
        
        public IActionResult History()
        {
            var orders = admin.GetOrderHistorydetails(userManager1.GetUserId(HttpContext.User));
            return View(orders);
        }

        public IActionResult MyOrder()
        {
            var orders = admin.GetCurrentOrderdetails(userManager1.GetUserId(HttpContext.User));
            return View(orders);
        }

        public IActionResult HistoryOrderDetails(int Id)
        {
            var order = admin.GetSingleOrderdetails(Id);
            return View(order);
        }

        public IActionResult MyOrderDetails(int Id)
        {
            var order = admin.GetSingleOrderdetails(Id);
            return View(order);
        }

        [HttpPost]
        public async Task<ResponseDto> PlaceOrder([FromForm] PlaceOrderCustomer modal)
        {
            if (!ModelState.IsValid)
            {
                var message = string.Join(" | ", ModelState.Values
                                .SelectMany(v => v.Errors)
                                .Select(e => e.ErrorMessage));

                ResponseDto responseDto = new ResponseDto
                {
                    ShortMessage = message,
                    Result = null,
                    Code = 400,
                };
                return responseDto;
            }

            PayModel payModel = new PayModel
            {
                amount = modal.amount,
                cardNumber = modal.cardNumber,
                Cvc = modal.Cvc,
                month = modal.month,
                year = modal.year,
            };
            var s = await PayWithStripe(payModel);
            if(s == "Success")
            {
                var responseDto2 = admin.SaveOrderCustomer(modal, userManager1.GetUserId(HttpContext.User));
                return responseDto2;
            }
            else
            {
                ResponseDto responseDto2 = new ResponseDto
                {
                    ShortMessage = s,
                    Result = null,
                    Code = 400,
                };
                return responseDto2;
            }
        }

        [HttpPost]
        public static async Task<string> PayWithStripe(PayModel payModel)
        {
            try
            {
                StripeConfiguration.ApiKey = "sk_test_51K8jdhHi7BAOnppNmFaQqxfwhFTifehbz2MHhRuJo5v2iZMWUciO2oIe0vSbtsSPaotLkEfJpbj78ZAIvWz1YNHX00vwG6Ev5V";
                var options = new TokenCreateOptions
                {
                    Card = new TokenCardOptions
                    {
                        Number = payModel.cardNumber,
                        ExpMonth = payModel.month,
                        ExpYear = payModel.year,
                        Cvc = payModel.Cvc
                    },
                };
                var serviceToken = new TokenService();
                Token stripeToken = await serviceToken.CreateAsync(options);

                var chargeOptions = new ChargeCreateOptions
                {
                    Amount = ((long)payModel.amount),
                    Currency = "usd",
                    Description = "Stripe Test Payment",
                    Source = stripeToken.Id
                };

                var chargeService = new ChargeService();
                Charge charge = await chargeService.CreateAsync(chargeOptions);

                if (charge.Paid)
                {
                    return "Success";
                }
                else
                {
                    return "Failed";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
