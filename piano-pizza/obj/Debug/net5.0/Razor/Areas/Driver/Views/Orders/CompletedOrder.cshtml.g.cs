#pragma checksum "D:\repos\piano-pizza\piano-pizza\Areas\Driver\Views\Orders\CompletedOrder.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d663bda77e62581eed05e738bd18fbf8e39f6ba6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Driver_Views_Orders_CompletedOrder), @"mvc.1.0.view", @"/Areas/Driver/Views/Orders/CompletedOrder.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d663bda77e62581eed05e738bd18fbf8e39f6ba6", @"/Areas/Driver/Views/Orders/CompletedOrder.cshtml")]
    public class Areas_Driver_Views_Orders_CompletedOrder : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Entities.GetOrderdetails>>
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
#line 2 "D:\repos\piano-pizza\piano-pizza\Areas\Driver\Views\Orders\CompletedOrder.cshtml"
  
    Layout = "~/Areas/Driver/Views/Shared/_Layout.cshtml";

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
                        <div>

                        </div>
                    </div>
                    <div class=""body"">
                        <div");
            BeginWriteAttribute("class", " class=\"", 744, "\"", 752, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            <table id=""table-1"" class=""table js-basic-example dataTable table-responsive"">
                                <thead class=""no-wrap"">
                                    <tr>
                                        <th>Order Id</th>
                                        <th>Email</th>
                                        <th data-breakpoints=""sm xs"">Datetime</th>
                                        <th data-breakpoints=""sm xs"">Amount</th>
                                        <th>Products Detail</th>
                                        <th>Elapsed Time</th>
                                        <th>Start Time</th>
                                        <th>End Time</th>
                                    </tr>
                                </thead>

                                <tbody class=""no-wrap"">
");
#nullable restore
#line 42 "D:\repos\piano-pizza\piano-pizza\Areas\Driver\Views\Orders\CompletedOrder.cshtml"
                                     foreach (var i in Model)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr data-row=\"1\">\r\n                                            <td class=\"align-middle\">#");
#nullable restore
#line 45 "D:\repos\piano-pizza\piano-pizza\Areas\Driver\Views\Orders\CompletedOrder.cshtml"
                                                                 Write(i.OrderId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td class=\"align-middle\">");
#nullable restore
#line 46 "D:\repos\piano-pizza\piano-pizza\Areas\Driver\Views\Orders\CompletedOrder.cshtml"
                                                                Write(i.UserEmail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td class=\"align-middle\">");
#nullable restore
#line 47 "D:\repos\piano-pizza\piano-pizza\Areas\Driver\Views\Orders\CompletedOrder.cshtml"
                                                                Write(i.CreatedAt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td class=\"align-middle\">$");
#nullable restore
#line 48 "D:\repos\piano-pizza\piano-pizza\Areas\Driver\Views\Orders\CompletedOrder.cshtml"
                                                                 Write(i.TotalPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td class=\"align-middle text-center\">\r\n                                                <a class=\"description\" style=\"cursor:pointer\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2327, "\"", 2362, 3);
            WriteAttributeValue("", 2337, "GetProductsDetails(", 2337, 19, true);
#nullable restore
#line 50 "D:\repos\piano-pizza\piano-pizza\Areas\Driver\Views\Orders\CompletedOrder.cshtml"
WriteAttributeValue("", 2356, i.Id, 2356, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2361, ")", 2361, 1, true);
            EndWriteAttribute();
            WriteLiteral(">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d663bda77e62581eed05e738bd18fbf8e39f6ba67843", async() => {
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
#line 52 "D:\repos\piano-pizza\piano-pizza\Areas\Driver\Views\Orders\CompletedOrder.cshtml"
                                                                Write(i.ElaspedTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td class=\"align-middle\">");
#nullable restore
#line 53 "D:\repos\piano-pizza\piano-pizza\Areas\Driver\Views\Orders\CompletedOrder.cshtml"
                                                                Write(i.StartTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td class=\"align-middle\">");
#nullable restore
#line 54 "D:\repos\piano-pizza\piano-pizza\Areas\Driver\Views\Orders\CompletedOrder.cshtml"
                                                                Write(i.EndTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        </tr>\r\n");
#nullable restore
#line 56 "D:\repos\piano-pizza\piano-pizza\Areas\Driver\Views\Orders\CompletedOrder.cshtml"
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
                            <span aria-hidden=""true"">×</span>
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
                                    <tr><th colspan=""4"">Total Bill</th><th rowspan=""1"" colspan=""1"" id=""TotalPrice"">$</th></tr>
                                </tfoot>
                            </table>
                        </div>
                    </div>
                </div>
            </div><!-- /.modal -->
 ");
            WriteLiteral(@"       </div>
        <!-- #END# Exportable Table -->
        <div class=""modal fade bs-example-modal-md mt-5"" id=""des"" tabindex=""-1"" role=""dialog"" aria-labelledby=""des"" aria-hidden=""true"">
            <div class=""modal-dialog modal-md"">
                <div class=""modal-content"">
                    <div class=""modal-header"">
                        <h5 class=""modal-title"" id=""formModal"">Details</h5>
                        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                            <span aria-hidden=""true"">×</span>
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
            </div>");
            WriteLiteral(@"<!-- /.modal -->
        </div>

        <div class=""modal fade bs-example-modal-md mt-5"" id=""ingredients"" tabindex=""-1"" role=""dialog"" aria-labelledby=""ingredients"" aria-hidden=""true"">
            <div class=""modal-dialog modal-md"">
                <div class=""modal-content"">
                    <div class=""modal-header"">
                        <h5 class=""modal-title"" id=""formModal"">Ingredients</h5>
                        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                            <span aria-hidden=""true"">×</span>
                        </button>
                    </div>
                    <div class=""modal-body"">
                        <div class=""row"" id=""IngredientsBody"">

                        </div>
                    </div>
                </div><!-- /.modal -->
            </div>
        </div>

    </div>
</section>
<script>
    $(function () {
        $('#table-1').DataTable({
            ""aaSorting"": [],
        });
 ");
            WriteLiteral(@"   })
</script>
<script>
    function GetProductsDetails(Id) {
        var response = getResponseFromUrl('Get', '/Driver/Orders/GetProducts?Id=' + Id, null, false);
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
                        s += `<input type=""hidden"" data-product=""${data.productId}"" id=""n-${srCount}-${data.product");
            WriteLiteral(@"Id}"" value=""${item.ingredientName}"">`;
                        s += `<input type=""hidden"" data-product=""${data.productId}"" id=""q-${srCount}-${data.productId}"" value=""${item.quantity}"">`;
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
                     ");
            WriteLiteral(@"                       </a>`;
                    }
                    else {
                        var ingredients = 0;
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
            var pri");
            WriteLiteral(@"ce = $('#p-' + i + ""-"" + productId).val();
            var quantity = $('#q-' + i + ""-"" + productId).val();
            var name = $('#n-' + i + ""-"" + productId).val();

            $('#IngredientsBody').append(` <div class=""col-md-12"">
                                <label>${name}:</label><span class=""float-right"">${price} (${quantity})</span>
                            </div>`);
        }
        $('#ingredients').modal('show');
    }

</script>
<!--Ajax-->
<script>
    var getResponseFromUrl = function (requestType, requestUrl, requestData, async) {
        var response;
        $.ajax({
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
    }");
            WriteLiteral("\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Entities.GetOrderdetails>> Html { get; private set; }
    }
}
#pragma warning restore 1591
