#pragma checksum "D:\repos\piano-pizza\piano-pizza\Views\Order\Cart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "58afe6dc7375fa8503b770b16463aa0224e56fcf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Cart), @"mvc.1.0.view", @"/Views/Order/Cart.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\repos\piano-pizza\piano-pizza\Views\_ViewImports.cshtml"
using piano_pizza;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\repos\piano-pizza\piano-pizza\Views\_ViewImports.cshtml"
using piano_pizza.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58afe6dc7375fa8503b770b16463aa0224e56fcf", @"/Views/Order/Cart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4fd62fd606701e7948749f622ddc31478ced86fe", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_Cart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Entities.MyCarts>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/orderassets/assets/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/orderassets/assets/css/style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/empty cart.gif"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\repos\piano-pizza\piano-pizza\Views\Order\Cart.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "58afe6dc7375fa8503b770b16463aa0224e56fcf4657", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<!-- Custom Stylesheet -->\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "58afe6dc7375fa8503b770b16463aa0224e56fcf5802", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<link rel=""stylesheet"" href=""https://pro.fontawesome.com/releases/v5.10.0/css/all.css"" integrity=""sha384-AYmEC3Yw5cVb3ZcuHtOA93w35dYTsvhLPVnYs9eStHfGJvOvKxVfELGroGkvsg+p"" crossorigin=""anonymous"" />

<div id=""header-bottom-wrap"" class=""is-clearfix"">
    <div id=""header-bottom"" class=""site-header-bottom"">
        <div id=""header-bottom-inner"" class=""site-header-bottom-inner "">
            <section class=""hero slider is-clearfix "">
                <div style=""background-image: url('/app-images/home.jpg');background-repeat: no-repeat;background-size: cover;height: 200px;position: relative;background-position: center center;"">
                </div>
                <div style=""position: absolute;width: 100%;height: 100%;background-color: #000000;opacity: 0.5;transition: background 0.3s, border-radius 0.3s, opacity 0.3s;"">
                </div>
                <div style=""text-align: center;position: absolute;width: 100%;"">
                    <h2 style=""color: #fff;font-size: 36px;margin-top: 138px;f");
            WriteLiteral("ont-family: \'LIBRE FRANKLIN\', sans-serif;\"");
            BeginWriteAttribute("class", " class=\"", 1326, "\"", 1334, 0);
            EndWriteAttribute();
            WriteLiteral(@">Cart </h2>
                </div>
            </section>
            <!-- .slider -->
        </div>
        <!-- #header-bottom-inner -->
    </div>
    <!-- #header-bottom -->
</div>

<div id=""content-main-wrap"" class=""is-clearfix"">
    <div id=""content-area"" class=""site-content-area"">
        <div id=""content-area-inner"" class=""site-content-area-inner"">
            <div class=""container py-5"">
                <div class=""row"">
");
#nullable restore
#line 34 "D:\repos\piano-pizza\piano-pizza\Views\Order\Cart.cshtml"
                     if (Model.Count() == 0)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-md-12\" style=\"text-align: center;\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "58afe6dc7375fa8503b770b16463aa0224e56fcf9001", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n");
#nullable restore
#line 39 "D:\repos\piano-pizza\piano-pizza\Views\Order\Cart.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-lg-8 col-md-12 col-12\">\r\n");
#nullable restore
#line 43 "D:\repos\piano-pizza\piano-pizza\Views\Order\Cart.cshtml"
                              
                                var Price = 0.0m;
                                var TotalPrice = 0.0m;
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "D:\repos\piano-pizza\piano-pizza\Views\Order\Cart.cshtml"
                             foreach (var i in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"row rounded p-3 shadow-sm mt-2\">\r\n                                    <div class=\"col-lg-5 col-md-12 col-12 d-flex justify-content-center\">\r\n                                        <img");
            BeginWriteAttribute("src", " src=\"", 2645, "\"", 2658, 1);
