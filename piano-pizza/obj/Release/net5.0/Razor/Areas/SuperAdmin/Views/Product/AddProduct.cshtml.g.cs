#pragma checksum "D:\repos\piano-pizza\piano-pizza\Areas\SuperAdmin\Views\Product\AddProduct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aa09c1e4660fa99bb6ca8ecc7ef0b0238004952b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_SuperAdmin_Views_Product_AddProduct), @"mvc.1.0.view", @"/Areas/SuperAdmin/Views/Product/AddProduct.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa09c1e4660fa99bb6ca8ecc7ef0b0238004952b", @"/Areas/SuperAdmin/Views/Product/AddProduct.cshtml")]
    public class Areas_SuperAdmin_Views_Product_AddProduct : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\repos\piano-pizza\piano-pizza\Areas\SuperAdmin\Views\Product\AddProduct.cshtml"
  
    ViewBag.Title = "AddProduct";
    Layout = "~/Areas/SuperAdmin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<section class=\"content\">\r\n    <div class=\"block-header\">\r\n        <div class=\"row\">\r\n            <div class=\"col-12\">\r\n                <h2>\r\n                    ");
#nullable restore
#line 12 "D:\repos\piano-pizza\piano-pizza\Areas\SuperAdmin\Views\Product\AddProduct.cshtml"
               Write(local.GetLocalizedHtmlString("AddProduct"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </h2>
            </div>

        </div>
    </div>
    <div class=""container-fluid"">
        <!-- Basic Validation -->
        <div class=""row clearfix"">
            <div class=""col-lg-12 col-md-12 col-sm-12"">
                <div class=""card"">
                    <div class=""body"">
                        <div id=""form_validation"" method=""POST"">
                            <div class=""Scriptcontent"">

                                <main>
                                    <form method=""POST"" name=""form-example-1"" id=""form-example-1"" class=""rounded"" enctype=""multipart/form-data"">
                                        <div style=""cursor:pointer"" class=""input-field "">
                                            <label class=""active"">");
#nullable restore
#line 30 "D:\repos\piano-pizza\piano-pizza\Areas\SuperAdmin\Views\Product\AddProduct.cshtml"
                                                             Write(local.GetLocalizedHtmlString("ProductPictures"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</label>
                                            <div class=""input-images-1 rounded"" style=""padding-top: .5rem;""></div>
                                        </div>

                                    </form>
                                </main>

                            </div>
                            <!-- #END# File Upload | Drag & Drop OR With Click & Choose -->

                            <div class=""row mt-4"">
                                <div class=""col-md-3"">
                                    <label>Select Branch</label>
                                    <select class=""form-group form-float show-tick w-100"">
                                        <option");
            BeginWriteAttribute("value", " value=\"", 1908, "\"", 1916, 0);
            EndWriteAttribute();
            WriteLiteral(" disabled selected>-- Select Branch</option>\r\n                                        <option");
            BeginWriteAttribute("value", " value=\"", 2010, "\"", 2018, 0);
            EndWriteAttribute();
            WriteLiteral(">MAASTRICHT</option>\r\n                                        <option");
            BeginWriteAttribute("value", " value=\"", 2088, "\"", 2096, 0);
            EndWriteAttribute();
            WriteLiteral(@">LEIDEN</option>
                                    </select>
                                </div>

                                <div class=""col-md-3"">
                                    <label>Select Category</label>
                                    <select class=""form-group form-float show-tick w-100"">
                                        <option");
            BeginWriteAttribute("value", " value=\"", 2467, "\"", 2475, 0);
            EndWriteAttribute();
            WriteLiteral(@" disabled selected>-- Select Category</option>
                                        <option value=""10"">PIZZE SPECIALI</option>
                                        <option value=""20"">DRINKS</option>
                                    </select>
                                </div>

                                <div class=""col-md-3"">
                                    <div class=""form-group form-float"">
                                        <label>");
#nullable restore
#line 61 "D:\repos\piano-pizza\piano-pizza\Areas\SuperAdmin\Views\Product\AddProduct.cshtml"
                                          Write(local.GetLocalizedHtmlString("Name"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</label>
                                        <input type=""text"" class=""form-control mt-1"" placeholder=""Name"" name=""name"" required>
                                    </div>
                                </div>


                                <div class=""col-md-3"">
                                    <div class=""form-group form-float"">
                                        <label>");
#nullable restore
#line 69 "D:\repos\piano-pizza\piano-pizza\Areas\SuperAdmin\Views\Product\AddProduct.cshtml"
                                          Write(local.GetLocalizedHtmlString("Price"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</label>
                                        <input type=""number"" class=""form-control mt-1"" placeholder=""Price"" maxlength=""4"" oninput=""javascript: if (this.value.length > this.maxLength) this.value = this.value.slice(0, this.maxLength);"" onkeypress=""return event.charCode != 45"" min=""0"" max=""9999"" required>
                                    </div>
                                </div>

                                <div class=""col-12 mt-2"">
                                    <div class=""form-group form-float"">
                                        <textarea class=""border-top-0 border-left-0 border-right-0 w-100"" rows=""4"" style=""outline:none;border-color:#eee!important"" placeholder=""Pizza description""></textarea>
                                    </div>
                                </div>

                            </div>
                            <button class=""btn btn-raised btn-primary btn-round waves-effect mb-4"" style=""float:right"" type=""submit"">");
#nullable restore
#line 81 "D:\repos\piano-pizza\piano-pizza\Areas\SuperAdmin\Views\Product\AddProduct.cshtml"
                                                                                                                                Write(local.GetLocalizedHtmlString("SUBMIT"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <!-- #END# Basic Validation -->\r\n\r\n    </div>\r\n</section>\r\n\r\n");
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
