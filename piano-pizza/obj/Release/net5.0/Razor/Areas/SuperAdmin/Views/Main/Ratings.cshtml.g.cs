#pragma checksum "D:\repos\piano-pizza\piano-pizza\Areas\SuperAdmin\Views\Main\Ratings.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "01f158aae132b646e834700eb6da1a26f1733bd1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_SuperAdmin_Views_Main_Ratings), @"mvc.1.0.view", @"/Areas/SuperAdmin/Views/Main/Ratings.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01f158aae132b646e834700eb6da1a26f1733bd1", @"/Areas/SuperAdmin/Views/Main/Ratings.cshtml")]
    public class Areas_SuperAdmin_Views_Main_Ratings : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("rounded shadow"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/images/sm/avatar1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("35"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/images/sm/avatar1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/images/piano/Bg-transparent/Page-2-Image-14-removebg-preview.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/images/sm/avatar2.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/images/sm/avatar2.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/images/piano/Bg-transparent/Ingredient-removebg-preview.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\repos\piano-pizza\piano-pizza\Areas\SuperAdmin\Views\Main\Ratings.cshtml"
  
    ViewBag.Title = "Ratings";
    Layout = "~/Areas/SuperAdmin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<section class=\"content\">\r\n    <div class=\"block-header\">\r\n        <div class=\"row\">\r\n            <div class=\"col-12\">\r\n                <h5>");
#nullable restore
#line 11 "D:\repos\piano-pizza\piano-pizza\Areas\SuperAdmin\Views\Main\Ratings.cshtml"
               Write(local.GetLocalizedHtmlString("OrdersRating"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
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
                            <div class=""table-responsive"">
                                <table class=""table table-bordered js-basic-example dataTable"">
                                    <thead style=""white-space:nowrap"">
                                        <tr>
                                            <th>");
#nullable restore
#line 28 "D:\repos\piano-pizza\piano-pizza\Areas\SuperAdmin\Views\Main\Ratings.cshtml"
                                           Write(local.GetLocalizedHtmlString("OrderId"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                            <th>");
#nullable restore
#line 29 "D:\repos\piano-pizza\piano-pizza\Areas\SuperAdmin\Views\Main\Ratings.cshtml"
                                           Write(local.GetLocalizedHtmlString("Name"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                            <th class=\"text-center\">");
#nullable restore
#line 30 "D:\repos\piano-pizza\piano-pizza\Areas\SuperAdmin\Views\Main\Ratings.cshtml"
                                                               Write(local.GetLocalizedHtmlString("ProductsDetail"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                            <th>");
#nullable restore
#line 31 "D:\repos\piano-pizza\piano-pizza\Areas\SuperAdmin\Views\Main\Ratings.cshtml"
                                           Write(local.GetLocalizedHtmlString("Rating"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</th>
                                        </tr>
                                    </thead>

                                    <tbody style=""white-space:nowrap"">

                                        <tr data-attribute=""1"" class=""no-wrap"">
                                            <td>#123456</td>
                                            <td class=""align-middle"">
                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "01f158aae132b646e834700eb6da1a26f1733bd18748", async() => {
                WriteLiteral("\r\n                                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "01f158aae132b646e834700eb6da1a26f1733bd19055", async() => {
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
                WriteLiteral("\r\n                                                ");
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


                                            <td class=""align-middle text-center"">
                                                <a class=""description"" style=""cursor:pointer"" data-toggle=""modal"" data-target=""#PrdDtls"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "01f158aae132b646e834700eb6da1a26f1733bd111565", async() => {
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
                                            <td>
                                                <span class=""m-l-10"">
                                                    <a href=""#""><i class=""zmdi zmdi-star col-amber""></i></a>
                                                    <a href=""#""><i class=""zmdi zmdi-star col-amber""></i></a>
                                                    <a href=""#""><i class=""zmdi zmdi-star col-amber""></i></a>
                                                    <a href=""#""><i class=""zmdi zmdi-star col-amber""></i></a>
                                                    <a href=""#""><i class=""zmdi zmdi-star-outline text-muted""></i></a>
                                                </span>
                                            </td>

                                        </tr>

                                        <tr data-attribute=""2"" class=""no-wrap"">
                                            <td");
            WriteLiteral(">#678904</td>\r\n                                            <td class=\"align-middle\">\r\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "01f158aae132b646e834700eb6da1a26f1733bd113897", async() => {
                WriteLiteral("\r\n                                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "01f158aae132b646e834700eb6da1a26f1733bd114205", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
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
                                            <td class=""align-middle text-center"">
                                                <a class=""description"" style=""cursor:pointer"" data-toggle=""modal"" data-target=""#PrdDtls"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "01f158aae132b646e834700eb6da1a26f1733bd116712", async() => {
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
                                            <td>
                                                <span class=""m-l-10"">
                                                    <a href=""#""><i class=""zmdi zmdi-star col-amber""></i></a>
                                                    <a href=""#""><i class=""zmdi zmdi-star col-amber""></i></a>
                                                    <a href=""#""><i class=""zmdi zmdi-star col-amber""></i></a>
                                                    <a href=""#""><i class=""zmdi zmdi-star col-amber""></i></a>
                                                    <a href=""#""><i class=""zmdi zmdi-star-outline text-muted""></i></a>
                                                </span>
                                            </td>

                                        </tr>

                                    </tbody>
                                </table>
                            </div>
    ");
            WriteLiteral(@"                    </div>
                    </div>
                </div>
            </div>
        </div>
        <!-- #END# Exportable Table -->
        <div class=""modal fade bs-example-modal-md mt-5"" id=""des"" tabindex=""-1"" role=""dialog"" aria-labelledby=""des"" aria-hidden=""true"">
            <div class=""modal-dialog modal-md"">
                <div class=""modal-content"">
                    <div class=""modal-header"">
                        <h5 class=""modal-title"" id=""formModal"">");
#nullable restore
#line 100 "D:\repos\piano-pizza\piano-pizza\Areas\SuperAdmin\Views\Main\Ratings.cshtml"
                                                          Write(local.GetLocalizedHtmlString("Details"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
                        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                            <span aria-hidden=""true"">×</span>
                        </button>
                    </div>
                    <div class=""modal-body"">
                        <div class=""row"">
                            <div class=""col-md-12"">
                                <textarea readonly class=""w-100 border-0"" style=""outline:none"">Sample Details</textarea>
                            </div>
                        </div>

                    </div>
                </div>
            </div><!-- /.modal -->
        </div>
    </div>
    <div class=""modal fade bs-example-modal-md mt-5"" id=""PrdDtls"" tabindex=""-1"" role=""dialog"" aria-labelledby=""PrdDtls"" aria-hidden=""true"">
        <div class=""modal-dialog modal-lg"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"" id=""formModal"">");
#nullable restore
#line 121 "D:\repos\piano-pizza\piano-pizza\Areas\SuperAdmin\Views\Main\Ratings.cshtml"
                                                      Write(local.GetLocalizedHtmlString("ProductsDetail"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">×</span>
                    </button>
                </div>
                <div class=""modal-body"">
                    <div class=""table-responsive"">
                        <table class=""table js-basic-example dataTable"">
                            <thead class=""no-wrap"">
                                <tr>
                                    <th>");
#nullable restore
#line 131 "D:\repos\piano-pizza\piano-pizza\Areas\SuperAdmin\Views\Main\Ratings.cshtml"
                                   Write(local.GetLocalizedHtmlString("Image"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                    <th>");
#nullable restore
#line 132 "D:\repos\piano-pizza\piano-pizza\Areas\SuperAdmin\Views\Main\Ratings.cshtml"
                                   Write(local.GetLocalizedHtmlString("ProductName"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                    <th data-breakpoints=\"sm xs\">");
#nullable restore
#line 133 "D:\repos\piano-pizza\piano-pizza\Areas\SuperAdmin\Views\Main\Ratings.cshtml"
                                                            Write(local.GetLocalizedHtmlString("Detail"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                    <th data-breakpoints=\"sm xs\" class=\"text-center\">");
#nullable restore
#line 134 "D:\repos\piano-pizza\piano-pizza\Areas\SuperAdmin\Views\Main\Ratings.cshtml"
                                                                                Write(local.GetLocalizedHtmlString("Ingredients"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                    <th data-breakpoints=\"xs\">");
#nullable restore
#line 135 "D:\repos\piano-pizza\piano-pizza\Areas\SuperAdmin\Views\Main\Ratings.cshtml"
                                                         Write(local.GetLocalizedHtmlString("Quantity"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                    <th data-breakpoints=\"xs\">");
#nullable restore
#line 136 "D:\repos\piano-pizza\piano-pizza\Areas\SuperAdmin\Views\Main\Ratings.cshtml"
                                                         Write(local.GetLocalizedHtmlString("Amount"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</th>
                                </tr>
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
                                        <a class=""ingredients"" style=""cursor:pointer"" data-toggle=""modal"" data-target=""#ingr");
            WriteLiteral("edients\">\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "01f158aae132b646e834700eb6da1a26f1733bd124885", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
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
                                    <td class=""align-middle text-center");
            WriteLiteral("\">\r\n                                        <a class=\"ingredients\" style=\"cursor:pointer\" data-toggle=\"modal\" data-target=\"#ingredients\">\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "01f158aae132b646e834700eb6da1a26f1733bd127272", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
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
                                <tr><th rowspan=""1"" colspan=""5"">");
#nullable restore
#line 178 "D:\repos\piano-pizza\piano-pizza\Areas\SuperAdmin\Views\Main\Ratings.cshtml"
                                                           Write(local.GetLocalizedHtmlString("TotalBill"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</th><th rowspan=""1"" colspan=""1"">$31.00</th></tr>
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
                <div class=""modal-header"">
                    <h5 class=""modal-title"" id=""formModal"">");
#nullable restore
#line 191 "D:\repos\piano-pizza\piano-pizza\Areas\SuperAdmin\Views\Main\Ratings.cshtml"
                                                      Write(local.GetLocalizedHtmlString("Details"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
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
                    <h5 class=""modal-title"" id=""formModal"">");
#nullable restore
#line 213 "D:\repos\piano-pizza\piano-pizza\Areas\SuperAdmin\Views\Main\Ratings.cshtml"
                                                      Write(local.GetLocalizedHtmlString("Ingredients"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
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


<script>
    $('#Query').addClass('active');

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