#nullable restore
#line 51 "D:\repos\piano-pizza\piano-pizza\Views\Order\Cart.cshtml"
WriteAttributeValue("", 2651, i.Logo, 2651, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" style=""max-width:200px;max-height:200px"" />
                                    </div>
                                    <div class=""col-lg-7 col-md-12 col-12 d-flex flex-row"">
                                        <div>
                                            <p class=""mb-0"">");
#nullable restore
#line 55 "D:\repos\piano-pizza\piano-pizza\Views\Order\Cart.cshtml"
                                                       Write(i.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                            <p>");
#nullable restore
#line 56 "D:\repos\piano-pizza\piano-pizza\Views\Order\Cart.cshtml"
                                          Write(i.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n                                            <div class=\"flex-row d-flex mb-2\">\r\n                                                <span>");
#nullable restore
#line 59 "D:\repos\piano-pizza\piano-pizza\Views\Order\Cart.cshtml"
                                                 Write(i.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Qty</span>\r\n                                            </div>\r\n                                            <button data-cart=\"");
#nullable restore
#line 61 "D:\repos\piano-pizza\piano-pizza\Views\Order\Cart.cshtml"
                                                          Write(i.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-quantity=\"");
#nullable restore
#line 61 "D:\repos\piano-pizza\piano-pizza\Views\Order\Cart.cshtml"
                                                                                Write(i.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" onclick=\"EditCart(this)\" class=\"main-section-btn rounded mt-1 edit\">Edit Cart</button>\r\n                                            <button data-cart=\"");
#nullable restore
#line 62 "D:\repos\piano-pizza\piano-pizza\Views\Order\Cart.cshtml"
                                                          Write(i.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-quantity=\"");
#nullable restore
#line 62 "D:\repos\piano-pizza\piano-pizza\Views\Order\Cart.cshtml"
                                                                                Write(i.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""" onclick=""UpdateCart(this)"" class=""main-section-btn rounded mt-1 SpinnerBtn update"">
                                                <span class=""spinner-grow spinner-grow-sm"" role=""status"" aria-hidden=""true""></span>
                                                <span class=""spinner-loading ms-25 align-middle"">Loading...</span>
                                                <span class=""SpinnerText"">Update</span>
                                            </button>
                                            <button data-cart=""");
#nullable restore
#line 67 "D:\repos\piano-pizza\piano-pizza\Views\Order\Cart.cshtml"
                                                          Write(i.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-quantity=\"");
#nullable restore
#line 67 "D:\repos\piano-pizza\piano-pizza\Views\Order\Cart.cshtml"
                                                                                Write(i.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" onclick=\"Cancel(this)\" class=\"main-section-btn rounded mt-1 update\">Cancel</button>\r\n                                            <div id=\"IngredientCard\">\r\n");
#nullable restore
#line 69 "D:\repos\piano-pizza\piano-pizza\Views\Order\Cart.cshtml"
                                                 foreach (var a in i.IngredientLists.Where(p => p.AddedInCart == true))
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <div class=\"flex-row mt-3\">\r\n                                                        <small class=\"text-muted\"><b><i class=\"fas fa-circle font-8 mr-2\"></i> ");
#nullable restore
#line 72 "D:\repos\piano-pizza\piano-pizza\Views\Order\Cart.cshtml"
                                                                                                                          Write(a.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(": </b></small> <small class=\"ml-2\">");
#nullable restore
#line 72 "D:\repos\piano-pizza\piano-pizza\Views\Order\Cart.cshtml"
                                                                                                                                                                    Write(a.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Qty</small>\r\n                                                    </div>\r\n");
#nullable restore
#line 74 "D:\repos\piano-pizza\piano-pizza\Views\Order\Cart.cshtml"
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                            </div>
                                            <div style=""display:none;"" class=""mt-4"" id=""EditCard"">
                                                <div class=""item-quantity"" style="" margin-top: 20px;"">
                                                    <div class=""quantity-title"">");
#nullable restore
#line 78 "D:\repos\piano-pizza\piano-pizza\Views\Order\Cart.cshtml"
                                                                           Write(i.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Qty:</div>\r\n                                                    <div class=\"quantity-counter-wrapper\"");
            BeginWriteAttribute("style", " style=\"", 5260, "\"", 5268, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                                        <div class=""input-group bootstrap-touchspin"" style=""display: flex;position: relative;"">
                                                            <span class=""input-group-btn bootstrap-touchspin-injected""");
            BeginWriteAttribute("style", " style=\"", 5535, "\"", 5543, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                                                <button class=""btn btn-primary touch-down bootstrap-touchspin-down disabled-max-min rounded-circle"" type=""button"">-</button>
                                                            </span>
                                                            <input");
            BeginWriteAttribute("id", " id=\"", 5872, "\"", 5891, 2);
            WriteAttributeValue("", 5877, "Quantity-", 5877, 9, true);
#nullable restore
#line 84 "D:\repos\piano-pizza\piano-pizza\Views\Order\Cart.cshtml"
WriteAttributeValue("", 5886, i.Id, 5886, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"text\" class=\"quantity-counter form-control\"");
            BeginWriteAttribute("readonly", " readonly=\"", 5942, "\"", 5953, 0);
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 5954, "\"", 5973, 1);
#nullable restore
#line 84 "D:\repos\piano-pizza\piano-pizza\Views\Order\Cart.cshtml"
WriteAttributeValue("", 5962, i.Quantity, 5962, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("style", " style=\"", 5974, "\"", 5982, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                            <span class=\"input-group-btn bootstrap-touchspin-injected\"");
            BeginWriteAttribute("style", " style=\"", 6104, "\"", 6112, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                                                <button class=""btn btn-primary touch-up bootstrap-touchspin-up rounded-circle"" type=""button"">+</button>
                                                            </span>
                                                        </div>
                                                    </div>
                                                </div>
                                                <ul class=""list no-margin mt-5"" id=""EditUl"" style=""padding:0px 100px 0px 0px;"">
");
#nullable restore
#line 92 "D:\repos\piano-pizza\piano-pizza\Views\Order\Cart.cshtml"
                                                     foreach (var a in i.IngredientLists)
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                        <li>
                                                            <div class=""row"">
                                                                <div class=""col-sm-5 col-12"">
                                                                    <div class=""ps-checkbox"">
");
#nullable restore
#line 98 "D:\repos\piano-pizza\piano-pizza\Views\Order\Cart.cshtml"
                                                                         if (a.AddedInCart == true)
                                                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                            <input class=\"form-control\" data-cart=\"");
#nullable restore
#line 100 "D:\repos\piano-pizza\piano-pizza\Views\Order\Cart.cshtml"
                                                                                                              Write(i.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-ingredient=\"");
#nullable restore
#line 100 "D:\repos\piano-pizza\piano-pizza\Views\Order\Cart.cshtml"
                                                                                                                                      Write(a.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-price=\"");
#nullable restore
#line 100 "D:\repos\piano-pizza\piano-pizza\Views\Order\Cart.cshtml"
                                                                                                                                                         Write(a.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" checked type=\"checkbox\"");
            BeginWriteAttribute("id", " id=\"", 7507, "\"", 7519, 2);
            WriteAttributeValue("", 7512, "c-", 7512, 2, true);
#nullable restore
#line 100 "D:\repos\piano-pizza\piano-pizza\Views\Order\Cart.cshtml"
WriteAttributeValue("", 7514, a.Id, 7514, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 101 "D:\repos\piano-pizza\piano-pizza\Views\Order\Cart.cshtml"
                                                                        }
                                                                        else
                                                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                            <input class=\"form-control\" data-ingredient=\"");
#nullable restore
#line 104 "D:\repos\piano-pizza\piano-pizza\Views\Order\Cart.cshtml"
                                                                                                                    Write(a.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-price=\"");
#nullable restore
#line 104 "D:\repos\piano-pizza\piano-pizza\Views\Order\Cart.cshtml"
                                                                                                                                       Write(a.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" type=\"checkbox\"");
            BeginWriteAttribute("id", " id=\"", 7916, "\"", 7928, 2);
            WriteAttributeValue("", 7921, "c-", 7921, 2, true);
#nullable restore
#line 104 "D:\repos\piano-pizza\piano-pizza\Views\Order\Cart.cshtml"
WriteAttributeValue("", 7923, a.Id, 7923, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 105 "D:\repos\piano-pizza\piano-pizza\Views\Order\Cart.cshtml"
                                                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                        <label");
            BeginWriteAttribute("for", " for=\"", 8085, "\"", 8098, 2);
            WriteAttributeValue("", 8091, "c-", 8091, 2, true);
#nullable restore
#line 106 "D:\repos\piano-pizza\piano-pizza\Views\Order\Cart.cshtml"
WriteAttributeValue("", 8093, a.Id, 8093, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 106 "D:\repos\piano-pizza\piano-pizza\Views\Order\Cart.cshtml"
                                                                                        Write(a.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</label>
                                                                    </div>
                                                                </div>
                                                                <div class=""col-sm-7 col-12 d-flex flex-row mt-n3"">
                                                                    <div class=""input-group bootstrap-touchspin m-0"" style=""display: flex;position: relative;margin:auto"">
                                                                        <span class=""input-group-btn bootstrap-touchspin-injected""");
            BeginWriteAttribute("style", " style=\"", 8684, "\"", 8692, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                                                            <button onclick=""IngredientDownFunction(this)"" class=""btn btn-primary bootstrap-touchspin-down disabled-max-min rounded-circle"" type=""button"">-</button>
                                                                        </span>
                                                                        <input");
            BeginWriteAttribute("id", " id=\"", 9085, "\"", 9099, 2);
            WriteAttributeValue("", 9090, "val-", 9090, 4, true);
#nullable restore
#line 114 "D:\repos\piano-pizza\piano-pizza\Views\Order\Cart.cshtml"
WriteAttributeValue("", 9094, a.Id, 9094, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"text\" class=\"quantity-counter form-control\"");
            BeginWriteAttribute("readonly", " readonly=\"", 9150, "\"", 9161, 0);
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 9162, "\"", 9181, 1);
#nullable restore
#line 114 "D:\repos\piano-pizza\piano-pizza\Views\Order\Cart.cshtml"
WriteAttributeValue("", 9170, a.Quantity, 9170, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("style", " style=\"", 9182, "\"", 9190, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                                        <span class=\"input-group-btn bootstrap-touchspin-injected\"");
            BeginWriteAttribute("style", " style=\"", 9324, "\"", 9332, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                                                            <button onclick=""IngredientUpFunction(this)"" class=""btn btn-primary bootstrap-touchspin-up rounded-circle"" type=""button"">+</button>
                                                                        </span>
                                                                    </div>
                                                                </div>
                                                            </div>
                                                        </li>
");
#nullable restore
#line 122 "D:\repos\piano-pizza\piano-pizza\Views\Order\Cart.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                </ul>
                                            </div>
                                        </div>
                                        <div class=""ml-auto"">
                                            <span>$");
#nullable restore
#line 127 "D:\repos\piano-pizza\piano-pizza\Views\Order\Cart.cshtml"
                                              Write(i.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                            <button");
            BeginWriteAttribute("onclick", " onclick=\"", 10297, "\"", 10332, 3);
            WriteAttributeValue("", 10307, "RemoveItemFromCart(", 10307, 19, true);
#nullable restore
#line 128 "D:\repos\piano-pizza\piano-pizza\Views\Order\Cart.cshtml"
WriteAttributeValue("", 10326, i.Id, 10326, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 10331, ")", 10331, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"ml-3\"><i class=\"fas fa-times\"></i></button>\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n");
#nullable restore
#line 132 "D:\repos\piano-pizza\piano-pizza\Views\Order\Cart.cshtml"
                                {
                                    Price += @i.Price;
                                }
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n");
#nullable restore
#line 137 "D:\repos\piano-pizza\piano-pizza\Views\Order\Cart.cshtml"
                        { 
                            TotalPrice = Price + ViewBag.DeliveryCharges + ViewBag.ServiceCharges;
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <div class=""col-lg-4 col-md-12 col-12"">
                            <div class=""p-3 shadow-sm"">
                                <h2 class=""mb-2"">Summary</h2>

                                <div class=""d-flex flex-row"">
                                    <p><b>Subtotal: </b></p>
                                    <span class=""ml-auto"">$");
#nullable restore
#line 146 "D:\repos\piano-pizza\piano-pizza\Views\Order\Cart.cshtml"
                                                      Write(Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                </div>

                                <div class=""d-flex flex-row"">
                                    <p><b>Delivery Charges: </b></p>
                                    <span id=""deliveryCharge"" class=""ml-auto"">$");
#nullable restore
#line 151 "D:\repos\piano-pizza\piano-pizza\Views\Order\Cart.cshtml"
                                                                          Write(ViewBag.DeliveryCharges);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                </div>

                                <div class=""d-flex flex-row"">
                                    <p><b>Service Charges: </b></p>

                                    <div class=""ml-auto flex-column d-flex"">
                                        <span id=""serviceCharge"">$");
#nullable restore
#line 158 "D:\repos\piano-pizza\piano-pizza\Views\Order\Cart.cshtml"
                                                             Write(ViewBag.ServiceCharges);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                    </div>
                                </div>

                                <hr />
                                <div class=""d-flex flex-row"">
                                    <p><b>Total: </b></p>
                                    <span class=""ml-auto"">$");
#nullable restore
#line 165 "D:\repos\piano-pizza\piano-pizza\Views\Order\Cart.cshtml"
                                                      Write(TotalPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                </div>
                                <hr />
                                <button onclick=""window.location.href='/Order/Index'"" class=""main-section-btn rounded w-100 p-2"">Checkout</button>
                            </div>
                        </div>
");
#nullable restore
#line 171 "D:\repos\piano-pizza\piano-pizza\Views\Order\Cart.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
            </div>

        </div>
    </div>
</div>

<script>
    $(function () {
        $('.touch-up').on('click', function () {
            var s = parseInt($(this).parent().siblings('input').val()) + 1;
            $(this).parent().siblings('input').val(s > 50 ? 50 : s);
        })
        $('.touch-down').on('click', function () {
            var s = parseInt($(this).parent().siblings('input').val()) - 1;
            $(this).parent().siblings('input').val(s <= 0 ? 1 : s);
        })
        $('.update').hide();
    })
    function IngredientUpFunction(element) {
        var input = $(element).parent().siblings('.quantity-counter');
        var itemCount = $(element).parent().siblings('.quantity-counter').val();
        var itemCount = parseInt(itemCount);
        itemCount += 1;
        if (itemCount <= 99) {
            $(input).val(itemCount);
        }
        $(element).closest('.col-sm-7').prev('.col-sm-5').find('input').prop('checked', true);
    ");
            WriteLiteral(@"}
    function IngredientDownFunction(element) {
        var input = $(element).parent().siblings('.quantity-counter');
        var itemCount = $(element).parent().siblings('.quantity-counter').val();
        var itemCount = parseInt(itemCount);
        itemCount -= 1;
        if (itemCount >= 0) {
            $(input).val(itemCount);
        }
        if (itemCount == 0) {
            $(element).closest('.col-sm-7').prev('.col-sm-5').find('input').prop('checked', false);
        }
    }
</script>

<script>
    function RemoveItemFromCart(Id) {
        $.ajax({
            type: 'Get',
            url: '/Order/RemoveFromCart?Id=' + Id,
            async: true,
            contentType: 'application/json; charset=utf-8',
            dataType: 'json',
            success: function (data) {
                console.log(""Api"", data);
                if (data.code == 200) {
                    MixinSweet(""Product removed from cart!"", """", ""success"", ""2000"");
                    setTimeout(f");
            WriteLiteral(@"unction () {
                        location.reload();
                    }, 2000);
                }
                else {
                    sweetMessage(""Warning!"", data.shortMessage, ""error"");
                }
            },
            error: function (error) {
                return error;
            },
        });
    }
    function EditCart(element) {
        $(element).siblings('#IngredientCard').hide();
        $(element).hide();
        $(element).siblings('.update').show();
        $(element).siblings('#EditCard').show();
    }
    function Cancel(element) {
        $(element).siblings('#IngredientCard').show();
        $(element).hide();
        $(element).siblings('.edit').show();
        $(element).siblings('.update').hide();
        $(element).siblings('#EditCard').hide();
    }
    function UpdateCart(element) {
        var pushs = [];
        var quantity = 0;
        $(element).addClass('SpinnerProgressBtn').removeClass('SpinnerBtn');
        var cartId =");
            WriteLiteral(@" $(element).attr('data-cart');
        quantity = $('#Quantity-' + cartId).val();
        $(element).siblings('#EditCard').find('ul').find('input[type=""checkbox""]:checked').each(function (index, obj) {
            var ingredient = $(obj).attr('data-ingredient');
            var quantity2 = $(obj).closest('.col-sm-5').siblings('.col-sm-7').find('#val-' + ingredient).val();
            var data = {
                Id: parseInt(ingredient),
                quantity: parseInt(quantity2),
            };
            pushs.push(data);
        })
        console.log(pushs);
        var cart_data = JSON.stringify({
            'allIngredients': pushs,
            'quantity': quantity,
            'cartId': cartId,
        });

        $.ajax({
            type: 'POST',
            url: '/Order/UpdateCart',
            data: cart_data,
            async: true,
            contentType: 'application/json; charset=utf-8',
            dataType: 'json',
            success: function (data) {
      ");
            WriteLiteral(@"          console.log(""Api"", data);
                if (data.code == 200) {
                    $(element).addClass('SpinnerBtn').removeClass('SpinnerProgressBtn');
                    MixinSweet(""Cart updated!"", """", ""success"", ""2000"");
                    setTimeout(function () {
                        location.reload();
                    }, 2000);
                }
                else {
                    $(element).removeClass('btn-progress');
                    sweetMessage(""Warning!"", data.shortMessage, ""error"");
                }
            },
            error: function (error) {
                $(element).removeClass('btn-progress');
                return error;
            },
        });
    }
</script>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Entities.MyCarts>> Html { get; private set; }
    }
}
#pragma warning restore 1591
