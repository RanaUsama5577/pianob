#pragma checksum "D:\repos\piano-pizza\piano-pizza\Areas\SuperAdmin\Views\Main\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2f7dc057f7a26f57fe4de294e0bba67440b369e4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_SuperAdmin_Views_Main_Index), @"mvc.1.0.view", @"/Areas/SuperAdmin/Views/Main/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f7dc057f7a26f57fe4de294e0bba67440b369e4", @"/Areas/SuperAdmin/Views/Main/Index.cshtml")]
    public class Areas_SuperAdmin_Views_Main_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Entities.AdminDashboard>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\repos\piano-pizza\piano-pizza\Areas\SuperAdmin\Views\Main\Index.cshtml"
  
    Layout = "~/Areas/SuperAdmin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<style>\r\n    #bar_chart {\r\n        height: 350px !important;\r\n    }\r\n</style>\r\n<section class=\"content home\">\r\n    <div class=\"block-header\">\r\n        <div class=\"row\">\r\n            <div class=\"col-12\">\r\n                <h2>\r\n                    ");
#nullable restore
#line 16 "D:\repos\piano-pizza\piano-pizza\Areas\SuperAdmin\Views\Main\Index.cshtml"
               Write(local.GetLocalizedHtmlString("Dashboard"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </h2>
            </div>

        </div>
    </div>
    <div class=""container-fluid"">
        <div class=""row clearfix social-widget"">
            <div class=""col-lg-3 col-md-3 col-6 d-flex"">
                <a href=""/SuperAdmin/Users/Detail"" style=""cursor:pointer"" class=""card info-box-2 hover-zoom-effect facebook-widget"">
                    <div class=""icon"">
                        <i class=""fas fa-users""></i>
                    </div>
                    <div class=""content pt-0"">
                        <div class=""number"">");
#nullable restore
#line 30 "D:\repos\piano-pizza\piano-pizza\Areas\SuperAdmin\Views\Main\Index.cshtml"
                                       Write(Model.TotalUsers);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>  <div class=\"text\">");
#nullable restore
#line 30 "D:\repos\piano-pizza\piano-pizza\Areas\SuperAdmin\Views\Main\Index.cshtml"
                                                                                  Write(local.GetLocalizedHtmlString("Customers"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                    </div>
                </a>
            </div>
            <div class=""col-lg-3 col-md-3 col-6 d-flex"">
                <a href=""/SuperAdmin/Product/Detail"" style=""cursor:pointer"" class=""card info-box-2 hover-zoom-effect instagram-widget"">
                    <div class=""icon"">
                        <i class=""fas fa-pizza-slice text-warning""></i>
                    </div>
                    <div class=""content pt-3"">
                        <div class=""number"">");
#nullable restore
#line 40 "D:\repos\piano-pizza\piano-pizza\Areas\SuperAdmin\Views\Main\Index.cshtml"
                                       Write(Model.TotalProducts);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>   <div class=\"text\">");
#nullable restore
#line 40 "D:\repos\piano-pizza\piano-pizza\Areas\SuperAdmin\Views\Main\Index.cshtml"
                                                                                      Write(local.GetLocalizedHtmlString("Products"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                    </div>
                </a>
            </div>
            <div class=""col-lg-3 col-md-3 col-6 d-flex"">
                <a href=""/SuperAdmin/Order/Detail"" style=""cursor:pointer"" class=""card info-box-2 hover-zoom-effect twitter-widget"">
                    <div class=""icon"">
                        <i class=""fas fa-shopping-cart text-warning""></i>
                    </div>
                    <div class=""content pt-0"">
                        <div class=""number"">");
#nullable restore
#line 50 "D:\repos\piano-pizza\piano-pizza\Areas\SuperAdmin\Views\Main\Index.cshtml"
                                       Write(Model.TotalOrders);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div><div class=\"text\">");
#nullable restore
#line 50 "D:\repos\piano-pizza\piano-pizza\Areas\SuperAdmin\Views\Main\Index.cshtml"
                                                                                 Write(local.GetLocalizedHtmlString("Orders"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                    </div>
                </a>
            </div>
            <div class=""col-lg-3 col-md-3 col-6 d-flex"">
                <a href=""/SuperAdmin/Category/Index"" style=""cursor:pointer"" class=""card info-box-2 hover-zoom-effect google-widget"">
                    <div class=""icon"">
                        <i class=""far fa-question-circle text-secondary""></i>
                    </div>
                    <div class=""content pt-0"">
                        <div class=""number"">");
#nullable restore
#line 60 "D:\repos\piano-pizza\piano-pizza\Areas\SuperAdmin\Views\Main\Index.cshtml"
                                       Write(Model.TotalCategories);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>  <div class=\"text\">");
#nullable restore
#line 60 "D:\repos\piano-pizza\piano-pizza\Areas\SuperAdmin\Views\Main\Index.cshtml"
                                                                                       Write(local.GetLocalizedHtmlString("Categories"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                    </div>
                </a>
            </div>

        </div>
        <div hidden class=""row mt-0 pt-0"">
            <div class=""col-12"">
                <div class=""card mb-0 pb-0"">
                    <div class=""header"">
                        <h2><strong>");
#nullable restore
#line 70 "D:\repos\piano-pizza\piano-pizza\Areas\SuperAdmin\Views\Main\Index.cshtml"
                               Write(local.GetLocalizedHtmlString("Orders"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong> ");
#nullable restore
#line 70 "D:\repos\piano-pizza\piano-pizza\Areas\SuperAdmin\Views\Main\Index.cshtml"
                                                                                Write(local.GetLocalizedHtmlString("Detail"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
                        <ul class=""header-dropdown"">
                            <li class=""dropdown"">
                                <a href=""javascript:void(0);"" class=""dropdown-toggle"" data-toggle=""dropdown"" role=""button"" aria-haspopup=""true"" aria-expanded=""false""> <i class=""zmdi zmdi-more""></i> </a>
                            </li>
                        </ul>
                    </div>
                    <div class=""body"">
                        <canvas id=""bar_chart"" height=""150""></canvas>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>

<script>
    $('#Dash').addClass('active');
    $('#Dash').addClass('open');
</script>

<script>
    $(function () {
        new Chart(document.getElementById(""bar_chart"").getContext(""2d""), getChartJs());
    });

    function getChartJs(type) {
        var config = null;



        config = {
            type: 'bar',
            width: '30',
            data: {
     ");
            WriteLiteral(@"           labels: [""January"", ""February"", ""March"", ""April"", ""May"", ""June"", ""July"", ""August"", ""September"", ""October"", ""November"", ""December""],
                datasets: [{
                    label: ""Take Away"",
                    data: [28, 48, 40, 19, 86, 27, 90, 19, 86, 27, 90, 3],
                    backgroundColor: '#f4f6f9',
                    strokeColor: ""rgba(255,118,118,0.1)"",
                }, {
                    label: ""Online Order"",
                    data: [10, 30, 80, 61, 26, 75, 40, 61, 26, 75, 6, 10],
                    backgroundColor: '#3b5998',
                    strokeColor: ""rgba(255,118,118,0.1)"",
                }]
            },
            options: {
                responsive: true,
                legend: false
            }
        }


        return config;
    }
</script>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Entities.AdminDashboard> Html { get; private set; }
    }
}
#pragma warning restore 1591
