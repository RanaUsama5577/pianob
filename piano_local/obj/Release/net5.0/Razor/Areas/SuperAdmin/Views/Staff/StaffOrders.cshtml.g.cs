#pragma checksum "D:\repos\piano_local\piano_local\Areas\SuperAdmin\Views\Staff\StaffOrders.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "689d9362a061cbb8361614f45137988e9fe9ac94"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_SuperAdmin_Views_Staff_StaffOrders), @"mvc.1.0.view", @"/Areas/SuperAdmin/Views/Staff/StaffOrders.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"689d9362a061cbb8361614f45137988e9fe9ac94", @"/Areas/SuperAdmin/Views/Staff/StaffOrders.cshtml")]
    public class Areas_SuperAdmin_Views_Staff_StaffOrders : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Entities.GetStaffStatsAndCompletedOrders>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin-assets/images/piano/Bg-transparent/Page-2-Image-14-removebg-preview.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("35"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin-assets/images/food-cover.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mt-4 mb-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin-assets/images/piano/cooking.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\repos\piano_local\piano_local\Areas\SuperAdmin\Views\Staff\StaffOrders.cshtml"
  
    Layout = "~/Areas/SuperAdmin/Views/Shared/_Layout.cshtml";

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
            <div class=""col-lg-8 col-sm-12 col-12"">
                <div class=""card"">
                    <div class=""body"">
                        <table id=""table-1"" class=""table js-basic-example dataTable table-responsive"">
                            <thead class=""no-wrap"">
                                <tr>
                                    <th>Order Id</th>
                                    <th>Email</th>
                                    <th data-breakpoints=""sm xs"">Datetime</th>
                                    <th data-breakpoints=""sm xs"">Amount</th>
                                    <th>Products Detail</th>
                                    <th>Elapsed Time</th>
   ");
            WriteLiteral("                                 <th>Start Time</th>\r\n                                    <th>End Time</th>\r\n                                </tr>\r\n                            </thead>\r\n\r\n                            <tbody class=\"no-wrap\">\r\n");
#nullable restore
#line 35 "D:\repos\piano_local\piano_local\Areas\SuperAdmin\Views\Staff\StaffOrders.cshtml"
                                 if (Model.OrderDetails != null)
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "D:\repos\piano_local\piano_local\Areas\SuperAdmin\Views\Staff\StaffOrders.cshtml"
                                     foreach (var i in Model.OrderDetails)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr data-row=\"1\">\r\n                                            <td class=\"align-middle\">#");
#nullable restore
#line 40 "D:\repos\piano_local\piano_local\Areas\SuperAdmin\Views\Staff\StaffOrders.cshtml"
                                                                 Write(i.OrderId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td class=\"align-middle\">");
#nullable restore
#line 41 "D:\repos\piano_local\piano_local\Areas\SuperAdmin\Views\Staff\StaffOrders.cshtml"
                                                                Write(i.UserEmail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td class=\"align-middle\">");
#nullable restore
#line 42 "D:\repos\piano_local\piano_local\Areas\SuperAdmin\Views\Staff\StaffOrders.cshtml"
                                                                Write(i.CreatedAt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td class=\"align-middle\">$");
#nullable restore
#line 43 "D:\repos\piano_local\piano_local\Areas\SuperAdmin\Views\Staff\StaffOrders.cshtml"
                                                                 Write(i.TotalPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td class=\"align-middle text-center\">\r\n                                                <a class=\"description\" style=\"cursor:pointer\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2190, "\"", 2225, 3);
            WriteAttributeValue("", 2200, "GetProductsDetails(", 2200, 19, true);
