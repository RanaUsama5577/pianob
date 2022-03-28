#pragma checksum "D:\repos\piano_local\piano_local\Areas\SuperAdmin\Views\AppContent\CookiePolicy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c687a62c6c9ad66bd5e4de67a03b5cf46a6ba212"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_SuperAdmin_Views_AppContent_CookiePolicy), @"mvc.1.0.view", @"/Areas/SuperAdmin/Views/AppContent/CookiePolicy.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c687a62c6c9ad66bd5e4de67a03b5cf46a6ba212", @"/Areas/SuperAdmin/Views/AppContent/CookiePolicy.cshtml")]
    public class Areas_SuperAdmin_Views_AppContent_CookiePolicy : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin-assets/summernote/dist/summernote.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\repos\piano_local\piano_local\Areas\SuperAdmin\Views\AppContent\CookiePolicy.cshtml"
  
    Layout = "~/Areas/SuperAdmin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c687a62c6c9ad66bd5e4de67a03b5cf46a6ba2123654", async() => {
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
            WriteLiteral(@"

<section class=""content profile-page"">
    <div class=""block-header"">
        <div class=""row"">
            <div class=""col-lg-5 col-md-6 col-sm-12"">
                <ul class=""breadcrumb bg-transparent"">
                    <li class=""breadcrumb-item""><a class=""text-secondary""><i class=""far fa-file-alt mr-2""></i>");
#nullable restore
#line 13 "D:\repos\piano_local\piano_local\Areas\SuperAdmin\Views\AppContent\CookiePolicy.cshtml"
                                                                                                         Write(local.GetLocalizedHtmlString("Home"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                    <li class=\"breadcrumb-item text-secondary\">");
#nullable restore
#line 14 "D:\repos\piano_local\piano_local\Areas\SuperAdmin\Views\AppContent\CookiePolicy.cshtml"
                                                          Write(local.GetLocalizedHtmlString("Cookie Policy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</li>
                </ul>
            </div>
        </div>

    </div>
    <div class=""container-fluid"">

        <div class=""row clearfix"">
            <div class=""col-lg-12"">
                <div class=""card"">
                    <div class=""header"">
                        <h2 style=""display: inline-block;"">");
#nullable restore
#line 26 "D:\repos\piano_local\piano_local\Areas\SuperAdmin\Views\AppContent\CookiePolicy.cshtml"
                                                      Write(local.GetLocalizedHtmlString("Cookie Policy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
                        <button id=""edit-button"" onclick=""edit()"" style=""margin-left: auto; font-size: 15px; float: right;"" class=""btn btn-primary"">Edit</button>
                    </div>
                    <div class=""body"">
                        <div id=""simple-text""></div>
                    </div>
                    <div id=""footerdiv"" style=""display:none;"">
                        <div class=""card-footer d-flex flex-row bg-white rounded"">
                            <button onclick=""CancelSection()""  data-context=""warning"" class=""btn-toastr btn btn-danger ml-auto font-15"">");
#nullable restore
#line 34 "D:\repos\piano_local\piano_local\Areas\SuperAdmin\Views\AppContent\CookiePolicy.cshtml"
                                                                                                                                   Write(local.GetLocalizedHtmlString("Cancel"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n                            <button onclick=\"UpdateContent()\" class=\"btn btn-success font-15 ml-3\">");
#nullable restore
#line 35 "D:\repos\piano_local\piano_local\Areas\SuperAdmin\Views\AppContent\CookiePolicy.cshtml"
                                                                                              Write(local.GetLocalizedHtmlString("Update"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</button>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
<script>
    function CancelSection() {
        $('#simple-text').summernote('reset');
        $('#simple-text').summernote('destroy');
        $('#footerdiv').hide();
        $('#edit-button').show();
        $('#HeadingContent').show();
        $('#signup_heading').hide();
    }
    function callbackMax(max) {
        $('#text-count').text(max);
    }
    var edit = function () {
        var max = 4000;
        $('#simple-text').summernote({
            focus: true,
            callbacks: {
                onKeydown: function (e) {
                    var t = e.currentTarget.innerText;
                    if (t.length >= max) {
                        //delete key
                        if (e.keyCode != 8) {
                            e.preventDefault();
                            MixinSweet(""Maximum content limit is 4000"", """", """);
            WriteLiteral(@"info"", 1500);
                        }
                    }
                },
                onKeyup: function (e) {
                    var t = e.currentTarget.innerText;
                    if (typeof callbackMax == 'function') {
                        callbackMax(max - t.length);
                    }
                },
                onPaste: function (e) {
                    var t = e.currentTarget.innerText;
                    var bufferText = ((e.originalEvent || e).clipboardData || window.clipboardData).getData('Text');
                    var all = t + bufferText;
                    if (all.length > max) {
                        e.preventDefault();
                        MixinSweet(""Maximum content limit is 4000"", """", ""info"", 1500);
                    }
                    if (typeof callbackMax == 'function') {
                        callbackMax(max - t.length);
                    }
                }
            }
        });
        $('#edit-button').hide();
 ");
            WriteLiteral(@"       $('#footerdiv').show();
        $('#HeadingContent').hide();
        $('#signup_heading').show();
    };
    var save = function () {
        var markup = $('#simple-text').summernote('code');
        $('#simple-text').summernote('destroy');
        $('#footerdiv').hide();
        $('#edit-button').show();
        $('#HeadingContent').show();
        $('#signup_heading').hide();
    };
</script>

<script>
    $(function () {
        $('#cookie').addClass('active');
        $('#AppData').addClass('toggled');
        GetContent();
    })
    function GetContent() {
        $.ajax({
            url: ""/SuperAdmin/AppContent/GetCookiePolicy"",
            type: ""GET"",
            data: null,
            success: function (response) {
                $('#simple-text').html(response.content);
                $('#HeadingContent').html(response.title);
                $('#signup_heading').val(response.title);
            },
            error: function (result) {
                con");
            WriteLiteral(@"sole.log(""Save Error"", result);
            }
        });
    }
    function UpdateContent() {
        var txt = $('#simple-text').summernote('code');
        var heading = $('#signup_heading').val();
        var data = {};
        data.content = txt;
        data.title = heading;
        $.ajax({
            url: ""/SuperAdmin/AppContent/UpdateCookiePolicy"",
            type: ""POST"",
            contentType: ""application/json"",
            data: JSON.stringify(data),
            dataType: ""json"",
            success: function (response) {
                if (response.code == 200) {
                    TimerSweet(""Cookie Policy Updated!"", 'Cookie Policy are successfully updated', ""success"", 2000);
                    setTimeout(function () {
                        GetContent();
                        $('#simple-text').summernote('destroy');
                        $('#footerdiv').hide();
                        $('#edit-button').show();
                        $('#HeadingContent').sho");
            WriteLiteral(@"w();
                        $('#signup_heading').hide();
                    }, 2000);
                }
                else {
                    sweetMessage(""Error!"", response.shortMessage, ""error"");
                }
            },
            error: function (result) {
                console.log(""Save Error"", result);
            }
        });
    }
</script>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public piano_local.Resources.LocalizationService local { get; private set; }
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