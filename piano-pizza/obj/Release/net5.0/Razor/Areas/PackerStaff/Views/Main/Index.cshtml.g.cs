#pragma checksum "D:\repos\piano-pizza\piano-pizza\Areas\PackerStaff\Views\Main\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "654b4052c78ab9c43f38244540539c55dc300c12"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_PackerStaff_Views_Main_Index), @"mvc.1.0.view", @"/Areas/PackerStaff/Views/Main/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"654b4052c78ab9c43f38244540539c55dc300c12", @"/Areas/PackerStaff/Views/Main/Index.cshtml")]
    public class Areas_PackerStaff_Views_Main_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Entities.GetStaffDashboardStats>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin-assets/images/food-pack (2).png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("20"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin-assets/images/food-pack (1).png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("25"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("25"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin-assets/images/piano/cooking.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mt-4 mb-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("35"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\repos\piano-pizza\piano-pizza\Areas\PackerStaff\Views\Main\Index.cshtml"
  
    Layout = "/Areas/PackerStaff/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<section class=""content home"">
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
        <div class=""row"">
");
#nullable restore
#line 17 "D:\repos\piano-pizza\piano-pizza\Areas\PackerStaff\Views\Main\Index.cshtml"
             if (Model.OrderDetails.Count() > 0 && !Model.OrderDetails.Any(p => p.WorkerStatus == Entities.Enum.WorkerStatus.Working))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-12\">\r\n                    <button onclick=\"StartOrder()\" class=\"btn btn-primary mb-4 px-5 bg-black font-19\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "654b4052c78ab9c43f38244540539c55dc300c126531", async() => {
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
            WriteLiteral("Start Order</button>\r\n                </div>\r\n");
#nullable restore
#line 22 "D:\repos\piano-pizza\piano-pizza\Areas\PackerStaff\Views\Main\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-lg-8 col-sm-12 col-12\">\r\n                <div class=\"row\">\r\n");
#nullable restore
#line 25 "D:\repos\piano-pizza\piano-pizza\Areas\PackerStaff\Views\Main\Index.cshtml"
                     foreach (var i in Model.OrderDetails)
                    {
                        if (i.WorkerStatus == Entities.Enum.WorkerStatus.Waiting)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <div class=""col-md-6 col-12 d-flex"">
                                <div class=""card project_widget p-1"">
                                    <div class=""pw_img m-auto d-flex"">
                                        <img class=""img-responsive w-25 m-auto"" src=""/cooking.png"" alt=""About the image"">
                                    </div>
                                    <div class=""pw_content mt-30"">
                                        <div class=""pw_header d-flex"">
                                            <div>
                                                <h6>Order Id: #");
#nullable restore
#line 37 "D:\repos\piano-pizza\piano-pizza\Areas\PackerStaff\Views\Main\Index.cshtml"
                                                          Write(i.OrderId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                                                <small class=\"text-muted\">Datetime: ");
#nullable restore
#line 38 "D:\repos\piano-pizza\piano-pizza\Areas\PackerStaff\Views\Main\Index.cshtml"
                                                                               Write(i.CreatedAt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                                            </div>\r\n                                            <a class=\"ml-auto mt-3 cursor-pointer\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2007, "\"", 2042, 3);
            WriteAttributeValue("", 2017, "GetProductsDetails(", 2017, 19, true);
#nullable restore
#line 40 "D:\repos\piano-pizza\piano-pizza\Areas\PackerStaff\Views\Main\Index.cshtml"
WriteAttributeValue("", 2036, i.Id, 2036, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2041, ")", 2041, 1, true);
            EndWriteAttribute();
            WriteLiteral("><u>Details</u></a>\r\n                                        </div>\r\n                                        <div class=\"pw_meta d-flex\">\r\n                                            <span>Amount: $");
#nullable restore
#line 43 "D:\repos\piano-pizza\piano-pizza\Areas\PackerStaff\Views\Main\Index.cshtml"
                                                      Write(i.TotalPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                            <span class=""text-danger ml-auto"">Not Started</span>
                                        </div>
                                    </div>
                                </div>
                            </div>
");
#nullable restore
#line 49 "D:\repos\piano-pizza\piano-pizza\Areas\PackerStaff\Views\Main\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <div class=""col-md-6 col-12 d-flex"">
                                <div class=""card project_widget p-1"">
                                    <div class=""pw_img m-auto d-flex"">
                                        <img class=""img-responsive w-25 m-auto"" src=""/cooking.png"" alt=""About the image"">
                                    </div>

                                    <div class=""d-flex mt-1"">
                                        <div class=""m-auto"">
");
            WriteLiteral("                                            <a");
            BeginWriteAttribute("onclick", " onclick=\"", 3364, "\"", 3398, 3);
            WriteAttributeValue("", 3374, "MarkOrderAsPacked(", 3374, 18, true);
#nullable restore
#line 61 "D:\repos\piano-pizza\piano-pizza\Areas\PackerStaff\Views\Main\Index.cshtml"
WriteAttributeValue("", 3392, i.Id, 3392, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3397, ")", 3397, 1, true);
            EndWriteAttribute();
            WriteLiteral(" data-toggle=\"tooltip\" title=\"Mark order as packed\" class=\"cursor-pointer ml-3 btn-sm btn-default waves-effect waves-float waves-black\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "654b4052c78ab9c43f38244540539c55dc300c1212573", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</a>
                                        </div>
                                    </div>

                                    <div class=""pw_content"">
                                        <div class=""pw_header d-flex"">
                                            <div>
                                                <h6>Order Id: #");
#nullable restore
#line 68 "D:\repos\piano-pizza\piano-pizza\Areas\PackerStaff\Views\Main\Index.cshtml"
                                                          Write(i.OrderId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                                                <small class=\"text-muted\">Datetime: ");
#nullable restore
#line 69 "D:\repos\piano-pizza\piano-pizza\Areas\PackerStaff\Views\Main\Index.cshtml"
                                                                               Write(i.CreatedAt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                                            </div>\r\n                                            <a class=\"ml-auto mt-3 cursor-pointer\"");
            BeginWriteAttribute("onclick", " onclick=\"", 4216, "\"", 4251, 3);
            WriteAttributeValue("", 4226, "GetProductsDetails(", 4226, 19, true);
#nullable restore
#line 71 "D:\repos\piano-pizza\piano-pizza\Areas\PackerStaff\Views\Main\Index.cshtml"
WriteAttributeValue("", 4245, i.Id, 4245, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4250, ")", 4250, 1, true);
            EndWriteAttribute();
            WriteLiteral("><u>Details</u></a>\r\n                                        </div>\r\n                                        <div class=\"pw_meta d-flex\">\r\n                                            <span>Amount: $");
#nullable restore
#line 74 "D:\repos\piano-pizza\piano-pizza\Areas\PackerStaff\Views\Main\Index.cshtml"
                                                      Write(i.TotalPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                            <span class=""text-warning ml-auto"">In-process</span>
                                        </div>
                                        <div class=""pw_meta"" style=""padding-top: 0px;"">
                                            <span id=""Timer""></span>
                                        </div>
                                        <input type=""hidden"" class=""Timers""");
            BeginWriteAttribute("id", " id=\"", 4900, "\"", 4916, 2);
            WriteAttributeValue("", 4905, "start-", 4905, 6, true);
#nullable restore
#line 80 "D:\repos\piano-pizza\piano-pizza\Areas\PackerStaff\Views\Main\Index.cshtml"
WriteAttributeValue("", 4911, i.Id, 4911, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 4917, "\"", 4937, 1);
#nullable restore
#line 80 "D:\repos\piano-pizza\piano-pizza\Areas\PackerStaff\Views\Main\Index.cshtml"
WriteAttributeValue("", 4925, i.StartTime, 4925, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 84 "D:\repos\piano-pizza\piano-pizza\Areas\PackerStaff\Views\Main\Index.cshtml"
                        }
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
                <div hidden class=""card"">
                    <div class=""body"">
                        <ul class=""pagination pagination-primary m-b-0"">
                            <li class=""page-item""><a class=""page-link"" href=""#""><i class=""zmdi zmdi-arrow-left""></i></a></li>
                            <li class=""page-item active""><a class=""page-link"" href=""#"">1</a></li>
                            <li class=""page-item""><a class=""page-link"" href=""#"">2</a></li>
                            <li class=""page-item""><a class=""page-link"" href=""#"">3</a></li>
                            <li class=""page-item""><a class=""page-link"" href=""#"">4</a></li>
                            <li class=""page-item""><a class=""page-link"" href=""#""><i class=""zmdi zmdi-arrow-right""></i></a></li>
                        </ul>
                    </div>
                </div>
            </div>

            <div class=""col-lg-4 col-sm-12 col-12"">
                <div class=""w-100"">
                  ");
            WriteLiteral("  <a");
            BeginWriteAttribute("href", " href=\"", 6141, "\"", 6177, 1);
#nullable restore
#line 103 "D:\repos\piano-pizza\piano-pizza\Areas\PackerStaff\Views\Main\Index.cshtml"
WriteAttributeValue("", 6148, Url.Action("Orders","Order"), 6148, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"cursor:pointer\" class=\"card info-box-2 hover-zoom-effect twitter-widget\">\r\n                        <div class=\"icon\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "654b4052c78ab9c43f38244540539c55dc300c1219102", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"content mb-2\">\r\n                            <div class=\"number\">");
#nullable restore
#line 108 "D:\repos\piano-pizza\piano-pizza\Areas\PackerStaff\Views\Main\Index.cshtml"
                                           Write(Model.TotalOrders);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div><div class=\"text\">Assigned Orders</div>\r\n                        </div>\r\n                    </a>\r\n                </div>\r\n\r\n                <div class=\"w-100 mt-43\">\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 6764, "\"", 6800, 1);
#nullable restore
#line 114 "D:\repos\piano-pizza\piano-pizza\Areas\PackerStaff\Views\Main\Index.cshtml"
WriteAttributeValue("", 6771, Url.Action("Orders","Order"), 6771, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"cursor:pointer\" class=\"card info-box-2 hover-zoom-effect twitter-widget\">\r\n                        <div class=\"icon\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "654b4052c78ab9c43f38244540539c55dc300c1221450", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"content mb-2\">\r\n                            <div class=\"number\">");
#nullable restore
#line 119 "D:\repos\piano-pizza\piano-pizza\Areas\PackerStaff\Views\Main\Index.cshtml"
                                           Write(Model.InProcessOrder);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div><div class=\"text\">In-process Orders</div>\r\n                        </div>\r\n                    </a>\r\n                </div>\r\n\r\n                <div class=\"w-100 mt-43\">\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 7392, "\"", 7428, 1);
#nullable restore
#line 125 "D:\repos\piano-pizza\piano-pizza\Areas\PackerStaff\Views\Main\Index.cshtml"
WriteAttributeValue("", 7399, Url.Action("Orders","Order"), 7399, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"cursor:pointer\" class=\"card info-box-2 hover-zoom-effect twitter-widget\">\r\n                        <div class=\"icon\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "654b4052c78ab9c43f38244540539c55dc300c1223803", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"content mb-2\">\r\n                            <div class=\"number\">");
#nullable restore
#line 130 "D:\repos\piano-pizza\piano-pizza\Areas\PackerStaff\Views\Main\Index.cshtml"
                                           Write(Model.Completed);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div><div class=""text"">Completed Orders</div>
                        </div>
                    </a>
                </div>

            </div>
        </div>
    </div>

    <div class=""modal fade bs-example-modal-md mt-5"" id=""PrdDtls"" tabindex=""-1"" role=""dialog"" aria-labelledby=""PrdDtls"" aria-hidden=""true"">
        <div class=""modal-dialog modal-lg"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"" id=""formModal"">Products Detail</h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">×</span>
                    </button>
                </div>
                <div class=""modal-body"">
                    <div class=""row"" id=""AppendProducts"">

                    </div>
                    <div class=""row"">
                        <div class=""col-12"">
                            <div class=""float-right"">
       ");
            WriteLiteral(@"                         <b>Total Bill: </b> <span id=""TotalPrice"">800</span>
                            </div>
                        </div>
                    </div>

                </div>
            </div>
        </div><!-- /.modal -->
    </div>
</section>

<script>
    $(""[data-toggle='tooltip']"").tooltip();
    $('#Dash').addClass('active');
    $('#Dash').addClass('open');
</script>
<script>
    $(function () {
        $('.Timers').each(function (index, obj) {
            var s = $(obj).val();
            s = new Date(s);
            var newTime = new Date();
            var different = newTime.getTime() - s.getTime();

            console.log(""startDate : "" + s);
            console.log(""endDate : "" + newTime);
            console.log(""different : "" + different);

            var secondsInMilli = 1000;
            var minutesInMilli = secondsInMilli * 60;
            var hoursInMilli = minutesInMilli * 60;

            var elapsedHours = different / hoursInMilli;");
            WriteLiteral(@"
            different = different % hoursInMilli;

            var elapsedMinutes = different / minutesInMilli;
            different = different % minutesInMilli;
            elapsedMinutes += parseInt(elapsedHours) * 60;
            var elapsedSeconds = different / secondsInMilli;
            console.log(""%d hours, %d minutes, %d seconds%n"",
                elapsedHours, elapsedMinutes, elapsedSeconds);
            var objectToUpdate = $(obj).siblings('.pw_meta').find('#Timer');
            startTimer(elapsedMinutes, elapsedSeconds, objectToUpdate);
        })
    })
    function startTimer(duration, elapsedSeconds, display) {
        var timer = duration * 60;
        var seconds = elapsedSeconds;
        var hours = 0;
        var minutes = duration;
        var count = 0;
        setInterval(function () {
            console.log(""timer"", timer);
            minutes = parseInt(timer / 60, 10);
            seconds = parseInt(timer % 60, 10);
            if (minutes > 60) {
         ");
            WriteLiteral(@"       hours = parseInt(minutes / 60);
                hours = hours < 10 ? ""0"" + hours : hours;
            }
            minutes = minutes < 10 ? ""0"" + minutes : minutes;
            seconds = seconds < 10 ? ""0"" + seconds : seconds;
            var displayMinutes = parseInt(minutes);
            displayMinutes = displayMinutes > 60 ? displayMinutes % 60 : displayMinutes;
            if (hours > 0) {
                $(display).html(hours + "":"" + displayMinutes + "":"" + seconds);
            }
            else {
                $(display).html(displayMinutes + "":"" + seconds);
            }

            if (++timer < 0) {
                timer = minutes;
            }
            count++;
        }, 1000);
    }
</script>
<script>
    function GetProductsDetails(Id) {
        var response = getResponseFromUrl('Get', '/packerStaff/main/GetProducts?Id=' + Id, null, false);
        response = response.responseJSON;
        if (response.code == 200) {
            var result = response.resu");
            WriteLiteral(@"lt;
            if (result.length > 0) {
                var price = 0;
                $('#AppendProducts').html("""");
                result.forEach(function (doc) {
                    var data = doc;
                    console.log(""list"", data.ingredientList);
                    var s = """";
                    data.ingredientList.forEach(function (item) {
                        s += `<div class=""flex-row"">
                                            <small class=""text-muted""><b><i class=""fas fa-circle font-8 mr-2""></i>${item.ingredientName}: </b></small> <small class=""ml-2"">${item.quantity} Qty</small>
                                        </div>`;
                    });
                    var product = `<div class=""col-12"">
                            <div class=""card project_widget p-1"">
                                <div class=""d-flex"">
                                    <img class=""img-responsive"" width=""70"" height=""70"" src=""${data.productImage}"" alt=""About the image"">
      ");
            WriteLiteral(@"                              <div class=""ml-3 mt-2"">
                                        <p class=""mb-0"">${data.productName}</p>
                                        ${s}
                                    </div>
                                    <div class=""ml-auto"">
                                        <span>${data.quantity} Qty</span>
                                    </div>
                                </div>
                            </div>
                        </div>`;
                    price += data.total_price;
                    $('#AppendProducts').append(product);
                })
                $('#TotalPrice').html(""$"" + price);
                $('#PrdDtls').modal(""show"");
            }
        }
        else {
            console.log(response);
            sweetMessage(""Error!"", response.shortMessage + ""<br>"" + response.result, ""error"");
        }
    }
</script>
<script>
    function StartOrder() {
        Swal.fire({
            title: 'A");
            WriteLiteral(@"re you sure you start working?',
            text: """",
            icon: 'warning',
            showCancelButton: true,
            confirmButtonColor: '#3085d6',
            cancelButtonColor: '#d33',
            showLoaderOnConfirm: true,
            preConfirm: (ref) => {
                return new Promise(async function (resolve, reject) {
                    var response = await getResponseFromUrl('Get', '/packerStaff/main/startOrder', null, true);
                    if (response.code == 200) {
                        MixinSweet(""Success"", """", ""success"", 2000);
                        setTimeout(function () {
                            location.reload();
                        }, 2000);
                    }
                    else {
                        MixinSweet(response.shortMessage, """", ""success"", 2000);
                    }
                })
            },
            confirmButtonText: 'Confirm!'
        }).then((result) => {
            if (result.isConfirmed) {
 ");
            WriteLiteral(@"           }
        })
    }
    function MarkOrderAsPacked(Id) {
        Swal.fire({
            title: 'Are you sure you want mark this order as packed?',
            text: """",
            icon: 'warning',
            showCancelButton: true,
            confirmButtonColor: '#3085d6',
            cancelButtonColor: '#d33',
            showLoaderOnConfirm: true,
            preConfirm: (ref) => {
                return new Promise(async function (resolve, reject) {
                    var response = await getResponseFromUrl('Get', '/packerStaff/main/MarkOrderAsPacked?Id=' + Id, null, true);
                    if (response.code == 200) {
                        MixinSweet(""Success"", """", ""success"", 2000);
                        setTimeout(function () {
                            location.reload();
                        }, 2000);
                    }
                    else {
                        MixinSweet(response.shortMessage, """", ""success"", 2000);
                    }
    ");
            WriteLiteral(@"            })
            },
            confirmButtonText: 'Confirm!'
        }).then((result) => {
            if (result.isConfirmed) {
            }
        })
    }
</script>
<!--Ajax-->
<script>
    var getResponseFromUrl = function (requestType, requestUrl, requestData, async) {
        var response;
        return $.ajax({
            type: requestType,
            url: requestUrl,
            data: requestData,
            async: async,
            processData: false,
            contentType: false,
            success: function (data) {
                response = data;
                return response;
            },
            error: function (error) {
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Entities.GetStaffDashboardStats> Html { get; private set; }
    }
}
#pragma warning restore 1591
