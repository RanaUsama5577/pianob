#pragma checksum "D:\repos\piano-pizza\piano-pizza\Views\Menu\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "059617ae87fd9fa80ea64ca8325bc3aa39c730d8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Menu_Index), @"mvc.1.0.view", @"/Views/Menu/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"059617ae87fd9fa80ea64ca8325bc3aa39c730d8", @"/Views/Menu/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4fd62fd606701e7948749f622ddc31478ced86fe", @"/Views/_ViewImports.cshtml")]
    public class Views_Menu_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Entities.CategoryAndProductsVms>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\repos\piano-pizza\piano-pizza\Views\Menu\Index.cshtml"
  
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
            BeginWriteAttribute("class", " class=\"", 993, "\"", 1001, 0);
            EndWriteAttribute();
            WriteLiteral(@">Menu </h2>
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
                    <p class=""heading-title-top has-text-centered style-2"">menu</p>
                    <div class=""works isotope"">
                        <ul class=""isotope-filter"">
                            <li data-filter=""*"" class=""active"">show all</li>
");
#nullable restore
#line 36 "D:\repos\piano-pizza\piano-pizza\Views\Menu\Index.cshtml"
                             foreach (var i in Model)
                            {
                                if (i.ProductList.Count() != 0 )
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li data-filter=\".");
#nullable restore
#line 40 "D:\repos\piano-pizza\piano-pizza\Views\Menu\Index.cshtml"
                                                 Write(i.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">");
#nullable restore
#line 40 "D:\repos\piano-pizza\piano-pizza\Views\Menu\Index.cshtml"
                                                        Write(i.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 41 "D:\repos\piano-pizza\piano-pizza\Views\Menu\Index.cshtml"
                                }
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </ul>\r\n                        <div class=\"columns is-variable is-4 is-multiline\">\r\n");
#nullable restore
#line 45 "D:\repos\piano-pizza\piano-pizza\Views\Menu\Index.cshtml"
                             foreach (var i in Model)
                            {
                                foreach (var a in i.ProductList)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div");
            BeginWriteAttribute("class", " class=\"", 2515, "\"", 2540, 3);
            WriteAttributeValue("", 2523, "column", 2523, 6, true);
            WriteAttributeValue(" ", 2529, "is-4", 2530, 5, true);
#nullable restore
#line 49 "D:\repos\piano-pizza\piano-pizza\Views\Menu\Index.cshtml"
WriteAttributeValue(" ", 2534, i.Id, 2535, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-aos=\"fade\">\r\n                                        <div class=\"work-item\">\r\n                                            <figure class=\"work-item-img\">\r\n                                                <a");
            BeginWriteAttribute("href", " href=\"", 2751, "\"", 2852, 1);
#nullable restore
#line 52 "D:\repos\piano-pizza\piano-pizza\Views\Menu\Index.cshtml"
WriteAttributeValue("", 2758, Url.Action("Index","Product",new {CategoryName = i.Name,Id = a.Id,BranchName = i.BranchName}), 2758, 94, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                    <img alt=\"niche\"");
            BeginWriteAttribute("src", " src=\"", 2924, "\"", 2937, 1);
#nullable restore
#line 53 "D:\repos\piano-pizza\piano-pizza\Views\Menu\Index.cshtml"
WriteAttributeValue("", 2930, a.Logo, 2930, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                                </a>
                                            </figure>
                                            <div class=""work-item-meta"">
                                                <h3>
                                                    <a");
            BeginWriteAttribute("href", " href=\"", 3232, "\"", 3269, 1);
#nullable restore
#line 58 "D:\repos\piano-pizza\piano-pizza\Views\Menu\Index.cshtml"
WriteAttributeValue("", 3239, Url.Action("Index","Product"), 3239, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                        ");
#nullable restore
#line 59 "D:\repos\piano-pizza\piano-pizza\Views\Menu\Index.cshtml"
                                                   Write(a.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                        <span class=\"work-price\">$");
#nullable restore
#line 60 "D:\repos\piano-pizza\piano-pizza\Views\Menu\Index.cshtml"
                                                                             Write(a.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                                    </a>\r\n                                                </h3>\r\n                                                <p>");
#nullable restore
#line 63 "D:\repos\piano-pizza\piano-pizza\Views\Menu\Index.cshtml"
                                              Write(a.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                            </div>\r\n                                        </div>\r\n                                    </div>\r\n");
#nullable restore
#line 67 "D:\repos\piano-pizza\piano-pizza\Views\Menu\Index.cshtml"
                                }
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </div>
                        <!-- .columns -->
                    </div>
                    <!-- .works -->
                </div>
            </section>
            <!-- . -->
            <section>
                <div style=""text-align: center;"">
                    <img src=""/app-images/8-slice-of-pizza.jpg"" style=""height: 100%;width: 100%;"">
                </div>
            </section>
            <section>
                <div class=""columns"">
                    <div class=""column is-4"" style=""padding: 0px 0px 0px 92px;"">
                        <h2 style=""color: #17b117;font-family: fangsong;padding: 26px;font-size: 46px;"">
                            WE PRESENT <br> TO YOU<br> THE PIZZA<br> OF THE<br> MONTH
                        </h2>
                        <h2 style=""padding: 0px 26px;font-size: 34px;"">
                            THE BRESAOLA
                        </h2>
                    </div>
                    <div class=""column is-8"">
 ");
            WriteLiteral("                       <img src=\"/app-images/braseol1.jpg\">\r\n                    </div>\r\n                </div>\r\n            </section>\r\n        </div>\r\n    </div>\r\n    <!-- #content-area -->\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Entities.CategoryAndProductsVms>> Html { get; private set; }
    }
}
#pragma warning restore 1591
