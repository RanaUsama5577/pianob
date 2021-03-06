#pragma checksum "D:\repos\piano-pizza\piano-pizza\Areas\SuperAdmin\Views\Order\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f5cfb835fce77c1d779438bc91fb677bbde558d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_SuperAdmin_Views_Order_Detail), @"mvc.1.0.view", @"/Areas/SuperAdmin/Views/Order/Detail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f5cfb835fce77c1d779438bc91fb677bbde558d", @"/Areas/SuperAdmin/Views/Order/Detail.cshtml")]
    public class Areas_SuperAdmin_Views_Order_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Entities.GetOrderdetails>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin-assets/images/piano/Bg-transparent/Page-2-Image-14-removebg-preview.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("35"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\repos\piano-pizza\piano-pizza\Areas\SuperAdmin\Views\Order\Detail.cshtml"
  
    ViewBag.Title = "Detail";
    Layout = "~/Areas/SuperAdmin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<section class=""content"">
    <div class=""block-header"">
        <div class=""row"">
            <div class=""col-12"">
                <h2>
                    Orders Detail
                </h2>
            </div>
        </div>
    </div>
    <div class=""container-fluid"">
        <!-- Exportable Table -->
        <div class=""row clearfix"">
            <div class=""col-lg-12"">
                <div class=""card"">
                    <div class=""header"">
                        <h3>Completed Orders</h3>
                    </div>
                    <div class=""body"">
                        <div");
            BeginWriteAttribute("class", " class=\"", 822, "\"", 830, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            <table id=""table-1"" class=""table js-basic-example dataTable table-responsive"">
                                <thead class=""no-wrap"">
                                    <tr>
                                        <th>Order Id</th>
                                        <th>Customer Email</th>
                                        <th>Branch</th>
                                        <th>Staff Reports</th>
                                        <th>Products Detail</th>
                                        <th data-breakpoints=""sm xs"">Datetime</th>
                                        <th data-breakpoints=""sm xs"">Amount</th>
                                        <th>Customer Name</th>
                                        <th>Phone</th>
                                    </tr>
                                </thead>
                                <tbody class=""no-wrap"">
");
#nullable restore
#line 42 "D:\repos\piano-pizza\piano-pizza\Areas\SuperAdmin\Views\Order\Detail.cshtml"
                                     foreach (var i in Model)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr data-row=\"7\">\r\n                                        <td>#");
#nullable restore
#line 45 "D:\repos\piano-pizza\piano-pizza\Areas\SuperAdmin\Views\Order\Detail.cshtml"
                                        Write(i.OrderId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 46 "D:\repos\piano-pizza\piano-pizza\Areas\SuperAdmin\Views\Order\Detail.cshtml"
                                       Write(i.UserEmail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 47 "D:\repos\piano-pizza\piano-pizza\Areas\SuperAdmin\Views\Order\Detail.cshtml"
                                       Write(i.BranchName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td class=\"align-middle text-center\">\r\n                                            <a class=\"description\" style=\"cursor:pointer\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2294, "\"", 2322, 3);
            WriteAttributeValue("", 2304, "UserReports(", 2304, 12, true);
#nullable restore
#line 49 "D:\repos\piano-pizza\piano-pizza\Areas\SuperAdmin\Views\Order\Detail.cshtml"
WriteAttributeValue("", 2316, i.Id, 2316, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2321, ")", 2321, 1, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fas fa-user-clock\"></i></a>\r\n                                        </td>\r\n                                        <td class=\"align-middle text-center\">\r\n                                            <a class=\"description\" style=\"cursor:pointer\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2578, "\"", 2613, 3);
            WriteAttributeValue("", 2588, "GetProductsDetails(", 2588, 19, true);
#nullable restore
#line 52 "D:\repos\piano-pizza\piano-pizza\Areas\SuperAdmin\Views\Order\Detail.cshtml"
WriteAttributeValue("", 2607, i.Id, 2607, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2612, ")", 2612, 1, true);
            EndWriteAttribute();
            WriteLiteral(">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5f5cfb835fce77c1d779438bc91fb677bbde558d8112", async() => {
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
            WriteLiteral("</a>\r\n                                        </td>\r\n                                        <td class=\"align-middle\">");
#nullable restore
#line 54 "D:\repos\piano-pizza\piano-pizza\Areas\SuperAdmin\Views\Order\Detail.cshtml"
                                                            Write(i.CreatedAt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td class=\"align-middle\">$");
#nullable restore
#line 55 "D:\repos\piano-pizza\piano-pizza\Areas\SuperAdmin\Views\Order\Detail.cshtml"
                                                             Write(i.TotalPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>\r\n                                            <span class=\"w-space-no ml-2\">");
#nullable restore
#line 57 "D:\repos\piano-pizza\piano-pizza\Areas\SuperAdmin\Views\Order\Detail.cshtml"
                                                                     Write(i.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                        </td>\r\n                                        <td>");
#nullable restore
#line 59 "D:\repos\piano-pizza\piano-pizza\Areas\SuperAdmin\Views\Order\Detail.cshtml"
                                       Write(i.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    </tr>\r\n");
#nullable restore
#line 61 "D:\repos\piano-pizza\piano-pizza\Areas\SuperAdmin\Views\Order\Detail.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </tbody>
                            </table>
                        </div>
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
                            <span aria-hidden=""true"">??</span>
                        </button>
                    </div>
                    <div class=""modal-body"">
                        <div class=""table-responsive"">
                            <table id=""table-2"" class=""table js-basic-example dataTable"">
                               ");
            WriteLiteral(@" <thead class=""no-wrap"">
                                    <tr>
                                        <th>Image</th>
                                        <th>Product Name</th>
                                        <th data-breakpoints=""sm xs"" class=""text-center"">Ingredients</th>
                                        <th data-breakpoints=""xs"">Quantity</th>
                                        <th data-breakpoints=""xs"">Amount</th>
                                    </tr>
                                </thead>
                                <tbody id=""dataTable2"" class=""no-wrap"">
                                </tbody>
                                <tfoot>
                                    <tr><th colspan=""4"">Total Bill</th><th rowspan=""1"" colspan=""1"" id=""TotalPrice"">$31.00</th></tr>
                                </tfoot>
                            </table>
                        </div>
                    </div>
                </div>
            </div><!-- /.modal -");
            WriteLiteral(@"->
        </div>
        <!-- #END# Exportable Table -->
        <div class=""modal fade bs-example-modal-md mt-5"" id=""des"" tabindex=""-1"" role=""dialog"" aria-labelledby=""des"" aria-hidden=""true"">
            <div class=""modal-dialog modal-md"">
                <div class=""modal-content"">
                    <div class=""modal-header"">
                        <h5 class=""modal-title"" id=""formModal"">Details</h5>
                        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                            <span aria-hidden=""true"">??</span>
                        </button>
                    </div>
                    <div class=""modal-body"">
                        <div class=""row"">
                            <div class=""col-md-12"">
                                <textarea readonly class=""w-100 border-0""> Sample Details</textarea>
                            </div>
                        </div>

                    </div>
                </div>
            <");
            WriteLiteral(@"/div><!-- /.modal -->
        </div>

        <div class=""modal fade bs-example-modal-md mt-5"" id=""ingredients"" tabindex=""-1"" role=""dialog"" aria-labelledby=""ingredients"" aria-hidden=""true"">
            <div class=""modal-dialog modal-md"">
                <div class=""modal-content"">
                    <div class=""modal-header"">
                        <h5 class=""modal-title"" id=""formModal"">Ingredients</h5>
                        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                            <span aria-hidden=""true"">??</span>
                        </button>
                    </div>
                    <div class=""modal-body"">
                        <div class=""row"" id=""IngredientsBody"">

                        </div>
                    </div>
                </div><!-- /.modal -->
            </div>
        </div>
        <div class=""modal fade bs-example-modal-md mt-5"" id=""StaffDtls"" tabindex=""-1"" role=""dialog"" aria-labelledby=""PrdDtls"" aria-");
            WriteLiteral(@"hidden=""true"">
            <div class=""modal-dialog modal-lg"">
                <div class=""modal-content"">
                    <div class=""modal-header"">
                        <h5 class=""modal-title"" id=""formModal"">Staff Reports</h5>
                        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                            <span aria-hidden=""true"">??</span>
                        </button>
                    </div>
                    <div class=""modal-body"">
                        <div");
            BeginWriteAttribute("class", " class=\"", 7916, "\"", 7924, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            <table id=""table-3"" class=""table js-basic-example dataTable table-responsive"">
                                <thead class=""no-wrap"">
                                    <tr>
                                        <th>Email</th>
                                        <th data-breakpoints=""xs"">Start Time</th>
                                        <th data-breakpoints=""xs"">End Time</th>
                                        <th data-breakpoints=""xs"">Elapsed Time</th>
                                    </tr>
                                </thead>
                                <tbody id=""dataTable3"" class=""no-wrap"">
                                </tbody>
                            </table>
                        </div>
                    </div>
                </div>
            </div><!-- /.modal -->
        </div>
    </div>
</section>
<script>
    function GetProductsDetails(Id) {
        var response = getResponseFromUrl('Get', '/superadmin/");
            WriteLiteral(@"Order/GetProducts?Id=' + Id, null, false);
        response = response.responseJSON;
        if (response.code == 200) {
            var result = response.result;
            var count = 0;
            if (result.length > 0) {
                $(""#table-2"").DataTable().destroy();
                $(""#dataTable2"").html('');
                var price = 0;
                result.forEach(function (doc) {
                    count++;
                    var data = doc;
                    console.log(""list"", data.ingredientList);
                    var s = """";
                    var srCount = 0;
                    data.ingredientList.forEach(function (item) {
                        s += `<input type=""hidden"" data-product=""${data.productId}"" id=""p-${srCount}-${data.productId}"" value=""${item.price}"">`;
                        s += `<input type=""hidden"" data-product=""${data.productId}"" id=""n-${srCount}-${data.productId}"" value=""${item.ingredientName}"">`;
                        s += `<input type=""");
            WriteLiteral(@"hidden"" data-product=""${data.productId}"" id=""q-${srCount}-${data.productId}"" value=""${item.quantity}"">`;
                        srCount++;
                    })

                    var image = `<div class=""image-link"">
                                    <a class=""image-popup-vertical-fit"" href=""${data.productImage}"">
                        <img class=""img-responsive thumbnail"" src =""${data.productImage}"" width=""35"" height=""30"">
                                    </a>
                                </div>`;
                    if (data.ingredientList.length != 0) {
                        var ingredients = `<a class=""ingredients"" style=""cursor:pointer"" onclick=""GetProductsIngredients(${data.productId},${data.ingredientList.length},this)"">
                                                <img src=""/admin-assets/images/piano/Bg-transparent/Page-2-Image-14-removebg-preview.png"" height=""35"" />
                                            </a>`;
                    }
                    else {
 ");
            WriteLiteral(@"                       var ingredients = 0;
                    }
                    var row = '<tr><td>' + image + '</td><td>' + data.productName + '</td><td  class=""text-center"">' + ingredients + s + '</td><td>' + data.quantity + '</td><td>$' + data.total_price + '</td></tr>';
                    price += data.total_price;
                    $('#dataTable2').append(row);
                })
                $('#TotalPrice').html(""$"" + price);
                $('#table-2').DataTable();
                $('#PrdDtls').modal(""show"");
            }
        }
        else {
            console.log(response);
            sweetMessage(""Error!"", response.shortMessage + ""<br>"" + response.result, ""error"");
        }
    }
    function GetProductsIngredients(productId, num, element) {
        console.log(productId, num);
        $('#IngredientsBody').html("""");
        for (var i = 0; i < num; i++) {
            var price = $('#p-' + i + ""-"" + productId).val();
            var quantity = $('#q-' + i ");
            WriteLiteral(@"+ ""-"" + productId).val();
            var name = $('#n-' + i + ""-"" + productId).val();

            $('#IngredientsBody').append(` <div class=""col-md-12"">
                                <label>${name}:</label><span class=""float-right"">${price} (${quantity})</span>
                            </div>`);
        }
        $('#ingredients').modal('show');
    }
</script>
<script>
    function UserReports(Id) {
        var response = getResponseFromUrl('Get', '/superadmin/Order/UserReports?Id=' + Id, null, false);
        response = response.responseJSON;
        if (response.code == 200) {
            var result = response.result;
            if (result.length > 0) {
                $(""#table-3"").DataTable().destroy();
                $(""#dataTable3"").html('');
                result.forEach(function (doc) {
                    var data = doc;

                    var image = `<div class=""image-link"">
                                    <a class=""image-popup-vertical-fit"" href=""${data.staf");
            WriteLiteral(@"fImage}"">
                        <img class=""img-responsive thumbnail"" src =""${data.staffImage}"" width=""35"" height=""30"">
                                    </a>
                                </div>`;
                    var row = '<tr><td>' + data.staffEmail + '</td><td>' + data.startTime + '</td><td>' + data.endTime + '</td><td>' + data.minutesSpent + '</td></tr>';
                    $('#dataTable3').append(row);
                })
                $('#table-3').DataTable();
                $('#StaffDtls').modal(""show"");
            }
            else {
                sweetMessage(""Error!"", ""No reports found"", ""error"");
            }
        }
        else {
            console.log(response);
            sweetMessage(""Error!"", response.shortMessage + ""<br>"" + response.result, ""error"");
        }
    }
</script>
<!--Ajax-->
<script>
    var getResponseFromUrl = function (requestType, requestUrl, requestData, async) {
        var response;
        return $.ajax({
            type:");
            WriteLiteral(@" requestType,
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Entities.GetOrderdetails>> Html { get; private set; }
    }
}
#pragma warning restore 1591
