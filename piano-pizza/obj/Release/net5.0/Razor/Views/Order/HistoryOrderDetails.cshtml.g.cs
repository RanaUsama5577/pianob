#pragma checksum "D:\repos\piano-pizza\piano-pizza\Views\Order\HistoryOrderDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2752e331f9e4b086f4f42ce26f79326665d96ef1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_HistoryOrderDetails), @"mvc.1.0.view", @"/Views/Order/HistoryOrderDetails.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2752e331f9e4b086f4f42ce26f79326665d96ef1", @"/Views/Order/HistoryOrderDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4fd62fd606701e7948749f622ddc31478ced86fe", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_HistoryOrderDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Entities.GetSingleOrderdetails>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/orderassets/assets/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/orderassets/assets/css/style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/orderassets/assets/css/responsive.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/images/menu/banner.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid full-width"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("banner-adv"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\repos\piano-pizza\piano-pizza\Views\Order\HistoryOrderDetails.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<style>\r\n    .product_width {\r\n        max-width: 80px;\r\n        max-height: 80px;\r\n    }\r\n    .ft-15 {\r\n        font-size: 1.5rem !important;\r\n    }\r\n</style>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2752e331f9e4b086f4f42ce26f79326665d96ef16059", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2752e331f9e4b086f4f42ce26f79326665d96ef17204", async() => {
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
            WriteLiteral("\r\n<!-- Custom Responsive -->\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2752e331f9e4b086f4f42ce26f79326665d96ef18349", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<div id=""header-bottom-wrap"" class=""is-clearfix"">
    <div id=""header-bottom"" class=""site-header-bottom"">
        <div id=""header-bottom-inner"" class=""site-header-bottom-inner "">
            <section class=""hero slider is-clearfix "">
                <div style=""background-image: url('/app-images/home.jpg');background-repeat: no-repeat;background-size: cover;height: 200px;position: relative;background-position: center center;"">
                </div>
                <div style=""position: absolute;width: 100%;height: 100%;background-color: #000000;opacity: 0.5;transition: background 0.3s, border-radius 0.3s, opacity 0.3s;"">
                </div>
                <div style=""text-align: center;position: absolute;width: 100%;"">
                    <h2 style=""color: #fff;font-size: 36px;margin-top: 138px;font-family: 'LIBRE FRANKLIN', sans-serif;""");
            BeginWriteAttribute("class", " class=\"", 1390, "\"", 1398, 0);
            EndWriteAttribute();
            WriteLiteral(@">Order Details </h2>
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
                    <div class=""col-md-12"">
                        <!-- recipt -->
                        <div class=""recipt-sec padding-20"">
                            <div class=""u-line mb-xl-20"">
                                <div class=""row"">
                                    <div class=""col-lg-4"">
                                        <div class=""recipt-name full-width padding-tb-10 pt-0"">
                                            <h5 class=""text-light-black fw-600"">Deliverd to:</h5>
                                            <span clas");
            WriteLiteral("s=\"text-light-white \">");
#nullable restore
#line 51 "D:\repos\piano-pizza\piano-pizza\Views\Order\HistoryOrderDetails.cshtml"
                                                                       Write(Model.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                        </div>
                                    </div>
                                    <div class=""col-lg-4"">
                                        <div class=""recipt-name full-width padding-tb-10 pt-0"">
                                            <h5 class=""text-light-black fw-600"">Delivery instructions</h5>
                                            <p class=""text-light-white "">");
#nullable restore
#line 57 "D:\repos\piano-pizza\piano-pizza\Views\Order\HistoryOrderDetails.cshtml"
                                                                    Write(Model.Note);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                        </div>
                                    </div>
                                    <div class=""col-lg-4"">
                                        <div class=""ad-banner padding-tb-10 h-100"">
                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2752e331f9e4b086f4f42ce26f79326665d96ef112892", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class=""u-line mb-xl-20"">
                                <div class=""row"">
                                    <div class=""col-lg-12"">
                                        <h5 class=""text-light-black fw-600 title ft-15"">Your Order</h5>
                                        <p class=""title font-19 text-light-white ft-15"">
                                            ");
#nullable restore
#line 72 "D:\repos\piano-pizza\piano-pizza\Views\Order\HistoryOrderDetails.cshtml"
                                       Write(Model.CreatedAt);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span class=\"text-light-black\">Order #");
#nullable restore
#line 72 "D:\repos\piano-pizza\piano-pizza\Views\Order\HistoryOrderDetails.cshtml"
                                                                                              Write(Model.OrderId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                        </p>\r\n                                    </div>\r\n                                    <div class=\"col-lg-12 mt-3\">\r\n");
#nullable restore
#line 76 "D:\repos\piano-pizza\piano-pizza\Views\Order\HistoryOrderDetails.cshtml"
                                         foreach (var i in Model.AllProducts)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                            <div class=""checkout-product"">
                                                <div class=""img-name-value"">
                                                    <div class=""product-img"">
                                                        <a href=""#"">
                                                            <img");
            BeginWriteAttribute("src", " src=\"", 4588, "\"", 4609, 1);
#nullable restore
#line 82 "D:\repos\piano-pizza\piano-pizza\Views\Order\HistoryOrderDetails.cshtml"
WriteAttributeValue("", 4594, i.productImage, 4594, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""product_width"" alt=""#"">
                                                        </a>
                                                    </div>
                                                    <div class=""product-name ml-2"">
                                                        <span><a href=""#"" class=""text-light-white""><span class=""text-light-white"">");
#nullable restore
#line 86 "D:\repos\piano-pizza\piano-pizza\Views\Order\HistoryOrderDetails.cshtml"
                                                                                                                             Write(i.quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> ");
#nullable restore
#line 86 "D:\repos\piano-pizza\piano-pizza\Views\Order\HistoryOrderDetails.cshtml"
                                                                                                                                                Write(i.productName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></span>\r\n");
#nullable restore
#line 87 "D:\repos\piano-pizza\piano-pizza\Views\Order\HistoryOrderDetails.cshtml"
                                                         foreach (var a in i.ingredientList)
                                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                            <div class=\"flex-row\">\r\n                                                                <small class=\"text-muted\"><b><i class=\"fas fa-circle font-8 mr-2\"></i> ");
#nullable restore
#line 90 "D:\repos\piano-pizza\piano-pizza\Views\Order\HistoryOrderDetails.cshtml"
                                                                                                                                  Write(a.ingredientName);

#line default
#line hidden
#nullable disable
            WriteLiteral(": </b></small> <small class=\"ml-2\">");
#nullable restore
#line 90 "D:\repos\piano-pizza\piano-pizza\Views\Order\HistoryOrderDetails.cshtml"
                                                                                                                                                                                      Write(a.quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Qty</small>\r\n                                                            </div>\r\n");
#nullable restore
#line 92 "D:\repos\piano-pizza\piano-pizza\Views\Order\HistoryOrderDetails.cshtml"
                                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                    </div>
                                                </div>
                                                <div class=""price"">
                                                    <span class=""text-light-white"">$");
#nullable restore
#line 96 "D:\repos\piano-pizza\piano-pizza\Views\Order\HistoryOrderDetails.cshtml"
                                                                               Write(i.total_price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                                </div>\r\n                                            </div>\r\n");
#nullable restore
#line 99 "D:\repos\piano-pizza\piano-pizza\Views\Order\HistoryOrderDetails.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    </div>
                                </div>
                            </div>
                            <div class=""row"">
                                <div class=""col-lg-7"">
                                    <div class=""payment-method mb-md-40"">
                                        <h5 class=""text-light-black fw-600"">Payment Method</h5>
                                        <div class=""method-type"">
                                            <i class=""far fa-credit-card text-dark-white""></i>
                                            <span class=""text-light-white"">Credit Card</span>
                                        </div>
                                    </div>
                                </div>
                                <div class=""col-lg-5"">
                                    <div class=""price-table u-line"">
                                        <div class=""item"">
                                            <span cla");
            WriteLiteral("ss=\"text-light-white\">Item subtotal:</span>\r\n                                            <span class=\"text-light-white\">$");
#nullable restore
#line 117 "D:\repos\piano-pizza\piano-pizza\Views\Order\HistoryOrderDetails.cshtml"
                                                                       Write(Model.SubTotal);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                        </div>
                                        <div class=""item"">
                                            <span class=""text-light-white"">Delivery fee:</span>
                                            <span class=""text-light-white"">$");
#nullable restore
#line 121 "D:\repos\piano-pizza\piano-pizza\Views\Order\HistoryOrderDetails.cshtml"
                                                                       Write(Model.DeliveryCharges);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                        </div>
                                        <div class=""item"">
                                            <span class=""text-light-white"">Service Charges:</span>
                                            <span class=""text-light-white"">$");
#nullable restore
#line 125 "D:\repos\piano-pizza\piano-pizza\Views\Order\HistoryOrderDetails.cshtml"
                                                                       Write(Model.ServiceCharges);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                        </div>
                                    </div>
                                    <div class=""total-price padding-tb-10"">
                                        <h5 class=""title text-light-black fw-700 ft-15"">Total: <span>$");
#nullable restore
#line 129 "D:\repos\piano-pizza\piano-pizza\Views\Order\HistoryOrderDetails.cshtml"
                                                                                                 Write(Model.TotalPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span></h5>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>

        </div>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Entities.GetSingleOrderdetails> Html { get; private set; }
    }
}
#pragma warning restore 1591
