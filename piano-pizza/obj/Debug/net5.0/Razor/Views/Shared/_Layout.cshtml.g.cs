#pragma checksum "D:\repos\piano-pizza\piano-pizza\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f7f3cfdcd24e7c598ffb1a28a80fd4d62a1c047f"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7f3cfdcd24e7c598ffb1a28a80fd4d62a1c047f", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4fd62fd606701e7948749f622ddc31478ced86fe", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString(@"active-pageloader entertainment restaurant header-sticky hide-on-scroll header-logo-left footer-widgets footer-background dark-color widget-7 header-transparent submenu-show-arrow-right menu-is-uppercase submenu-is-capitalized logo-text-is-capitalized page-header-logo-left"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\" class=\"no-js no-svg\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f7f3cfdcd24e7c598ffb1a28a80fd4d62a1c047f3842", async() => {
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
    <link href=""https://fonts.googleapis.com/css?family=Kalam:700|Oswald:400,500,700|Open+Sans:300,400&amp;v=1557174088386"" rel=""stylesheet"">
    <link rel=""apple-touch-icon"" sizes=""57x57"" href=""cropped-b-black-180x180.png"">
    <meta name=""apple-mobile-web-app-capable"" content=""yes"">
    <meta name=""apple-mobile-web-app-status-bar-style"" content=""black-translucent"">
    <meta name=""");
                WriteLiteral("apple-mobile-web-app-title\" content=\"PianoPizza\">\r\n    <link rel=\"shortcut icon\" href=\"cropped-b-black-180x180.png\">\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f7f3cfdcd24e7c598ffb1a28a80fd4d62a1c047f6048", async() => {
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
                BeginWriteAttribute("href", " href=\"", 2145, "\"", 2179, 1);
#nullable restore
#line 35 "D:\repos\piano-pizza\piano-pizza\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2152, Url.Action("Index","Home"), 2152, 27, false);

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
                                    <ul class=""menu"">
                                        <li class=""niche-templates"">
                                            <a");
                BeginWriteAttribute("href", " href=\"", 3141, "\"", 3175, 1);
#nullable restore
#line 52 "D:\repos\piano-pizza\piano-pizza\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 3148, Url.Action("Index","Home"), 3148, 27, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 52 "D:\repos\piano-pizza\piano-pizza\Views\Shared\_Layout.cshtml"
                                                                             Write(local.GetLocalizedHtmlString("Home"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n                                        </li>\r\n                                        <li class=\"active\">\r\n                                            <a");
                BeginWriteAttribute("href", " href=\"", 3374, "\"", 3408, 1);
#nullable restore
#line 55 "D:\repos\piano-pizza\piano-pizza\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 3381, Url.Action("Index","Menu"), 3381, 27, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">MAASTRICHT</a>\r\n                                        </li>\r\n                                        <li class=\"active\">\r\n                                            <a");
                BeginWriteAttribute("href", " href=\"", 3580, "\"", 3614, 1);
#nullable restore
#line 58 "D:\repos\piano-pizza\piano-pizza\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 3587, Url.Action("Index","Menu"), 3587, 27, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">LEIDEN</a>\r\n                                        </li>\r\n                                        <li class=\"active\">\r\n                                            <a");
                BeginWriteAttribute("href", " href=\"", 3782, "\"", 3816, 1);
#nullable restore
#line 61 "D:\repos\piano-pizza\piano-pizza\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 3789, Url.Action("Index","Home"), 3789, 27, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 61 "D:\repos\piano-pizza\piano-pizza\Views\Shared\_Layout.cshtml"
                                                                             Write(local.GetLocalizedHtmlString("History"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n                                        </li>\r\n                                        <li class=\"active\">\r\n                                            <a");
                BeginWriteAttribute("href", " href=\"", 4018, "\"", 4052, 1);
#nullable restore
#line 64 "D:\repos\piano-pizza\piano-pizza\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 4025, Url.Action("Index","Home"), 4025, 27, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                                <span class=\"headerBtn\">");
#nullable restore
#line 65 "D:\repos\piano-pizza\piano-pizza\Views\Shared\_Layout.cshtml"
                                                                   Write(local.GetLocalizedHtmlString("MyOrder"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</span>
                                            </a>
                                        </li>
                                        <li class=""active"">
                                            <a href=""#"">
                                                <span class=""selectedLanguage languages"">
                                                    ENG
                                                </span>
                                            </a>
                                        </li>
                                        <li class=""active"">
                                            <a href=""#"">
                                                <span class="" languages"">
                                                    IT
                                                </span>
                                            </a>
                                        </li>
                                        <li class=""active"">
                                ");
                WriteLiteral(@"            <a href=""#"">
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
#line 103 "D:\repos\piano-pizza\piano-pizza\Views\Shared\_Layout.cshtml"
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
                        <div class=""columns"">
                            <!-- .column -->
                            <div class=""column is-4"">
                                <div class=""widget widget-tags"">
                                    <h3 class=""widget-title "">");
#nullable restore
#line 117 "D:\repos\piano-pizza\piano-pizza\Views\Shared\_Layout.cshtml"
                                                         Write(local.GetLocalizedHtmlString("Home"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n                                    <div class=\"widget-links links-with-icons\">\r\n                                        <ul>\r\n                                            <li>\r\n                                                <span");
                BeginWriteAttribute("class", " class=\"", 7177, "\"", 7185, 0);
                EndWriteAttribute();
                WriteLiteral(@" style=""float: left;line-height: 2;margin-right: 4px;font-size: 11px;"">
                                                    <i class=""fas fa-chevron-right""></i>
                                                </span>
                                                <a style=""font-size: 11px;"" href=""#"">Tongersestraat 25<br> 6211 LL Maastricht<br></a>
                                            </li>
                                            <li>
                                                <span");
                BeginWriteAttribute("class", " class=\"", 7695, "\"", 7703, 0);
                EndWriteAttribute();
                WriteLiteral(@" style=""float: left;line-height: 2;margin-right: 4px;font-size: 11px;"">
                                                    <i class=""fas fa-chevron-right""></i>
                                                </span>
                                                <a style=""font-size: 11px;"" href=""tel:+31(0)6 151 44 232"">+31(0)6 151 44 232</a>
                                            </li>
                                            <li>
                                                <span");
                BeginWriteAttribute("class", " class=\"", 8208, "\"", 8216, 0);
                EndWriteAttribute();
                WriteLiteral(@" style=""float: left;line-height: 2;margin-right: 4px;font-size: 11px;"">
                                                    <i class=""fas fa-chevron-right""></i>
                                                </span>
                                                <a style=""font-size: 11px;"" href=""mailto:info@pizzeriapianob.com"">info@pizzeriapianob.com</a>
                                            </li>
                                        </ul>
                                    </div>
                                </div>
                                <!-- .widget -->
                            </div>
                            <!-- .column -->
                            <div class=""column is-4"">
                                <div class=""widget widget-tags"">
                                    <h3 class=""widget-title "">LEIDEN</h3>
                                    <div class=""widget-links links-with-icons"">
                                        <ul>
                        ");
                WriteLiteral("                    <li>\r\n                                                <span");
                BeginWriteAttribute("class", " class=\"", 9320, "\"", 9328, 0);
                EndWriteAttribute();
                WriteLiteral(@" style=""float: left;line-height: 4;margin-right: 4px;font-size: 11px;"">
                                                    <i class=""fas fa-chevron-right""></i>
                                                </span>
                                                <a style=""font-size: 11px;"" href=""#"">Kaiserstraat 19 <br> 2311 GN <br> Leiden </a>
                                            </li>
                                            <li>
                                                <span");
                BeginWriteAttribute("class", " class=\"", 9835, "\"", 9843, 0);
                EndWriteAttribute();
                WriteLiteral(@" style=""float: left;line-height: 2;margin-right: 4px;font-size: 11px;"">
                                                    <i class=""fas fa-chevron-right""></i>
                                                </span>
                                                <a style=""font-size: 11px;"" href=""tel:+31(0)6 879 97 581"">+31(0)6 879 97 581</a>
                                            </li>
                                            <li>
                                                <span");
                BeginWriteAttribute("class", " class=\"", 10348, "\"", 10356, 0);
                EndWriteAttribute();
                WriteLiteral(@" style=""float: left;line-height: 2;margin-right: 4px;font-size: 11px;"">
                                                    <i class=""fas fa-chevron-right""></i>
                                                </span>
                                                <a style=""font-size: 11px;"" href=""mailto:info@pizzeriapianob.com"">info@pizzeriapianob.com</a>
                                            </li>
                                        </ul>
                                    </div>
                                </div>
                                <!-- .widget -->
                            </div>
                            <!-- .column -->
                            <div class=""column is-5"">
                                <div class=""widget widget-links"">
                                    <h3 class=""widget-title "">Social Links</h3>
                                    <div class=""footer-social"">
                                        <a href=""#""><i class=""fab fa-facebook-f");
                WriteLiteral(@"""></i></a>
                                        <a href=""#""><i class=""fab fa-instagram""></i></a>
                                        <a href=""#""><i class=""fab fa-google-plus-g""></i></a>
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
    <script src=""/assets/js/vendor.mind652.js?v=1557174151243""></script>
    <script src=""/assets/js/scripts.mind652.js?v=1557174151243""></script>
    <script src=""/assets/js/customd652.js?v=1557174151243""></script>
    <script src=""/custom/custom.js""></script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
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
