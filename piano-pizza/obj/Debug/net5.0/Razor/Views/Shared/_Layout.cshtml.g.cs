#pragma checksum "D:\repos\piano-pizza\piano-pizza\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b5d4975cdd8b6737c6ed3ae677e5be6534a73d49"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
#nullable restore
#line 2 "D:\repos\piano-pizza\piano-pizza\Views\Shared\_Layout.cshtml"
using Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5d4975cdd8b6737c6ed3ae677e5be6534a73d49", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4fd62fd606701e7948749f622ddc31478ced86fe", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/toast/toastr.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/toast/toastr-custom.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/sweet alert/sweetalert2.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin-assets/css/custom.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/number_input/jquery.bootstrap-touchspin.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/number_input/form-number-input.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/toast/toastr.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/sweet alert/sweetalert2.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/custom.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString(@"active-pageloader entertainment restaurant header-sticky hide-on-scroll header-logo-left footer-widgets footer-background dark-color widget-7 header-transparent submenu-show-arrow-right menu-is-uppercase submenu-is-capitalized logo-text-is-capitalized page-header-logo-left"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\" class=\"no-js no-svg\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b5d4975cdd8b6737c6ed3ae677e5be6534a73d497844", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <meta name=""author"" content='Piano Pizza'>
    <meta name=""description"" content=""Pizza"">
    <meta name=""keywords"" content=""Pizza"">
    <title>Piano Pizza</title>
    <link rel=""stylesheet"" href=""/assets/css/vendor.mind652.css?v=1557174151243"">
    <link rel=""stylesheet"" href=""/assets/css/styles.mind652.css?v=1557174151243"">
    <link rel=""stylesheet"" href=""/assets/css/customd652.css?v=1557174151243"">
    <link rel=""stylesheet"" href=""/custom/custom.css"">
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b5d4975cdd8b6737c6ed3ae677e5be6534a73d498773", async() => {
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
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b5d4975cdd8b6737c6ed3ae677e5be6534a73d499951", async() => {
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
    <link href=""https://fonts.googleapis.com/css?family=Kalam:700|Oswald:400,500,700|Open+Sans:300,400&amp;v=1557174088386"" rel=""stylesheet"">
    <link rel=""apple-touch-icon"" sizes=""57x57"" href=""/app-images/cropped-b-black-180x180.png"">
    <meta name=""apple-mobile-web-app-capable"" content=""yes"">
    <meta name=""apple-mobile-web-app-status-bar-style"" content=""black-translucent"">
    <meta name=""apple-mobile-web-app-title"" content=""PianoPizza"">
    <link rel=""shortcut icon"" href=""/app-images/cropped-b-black-180x180.png"">
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b5d4975cdd8b6737c6ed3ae677e5be6534a73d4911686", async() => {
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
                WriteLiteral("\r\n    <script src=\"/assets/js/vendor.mind652.js?v=1557174151243\"></script>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b5d4975cdd8b6737c6ed3ae677e5be6534a73d4912943", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b5d4975cdd8b6737c6ed3ae677e5be6534a73d4914830", async() => {
                WriteLiteral(@"
    <!-- Loader -->
    <div class=""customloader""></div>
    <!-- Loader End -->
    <div id=""site-wrap"" class=""site"">
        <div id=""header-wrap"" class=""is-clearfix"">
            <header id=""header"" class=""site-header"">
                <div id=""header-inner"" class=""site-header-inner container"">
                    <div class=""level"">
                        <div class=""level-left"">
                            <div id=""header-logo"" class=""site-logo "">
                                <div id=""logo-inner"" class=""site-logo-inner"">
                                    <a");
                BeginWriteAttribute("href", " href=\"", 2542, "\"", 2576, 1);
#nullable restore
#line 42 "D:\repos\piano-pizza\piano-pizza\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2549, Url.Action("Index","Home"), 2549, 27, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" class=""defaultImage"">
                                        <img alt=""Piano"" src=""/app-images/Piano-b-white.png"">
                                    </a>
                                    <a class=""stickyImage"">
                                        <img alt=""Piano"" src=""/app-images/Piano-b-black.png"">
                                    </a>
                                </div>
                                <!-- #logo-inner -->
                            </div>
                            <!-- #header-logo -->
                        </div>
                        <!-- .level-left -->
                        <div class=""level-right"">
                            <div class=""nav-wrap"">
                                <nav class=""main-navigation right"">
                                    <ul class=""menu"" id=""ul_menu"">
");
#nullable restore
#line 58 "D:\repos\piano-pizza\piano-pizza\Views\Shared\_Layout.cshtml"
                                         if (!User.Identity.IsAuthenticated)
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            <li class=\"active\">\r\n                                                <a");
                BeginWriteAttribute("href", " href=\"", 3671, "\"", 3709, 1);
#nullable restore
#line 61 "D:\repos\piano-pizza\piano-pizza\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 3678, Url.Action("Signin","Account"), 3678, 31, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 61 "D:\repos\piano-pizza\piano-pizza\Views\Shared\_Layout.cshtml"
                                                                                     Write(local.GetLocalizedHtmlString("Login/Signup"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n                                            </li>\r\n");
#nullable restore
#line 63 "D:\repos\piano-pizza\piano-pizza\Views\Shared\_Layout.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            <li class=\"active\">\r\n                                                <a");
                BeginWriteAttribute("href", " href=\"", 4060, "\"", 4094, 1);
#nullable restore
#line 67 "D:\repos\piano-pizza\piano-pizza\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 4067, Url.Action("Cart","Order"), 4067, 27, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                                    <span");
                BeginWriteAttribute("class", " class=\"", 4155, "\"", 4163, 0);
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 68 "D:\repos\piano-pizza\piano-pizza\Views\Shared\_Layout.cshtml"
                                                              Write(local.GetLocalizedHtmlString("Cart"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                                                </a>\r\n                                            </li>\r\n                                            <li class=\"active\">\r\n                                                <a");
                BeginWriteAttribute("href", " href=\"", 4431, "\"", 4468, 1);
#nullable restore
#line 72 "D:\repos\piano-pizza\piano-pizza\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 4438, Url.Action("History","Order"), 4438, 30, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                                    <span");
                BeginWriteAttribute("class", " class=\"", 4529, "\"", 4537, 0);
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 73 "D:\repos\piano-pizza\piano-pizza\Views\Shared\_Layout.cshtml"
                                                              Write(local.GetLocalizedHtmlString("History"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n\r\n                                                </a>\r\n                                            </li>\r\n                                            <li class=\"active\">\r\n                                                <a");
                BeginWriteAttribute("href", " href=\"", 4810, "\"", 4847, 1);
#nullable restore
#line 78 "D:\repos\piano-pizza\piano-pizza\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 4817, Url.Action("MyOrder","Order"), 4817, 30, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                                    <span");
                BeginWriteAttribute("class", " class=\"", 4908, "\"", 4916, 0);
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 79 "D:\repos\piano-pizza\piano-pizza\Views\Shared\_Layout.cshtml"
                                                              Write(local.GetLocalizedHtmlString("My Order"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</span>
                                                </a>
                                            </li>
                                            <li class=""active"">
                                                <a href=""#"">
                                                    <img style=""width: 40px; border-radius: 50%; margin-top: -8px;"" src=""/user_icon.jpg"" />
                                                    <span>");
#nullable restore
#line 85 "D:\repos\piano-pizza\piano-pizza\Views\Shared\_Layout.cshtml"
                                                     Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                                                </a>\r\n                                                <ul class=\"open-left\">\r\n                                                    <li>\r\n                                                        <a");
                BeginWriteAttribute("href", " href=\"", 5669, "\"", 5710, 1);
#nullable restore
#line 89 "D:\repos\piano-pizza\piano-pizza\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 5676, Url.Action("MyProfile","Account"), 5676, 34, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">My Profile</a>\r\n                                                    </li>\r\n                                                    <li>\r\n                                                        <a");
                BeginWriteAttribute("href", " href=\"", 5903, "\"", 5945, 1);
#nullable restore
#line 92 "D:\repos\piano-pizza\piano-pizza\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 5910, Url.Action("LogoutUser","Account"), 5910, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Logout</a>\r\n                                                    </li>\r\n                                                </ul>\r\n                                            </li>\r\n");
#nullable restore
#line 96 "D:\repos\piano-pizza\piano-pizza\Views\Shared\_Layout.cshtml"
                                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                        <li class=""active"" style=""font-size: 8px;top: 8px;"">
                                            <a href=""#"" style=""padding: 14px 4px;"">
                                                <span class=""selectedLanguage languages"">
                                                    ENG
                                                </span>
                                            </a>
                                        </li>
                                        <li class=""active"" style=""font-size: 8px;top: 8px;"">
                                            <a href=""#"" style=""padding: 14px 4px;"">
                                                <span class="" languages"">
                                                    IT
                                                </span>
                                            </a>
                                        </li>
                                        <li class=""active"" style=""font-size: 8p");
                WriteLiteral(@"x;top: 8px;"">
                                            <a href=""#"" style=""padding: 14px 4px;"">
                                                <span class="" languages"">
                                                    NL
                                                </span>
                                            </a>
                                        </li>
                                    </ul>
                                </nav>
                                <!-- #site-navigation -->
                            </div>
                            <!-- #nav-wrap -->
                        </div>
                        <!-- .level-right -->
                    </div>
                    <!-- .level -->
                </div>
                <!-- #header-inner -->
            </header>
            <!-- #header -->
        </div>
        ");
#nullable restore
#line 132 "D:\repos\piano-pizza\piano-pizza\Views\Shared\_Layout.cshtml"
   Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
        <div id=""footer-wrap"" class=""is-clearfix"">
            <footer id=""footer"" class=""site-footer"" style=""padding: 14px;"">
                <div id=""footer-inner"" class=""site-footer-inner container"">
                    <div class=""columns is-variable is-4 is-multiline"">
                        <div class=""column is-4"">
                            <div class=""widget widget-html"" style=""text-align: center;"">
                                <img src=""/app-images/piano-b-logo-2-1024x1024.png"" style=""width: 195px;"" />
                            </div>
                        </div>
                        <div class=""columns"" id=""footerTab"">
                            <!-- .column -->
                            <div class=""column is-5"">
                                <div class=""widget widget-links"">
                                    <h3 class=""widget-title "">Social Links</h3>
                                    <div class=""footer-social"">
                                        <a id=""F");
                WriteLiteral(@"BLink"" target=""_blank"" href=""#""><i class=""fab fa-facebook-f""></i></a>
                                        <a id=""INSTALink"" target=""_blank"" href=""#""><i class=""fab fa-instagram""></i></a>
                                        <a id=""GGLLink"" target=""_blank"" href=""#""><i class=""fab fa-google-plus-g""></i></a>
                                    </div>
                                </div>
                                <!-- .widget -->
                            </div>
                            <!-- .column -->
                        </div>
                    </div>
                    <!-- .columns -->
                </div>
                <!-- #footer-inner -->
            </footer>
            <!-- #footer -->
        </div>
    </div>

    <script src=""/assets/js/scripts.mind652.js?v=1557174151243""></script>
    <script src=""/assets/js/customd652.js?v=1557174151243""></script>
    <script src=""/custom/custom.js""></script>
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b5d4975cdd8b6737c6ed3ae677e5be6534a73d4928288", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b5d4975cdd8b6737c6ed3ae677e5be6534a73d4929388", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b5d4975cdd8b6737c6ed3ae677e5be6534a73d4930488", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b5d4975cdd8b6737c6ed3ae677e5be6534a73d4931588", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b5d4975cdd8b6737c6ed3ae677e5be6534a73d4932688", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <script>
        $(function () {
            GetHeaderPartial();
            GetFooterPartial();
            GetAppInfo();
            $('.LoggedInNav').remove();
            $('.loginNav').show();
        })
        function GetHeaderPartial() {
            $.ajax({
                url: ""/Home/headerPartial"",
                type: ""GET"",
                data: null,
                success: function (response) {
                    $('#ul_menu').prepend(response);

                    var element = $('#ul_menu').find(""[href='"" + location.pathname + ""']"");
                    if (element.length != 0) {
                        element.find('span').addClass('headerBtn');
                    }
                    else {
                        var element = $('#ul_menu').find(""[href='/']"");
                        element.find('span').addClass('headerBtn');
                    }
                },
                error: function (result) {
                    console.log(""Save Erro");
                WriteLiteral(@"r"", result);
                }
            });
        }
        function GetFooterPartial() {
            $.ajax({
                url: ""/Home/footerPartial"",
                type: ""GET"",
                data: null,
                success: function (response) {
                    $('#footerTab').prepend(response);
                },
                error: function (result) {
                    console.log(""Save Error"", result);
                }
            });
        }
        function GetAppInfo() {
            $.ajax({
                url: ""/Home/GetAppInfo"",
                type: ""GET"",
                data: null,
                success: function (response) {
                    $('#FBLink').attr('href', response.facebookUrl);
                    $('#INSTALink').attr('href', response.instagramUrl);
                    $('#GGLLink').attr('href', response.googleUrl);
                    /////////////
                },
                error: function (result) {
           ");
                WriteLiteral("         console.log(\"Save Error\", result);\r\n                }\r\n            });\r\n        }\r\n    </script>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public piano_pizza.Resources.LocalizationService local { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