#nullable restore
#line 45 "D:\repos\piano_local\piano_local\Areas\SuperAdmin\Views\Staff\StaffOrders.cshtml"
WriteAttributeValue("", 2219, i.Id, 2219, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2224, ")", 2224, 1, true);
            EndWriteAttribute();
            WriteLiteral(">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "689d9362a061cbb8361614f45137988e9fe9ac948915", async() => {
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
            WriteLiteral("</a>\r\n                                            </td>\r\n                                            <td class=\"align-middle\">");
#nullable restore
#line 47 "D:\repos\piano_local\piano_local\Areas\SuperAdmin\Views\Staff\StaffOrders.cshtml"
                                                                Write(i.ElaspedTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td class=\"align-middle\">");
#nullable restore
#line 48 "D:\repos\piano_local\piano_local\Areas\SuperAdmin\Views\Staff\StaffOrders.cshtml"
                                                                Write(i.StartTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td class=\"align-middle\">");
#nullable restore
#line 49 "D:\repos\piano_local\piano_local\Areas\SuperAdmin\Views\Staff\StaffOrders.cshtml"
                                                                Write(i.EndTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        </tr>\r\n");
#nullable restore
#line 51 "D:\repos\piano_local\piano_local\Areas\SuperAdmin\Views\Staff\StaffOrders.cshtml"
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "D:\repos\piano_local\piano_local\Areas\SuperAdmin\Views\Staff\StaffOrders.cshtml"
                                     
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
            <div class=""col-lg-4 col-sm-12 col-12"">
                <div class=""w-100"">
                    <a class=""card info-box-2 hover-zoom-effect twitter-widget"">
                        <div class=""icon"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "689d9362a061cbb8361614f45137988e9fe9ac9412073", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"content mb-2\">\r\n                            <div class=\"number\">\r\n                                ");
#nullable restore
#line 66 "D:\repos\piano_local\piano_local\Areas\SuperAdmin\Views\Staff\StaffOrders.cshtml"
                           Write(Model.TotalOrders);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""text"">Total Orders</div>
                            </div>
                        </div>
                    </a>
                </div>

                <div class=""w-100 mt-43"">
                    <a class=""card info-box-2 hover-zoom-effect twitter-widget"">
                        <div class=""icon"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "689d9362a061cbb8361614f45137988e9fe9ac9414057", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"content mb-2\">\r\n                            <div class=\"number\">");
#nullable restore
#line 78 "D:\repos\piano_local\piano_local\Areas\SuperAdmin\Views\Staff\StaffOrders.cshtml"
                                           Write(Model.InProcessOrder);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div><div class=""text"">In-process Orders</div>
                        </div>
                    </a>
                </div>

                <div class=""w-100 mt-43"">
                    <a class=""card info-box-2 hover-zoom-effect twitter-widget"">
                        <div class=""icon"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "689d9362a061cbb8361614f45137988e9fe9ac9415999", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"content mb-2\">\r\n                            <div class=\"number\">");
#nullable restore
#line 89 "D:\repos\piano_local\piano_local\Areas\SuperAdmin\Views\Staff\StaffOrders.cshtml"
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
                </div>
            </div>
        </div><!-- /.modal -->
    </div>
</section>

<script>
    $(""[data-toggle='tooltip']");
            WriteLiteral(@""").tooltip();
    $('#staff').addClass('toggled');
</script>
<script>
    function GetProductsDetails(Id) {
        var response = getResponseFromUrl2('Get', '/receptionist/orders/GetProducts?Id=' + Id, null, false);
        response = response.responseJSON;
        if (response.code == 200) {
            var result = response.result;
            if (result.length > 0) {
                $('#AppendProducts').html("""");
                result.forEach(function (doc) {
                    var data = doc;
                    console.log(""list"", data.ingredientList);
                    var s = """";
                    data.ingredientList.forEach(function (item) {
                        s += `<div class=""flex-row"">
                                            <small class=""text-muted""><b><i class=""fas fa-circle font-8 mr-2""></i>${item.ingredientName}: </b></small> <small style=""float: right;"" class=""ml-2"">${item.quantity} Qty</small>
                                        </div>`;
                ");
            WriteLiteral(@"    });
                    var product = `<div class=""col-12"">
                            <div class=""card project_widget p-1"">
                                <div class=""d-flex"">
                                    <img class=""img-responsive"" width=""70"" height=""70"" src=""${data.productImage}"" alt=""About the image"">
                                    <div class=""ml-3 mt-2"">
                                        <p class=""mb-0"">${data.productName}</p>
                                        ${s}
                                    </div>
                                    <div class=""ml-auto"">
                                        <span>${data.quantity} Qty</span>
                                    </div>
                                </div>
                            </div>
                        </div>`;
                    $('#AppendProducts').append(product);
                })
                $('#PrdDtls').modal(""show"");
            }
        }
        else {
            ");
            WriteLiteral(@"console.log(response);
            sweetMessage(""Error!"", response.shortMessage + ""<br>"" + response.result, ""error"");
        }
    }
</script>
<!--Ajax-->
<script>
    var getResponseFromUrl2 = function (requestType, requestUrl, requestData, async) {
        var response;
        return $.ajax({
            type: requestType,
            url: requestUrl,
            data: requestData,
            async: false,
            processData: false,
            contentType: false,
            success: function (data) {
                response = data;
            },
            error: function (error) {
                return error;
            },
        });
        return response;
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Entities.GetStaffStatsAndCompletedOrders> Html { get; private set; }
    }
}
#pragma warning restore 1591
