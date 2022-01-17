#pragma checksum "D:\repos\piano-pizza\piano-pizza\Areas\Receptionist\Views\Orders\Payment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "10ff0bc5fc276723a864bb10a64b3c0b1e00f58d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Receptionist_Views_Orders_Payment), @"mvc.1.0.view", @"/Areas/Receptionist/Views/Orders/Payment.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"10ff0bc5fc276723a864bb10a64b3c0b1e00f58d", @"/Areas/Receptionist/Views/Orders/Payment.cshtml")]
    public class Areas_Receptionist_Views_Orders_Payment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("rounded shadow"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/images/sm/avatar1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("35"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/images/sm/avatar1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/images/piano/Bg-transparent/Page-2-Image-14-removebg-preview.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/images/piano/Bg-transparent/Ingredient-removebg-preview.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\repos\piano-pizza\piano-pizza\Areas\Receptionist\Views\Orders\Payment.cshtml"
  
    ViewBag.Title = "Payment";
    Layout = "~/Areas/Receptionist/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""content"">
    <div class=""block-header"">
        <div class=""row"">
            <div class=""col-12"">
                <h2>
                    Payments Detail
                </h2>
            </div>
        </div>
    </div>
    <div class=""container-fluid"">

        <!-- Exportable Table -->
        <div class=""row clearfix"">
            <div class=""col-lg-12"">
                <div class=""card"">

                    <div class=""body"">
                        <div class=""table-responsive"">
                            <table class=""table js-basic-example dataTable"">
                                <thead class=""no-wrap"">
                                    <tr>
                                        <th>Payment Id</th>
                                        <th>Order Id</th>
                                        <th>Name</th>
                                        <th>Email</th>
                                        <th>Phone</th>
                             ");
            WriteLiteral(@"           <th>Products Detail</th>
                                        <th data-breakpoints=""sm xs"">Payment Method</th>
                                        <th data-breakpoints=""sm xs"">Amount</th>
                                        <th data-breakpoints=""sm xs"">Datetime</th>

                                    </tr>
                                </thead>

                                <tbody class=""no-wrap"">

                                    <tr>
                                        <td>#pay123</td>
                                        <td>#123456</td>
                                        <td>
                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "10ff0bc5fc276723a864bb10a64b3c0b1e00f58d6974", async() => {
                WriteLiteral("\r\n                                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "10ff0bc5fc276723a864bb10a64b3c0b1e00f58d7277", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

                                            <span class=""w-space-no ml-2"">John Doe</span>
                                        </td>
                                        <td>john@gmail.com</td>
                                        <td>#92 ##########</td>

                                        <td class=""align-middle text-center"">
                                            <a class=""description"" style=""cursor:pointer"" data-toggle=""modal"" data-target=""#PrdDtls"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "10ff0bc5fc276723a864bb10a64b3c0b1e00f58d9895", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</a>
                                        </td>
                                        <td class=""align-middle"">
                                            <span><i class=""fas fa-money-bill-alt mr-1"" style=""color:#15aabf""></i>Cash</span>
                                        </td>

                                        <td class=""align-middle"">$16.00</td>
                                        <td class=""align-middle"">20 Sept 2021 12:00 PM</td>

                                    </tr>
                                    <tr>
                                        <td>#pay456</td>

                                        <td>#123456</td>
                                        <td>
                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "10ff0bc5fc276723a864bb10a64b3c0b1e00f58d11777", async() => {
                WriteLiteral("\r\n                                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "10ff0bc5fc276723a864bb10a64b3c0b1e00f58d12081", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

                                            <span class=""w-space-no ml-2"">John Doe</span>
                                        </td>

                                        <td>john@gmail.com</td>
                                        <td>#92 ##########</td>

                                        <td class=""align-middle text-center"">
                                            <a class=""description"" style=""cursor:pointer"" data-toggle=""modal"" data-target=""#PrdDtls"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "10ff0bc5fc276723a864bb10a64b3c0b1e00f58d14702", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</a>
                                        </td>

                                        <td class=""align-middle"">
                                            <span><i class=""fab fa-cc-visa mr-1"" style=""color:#15aabf""></i> Visa Card</span>
                                        </td>
                                        <td class=""align-middle"">$16.00</td>
                                        <td class=""align-middle"">20 Sept 2021 12:00 PM</td>

                                    </tr>



                                </tbody>
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
                ");
            WriteLiteral(@"        <h5 class=""modal-title"" id=""formModal"">Products Detail</h5>
                        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                            <span aria-hidden=""true"">×</span>
                        </button>
                    </div>
                    <div class=""modal-body"">
                        <div class=""table-responsive"">
                            <table class=""table js-basic-example dataTable"">
                                <thead class=""text-center no-wrap"">
                                    <tr>
                                        <th>Image</th>
                                        <th>Product Name</th>
                                        <th data-breakpoints=""sm xs"">Detail</th>
                                        <th data-breakpoints=""sm xs"">Ingredients</th>
                                        <th data-breakpoints=""xs"">Quantity</th>
                                        <th data-breakpoints=""xs"">A");
            WriteLiteral(@"mount</th>
                                    </tr>
                                </thead>

                                <tbody class=""text-center no-wrap"">

                                    <tr>
                                        <td class=""align-middle"">
                                            <a href=""/assets/images/piano/Page-1-Image-1.png"" target=""_blank""> <img src=""/assets/images/piano/Page-1-Image-1.png"" height=""30""> </a>
                                        </td>
                                        <td class=""align-middle""><h6>Lazania Pizza</h6></td>
                                        <td class=""align-middle"">
                                            <a class=""btn-sm btn-primary description"" data-toggle=""modal"" data-target=""#des""><i class=""zmdi zmdi-eye text-white""></i></a>
                                        </td>
                                        <td class=""align-middle"">
                                            <a class=""ingredients"" styl");
            WriteLiteral("e=\"cursor:pointer\" data-toggle=\"modal\" data-target=\"#ingredients\">\r\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "10ff0bc5fc276723a864bb10a64b3c0b1e00f58d19190", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                            </a>
                                        </td>
                                        <td class=""align-middle text-center"">2</td>
                                        <td class=""align-middle"">$16.00</td>

                                    </tr>
                                    <tr>
                                        <td class=""align-middle"">
                                            <a href=""/assets/images/piano/Page-1-Image-1.png""> <img src=""/assets/images/piano/Page-1-Image-1.png"" height=""30""> </a>
                                        </td>
                                        <td class=""align-middle""><h6>Kabab Pizza</h6></td>
                                        <td class=""align-middle"">
                                            <a class=""btn-sm btn-primary description"" data-toggle=""modal"" data-target=""#des""><i class=""zmdi zmdi-eye text-white""></i></a>
                                        </td>
                   ");
            WriteLiteral("                     <td class=\"align-middle\">\r\n                                            <a class=\"ingredients\" style=\"cursor:pointer\" data-toggle=\"modal\" data-target=\"#ingredients\">\r\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "10ff0bc5fc276723a864bb10a64b3c0b1e00f58d21629", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                            </a>
                                        </td>
                                        <td class=""align-middle text-center"">1</td>
                                        <td class=""align-middle"">$15.00</td>
                                    </tr>

                                </tbody>
                                <tfoot>
                                    <tr><th rowspan=""1"" colspan=""5"">Total Bill</th><th rowspan=""1"" colspan=""1"" class=""text-center"">$31.00</th></tr>
                                </tfoot>
                            </table>
                        </div>
                    </div>
                </div>
            </div><!-- /.modal -->
        </div>
    </div>

    <div class=""modal fade bs-example-modal-md mt-5"" id=""des"" tabindex=""-1"" role=""dialog"" aria-labelledby=""des"" aria-hidden=""true"">
        <div class=""modal-dialog modal-md"">
            <div class=""modal-content"">
                <div class=""modal-he");
            WriteLiteral(@"ader"">
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
        </div><!-- /.modal -->
    </div>

    <div class=""modal fade bs-example-modal-md mt-5"" id=""ingredients"" tabindex=""-1"" role=""dialog"" aria-labelledby=""ingredients"" aria-hidden=""true"">
        <div class=""modal-dialog modal-md"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"" id=""formModal"">Ingredients</");
            WriteLiteral(@"h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">×</span>
                    </button>
                </div>
                <div class=""modal-body"">
                    <div class=""row"">
                        <div class=""col-md-12"">
                            <label>Extra Topping:</label><span class=""float-right"">$25</span>
                        </div>
                        <div class=""col-md-12"">
                            <label>Extra Topping:</label><span class=""float-right"">$25</span>
                        </div>
                        <div class=""col-md-12"">
                            <label>Extra Topping:</label><span class=""float-right"">$25</span>
                        </div>
                    </div>

                </div>
            </div>
        </div><!-- /.modal -->
    </div>
</section>

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
