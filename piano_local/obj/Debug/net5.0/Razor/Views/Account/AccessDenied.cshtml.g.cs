#pragma checksum "D:\repos\piano_local\piano_local\Views\Account\AccessDenied.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3f5355e2267b6ef2d8f1d9e7ce4b35d5ee39ec3a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_AccessDenied), @"mvc.1.0.view", @"/Views/Account/AccessDenied.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f5355e2267b6ef2d8f1d9e7ce4b35d5ee39ec3a", @"/Views/Account/AccessDenied.cshtml")]
    public class Views_Account_AccessDenied : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\repos\piano_local\piano_local\Views\Account\AccessDenied.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!-- #header-wrap -->
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
            BeginWriteAttribute("class", " class=\"", 997, "\"", 1005, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 15 "D:\repos\piano_local\piano_local\Views\Account\AccessDenied.cshtml"
                                                                                                                             Write(local.GetLocalizedHtmlString("Access Denied"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </h2>
                </div>
            </section>
            <!-- .slider -->
        </div>
        <!-- #header-bottom-inner -->
    </div>
    <!-- #header-bottom -->
</div>
<!-- #header-bottom-wrap -->
<!-- import content layouts and modules -->
<div id=""content-main-wrap"" class=""is-clearfix"">
    <div id=""content-area"" class=""site-content-area"">
        <div id=""content-area-inner"" class=""site-content-area-inner"">
            <!-- works section -->
            <section class=""section works-list is-clearfix"">
                <div class=""container"">
                    <div class=""columns"">
                        <div class=""columns columns-6"">
                            <h3>");
#nullable restore
#line 34 "D:\repos\piano_local\piano_local\Views\Account\AccessDenied.cshtml"
                           Write(local.GetLocalizedHtmlString("You are allowed to access this portal please login again to access"));

#line default
#line hidden
#nullable disable
            WriteLiteral(".</h3><a href=\"/Account/Login\">");
#nullable restore
#line 34 "D:\repos\piano_local\piano_local\Views\Account\AccessDenied.cshtml"
                                                                                                                                                             Write(local.GetLocalizedHtmlString("Login Again"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>
                        </div>
                        <div class=""columns columns-6"" style=""margin-left: 138px;"">
                            <img src=""/animation_500_kyl7bduq.gif"" style=""width: 188px;"">
                        </div>
                    </div>
                </div>
            </section>
        </div>
    </div>
</div>
");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public piano_local.Resources.LocalizationService local { get; private set; }
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