#pragma checksum "D:\repos\piano-pizza\piano-pizza\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9442bd99442adc111a42007593f7c6cd6e0b38ae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "D:\repos\piano-pizza\piano-pizza\Views\Home\Index.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9442bd99442adc111a42007593f7c6cd6e0b38ae", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4fd62fd606701e7948749f622ddc31478ced86fe", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Entities.BranchVms>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "D:\repos\piano-pizza\piano-pizza\Views\Home\Index.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- #header-wrap -->
<div id=""header-bottom-wrap"" class=""is-clearfix"">
    <div id=""header-bottom"" class=""site-header-bottom"">
        <div id=""header-bottom-inner"" class=""site-header-bottom-inner "">
            <section class=""hero slider is-clearfix "">
                <div style=""background-image: url('/app-images/home.jpg');background-repeat: no-repeat;background-size: cover;height:600px;position: relative;background-position: center center;"">
                </div>
                <div style=""position: absolute;width: 100%;height: 100%;background-color: #000000;opacity: 0.5;transition: background 0.3s, border-radius 0.3s, opacity 0.3s;"">
                </div>
                <div style=""text-align: center;position: absolute;width: 100%;"">
                    <h2 style=""color: #fff;font-size: 10vh;margin-top: 138px;font-family: 'LIBRE FRANKLIN', sans-serif;""");
            BeginWriteAttribute("class", " class=\"", 1118, "\"", 1126, 0);
            EndWriteAttribute();
            WriteLiteral(">Where would you like <br>to order pizza?</h2>\r\n");
#nullable restore
#line 20 "D:\repos\piano-pizza\piano-pizza\Views\Home\Index.cshtml"
                     foreach (var i in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <a");
            BeginWriteAttribute("href", " href=\"", 1271, "\"", 1331, 1);
#nullable restore
#line 22 "D:\repos\piano-pizza\piano-pizza\Views\Home\Index.cshtml"
WriteAttributeValue("", 1278, Url.Action("Index","Menu",new {BranchName = i.Name}), 1278, 53, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"main-section-btn\">");
#nullable restore
#line 22 "D:\repos\piano-pizza\piano-pizza\Views\Home\Index.cshtml"
                                                                                                            Write(i.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 23 "D:\repos\piano-pizza\piano-pizza\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
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
            <!-- import content layouts and modules -->
            <section>
                <div style=""background: #010101;text-align: center;"">
                    <img src=""/app-images/piano-b-logo-2-1024x1024.png"" style=""height: 350px;"">
                </div>
            </section>
            <section>
                <div style=""text-align: center;"">
                    <img src=""/app-images/8-slice-of-pizza.jpg"" style=""height: 100%;width: 100%;"">
                </div>
            </section>
            <section>
                <div class=""columns"">
           ");
            WriteLiteral(@"         <div class=""column is-4"" style=""padding: 0px 0px 0px 92px;"">
                        <h2 style=""color: #17b117;font-family: fangsong;padding: 26px;font-size: 46px;"">
                            WE PRESENT <br> TO YOU<br> THE PIZZA<br> OF THE<br> MONTH
                        </h2>
                        <h2 style=""padding: 0px 26px;font-size: 34px;"">
                            THE BRESAOLA
                        </h2>
                    </div>
                    <div class=""column is-8"">
                        <img src=""/app-images/braseol1.jpg"">
                    </div>
                </div>
            </section>
        </div>
        <!-- #content-area-inner -->
    </div>
    <!-- #content-area -->
</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public piano_pizza.Resources.LocalizationService local { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IViewLocalizer Localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Entities.BranchVms>> Html { get; private set; }
    }
}
#pragma warning restore 1591
