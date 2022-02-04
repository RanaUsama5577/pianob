#pragma checksum "D:\repos\piano-pizza\piano-pizza\Areas\SuperAdmin\Views\Product\AddIngredients.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ad2a51be0f394ed68b53fad7e48b1a127b7778b0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_SuperAdmin_Views_Product_AddIngredients), @"mvc.1.0.view", @"/Areas/SuperAdmin/Views/Product/AddIngredients.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad2a51be0f394ed68b53fad7e48b1a127b7778b0", @"/Areas/SuperAdmin/Views/Product/AddIngredients.cshtml")]
    public class Areas_SuperAdmin_Views_Product_AddIngredients : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin-assets/images/piano/Bg-transparent/Ingredient-removebg-preview.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("30"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("ml-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\repos\piano-pizza\piano-pizza\Areas\SuperAdmin\Views\Product\AddIngredients.cshtml"
  
    Layout = "~/Areas/SuperAdmin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<section class=\"content\">\r\n    <div class=\"block-header\">\r\n        <div class=\"row\">\r\n            <div class=\"col-12\">\r\n                <h2>\r\n                    ");
#nullable restore
#line 10 "D:\repos\piano-pizza\piano-pizza\Areas\SuperAdmin\Views\Product\AddIngredients.cshtml"
               Write(local.GetLocalizedHtmlString("Add Ingredients"));

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ad2a51be0f394ed68b53fad7e48b1a127b7778b04430", async() => {
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
                        <form id=""Form"">
                            <div id=""form_validation"" method=""POST"">
                                <div class=""row mt-4"">
                                    <div class=""col-md-3"">
                                        <div class=""form-group"">
                                            <label>");
#nullable restore
#line 26 "D:\repos\piano-pizza\piano-pizza\Areas\SuperAdmin\Views\Product\AddIngredients.cshtml"
                                              Write(local.GetLocalizedHtmlString("Select Branch"));

#line default
#line hidden
#nullable disable
            WriteLiteral("*</label>\r\n                                            ");
#nullable restore
#line 27 "D:\repos\piano-pizza\piano-pizza\Areas\SuperAdmin\Views\Product\AddIngredients.cshtml"
                                       Write(Html.DropDownList("BranchId", (IEnumerable<SelectListItem>)ViewBag.Branches, new { @class = "form-group form-float selectLists show-tick w-100 border-light", onchange = "ShowCategories()" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </div>
                                    </div>
                                    <div class=""col-md-3"">
                                        <div class=""form-group"">
                                            <label>");
#nullable restore
#line 32 "D:\repos\piano-pizza\piano-pizza\Areas\SuperAdmin\Views\Product\AddIngredients.cshtml"
                                              Write(local.GetLocalizedHtmlString("Select Category"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"*</label>
                                            <select id=""CategoryId"" name=""CategoryId"" class=""form-group selectLists form-float show-tick w-100 border-light"" onchange=""ShowProducts()"">
                                            </select>
                                        </div>
                                    </div>
                                    <div class=""col-md-3"">
                                        <div class=""form-group"">
                                            <label>");
#nullable restore
#line 39 "D:\repos\piano-pizza\piano-pizza\Areas\SuperAdmin\Views\Product\AddIngredients.cshtml"
                                              Write(local.GetLocalizedHtmlString("Select Product"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</label>
                                            <select id=""ProductId"" name=""ProductId"" class=""form-group  form-float show-tick w-100 border-light"">
                                            </select>
                                        </div>
                                    </div>
                                    <div class=""col-md-12"">
                                        <div class=""row"">
                                            <div class=""col-md-3"">
                                                <a onclick=""AddForm()"" class=""btn btn-raised btn-primary btn-round waves-effect mb-4"" style=""color: #fff;"">Add Ingrendient</a>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div id=""targetDIV"">

                                </div>
                                <a onclick=""AddIngredient()"" class=""btn btn-r");
            WriteLiteral("aised btn-primary btn-round waves-effect mb-4\" style=\"float:right;color:#fff;\">");
#nullable restore
#line 55 "D:\repos\piano-pizza\piano-pizza\Areas\SuperAdmin\Views\Product\AddIngredients.cshtml"
                                                                                                                                                       Write(local.GetLocalizedHtmlString("SUBMIT"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>
                            </div>
                        </form>
                    </div>
                </div>
            </div>
        </div>
        <!-- #END# Basic Validation -->
        <div style=""display:none"">
            <select id=""CategorySelect"">
");
#nullable restore
#line 65 "D:\repos\piano-pizza\piano-pizza\Areas\SuperAdmin\Views\Product\AddIngredients.cshtml"
                 foreach (var i in (IEnumerable<SelectListItem>)ViewBag.Categories)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <optgroup");
            BeginWriteAttribute("label", " label=\"", 3843, "\"", 3864, 1);
#nullable restore
#line 67 "D:\repos\piano-pizza\piano-pizza\Areas\SuperAdmin\Views\Product\AddIngredients.cshtml"
WriteAttributeValue("", 3851, i.Group.Name, 3851, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <option");
            BeginWriteAttribute("value", " value=\"", 3899, "\"", 3915, 1);
#nullable restore
#line 68 "D:\repos\piano-pizza\piano-pizza\Areas\SuperAdmin\Views\Product\AddIngredients.cshtml"
WriteAttributeValue("", 3907, i.Value, 3907, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 68 "D:\repos\piano-pizza\piano-pizza\Areas\SuperAdmin\Views\Product\AddIngredients.cshtml"
                                            Write(i.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n                    </optgroup>\r\n");
#nullable restore
#line 70 "D:\repos\piano-pizza\piano-pizza\Areas\SuperAdmin\Views\Product\AddIngredients.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </select>\r\n            <select id=\"ProductSelect\">\r\n");
#nullable restore
#line 73 "D:\repos\piano-pizza\piano-pizza\Areas\SuperAdmin\Views\Product\AddIngredients.cshtml"
                 foreach (var i in (IEnumerable<SelectListItem>)ViewBag.Products)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <optgroup");
            BeginWriteAttribute("label", " label=\"", 4182, "\"", 4203, 1);
#nullable restore
#line 75 "D:\repos\piano-pizza\piano-pizza\Areas\SuperAdmin\Views\Product\AddIngredients.cshtml"
WriteAttributeValue("", 4190, i.Group.Name, 4190, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <option");
            BeginWriteAttribute("value", " value=\"", 4238, "\"", 4254, 1);
#nullable restore
#line 76 "D:\repos\piano-pizza\piano-pizza\Areas\SuperAdmin\Views\Product\AddIngredients.cshtml"
WriteAttributeValue("", 4246, i.Value, 4246, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 76 "D:\repos\piano-pizza\piano-pizza\Areas\SuperAdmin\Views\Product\AddIngredients.cshtml"
                                            Write(i.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n                    </optgroup>\r\n");
#nullable restore
#line 78 "D:\repos\piano-pizza\piano-pizza\Areas\SuperAdmin\Views\Product\AddIngredients.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </select>
        </div>
    </div>
</section>

<script>
    $(function () {
        $('#product').addClass('toggled');
        $('#AddIngredient').addClass('active');
        ShowCategories();
        ShowProducts();
    })
    function ShowCategories() {
        var s = $('#BranchId').val();
        $('#CategoryId').selectpicker('destroy');
        var options = $('#CategorySelect > optgroup[label=""' + s + '""] > option').clone();
        $('#CategoryId').html(options);
        $('#CategoryId').selectpicker();
        ShowProducts();
    }
    function ShowProducts() {
        var s = $('#CategoryId').val();
        $('#ProductId').selectpicker('destroy');
        var options = $('#ProductSelect > optgroup[label=""' + s + '""] > option').clone();
        $('#ProductId').html("""");
        $('#ProductId').html('<option value="""" disabled selected>----Select Product----</option>');
        $('#ProductId').append(options);
        $('#ProductId').selectpicker();
    }
    fu");
            WriteLiteral(@"nction AddForm() {
        var targetDiv = $(""#targetDIV"");
        targetDiv.append('<div class=""mb-3 p-2 border rounded"">' +
            '<div class=""form-row"">' +
            '<div class=""col-md-12"">'+
            '<a onclick=""DeleteThisForm(this)"" class=""btn btn-raised btn-danger btn-round waves-effect mb-4"" style=""color:#fff;float: right;margin-bottom: 0px !important;"">Remove</a>'+
            '</div>'+
            '<div class=""form-group col-md-6 col-sm-12 col-12"">' +
            '<label>Ingredient Name*</label>' +
            '<input type=""text"" class=""form-control name"" placeholder=""Enter Name..."" required>' +
            '</div>' +
            '<div class=""form-group col-md-6 col-sm-12 col-12"">' +
            '<label>Price*</label>' +
            '<input type=""number"" class=""form-control price float_valid"" placeholder=""Enter Price..."" required>' +
            '</div>' +
            '</div>' +
            '</div>');
        $("".float_valid"").keypress(function () {
            return ev");
            WriteLiteral(@"ent.charCode >= 48 && event.charCode <= 57 || event.charCode == 46;
        });
        $("".float_valid"").keyup(function (elem) {
            var val = $(this).val();

            var tmp = $(this).val().replace(/^0+/, '0');
            if (tmp.charAt(0) == 0 && tmp.charAt(1) > 0) {
                tmp = 0;
            }
            $(this).val(tmp);

            var fixer = 0;
            if (val.includes(""."")) {
                if (tmp.charAt(0) == ""."") {
                    $(this).val(fixer);
                }
                // IF DOUBLE MINUS APPEARS
                else if ((val.match(/\./g).length) > 1) {
                    $(this).val(fixer);
                }
            }
        });
        $("".float_valid"").on('input', function (elem) {
            var t = $(this).val();
            $(this).val((t.indexOf(""."") >= 0) ? (t.substr(0, t.indexOf(""."")) + t.substr(t.indexOf("".""), 3)) : t);
        });
    }
    function DeleteThisForm(element) {
        $(element).closest('.");
            WriteLiteral(@"mb-3').remove();
    }
    function AddIngredient() {
        var bool = true;
        var GetAllValues = [];
        $('#Form').find(('.form-control,.selectLists')).each(function (i, obj) {
            if (!$(obj).hasClass('dropdown')) {
                var values = getDataFromSimpleField($(obj));
                GetAllValues.push(values);
                if (GetAllValues.includes(false)) {
                    bool = false;
                }
            }
        })
        if (bool == false) {
            MixinSweet(""Please fill all the required fields"", """", ""error"", 2000);
        }
        else {
            var list = [];
            $('#Form').find(('.form-row')).each(function (i, obj) {
                var name = """";
                var price = """";
                $(obj).find('.form-control').each(function (i, childObj) {
                    if ($(childObj).hasClass('name')) {
                        name = $(childObj).val();
                    }
                    else {
 ");
            WriteLiteral(@"                       price = $(childObj).val();
                    }
                })
                var data = {
                    name: name,
                    price: price,
                }
                list.push(data);
            })
            console.log(list);

            var data = JSON.stringify({
                        'branchId': $('#BranchId').val(),
                        'categoryId': $('#CategoryId').val(),
                        'productId': $('#ProductId').val(),
                        'items': list,
                    });
            $.ajax({
                type: 'POST',
                url: '/SuperAdmin/Product/AddIngredients',
                data: data,
                async: true,
                contentType: 'application/json; charset=utf-8',
                dataType: 'json',
                success: function (data) {
                    console.log(data);
                    if (data.code == 200) {
                        TimerSweet(""Ing");
            WriteLiteral(@"rendients Added!"", 'Ingrendients is successfully added', ""success"", 2000);
                        setTimeout(function () {
                            location.reload();
                        }, 1000);
                    }
                    else {
                        sweetMessage(""Error!"", data.shortMessage, ""error"");
                    }
                },
                error: function (error) {
                    return error;
                },
            });
        }
    }
    $('#Form').submit(function (e) {
        e.preventDefault();
    });
    function getDataFromSimpleField(element) {
        var s = false;
        var value = $(element).val();

        if (value == """" || value == null || value == undefined) {
            s = false;
            if ($(element).hasClass('show-tick')) {
                $(element).closest('.dropdown').addClass('is-invalid');
                $(element).closest('.dropdown').removeClass('is-valid');
            }
            else");
            WriteLiteral(@" {
                $(element).addClass('is-invalid');
                $(element).removeClass('is-valid');
            }
        }
        else if (!value.replace(/\s/g, '')[0].length) {
            s = false;
            if ($(element).hasClass('show-tick')) {
                $(element).closest('.dropdown').addClass('is-invalid');
                $(element).closest('.dropdown').removeClass('is-valid');
            }
            else {
                $(element).addClass('is-invalid');
                $(element).removeClass('is-valid');
            }
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
</script>");
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
