#pragma checksum "D:\repos\piano-pizza\piano-pizza\Areas\SuperAdmin\Views\Staff\AddCook.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "13dbbf4c76bef061945c4a4942dcdee15a8fa59e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_SuperAdmin_Views_Staff_AddCook), @"mvc.1.0.view", @"/Areas/SuperAdmin/Views/Staff/AddCook.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13dbbf4c76bef061945c4a4942dcdee15a8fa59e", @"/Areas/SuperAdmin/Views/Staff/AddCook.cshtml")]
    public class Areas_SuperAdmin_Views_Staff_AddCook : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/images/profile_av.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("rounded-circle align-middle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("output"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("vertical-align:middle;max-width:250px!important;min-width: 250px!important;max-height:250px!important; min-height: 250px!important"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\repos\piano-pizza\piano-pizza\Areas\SuperAdmin\Views\Staff\AddCook.cshtml"
  
    Layout = "~/Areas/SuperAdmin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<section class=\"content\">\r\n    <div class=\"block-header\">\r\n        <div class=\"row\">\r\n            <div class=\"col-12\">\r\n                <h2>\r\n                    ");
#nullable restore
#line 11 "D:\repos\piano-pizza\piano-pizza\Areas\SuperAdmin\Views\Staff\AddCook.cshtml"
               Write(local.GetLocalizedHtmlString("AddCook"));

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



                            <div class=""row mt-4"">
                                <div class=""col-md-4 col-sm-12 col-12"">
                                    <div class=""card-body shadow"" style=""min-height:335px!important;max-height:335px!important"">
                                        <input type=""file"" accept=""image/*"" name=""imageFile"" id=""file"" onchange=""loadFile(event)"" style=""display: none"" />
                                        <div class=""d-flex justify-content-center mt-3"">
                                            <label for=""file"" style=""cursor: pointer;"" class=""mt-1"">
                                   ");
            WriteLiteral(@"             <span class=""position-absolute rounded-circle bg-white pl-1 pr-1 pt-1"" style=""margin-left: 200px;margin-top: 200px;"">
                                                    <i class=""fas fa-camera font-18 text-black""></i>
                                                </span>
                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "13dbbf4c76bef061945c4a4942dcdee15a8fa59e6287", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                            </label>
                                        </div>
                                    </div>
                                </div>
                                <div class=""col-md-8 col-sm-12 col-12"">
                                    <div class=""row"">
                                        <div class=""col-md-6 col-sm-12 col-12"">
                                            <label>");
#nullable restore
#line 44 "D:\repos\piano-pizza\piano-pizza\Areas\SuperAdmin\Views\Staff\AddCook.cshtml"
                                              Write(local.GetLocalizedHtmlString("SelectBranch"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                                            <select class=\"form-group form-float show-tick w-100\">\r\n                                                <option");
            BeginWriteAttribute("value", " value=\"", 2584, "\"", 2592, 0);
            EndWriteAttribute();
            WriteLiteral(" disabled selected>-- Select Branch</option>\r\n                                                <option");
            BeginWriteAttribute("value", " value=\"", 2694, "\"", 2702, 0);
            EndWriteAttribute();
            WriteLiteral(">MAASTRICHT</option>\r\n                                                <option");
            BeginWriteAttribute("value", " value=\"", 2780, "\"", 2788, 0);
            EndWriteAttribute();
            WriteLiteral(@">LEIDEN</option>
                                            </select>
                                        </div>
                                        <div class=""col-md-6 col-sm-12 col-12"">
                                            <div class=""form-group form-float"">
                                                <label>");
#nullable restore
#line 53 "D:\repos\piano-pizza\piano-pizza\Areas\SuperAdmin\Views\Staff\AddCook.cshtml"
                                                  Write(local.GetLocalizedHtmlString("Name"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</label>
                                                <input type=""text"" class=""form-control mt-1"" placeholder=""Name"" name=""name"" required>
                                            </div>
                                        </div>
                                        <div class=""col-md-6 col-sm-12 col-12"">
                                            <label>");
#nullable restore
#line 58 "D:\repos\piano-pizza\piano-pizza\Areas\SuperAdmin\Views\Staff\AddCook.cshtml"
                                              Write(local.GetLocalizedHtmlString("SelectGender"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                                            <select class=\"form-group form-float show-tick w-100\">\r\n                                                <option");
            BeginWriteAttribute("value", " value=\"", 3751, "\"", 3759, 0);
            EndWriteAttribute();
            WriteLiteral(" disabled selected>-- Select Gender</option>\r\n                                                <option");
            BeginWriteAttribute("value", " value=\"", 3861, "\"", 3869, 0);
            EndWriteAttribute();
            WriteLiteral(">Male</option>\r\n                                                <option");
            BeginWriteAttribute("value", " value=\"", 3941, "\"", 3949, 0);
            EndWriteAttribute();
            WriteLiteral(@">Female</option>
                                            </select>
                                        </div>
                                        <div class=""col-md-6 col-sm-12 col-12"">
                                            <div class=""form-group form-float"">
                                                <label>");
#nullable restore
#line 67 "D:\repos\piano-pizza\piano-pizza\Areas\SuperAdmin\Views\Staff\AddCook.cshtml"
                                                  Write(local.GetLocalizedHtmlString("Email"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</label>
                                                <input type=""text"" class=""form-control mt-1"" placeholder=""E-mail.."" required>
                                            </div>
                                        </div>
                                        <div class=""col-md-6 col-sm-12 col-12"">
                                            <div class=""form-group form-float"">
                                                <label>");
#nullable restore
#line 73 "D:\repos\piano-pizza\piano-pizza\Areas\SuperAdmin\Views\Staff\AddCook.cshtml"
                                                  Write(local.GetLocalizedHtmlString("Phone"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</label>
                                                <input type=""number"" class=""form-control"" placeholder=""Phone.."" required>
                                            </div>
                                        </div>
                                        <div class=""col-md-6 col-sm-12 col-12"">
                                            <label>");
#nullable restore
#line 78 "D:\repos\piano-pizza\piano-pizza\Areas\SuperAdmin\Views\Staff\AddCook.cshtml"
                                              Write(local.GetLocalizedHtmlString("JoiningDate"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</label>
                                            <div class=""input-group"">

                                                <span class=""input-group-addon"">
                                                    <i class=""zmdi zmdi-calendar""></i>
                                                </span>
                                                <input type=""text"" class=""form-control datetimepicker"" placeholder=""Please choose date & time..."">
                                            </div>
                                        </div> <div class=""col-md-6 col-sm-12 col-12"">
                                            <div class=""form-group form-float"">
                                                <label>");
#nullable restore
#line 88 "D:\repos\piano-pizza\piano-pizza\Areas\SuperAdmin\Views\Staff\AddCook.cshtml"
                                                  Write(local.GetLocalizedHtmlString("Password"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</label>
                                                <input type=""password"" class=""form-control mt-1"" placeholder=""Password.."" required>
                                            </div>
                                        </div>
                                        <div class=""col-md-6 col-sm-12 col-12"">
                                            <div class=""form-group form-float"">
                                                <label>");
#nullable restore
#line 94 "D:\repos\piano-pizza\piano-pizza\Areas\SuperAdmin\Views\Staff\AddCook.cshtml"
                                                  Write(local.GetLocalizedHtmlString("ConfirmPassword"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</label>
                                                <input type=""password"" class=""form-control"" placeholder=""Confirm Password.."" required>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>



                            <button class=""btn btn-raised btn-primary btn-round waves-effect mb-4"" style=""float:right"" type=""submit"">");
#nullable restore
#line 104 "D:\repos\piano-pizza\piano-pizza\Areas\SuperAdmin\Views\Staff\AddCook.cshtml"
                                                                                                                                Write(local.GetLocalizedHtmlString("SUBMIT"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</button>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <!-- #END# Basic Validation -->

    </div>
</section>

<script>
    var loadFile = function (event) {
        var image = document.getElementById(""output"");
        image.src = URL.createObjectURL(event.target.files[0]);
    };
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