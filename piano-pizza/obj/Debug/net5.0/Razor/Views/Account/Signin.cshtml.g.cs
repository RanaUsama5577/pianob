#pragma checksum "D:\repos\piano-pizza\piano-pizza\Views\Account\Signin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c25a3a74f6a49e73ebf82eeb39cd44d626e0e946"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Signin), @"mvc.1.0.view", @"/Views/Account/Signin.cshtml")]
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
#nullable restore
#line 1 "D:\repos\piano-pizza\piano-pizza\Views\_ViewImports.cshtml"
using piano_pizza;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\repos\piano-pizza\piano-pizza\Views\_ViewImports.cshtml"
using piano_pizza.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c25a3a74f6a49e73ebf82eeb39cd44d626e0e946", @"/Views/Account/Signin.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4fd62fd606701e7948749f622ddc31478ced86fe", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Signin : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("LoginForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "Post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("SignupForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("autocomplete", new global::Microsoft.AspNetCore.Html.HtmlString("off"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\repos\piano-pizza\piano-pizza\Views\Account\Signin.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!-- #header-wrap -->
<div id=""header-bottom-wrap"" class=""is-clearfix"">
    <div id=""header-bottom"" class=""site-header-bottom"">
        <div id=""header-bottom-inner"" class=""site-header-bottom-inner "">
            <section class=""hero slider is-clearfix "">
                <div style=""background-image: url('/app-images/home.jpg');background-repeat: no-repeat;background-size: cover;height: 200px;position: relative;background-position: center center;"">
                </div>
                <div style=""position: absolute;width: 100%;height: 100%;background-color: #000000;opacity: 0.5;transition: background 0.3s, border-radius 0.3s, opacity 0.3s;"">
                </div>
                <div style=""text-align: center;position: absolute;width: 100%;"">
                    <h2 style=""color: #fff;font-size: 36px;margin-top: 138px;font-family: 'LIBRE FRANKLIN', sans-serif;""");
            BeginWriteAttribute("class", " class=\"", 940, "\"", 948, 0);
            EndWriteAttribute();
            WriteLiteral(@">Sign In </h2>
                </div>
            </section>
            <!-- .slider -->
        </div>
        <!-- #header-bottom-inner -->
    </div>
    <!-- #header-bottom -->
</div>

<!-- import content layouts and modules -->
<div id=""content-main-wrap"" class=""is-clearfix"">
    <div id=""content-area"" class=""site-content-area"">
        <div id=""content-area-inner"" class=""site-content-area-inner"">
            <section class=""section  is-clearfix"">
                <div class=""container"">
                    <br>
                    <br>
                    <div class=""columns is-variable is-multiline"">
                        <div class=""column is-half is-offset-one-quarter"">
                            <div class=""tabs-list"">
                                <div class=""tabs is-boxed is-centered"">
                                    <ul>
                                        <li class=""is-active"">
                                            <a>
                                 ");
            WriteLiteral(@"               <span class=""icon"">
                                                    <i class=""fas fa-sign-in-alt""></i>
                                                </span>
                                                <span>Login</span>
                                            </a>
                                        </li>
                                        <li>
                                            <a>
                                                <span class=""icon"">
                                                    <i class=""fas fa-user""></i>
                                                </span>
                                                <span>Register</span>
                                            </a>
                                        </li>
                                    </ul>
                                </div>
                                <!-- .tabs -->
                                <div class=""tabs-content"">
                 ");
            WriteLiteral("                   <div class=\"tab-block content\">\r\n                                        <br>\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c25a3a74f6a49e73ebf82eeb39cd44d626e0e9468379", async() => {
                WriteLiteral("\r\n                                            ");
#nullable restore
#line 60 "D:\repos\piano-pizza\piano-pizza\Views\Account\Signin.cshtml"
                                       Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                            <div class=""field"">
                                                <div class=""control is-expanded"">
                                                    <input class=""input"" id=""EmailLogin"" type=""email"" name=""email"" placeholder=""Email"">
                                                </div>
                                            </div>
                                            <!-- .field -->
                                            <div class=""field"">
                                                <div class=""control is-expanded"">
                                                    <input class=""input"" id=""PasswordLogin"" type=""password"" name=""password"" placeholder=""Password"">
                                                </div>
                                            </div>
                                            <!-- .field -->
                                            <div class=""field "">
                                    ");
                WriteLiteral(@"            <div class=""control"">
                                                    <div class=""level"">
                                                        <div class=""level-left"">
                                                            <button class=""button is-small"">Login</button>
                                                        </div>
                                                        <div class=""level-right"">
                                                            <a href=""#"">Forgot Password?</a>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                            <!-- .field -->
                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                    </div>
                                    <!-- .tab-block -->
                                    <div class=""tab-block content"">
                                        <br>
                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c25a3a74f6a49e73ebf82eeb39cd44d626e0e94612501", async() => {
                WriteLiteral("\r\n                                            ");
#nullable restore
#line 92 "D:\repos\piano-pizza\piano-pizza\Views\Account\Signin.cshtml"
                                       Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                            <div class=""field"">
                                                <div class=""control is-expanded"">
                                                    <input class=""input"" type=""text"" id=""NameSignup"" name=""name"" placeholder=""Name"">
                                                </div>
                                            </div>
                                            <!-- .field -->
                                            <div class=""field"">
                                                <div class=""control is-expanded"">
                                                    <input class=""input"" type=""text"" id=""Username"" name=""Username"" placeholder=""Username"" maxlength=""10"">
                                                </div>
                                            </div>
                                            <!-- .field -->
                                            <div class=""field"">
                                  ");
                WriteLiteral(@"              <div class=""control is-expanded"">
                                                    <input class=""input"" type=""text"" id=""EmailSignup"" name=""email"" placeholder=""Email"">
                                                </div>
                                            </div>
                                            <!-- .field -->
                                            <div class=""field"">
                                                <div class=""control is-expanded"">
                                                    <input class=""input"" type=""password"" autocomplete=""new-password"" id=""PasswordSignup"" name=""password"" placeholder=""Password"">
                                                </div>
                                            </div>
                                            <!-- .field -->
                                            <div class=""field"">
                                                <div class=""control"">
                                      ");
                WriteLiteral(@"              <button class=""button is-small"">Register Now</button>
                                                </div>
                                            </div>
                                            <!-- .field -->
                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                    </div>
                                    <!-- .tab-block -->
                                </div>
                                <!-- .tabs-content -->
                            </div>
                        </div>
                    </div>
                    <br>
                </div>
            </section>
        </div>
        <!-- #content-area-inner -->
    </div>
    <!-- #content-area -->
</div>
<!-- #content-main-wrap -->

<script>
    $('#LoginForm').submit(async function (e) {
        e.preventDefault();
        if ($('#EmailLogin').val() == """" || $('#PasswordLogin').val() == """") {
            MixinSweet(""Please provide login details!"", """", ""success"", 2000);
            return false;
        }
        var formData = new FormData(document.getElementById(""LoginForm""));
        var response = await getResponseFromUrl('POST', '/Account/Signin', formData, true);
        if (response.code == 200) {
            MixinSweet(""Logged ");
            WriteLiteral(@"In!"","""", ""success"", 2000);
            document.getElementById('LoginForm').reset();
            window.location.href = response.shortMessage;
        }
        else {
            console.log(response);
            sweetMessage(""Error!"", response.shortMessage, ""error"");
        }
    })

    $('#SignupForm').submit(async function (e) {
        e.preventDefault();
        if ($('#NameSignup').val() == """" || $('#EmailSignup').val() == """" || $('#PasswordSignup').val() == """") {
            MixinSweet(""Please provide login details!"", """", ""success"", 2000);
            return false;
        }
        var formData = new FormData(document.getElementById(""SignupForm""));
        var response = await getResponseFromUrl('POST', '/Account/Signup', formData, true);
        if (response.code == 200) {
            MixinSweet(""Registered!"", ""Please login to continue"", ""success"", 2000);
            document.getElementById('SignupForm').reset();
            document.getElementById('LoginForm').reset();
    ");
            WriteLiteral(@"    }
        else if (response.code == 402) {
            console.log(response);
            var s = """";
            if (response.result.length > 0) {
                response.result.forEach(function (item) {
                    s += item + ""<br>"";
                })
            }
            sweetMessage(""Error!"", response.shortMessage + ""<br>"" + s, ""error"");
        }
        else {
            console.log(response);
            sweetMessage(""Error!"", response.shortMessage, ""error"");
        }
    })
</script>

<!--Ajax-->
<script>
    var getResponseFromUrl = function (requestType, requestUrl, requestData, async) {
        var response;
        return $.ajax({
            type: requestType,
            url: requestUrl,
            data: requestData,
            async: async,
            processData: false,
            contentType: false,
            success: function (data) {
                response = data;
                return response;
            },
            error");
            WriteLiteral(": function (error) {\r\n                return error;\r\n            },\r\n        });\r\n    }\r\n</script>");
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
