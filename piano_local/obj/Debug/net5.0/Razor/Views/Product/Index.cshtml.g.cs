#pragma checksum "D:\repos\piano_local\piano_local\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0dcb945d7d4bb96b0bf5d78d934141dce2e97b14"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0dcb945d7d4bb96b0bf5d78d934141dce2e97b14", @"/Views/Product/Index.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Entities.ProductAndIngredientDtos>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/orderassets/assets/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/orderassets/assets/css/style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\repos\piano_local\piano_local\Views\Product\Index.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0dcb945d7d4bb96b0bf5d78d934141dce2e97b143836", async() => {
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
            WriteLiteral("\r\n<!-- Custom Stylesheet -->\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0dcb945d7d4bb96b0bf5d78d934141dce2e97b144981", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<!-- #header-wrap -->
<div id=""header-bottom-wrap"" class=""is-clearfix"">
    <div id=""header-bottom"" class=""site-header-bottom"">
        <div id=""header-bottom-inner"" class=""site-header-bottom-inner "">
            <section class=""hero slider is-clearfix "">
                <div style=""background-image: url('/app-images/home.jpg'); background-repeat: no-repeat; background-size: cover; height: 200px; position: relative; background-position: center center;"">
                </div>
                <div style=""position: absolute;width: 100%;height: 100%;background-color: #000000;opacity: 0.5;transition: background 0.3s, border-radius 0.3s, opacity 0.3s;"">
                </div>
                <div style=""text-align: center;position: absolute;width: 100%;"">
                    <h2 style=""color: #fff;font-size: 36px;margin-top: 138px;font-family: 'LIBRE FRANKLIN', sans-serif;""");
            BeginWriteAttribute("class", " class=\"", 1215, "\"", 1223, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 19 "D:\repos\piano_local\piano_local\Views\Product\Index.cshtml"
                                                                                                                             Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
                </div>
            </section>
            <!-- .slider -->
        </div>
        <!-- #header-bottom-inner -->
    </div>
    <!-- #header-bottom -->
</div>
<!-- #header-bottom-wrap -->
<!-- import content layouts and modules -->
<div id=""content-main-wrap"" class=""is-clearfix"">
    <div id=""content-area"" class=""site-content-area"">
        <div id=""content-area-inner"" class=""site-content-area-inner"">
            <!-- works section -->
            <section id=""welcome"" class=""section introduction is-clearfix"">
                <div class=""container"">
                    <div class=""columns is-variable is-6 is-multiline"">
                        <div class=""column is-6-desktop is-12-tablet has-text-centered"">
                            <div class=""works-latest"">
                                <div class=""works-latest-item"">
                                    <img alt=""Joo - Niche Multi-Purpose HTML Template""");
            BeginWriteAttribute("src", " src=\"", 2200, "\"", 2217, 1);
#nullable restore
#line 40 "D:\repos\piano_local\piano_local\Views\Product\Index.cshtml"
WriteAttributeValue("", 2206, Model.Logo, 2206, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                </div>
                                <!-- .works-latest-item -->
                            </div>
                        </div>
                        <div class=""column is-6-desktop is-12-tablet"">
                            <h1 style=""font-size: 34px;"" class=""heading-title style-3 has-text-left"">
                                ");
#nullable restore
#line 47 "D:\repos\piano_local\piano_local\Views\Product\Index.cshtml"
                           Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - $");
#nullable restore
#line 47 "D:\repos\piano_local\piano_local\Views\Product\Index.cshtml"
                                          Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </h1>\r\n                            <p> ");
#nullable restore
#line 49 "D:\repos\piano_local\piano_local\Views\Product\Index.cshtml"
                           Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n                            <br>\r\n");
#nullable restore
#line 51 "D:\repos\piano_local\piano_local\Views\Product\Index.cshtml"
                             if (User.Identity.IsAuthenticated && Model.AddedToCart == true)
                            {

                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"content\">\r\n                                    <h3>\r\n                                        ");
#nullable restore
#line 59 "D:\repos\piano_local\piano_local\Views\Product\Index.cshtml"
                                   Write(local.GetLocalizedHtmlString("Additional Ingredients"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </h3>\r\n                                    <ul class=\"list no-margin\" style=\"padding:0px 100px 0px 0px;\">\r\n");
#nullable restore
#line 62 "D:\repos\piano_local\piano_local\Views\Product\Index.cshtml"
                                         foreach (var i in Model.IngredientLists)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                            <li>
                                                <div class=""row"">
                                                    <div class=""col-sm-5 col-12"">
                                                        <div class=""ps-checkbox"">
                                                            <input class=""form-control ingredient_name"" data-ingredient=""");
#nullable restore
#line 68 "D:\repos\piano_local\piano_local\Views\Product\Index.cshtml"
                                                                                                                    Write(i.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-price=\"");
#nullable restore
#line 68 "D:\repos\piano_local\piano_local\Views\Product\Index.cshtml"
                                                                                                                                       Write(i.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" type=\"checkbox\"");
            BeginWriteAttribute("id", " id=\"", 3886, "\"", 3898, 2);
            WriteAttributeValue("", 3891, "c-", 3891, 2, true);
#nullable restore
#line 68 "D:\repos\piano_local\piano_local\Views\Product\Index.cshtml"
WriteAttributeValue("", 3893, i.Id, 3893, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                            <label");
            BeginWriteAttribute("for", " for=\"", 3968, "\"", 3981, 2);
            WriteAttributeValue("", 3974, "c-", 3974, 2, true);
#nullable restore
#line 69 "D:\repos\piano_local\piano_local\Views\Product\Index.cshtml"
WriteAttributeValue("", 3976, i.Id, 3976, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 69 "D:\repos\piano_local\piano_local\Views\Product\Index.cshtml"
                                                                            Write(i.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</label>
                                                        </div>
                                                    </div>
                                                    <div class=""col-sm-7 col-12 d-flex flex-row mt-n3"">
                                                        <div class=""input-group bootstrap-touchspin m-0"" style=""display: flex;position: relative;margin:auto"">
                                                            <span class=""input-group-btn bootstrap-touchspin-injected""");
            BeginWriteAttribute("style", " style=\"", 4507, "\"", 4515, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                                                <button onclick=""IngredientDownFunction(this)"" class=""btn btn-primary bootstrap-touchspin-down disabled-max-min rounded-circle"" type=""button"">-</button>
                                                            </span>
                                                            <input");
            BeginWriteAttribute("id", " id=\"", 4872, "\"", 4886, 2);
            WriteAttributeValue("", 4877, "val-", 4877, 4, true);
#nullable restore
#line 77 "D:\repos\piano_local\piano_local\Views\Product\Index.cshtml"
WriteAttributeValue("", 4881, i.Id, 4881, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"text\" class=\"quantity-counter form-control\"");
            BeginWriteAttribute("readonly", " readonly=\"", 4937, "\"", 4948, 0);
            EndWriteAttribute();
            WriteLiteral(" value=\"0\"");
            BeginWriteAttribute("style", " style=\"", 4959, "\"", 4967, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                            <span class=\"input-group-btn bootstrap-touchspin-injected\"");
            BeginWriteAttribute("style", " style=\"", 5089, "\"", 5097, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                                                <button onclick=""IngredientUpFunction(this)"" class=""btn btn-primary bootstrap-touchspin-up rounded-circle"" type=""button"">+</button>
                                                            </span>
                                                        </div>
                                                        <span class=""ml-auto pt-4"">");
#nullable restore
#line 82 "D:\repos\piano_local\piano_local\Views\Product\Index.cshtml"
                                                                              Write(i.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                                    </div>\r\n                                                </div>\r\n                                            </li>\r\n");
#nullable restore
#line 86 "D:\repos\piano_local\piano_local\Views\Product\Index.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    </ul>
                                    <div class=""item-quantity"" style="" margin-top: 20px;"">
                                        <span class=""quantity-title"">Qty:</span>
                                        <div class=""quantity-counter-wrapper"">
                                            <div class=""input-group bootstrap-touchspin"" style=""display: flex;position: relative;"">
                                                <span class=""input-group-btn bootstrap-touchspin-injected""");
            BeginWriteAttribute("style", " style=\"", 6277, "\"", 6285, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                                    <button class=""btn btn-primary touch-down bootstrap-touchspin-down disabled-max-min rounded-circle"" type=""button"">-</button>
                                                </span>
                                                <input id=""Quantity"" type=""text"" class=""quantity-counter form-control""");
            BeginWriteAttribute("readonly", " readonly=\"", 6642, "\"", 6653, 0);
            EndWriteAttribute();
            WriteLiteral(" value=\"1\"");
            BeginWriteAttribute("style", " style=\"", 6664, "\"", 6672, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                <span class=\"input-group-btn bootstrap-touchspin-injected\"");
            BeginWriteAttribute("style", " style=\"", 6782, "\"", 6790, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                                    <button class=""btn btn-primary touch-up bootstrap-touchspin-up rounded-circle"" type=""button"">+</button>
                                                </span>
                                            </div>
                                        </div>
                                    </div>
                                </div>
");
#nullable restore
#line 103 "D:\repos\piano_local\piano_local\Views\Product\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 104 "D:\repos\piano_local\piano_local\Views\Product\Index.cshtml"
                             if (User.Identity.IsAuthenticated && Model.AddedToCart == false)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <button onclick=""AddToCart(this,false)"" href=""#"" style=""background-color: #2d2929;"" class=""button SpinnerBtn"">
                                    <span class=""spinner-grow spinner-grow-sm"" role=""status"" aria-hidden=""true""></span>
                                    <span class=""spinner-loading ms-25 align-middle"">Loading...</span>
                                    <span class=""SpinnerText"">");
#nullable restore
#line 109 "D:\repos\piano_local\piano_local\Views\Product\Index.cshtml"
                                                         Write(local.GetLocalizedHtmlString("Add To Cart"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span>\r\n                                </button>\r\n");
#nullable restore
#line 111 "D:\repos\piano_local\piano_local\Views\Product\Index.cshtml"
                            }
                            else if (User.Identity.IsAuthenticated && Model.AddedToCart == true)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <a");
            BeginWriteAttribute("href", " href=\"", 8063, "\"", 8097, 1);
#nullable restore
#line 114 "D:\repos\piano_local\piano_local\Views\Product\Index.cshtml"
WriteAttributeValue("", 8070, Url.Action("Cart","Order"), 8070, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"background-color: #2d2929;\" class=\"button\">");
#nullable restore
#line 114 "D:\repos\piano_local\piano_local\Views\Product\Index.cshtml"
                                                                                                           Write(local.GetLocalizedHtmlString("View In Cart"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 115 "D:\repos\piano_local\piano_local\Views\Product\Index.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <a style=\"background-color: #2d2929;\" class=\"button\"");
            BeginWriteAttribute("href", " href=\"", 8372, "\"", 8410, 1);
#nullable restore
#line 118 "D:\repos\piano_local\piano_local\Views\Product\Index.cshtml"
WriteAttributeValue("", 8379, Url.Action("Signin","Account"), 8379, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 118 "D:\repos\piano_local\piano_local\Views\Product\Index.cshtml"
                                                                                                               Write(local.GetLocalizedHtmlString("Sign In To Manage Cart"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 119 "D:\repos\piano_local\piano_local\Views\Product\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </div>
                    </div>
                </div>
            </section>
        </div>
    </div>
    <!-- #content-area -->
</div>
<script>
    $(function () {
        $('.touch-up').on('click', function () {
            var s = parseInt($(this).parent().siblings('input').val()) + 1;
            $(this).parent().siblings('input').val(s > 50 ? 50 : s);
        })
        $('.touch-down').on('click', function () {
            var s = parseInt($(this).parent().siblings('input').val()) - 1;
            $(this).parent().siblings('input').val(s <= 0 ? 1 : s);
        })
    })
    $('.ingredient_name').on('click', function () {
        if ($(this).prop('checked')) {
            $(this).closest('.col-sm-5').siblings('.col-sm-7').find('.quantity-counter').val(1);
        }
        else {
            $(this).closest('.col-sm-5').siblings('.col-sm-7').find('.quantity-counter').val(0);
        }
    })
    function IngredientUpFunction(element) {
        var i");
            WriteLiteral(@"nput = $(element).parent().siblings('.quantity-counter');
        var itemCount = $(element).parent().siblings('.quantity-counter').val();
        var itemCount = parseInt(itemCount);
        itemCount += 1;
        if (itemCount <= 99) {
            $(input).val(itemCount);
        }
        $(element).closest('.col-sm-7').prev('.col-sm-5').find('input').prop('checked', true);
    }
    function IngredientDownFunction(element) {
        var input = $(element).parent().siblings('.quantity-counter');
        var itemCount = $(element).parent().siblings('.quantity-counter').val();
        var itemCount = parseInt(itemCount);
        itemCount -= 1;
        if (itemCount >= 0) {
            $(input).val(itemCount);
        }
        if (itemCount == 0) {
            $(element).closest('.col-sm-7').prev('.col-sm-5').find('input').prop('checked', false);
        }
    }
</script>

<script>
    function AddToCart(element, n) {
        $(element).addClass('SpinnerProgressBtn').removeClass('S");
            WriteLiteral(@"pinnerBtn');
        var pushs = [];
        var quantity = 0;
        $('input[type=""checkbox""]:checked').each(function (index, obj) {
            var ingredient = $(obj).attr('data-ingredient');
            quantity = $('#val-' + ingredient).val();
            var data = {
                Id: parseInt(ingredient),
                quantity: parseInt(quantity),
            };
            pushs.push(data);
        })
        console.log(pushs);
        var product_data = JSON.stringify({
            'allIngredients': pushs,
            'quantity': $('#Quantity').val(),
            'branchBool': n,
            'price': '");
#nullable restore
#line 190 "D:\repos\piano_local\piano_local\Views\Product\Index.cshtml"
                 Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("\',\r\n            \'productId\': \'");
#nullable restore
#line 191 "D:\repos\piano_local\piano_local\Views\Product\Index.cshtml"
                     Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
        });

        $.ajax({
            type: 'POST',
            url: '/Product/AddToCart',
            data: product_data,
            async: true,
            contentType: 'application/json; charset=utf-8',
            dataType: 'json',
            success: function (data) {
                console.log(""Api"", data);
                $(element).addClass('SpinnerBtn').removeClass('SpinnerProgressBtn');
                if (data.code == 200) {
                    MixinSweet(""Product added to cart!"", """", ""success"", ""2000"");
                    setTimeout(function () {
                        location.reload();
                    }, 2000);
                }
                else if (data.code == 401) {
                    Swal.fire({
                        title: data.shortMessage,
                        text: """",
                        icon: 'warning',
                        showCancelButton: true,
                        confirmButtonColor: '#3085d6',
                        c");
            WriteLiteral(@"ancelButtonColor: '#d33',
                        confirmButtonText: 'Confirm!',
                    }).then((result) => {
                        if (result.isConfirmed) {
                            AddToCart(element,true);
                        }
                    })
                }
                else {
                    sweetMessage(""Warning!"", data.shortMessage, ""error"");
                }
            },
            error: function (error) {
                return error;
            },
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Entities.ProductAndIngredientDtos> Html { get; private set; }
    }
}
#pragma warning restore 1591