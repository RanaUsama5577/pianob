#pragma checksum "D:\repos\piano_local\piano_local\Areas\Receptionist\Views\Main\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "153f0096985636e63ac8abc5b8e1b88446169247"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Receptionist_Views_Main_Index), @"mvc.1.0.view", @"/Areas/Receptionist/Views/Main/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"153f0096985636e63ac8abc5b8e1b88446169247", @"/Areas/Receptionist/Views/Main/Index.cshtml")]
    public class Areas_Receptionist_Views_Main_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Entities.AdminDashboard>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\repos\piano_local\piano_local\Areas\Receptionist\Views\Main\Index.cshtml"
  
    Layout = "~/Areas/Receptionist/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    #bar_chart {
        height: 350px !important;
    }
</style>
<section class=""content home"">
    <div class=""block-header"">
        <div class=""row"">
            <div class=""col-12"">
                <h2>
                    Dashboard
                </h2>
            </div>
        </div>
    </div>
    <div class=""container-fluid"">
        <div class=""row clearfix social-widget"">
            <div class=""col-lg-3 col-md-3 col-6 d-flex"">
                <a");
            BeginWriteAttribute("href", " href=\"", 595, "\"", 631, 1);
#nullable restore
#line 23 "D:\repos\piano_local\piano_local\Areas\Receptionist\Views\Main\Index.cshtml"
WriteAttributeValue("", 602, Url.Action("Orders","Order"), 602, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" style=""cursor:pointer"" class=""card info-box-2 hover-zoom-effect twitter-widget"">
                    <div class=""icon"">
                        <i class=""fas fa-shopping-cart text-warning""></i>
                    </div>
                    <div class=""content pt-0"">
                        <div class=""number"">");
#nullable restore
#line 28 "D:\repos\piano_local\piano_local\Areas\Receptionist\Views\Main\Index.cshtml"
                                       Write(Model.PendingOrders);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div><div class=\"text\">Pending Orders</div>\r\n                    </div>\r\n                </a>\r\n            </div>\r\n            <div class=\"col-lg-3 col-md-3 col-6 d-flex\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 1162, "\"", 1198, 1);
#nullable restore
#line 33 "D:\repos\piano_local\piano_local\Areas\Receptionist\Views\Main\Index.cshtml"
WriteAttributeValue("", 1169, Url.Action("Orders","Order"), 1169, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" style=""cursor:pointer"" class=""card info-box-2 hover-zoom-effect twitter-widget"">
                    <div class=""icon"">
                        <i class=""fas fa-shopping-cart text-warning""></i>
                    </div>
                    <div class=""content pt-0"">
                        <div class=""number"">");
#nullable restore
#line 38 "D:\repos\piano_local\piano_local\Areas\Receptionist\Views\Main\Index.cshtml"
                                       Write(Model.InProcessOrders);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div><div class=\"text\">In-process Orders</div>\r\n                    </div>\r\n                </a>\r\n            </div>\r\n            <div class=\"col-lg-3 col-md-3 col-6 d-flex\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 1734, "\"", 1770, 1);
#nullable restore
#line 43 "D:\repos\piano_local\piano_local\Areas\Receptionist\Views\Main\Index.cshtml"
WriteAttributeValue("", 1741, Url.Action("Orders","Order"), 1741, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" style=""cursor:pointer"" class=""card info-box-2 hover-zoom-effect twitter-widget"">
                    <div class=""icon"">
                        <i class=""fas fa-shopping-cart text-warning""></i>
                    </div>
                    <div class=""content pt-0"">
                        <div class=""number"">");
#nullable restore
#line 48 "D:\repos\piano_local\piano_local\Areas\Receptionist\Views\Main\Index.cshtml"
                                       Write(Model.CompletedOrders);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div><div class=\"text\">Completed Orders</div>\r\n                    </div>\r\n                </a>\r\n            </div>\r\n            <div class=\"col-lg-3 col-md-3 col-6 d-flex\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 2305, "\"", 2341, 1);
#nullable restore
#line 53 "D:\repos\piano_local\piano_local\Areas\Receptionist\Views\Main\Index.cshtml"
WriteAttributeValue("", 2312, Url.Action("Orders","Order"), 2312, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" style=""cursor:pointer"" class=""card info-box-2 hover-zoom-effect twitter-widget"">
                    <div class=""icon"">
                        <i class=""fas fa-shopping-cart text-warning""></i>
                    </div>
                    <div class=""content pt-0"">
                        <div class=""number"">");
#nullable restore
#line 58 "D:\repos\piano_local\piano_local\Areas\Receptionist\Views\Main\Index.cshtml"
                                       Write(Model.CancelledOrders);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div><div class=""text"">Cancelled Orders</div>
                    </div>
                </a>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-lg-3"">
                <a href=""/receptionist/orders/PlaceOrder"" class=""btn btn-primary"" style=""width: 100%; height: 46px; color: #fff; background-color: #048e39; line-height: 2; "">
                    <i class=""fas fa-shopping-cart"" style=""margin-right: 11px; ""></i>Place Order
                </a>
            </div>
        </div>
        <div hidden class=""row mt-0 pt-0"">
            <div class=""col-12"">
                <div class=""card mb-0 pb-0"">
                    <div class=""header"">
                        <h2><strong>Orders</strong> Detail</h2>
                        <ul class=""header-dropdown"">
                            <li class=""dropdown"">
                                <a href=""javascript:void(0);"" class=""dropdown-toggle"" data-toggle=""dropdown"" role=""button"" aria-haspopup=""true"" aria-expanded=""");
            WriteLiteral(@"false""> <i class=""zmdi zmdi-more""></i> </a>
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
            width:'30',
            data: {
                labels: [""January"", ""February"", ""March"", ""April"", ""May"", ""June"", ""July"",""August"",""September"",""October"",""November"",""December""],
                datasets: [{
                    label: ""Take Away"",
                    data: [28, 48, 40, 19, 86, 27, 90, 19, 86, 27, 9");
            WriteLiteral(@"0,3],
                    backgroundColor: '#f4f6f9',
                    strokeColor: ""rgba(255,118,118,0.1)"",
                }, {
                        label: ""Online Order"",
                        data: [10, 30, 80, 61, 26, 75, 40, 61, 26, 75,6,10],
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
