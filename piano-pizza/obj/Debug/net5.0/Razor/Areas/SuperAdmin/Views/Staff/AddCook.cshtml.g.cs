#pragma checksum "D:\repos\piano-pizza\piano-pizza\Areas\SuperAdmin\Views\Staff\AddCook.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1902539f53f7806169a32f8563f3822193c47c57"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1902539f53f7806169a32f8563f3822193c47c57", @"/Areas/SuperAdmin/Views/Staff/AddCook.cshtml")]
    public class Areas_SuperAdmin_Views_Staff_AddCook : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
               Write(local.GetLocalizedHtmlString("Add Cook"));

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
                        <form autocomplete=""off"" id=""Form"" method=""POST"" action=""/SuperAdmin/Staff/AddStaff"" enctype=""multipart/form-data"">
                            ");
#nullable restore
#line 23 "D:\repos\piano-pizza\piano-pizza\Areas\SuperAdmin\Views\Staff\AddCook.cshtml"
                       Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            <input type=""hidden"" name=""Role"" id=""Role"" value=""2"" />
                            <div id=""form_validation"">
                                <div class=""row mt-4"">
                                    <div class=""col-md-4 col-sm-12 col-12"">
                                        <div class=""card-body shadow"" style=""min-height:335px!important;max-height:335px!important"">
                                            <input type=""file"" accept=""image/*"" name=""ImageFile"" id=""file"" onchange=""loadFile(event)"" class=""form-control"" style=""display: none"" />
                                            <div class=""d-flex justify-content-center mt-3"">
                                                <label for=""file"" style=""cursor: pointer;"" class=""mt-1"">
                                                    <span class=""position-absolute rounded-circle bg-white pl-1 pr-1 pt-1"" style=""margin-left: 200px;margin-top: 200px;"">
                                                        <i cla");
            WriteLiteral(@"ss=""fas fa-camera font-18 text-black""></i>
                                                    </span>
                                                    <img src=""/user_icon.jpg"" class=""rounded-circle align-middle"" id=""output"" style=""vertical-align:middle;max-width:250px!important;min-width: 250px!important;max-height:250px!important; min-height: 250px!important"" />
                                                </label>
                                            </div>
                                        </div>
                                    </div>
                                    <div class=""col-md-8 col-sm-12 col-12"">
                                        <div class=""row"">
                                            <div class=""col-md-6 col-sm-12 col-12"">
                                                <label>");
#nullable restore
#line 43 "D:\repos\piano-pizza\piano-pizza\Areas\SuperAdmin\Views\Staff\AddCook.cshtml"
                                                  Write(local.GetLocalizedHtmlString("Select Branch"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                                                ");
#nullable restore
#line 44 "D:\repos\piano-pizza\piano-pizza\Areas\SuperAdmin\Views\Staff\AddCook.cshtml"
                                           Write(Html.DropDownList("BranchId", (IEnumerable<SelectListItem>)ViewBag.Branches, new { @class = "form-group form-float show-tick w-100 border-light" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                            </div>
                                            <div class=""col-md-6 col-sm-12 col-12"">
                                                <div class=""form-group form-float"">
                                                    <label>");
#nullable restore
#line 48 "D:\repos\piano-pizza\piano-pizza\Areas\SuperAdmin\Views\Staff\AddCook.cshtml"
                                                      Write(local.GetLocalizedHtmlString("Name"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</label>
                                                    <input type=""text"" class=""form-control mt-1"" placeholder=""Name"" id=""Name"" name=""FullName"" required>
                                                </div>
                                            </div>
                                            <div class=""col-md-6 col-sm-12 col-12"">
                                                <label>");
#nullable restore
#line 53 "D:\repos\piano-pizza\piano-pizza\Areas\SuperAdmin\Views\Staff\AddCook.cshtml"
                                                  Write(local.GetLocalizedHtmlString("Select Gender"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                                                <select class=\"form-group form-float show-tick w-100\" name=\"Gender\" id=\"Gender\">\r\n                                                    <option");
            BeginWriteAttribute("value", " value=\"", 3983, "\"", 3991, 0);
            EndWriteAttribute();
            WriteLiteral(@" disabled selected>-- Select Gender--</option>
                                                    <option value=""Male"">Male</option>
                                                    <option value=""Female"">Female</option>
                                                </select>
                                            </div>
                                            <div class=""col-md-6 col-sm-12 col-12"">
                                                <div class=""form-group form-float"">
                                                    <label>");
#nullable restore
#line 62 "D:\repos\piano-pizza\piano-pizza\Areas\SuperAdmin\Views\Staff\AddCook.cshtml"
                                                      Write(local.GetLocalizedHtmlString("Email"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</label>
                                                    <input type=""text"" name=""Email"" id=""Email"" class=""form-control mt-1"" placeholder=""E-mail.."" required>
                                                </div>
                                            </div>
                                            <div class=""col-md-6 col-sm-12 col-12"">
                                                <div class=""form-group form-float"">
                                                    <label>");
#nullable restore
#line 68 "D:\repos\piano-pizza\piano-pizza\Areas\SuperAdmin\Views\Staff\AddCook.cshtml"
                                                      Write(local.GetLocalizedHtmlString("Phone"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</label>
                                                    <input type=""text"" name=""Phone"" id=""Phone"" class=""form-control"" placeholder=""Phone.."" required>
                                                </div>
                                            </div>
                                            <div class=""col-md-6 col-sm-12 col-12"">
                                                <label>");
#nullable restore
#line 73 "D:\repos\piano-pizza\piano-pizza\Areas\SuperAdmin\Views\Staff\AddCook.cshtml"
                                                  Write(local.GetLocalizedHtmlString("Joining Date"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</label>
                                                <div class=""input-group"">
                                                    <span class=""input-group-addon"">
                                                        <i class=""zmdi zmdi-calendar""></i>
                                                    </span>
                                                    <input type=""text"" id=""JoiningDate"" class=""form-control datetimepicker"" placeholder=""Please choose date & time..."">
                                                    <input type=""hidden"" id=""JoiningDate2"" name=""JoiningDate"">
                                                </div>
                                            </div> <div class=""col-md-6 col-sm-12 col-12"">
                                                <div class=""form-group form-float"">
                                                    <label>");
#nullable restore
#line 83 "D:\repos\piano-pizza\piano-pizza\Areas\SuperAdmin\Views\Staff\AddCook.cshtml"
                                                      Write(local.GetLocalizedHtmlString("Password"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</label>
                                                    <input type=""password"" id=""Password"" name=""Password"" autocomplete=""new-password"" class=""form-control mt-1"" placeholder=""Password.."" required>
                                                </div>
                                            </div>
                                            <div class=""col-md-6 col-sm-12 col-12"">
                                                <div class=""form-group form-float"">
                                                    <label>");
#nullable restore
#line 89 "D:\repos\piano-pizza\piano-pizza\Areas\SuperAdmin\Views\Staff\AddCook.cshtml"
                                                      Write(local.GetLocalizedHtmlString("Confirm Password"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</label>
                                                    <input type=""password"" id=""ConfirmPassword"" name=""ConfirmPassword"" class=""form-control"" placeholder=""Confirm Password.."" required>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div style=""display:flex;justify-content:end;"">
                                    <a class=""btn btn-raised btn-default btn-round waves-effect mb-4""  href=""/SuperAdmin/Staff/CookDetails"">");
#nullable restore
#line 97 "D:\repos\piano-pizza\piano-pizza\Areas\SuperAdmin\Views\Staff\AddCook.cshtml"
                                                                                                                                       Write(local.GetLocalizedHtmlString("Cancel"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                    <button class=\"btn btn-raised btn-default btn-round waves-effect mb-4\"  type=\"submit\">");
#nullable restore
#line 98 "D:\repos\piano-pizza\piano-pizza\Areas\SuperAdmin\Views\Staff\AddCook.cshtml"
                                                                                                                     Write(local.GetLocalizedHtmlString("SUBMIT"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</button>
                                </div>
                            </div>
                        </form>
                    </div>
                </div>
            </div>
        </div>
        <!-- #END# Basic Validation -->
    </div>
</section>
<script>
    $(function () {
        $('#CookDtls').addClass('active');
        $('#staff').addClass('toggled');
        if ('");
#nullable restore
#line 113 "D:\repos\piano-pizza\piano-pizza\Areas\SuperAdmin\Views\Staff\AddCook.cshtml"
        Write(ViewBag.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("\' == \'Success\') {\r\n            MixinSweet(\"Success!\", \"\",\"success\", 2000);\r\n        }\r\n        else if (\'");
#nullable restore
#line 116 "D:\repos\piano-pizza\piano-pizza\Areas\SuperAdmin\Views\Staff\AddCook.cshtml"
             Write(ViewBag.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"' == 'Error') {
            MixinSweet(""Error!"", """",""error"", 2000);
        }
    })
    var loadFile = function (event) {
        var image = document.getElementById(""output"");
        image.src = URL.createObjectURL(event.target.files[0]);
    };
</script>
<script>
    $('#Form').submit(function (e) {
        //e.preventDefault();
        var bool = true;
        var GetAllValues = [];
        var password = $('#Password').val();
        var confrimPassword = $('#ConfirmPassword').val();
        $('#Form').find(('.form-control')).each(function (i, obj) {
            var values = getDataFromSimpleField($(obj));
            GetAllValues.push(values);
            if (GetAllValues.includes(false)) {
                bool = false;
            }
        })
        if (bool == false) {
            MixinSweet(""Please fill all the required fields"", """", ""error"", 2000);
            e.preventDefault();
        }
        else if (password != confrimPassword) {
            MixinSweet(""Password ");
            WriteLiteral(@"and confirm password should be sam "", """", ""error"", 2000);
            e.preventDefault();
        }
        else if (password.length < 6) {
            MixinSweet(""Password length should be greater than 6"", """", ""error"", 2000);
            e.preventDefault();
        }
        else {

            var date = $('#JoiningDate').val();
            date = date.split(' ');
            date = date[1] + ""-"" + date[2] + ""-"" + date[3];
            var date = new Date(date);
            var day = (""0"" + date.getDate()).slice(-2);
            var month = (""0"" + (date.getMonth() + 1)).slice(-2);
            var join = date.getFullYear() + ""-"" + (month) + ""-"" + (day);
            $('#JoiningDate2').val(join);
            return true;
        }
    })
    function getDataFromSimpleField(element) {
        var s = false;
        var value = $(element).val();

        if (value == """" || value == null || value == undefined) {
            s = false;
            $(element).addClass('is-invalid');
      ");
            WriteLiteral(@"      $(element).removeClass('is-valid');
        }
        else if (!value.replace(/\s/g, '')[0].length) {
            s = false;
            $(element).addClass('is-invalid');
            $(element).removeClass('is-valid');
        }
        else {
            s = true;
            $(element).addClass('is-valid');
            $(element).removeClass('is-invalid');
        }
        if (s == false) {
            return false;
        }
        return true;
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
