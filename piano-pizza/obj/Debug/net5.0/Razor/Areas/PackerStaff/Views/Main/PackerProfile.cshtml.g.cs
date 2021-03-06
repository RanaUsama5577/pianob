#pragma checksum "D:\repos\piano-pizza\piano-pizza\Areas\PackerStaff\Views\Main\PackerProfile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1b116b34a420b4f2f2894bbc5d827af428aa9ab9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_PackerStaff_Views_Main_PackerProfile), @"mvc.1.0.view", @"/Areas/PackerStaff/Views/Main/PackerProfile.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b116b34a420b4f2f2894bbc5d827af428aa9ab9", @"/Areas/PackerStaff/Views/Main/PackerProfile.cshtml")]
    public class Areas_PackerStaff_Views_Main_PackerProfile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\repos\piano-pizza\piano-pizza\Areas\PackerStaff\Views\Main\PackerProfile.cshtml"
  
    Layout = "~/Areas/PackerStaff/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<section class=\"content profile-page\">\r\n    <div class=\"block-header\">\r\n        <div class=\"row\">\r\n            <div class=\"col-12\">\r\n                <h5>");
#nullable restore
#line 9 "D:\repos\piano-pizza\piano-pizza\Areas\PackerStaff\Views\Main\PackerProfile.cshtml"
               Write(local.GetLocalizedHtmlString("Profile"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
            </div>
        </div>
    </div>
    <div class=""container-fluid"">
        <div class=""row clearfix"">
            <div class=""col-lg-4 col-md-12"">
                <form class=""card member-card"" id=""editProfileForm"">
                    <div class=""header l-cyan"">
                    </div>
                    <div class=""member-img"">
                        <div class=""col-md-12 mb-1"">
                            <input type=""file"" accept=""image/*"" id=""file"" name=""file"" onchange=""loadFile(event)"" style=""display: none"" />

                            <label for=""file"" style=""cursor: pointer;"">
                                <span class=""position-absolute rounded-circle bg-white pl-1 pr-1 pt-1 "" style=""margin-left: 102px;margin-top: 115px;"">
                                    <i class=""fas fa-camera font-18 text-black""></i>
                                </span>
                                <img src=""/user_icon.jpg"" class=""rounded-circle imageUrl"" id=""output"" style=""max");
            WriteLiteral(@"-width:146px;min-width: 146px !important;max-height:146px; min-height: 146px !important"" />
                            </label>
                        </div>
                    </div>
                    <div class=""col-12 mb-2"">
                        <button id=""PhotoChange"" class=""btn btn-primary rounded-pill text-white"">");
#nullable restore
#line 32 "D:\repos\piano-pizza\piano-pizza\Areas\PackerStaff\Views\Main\PackerProfile.cshtml"
                                                                                            Write(local.GetLocalizedHtmlString("Update Photo"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</button>
                    </div>
                </form>
            </div>
            <div class=""col-lg-8 col-md-12"">
                <div class=""card mb-4"">
                    <ul class=""nav nav-tabs"">
                        <li class=""nav-item""><a class=""nav-link active"" data-toggle=""tab"" href=""#project"">");
#nullable restore
#line 39 "D:\repos\piano-pizza\piano-pizza\Areas\PackerStaff\Views\Main\PackerProfile.cshtml"
                                                                                                     Write(local.GetLocalizedHtmlString("Overview"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                        <li class=\"nav-item\"><a class=\"nav-link\" data-toggle=\"tab\" href=\"#timeline\">");
#nullable restore
#line 40 "D:\repos\piano-pizza\piano-pizza\Areas\PackerStaff\Views\Main\PackerProfile.cshtml"
                                                                                               Write(local.GetLocalizedHtmlString("Settings"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a></li>
                    </ul>
                </div>
                <div class=""tab-content"">
                    <div role=""tabpanel"" class=""tab-pane active"" id=""project"">
                        <div class=""card"">
                            <div class=""header bline"">
                                <h2>");
#nullable restore
#line 47 "D:\repos\piano-pizza\piano-pizza\Areas\PackerStaff\Views\Main\PackerProfile.cshtml"
                               Write(local.GetLocalizedHtmlString("Edit Profile"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
                            </div>
                            <form class=""body"" style=""padding: 20px 20px 9px 20px!important;"" id=""editBasicForm"">
                                <div class=""row"">
                                    <div class=""col-md-6 col-sm-12 col-12"">
                                        <div class=""form-group"">
                                            <input type=""text"" maxlength=""32"" class=""form-control"" id=""Username"" name=""Name"" value=""John Doe"" placeholder=""Name"">
                                        </div>
                                    </div>
                                </div>
                                <button id=""NameChange"" class=""btn btn-primary btn-round mt-3 text-white"">");
#nullable restore
#line 57 "D:\repos\piano-pizza\piano-pizza\Areas\PackerStaff\Views\Main\PackerProfile.cshtml"
                                                                                                     Write(local.GetLocalizedHtmlString("Save Changes"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</button>
                            </form>
                        </div>
                    </div>
                    <div role=""tabpanel"" class=""tab-pane "" id=""timeline"">
                        <div class=""card"">
                            <div class=""header bline"">
                                <h2>");
#nullable restore
#line 64 "D:\repos\piano-pizza\piano-pizza\Areas\PackerStaff\Views\Main\PackerProfile.cshtml"
                               Write(local.GetLocalizedHtmlString("Change Password"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
                            </div>
                            <div class=""body"" style=""padding: 20px 20px 9px 20px!important;"">
                                <form class=""row"" id=""editPasswordForm"">
                                    <div class=""col-md-4 col-sm-12 col-12"">
                                        <div class=""form-group"">
                                            <input type=""password"" class=""form-control"" id=""current_password"" name=""current_password""");
            BeginWriteAttribute("placeholder", " placeholder=\"", 4262, "\"", 4325, 1);
#nullable restore
#line 70 "D:\repos\piano-pizza\piano-pizza\Areas\PackerStaff\Views\Main\PackerProfile.cshtml"
WriteAttributeValue("", 4276, local.GetLocalizedHtmlString("Current Password"), 4276, 49, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                        </div>
                                    </div>
                                    <div class=""col-md-4 col-sm-12 col-12"">
                                        <div class=""form-group"">
                                            <input type=""password"" class=""form-control"" id=""new_password"" name=""new_password""");
            BeginWriteAttribute("placeholder", " placeholder=\"", 4689, "\"", 4748, 1);
#nullable restore
#line 75 "D:\repos\piano-pizza\piano-pizza\Areas\PackerStaff\Views\Main\PackerProfile.cshtml"
WriteAttributeValue("", 4703, local.GetLocalizedHtmlString("New Password"), 4703, 45, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                        </div>
                                    </div>
                                    <div class=""col-md-4 col-sm-12 col-12"">
                                        <div class=""form-group"">
                                            <input type=""password"" class=""form-control"" id=""confirm_password"" name=""confirm_password""");
            BeginWriteAttribute("placeholder", " placeholder=\"", 5120, "\"", 5183, 1);
#nullable restore
#line 80 "D:\repos\piano-pizza\piano-pizza\Areas\PackerStaff\Views\Main\PackerProfile.cshtml"
WriteAttributeValue("", 5134, local.GetLocalizedHtmlString("Confirm Password"), 5134, 49, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        </div>\r\n                                    </div>\r\n                                    <button id=\"PassChange\" class=\"btn btn-primary btn-round mt-3 text-white\">");
#nullable restore
#line 83 "D:\repos\piano-pizza\piano-pizza\Areas\PackerStaff\Views\Main\PackerProfile.cshtml"
                                                                                                         Write(local.GetLocalizedHtmlString("Save Changes"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</button>
                                </form>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
<script>
    var loadFile = function (event) {
        var image = document.getElementById(""output"");
        image.src = URL.createObjectURL(event.target.files[0]);
    };
</script>
<!-- Add New  modal -->
<script type=""text/javascript"">
    function changePictureModal() {
        $('#changePictureModal').modal(""show"");
    }
    function shower(type) {
        if (type == 1) {
            $(""#closer"").show();
            $(""#shower"").hide();
            $(""#editBasicForm"").find('input').attr('disabled', false);
        }
        else {
            $(""#editBasicForm"").find('input').attr('disabled', true);
            $(""#closer"").hide();
            $(""#shower"").show();
        }
    }
</script>
<script>
    $('#editProfileForm').submit(function (e) {
   ");
            WriteLiteral(@"     e.preventDefault();
        var file = $('#file').val();
        if (file != """") {
            var response;
            var form = new FormData(document.getElementById('editProfileForm'));
            $.ajax({
                type: 'POST',
                url: '/packerStaff/Main/UpdateProfileImage',
                data: form,
                async: true,
                processData: false,
                contentType: false,
                success: function (data) {
                    response = data;
                    if (response.code == 200) {
                        var data = response.result;
                        $('.UserName').html(data.fullName);
                        $('#UserName').val(data.fullName);
                        $('.imageUrl').attr('src', data.profileImageUrl);
                        $('#EmailUserId').html(data.email);
                        $('#changePictureModal').modal(""hide"");
                        MixinSweet(""Uploaded!"", """", ""success"", 2000);");
            WriteLiteral(@"
                    }
                    else {
                        sweetMessage(""Error!"", response.msg, ""error"");
                    }
                    console.log(data);
                },
                error: function (error) {
                    return error;
                },
            });
        }
    })

    $('#editBasicForm').submit(function (e) {
        e.preventDefault();
        var UserName = $('#Username').val();
        var response = getResponseFromUrl('GET', '/packerStaff/Main/UpdateProfile?Name=' + UserName, null, false);
        if (response.code == 200) {
            TimerSweet(""Profile Updated!"", 'Profile is successfully updated', ""success"", 2000);
            GetProfile();
        }
        else {
            sweetMessage(""Error!"", response.msg, ""error"");
        }
    })
    $('#editPasswordForm').submit(function (e) {
        e.preventDefault();
        var form = new FormData(document.getElementById('editPasswordForm'));
        if ($('#ne");
            WriteLiteral(@"w_password').val() != $('#confirm_password').val()) {
            sweetMessage(""Warning!"", ""Password and confirm password should be same"", ""warning"");
            return false;
        }
        else if ($('#new_password').val() == """" || $('#confirm_password').val() == """" || $('#current_password').val() == """") {
            sweetMessage(""Warning!"", ""Please provide password"", ""warning"");
            return false;
        }
        var response = getResponseFromUrl('POST', '/packerStaff/Main/ChangePassword', form, true);
        if (response.code == 200) {
            TimerSweet(""Password Updated!"", 'Passsword is successfully updated', ""success"", 2000);
            GetProfile();
            document.getElementById('editPasswordForm').reset();
        }
        else {
            console.log(response);
            sweetMessage(""Error!"", response.shortMessage + ""<br>"" + response.result, ""error"");
        }
    })
</script>

<!--Ajax-->
<script>
    var getResponseFromUrl = function (request");
            WriteLiteral(@"Type, requestUrl, requestData, async) {
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
