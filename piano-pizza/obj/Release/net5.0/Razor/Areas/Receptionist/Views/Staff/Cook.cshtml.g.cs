#pragma checksum "D:\repos\piano-pizza\piano-pizza\Areas\Receptionist\Views\Staff\Cook.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d1e2856b4cdde8bf9de1f969abf979909501cb36"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Receptionist_Views_Staff_Cook), @"mvc.1.0.view", @"/Areas/Receptionist/Views/Staff/Cook.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d1e2856b4cdde8bf9de1f969abf979909501cb36", @"/Areas/Receptionist/Views/Staff/Cook.cshtml")]
    public class Areas_Receptionist_Views_Staff_Cook : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 2 "D:\repos\piano-pizza\piano-pizza\Areas\Receptionist\Views\Staff\Cook.cshtml"
  
    ViewBag.Title = "Cook";
    Layout = "~/Areas/Receptionist/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<section class=""content"">
    <div class=""block-header"">
        <div class=""row"">
            <div class=""col-12"">
                <h5>Cook Detail</h5>
            </div>
        </div>
    </div>
    <div class=""container-fluid"">

        <!-- Exportable Table -->
        <div class=""row clearfix"">
            <div class=""col-lg-12"">
                <div class=""card"">
                    <div class=""header"">

                        <a href=""/Receptionist/Staff/AddCook"" class=""btn-sm btn-primary text-white "" style=""cursor:pointer"">Add Cook</a>
                    </div>
                    <div class=""body"">
                        <div class=""table-responsive"">
                            <table class=""table table-bordered  js-basic-example dataTable"">
                                <thead style=""white-space:nowrap"">
                                    <tr>
                                        <th>
                                            #Sr
                            ");
            WriteLiteral(@"            </th>
                                        <th>Name</th>
                                        <th>Gender</th>
                                        <th>Email</th>
                                        <th>Phone Number</th>
                                        <th class=""text-center"">Assigned Orders</th>
                                        <th>Joining Date</th>
                                        <th>Status</th>
                                    </tr>
                                </thead>

                                <tbody style=""white-space:nowrap"">

                                    <tr>
                                        <td>
                                            1
                                        </td>

                                        <td>
                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d1e2856b4cdde8bf9de1f969abf979909501cb367149", async() => {
                WriteLiteral("\r\n                                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d1e2856b4cdde8bf9de1f969abf979909501cb367452", async() => {
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
                                        <td>Male</td>
                                        <td>
                                            <div> John@gmail.com</div>
                                        </td>
                                        <td>+92 000 0000000</td>
                                        <td class=""align-middle text-center"">
                                            <a class=""description"" style=""cursor:pointer"" data-toggle=""modal"" data-target=""#OrderDtls"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d1e2856b4cdde8bf9de1f969abf979909501cb3610228", async() => {
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
                                        <td>20 Sept 2012</td>
                                        <td>
                                            <div class=""badge badge-success badge-shadow badge_width_height"">On Job</div>
                                        </td>

                                    </tr>
                                    <tr id=""two"">
                                        <td>
                                            1
                                        </td>

                                       
                                        <td>
                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d1e2856b4cdde8bf9de1f969abf979909501cb3612044", async() => {
                WriteLiteral("\r\n                                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d1e2856b4cdde8bf9de1f969abf979909501cb3612348", async() => {
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
                                        <td>Male</td>
                                        <td>
                                            <div> John@gmail.com</div>
                                        </td>
                                        <td>+92 000 0000000</td>
                                        <td class=""align-middle text-center"">
                                            <a class=""description"" style=""cursor:pointer"" data-toggle=""modal"" data-target=""#OrderDtls"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d1e2856b4cdde8bf9de1f969abf979909501cb3615125", async() => {
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
                                        <td>20 Sept 2012</td>
                                        <td>
                                            <div class=""badge badge-success badge-shadow badge_width_height"">On Job</div>
                                        </td>
                                    </tr>
                                </tbody>
                            </table>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <!-- #END# Exportable Table -->    <div class=""modal fade bs-example-modal-md mt-5"" id=""OrderDtls"" tabindex=""-1"" role=""dialog"" aria-labelledby=""OrderDtls"" aria-hidden=""true"">
            <div class=""modal-dialog modal-lg"">
                <div class=""modal-content"">
                    <div class=""modal-header"">
                        <h5 class=""modal-title"" id=""formModal"">Orders Detail</h5>
                        <button type=""bu");
            WriteLiteral(@"tton"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                            <span aria-hidden=""true"">×</span>
                        </button>
                    </div>
                    <div class=""modal-body"">
                        <div class=""table-responsive"">
                            <table class=""table js-basic-example dataTable"">
                                <thead class=""no-wrap"">
                                    <tr>
                                        <th>Order Id</th>
                                        <th class=""text-center"">Products Detail</th>
                                        <th data-breakpoints=""xs"">Amount</th>
                                        <th data-breakpoints=""xs"">Datetime</th>
                                    </tr>
                                </thead>

                                <tbody class=""no-wrap"">

                                    <tr>
                                        <td class=""align-middle""");
            WriteLiteral(">#123456</td>\r\n                                        <td class=\"align-middle  text-center\">\r\n                                            <a class=\"description\" style=\"cursor:pointer\" data-toggle=\"modal\" data-target=\"#PrdDtls\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d1e2856b4cdde8bf9de1f969abf979909501cb3618641", async() => {
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
                                        <td class=""align-middle"">$31.00</td>

                                        <td class=""align-middle"">20 Sept 2021 12:00 PM</td>

                                    </tr>
                                    <tr>
                                        <td class=""align-middle"">#123456</td>
                                        <td class=""align-middle text-center"">
                                            <a class=""description"" style=""cursor:pointer"" data-toggle=""modal"" data-target=""#PrdDtls"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d1e2856b4cdde8bf9de1f969abf979909501cb3620372", async() => {
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
                                        <td class=""align-middle"">$31.00</td>
                                        <td class=""align-middle"">20 Sept 2021 12:00 PM</td>
                                    </tr>

                                </tbody>
                                <tfoot>
                                    <tr><th rowspan=""1"" colspan=""3"">Total Bill</th><th rowspan=""1"" colspan=""1"">$31.00</th></tr>
                                </tfoot>
                            </table>
                        </div>
                    </div>
                </div>
            </div><!-- /.modal -->
        </div>

        <div class=""modal fade bs-example-modal-md mt-5"" id=""PrdDtls"" tabindex=""-1"" role=""dialog"" aria-labelledby=""PrdDtls"" aria-hidden=""true"">
            <div class=""modal-dialog modal-lg"">
                <div class=""modal-content"">
                    <div class=""modal-header"">
                        <h5 class=""mod");
            WriteLiteral(@"al-title"" id=""formModal"">Products Detail</h5>
                        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                            <span aria-hidden=""true"">×</span>
                        </button>
                    </div>
                    <div class=""modal-body"">
                        <div class=""table-responsive"">
                            <table class=""table js-basic-example dataTable"">
                                <thead class=""no-wrap"">
                                    <tr>
                                        <th>Image</th>
                                        <th>Product Name</th>
                                        <th data-breakpoints=""sm xs"">Detail</th>
                                        <th data-breakpoints=""sm xs"" class=""text-center"">Ingredients</th>
                                        <th data-breakpoints=""xs"">Quantity</th>
                                        <th data-breakpoints=""xs"">Amount</th>
  ");
            WriteLiteral(@"                                  </tr>
                                </thead>

                                <tbody class=""no-wrap"">

                                    <tr>
                                        <td class=""align-middle"">
                                            <a href=""/assets/images/piano/Page-1-Image-1.png"" target=""_blank""> <img src=""/assets/images/piano/Page-1-Image-1.png"" height=""30""> </a>
                                        </td>
                                        <td class=""align-middle""><h6>Lazania Pizza</h6></td>
                                        <td class=""align-middle"">
                                            <a class=""btn-sm btn-primary description"" data-toggle=""modal"" data-target=""#des""><i class=""zmdi zmdi-eye text-white""></i></a>
                                        </td>
                                        <td class=""align-middle text-center"">
                                            <a class=""ingredients"" style=""cursor:poin");
            WriteLiteral("ter\" data-toggle=\"modal\" data-target=\"#ingredients\">\r\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d1e2856b4cdde8bf9de1f969abf979909501cb3624850", async() => {
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
            WriteLiteral("                     <td class=\"align-middle text-center\">\r\n                                            <a class=\"ingredients\" style=\"cursor:pointer\" data-toggle=\"modal\" data-target=\"#ingredients\">\r\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d1e2856b4cdde8bf9de1f969abf979909501cb3627301", async() => {
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
                                    <tr><th rowspan=""1"" colspan=""5"">Total Bill</th><th rowspan=""1"" colspan=""1"">$31.00</th></tr>
                                </tfoot>
                            </table>
                        </div>
                    </div>
                </div>
            </div><!-- /.modal -->
        </div>

        <!-- #END# Exportable Table -->
        <div class=""modal fade bs-example-modal-md mt-5"" id=""des"" tabindex=""-1"" role=""dialog"" aria-labelledby=""des"" aria-hidden=""true"">
            <div class=""modal-dialog modal-md"">
                <div class=""modal-content"">
               ");
            WriteLiteral(@"     <div class=""modal-header"">
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
                 ");
            WriteLiteral(@"   <div class=""modal-header"">
                        <h5 class=""modal-title"" id=""formModal"">Ingredients</h5>
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
                        </div>");
            WriteLiteral(@"

                    </div>
                </div>
            </div><!-- /.modal -->
        </div>
    </div>
</section>


<script>
    $('#Usr').addClass('active');
    $('#Usr').addClass('open');

    $(""#active"").click(function () {
        $('#active').removeClass('FilterButton');
        $('#active').siblings().addClass('FilterButton');

    });
    $(""#all"").click(function () {
        $('#all').removeClass('FilterButton');
        $('#all').siblings().addClass('FilterButton');

    });
    $(""#block"").click(function () {
        $('#block').removeClass('FilterButton');
        $('#block').siblings().addClass('FilterButton');


    });

    $(""#Unban_button_2"").click(function () {

        Swal.fire({
            title: 'Are you sure, you want  to UnBlock User?',

            icon: 'warning',
            showCancelButton: true,
            confirmButtonColor: '#3085d6',
            cancelButtonColor: '#d33',
            confirmButtonText: 'Yes, UnBlock it!'
   ");
            WriteLiteral(@"     }).then((result) => {
            if (result.isConfirmed) {
                Swal.fire(
                    'UnBlocked!',
                    'User is UnBlocked.',
                    'success'
                )

                $(""#status_button_2"").text(""Active"");
                $(""#status_button_2"").removeClass(""badge-danger"");
                $(""#status_button_2"").addClass(""badge-success"");
                $('#ban_button_2').css(""display"", ""block"");
                $('#Unban_button_2').css(""display"", ""none"");

                if ($(""#status_button_1"").text() == ""Active"") {

                    console.log(""123"");

                    $(""#Active"").click(function () {
                        $('#one').show();
                        $('#two').show();

                    });

                    $(""#All"").click(function () {
                        $('#one').show();
                        $('#two').show();

                    });
                    $(""#Block"").click(func");
            WriteLiteral(@"tion () {
                        $('#one').hide();
                        $('#two').hide();

                    });
                }
                else if ($(""#status_button_1"").text() == ""Blocked"") {
                    $(""#Active"").click(function () {
                        $('#one').hide();
                        $('#two').show();

                    });

                    $(""#All"").click(function () {
                        $('#one').show();
                        $('#two').show();

                    });
                    $(""#Block"").click(function () {
                        $('#one').show();
                        $('#two').hide();

                    });
                }


            }
        })
    });

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
