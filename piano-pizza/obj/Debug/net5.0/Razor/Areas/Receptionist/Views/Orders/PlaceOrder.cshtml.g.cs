#pragma checksum "D:\repos\piano-pizza\piano-pizza\Areas\Receptionist\Views\Orders\PlaceOrder.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "19afc8d5f8bdd97dd073e33cc2f25fac2b9a5967"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Receptionist_Views_Orders_PlaceOrder), @"mvc.1.0.view", @"/Areas/Receptionist/Views/Orders/PlaceOrder.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"19afc8d5f8bdd97dd073e33cc2f25fac2b9a5967", @"/Areas/Receptionist/Views/Orders/PlaceOrder.cshtml")]
    public class Areas_Receptionist_Views_Orders_PlaceOrder : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin-assets/app-assets/forms/form-extended.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin-assets/images/piano/Bg-transparent/Ingredient-removebg-preview.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("30"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("ml-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin-assets/app-assets/forms/jquery.card.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin-assets/app-assets/forms/form-card.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\repos\piano-pizza\piano-pizza\Areas\Receptionist\Views\Orders\PlaceOrder.cshtml"
  
    ViewBag.Title = "PlaceOrder";
    Layout = "~/Areas/Receptionist/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "19afc8d5f8bdd97dd073e33cc2f25fac2b9a59675544", async() => {
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
<style>
    .btn-quantity.style-1 {
        width: 90px;
    }

    .input-group {
        position: relative;
        display: flex;
        flex-wrap: wrap;
        align-items: stretch;
        width: 100%;
    }

        .input-group > .form-control:not(:last-child), .input-group > .custom-select:not(:last-child) {
            border-top-right-radius: 0;
            border-bottom-right-radius: 0;
        }

    .btn-quantity.style-1 input {
        border: 0 none;
        font-size: 14px;
        padding: 0 25px;
        text-align: center;
        margin-top: 8px;
    }

    .input-group > .form-control, .input-group > .form-control-plaintext, .input-group > .custom-select, .input-group > .custom-file {
        position: relative;
        flex: 1 1 auto;
        width: 1%;
        margin-bottom: 0;
    }

    .btn-quantity.style-1 .bootstrap-touchspin .input-group-btn-vertical {
        position: absolute;
        width: 100%;
        left: 0;
    }

    .bootstra");
            WriteLiteral(@"p-touchspin .input-group-btn-vertical {
        position: absolute;
        right: 0;
        height: 100%;
        z-index: 11;
    }

    .btn-quantity.style-1 .input-group-btn-vertical button:first-child {
        right: 0;
    }

    .btn-quantity.style-1 .input-group-btn-vertical button {
        height: 25px;
        width: 25px;
        top: 50%;
        transform: translateY(-50%);
    }

    .bootstrap-touchspin .input-group-btn-vertical .bootstrap-touchspin-up {
        border-radius: 4px 4px 4px 4px;
        top: 0;
    }

    .bootstrap-touchspin .input-group-btn-vertical > .btn {
        position: absolute;
        right: 0;
        height: 50%;
        padding: 0;
        width: 2em;
        text-align: center;
        line-height: 1;
    }

    button:not(:disabled), [type=""button""]:not(:disabled), [type=""reset""]:not(:disabled), [type=""submit""]:not(:disabled) {
        cursor: pointer;
    }

    .btn-quantity.style-1 .input-group-btn-vertical button:last-ch");
            WriteLiteral(@"ild {
        left: 0;
    }

    .btn-quantity.style-1 .input-group-btn-vertical button {
        height: 25px;
        width: 25px;
        top: 50%;
        transform: translateY(-50%);
    }

    .bootstrap-touchspin .input-group-btn-vertical .bootstrap-touchspin-down {
        border-radius: 4px 4px 4px 4px;
        bottom: 0;
    }

    .bootstrap-touchspin .input-group-btn-vertical > .btn {
        position: absolute;
        right: 0;
        height: 50%;
        padding: 0;
        width: 2em;
        text-align: center;
        line-height: 1;
    }

    button:not(:disabled), [type=""button""]:not(:disabled), [type=""reset""]:not(:disabled), [type=""submit""]:not(:disabled) {
        cursor: pointer;
    }
</style>

<section class=""content"">
    <div class=""block-header"">
        <div class=""row"">
            <div class=""col-12"">
                <h2>
                    Place Order");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "19afc8d5f8bdd97dd073e33cc2f25fac2b9a59679722", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
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
            <div id=""AddItem"" class=""col-lg-12 col-md-12 col-sm-12"">
                <div class=""card"">
                    <div class=""body"">
                        <div id=""form_validation"" method=""POST"">

                            <div class=""row mt-4"">
                                <div class=""col-12"">
                                    <a id=""num1"" class=""btn btn-primary text-white""><i class=""fas fa-plus mr-2 text-white""></i>Add Item</a>

                                </div>
                            </div>
                            <div id=""targetDIV"">

                            </div>
                            <button onclick=""next()"" class=""btn btn-raised btn-primary btn-round waves-effect mb-4 mt-4"" style=""float:right"" type=""submit"">Next</button>
                        </div>
              ");
            WriteLiteral("      </div>\r\n                </div>\r\n            </div>\r\n\r\n");
            WriteLiteral(@"
            <div id=""pay"" class=""col-lg-12 col-md-12 col-sm-12 d-none"">
                <div class=""card"">
                    <div class=""body"">
                        <div id=""form_validation"" method=""POST"">

                            <div class=""row mt-4"">
                                <div class=""col-12"">
                                    <h5>Amount to Pay <b id=""TotalPrice"">$46</b> </h5>
                                </div>
                                <div class=""col-12 col-sm-12 col-md-4"">
                                    <label>Order type</label>
                                    <div>
                                        <input type=""radio"" id=""Takeaway"" name=""type"" class=""mr-1"" checked");
            BeginWriteAttribute("value", " value=\"", 5139, "\"", 5147, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        <label for=\"Takeaway\" class=\"font-13 font-bold\"> Takeaway</label><br>\r\n                                        <input type=\"radio\" class=\"mr-1\" id=\"dineIn\" name=\"type\"");
            BeginWriteAttribute("value", " value=\"", 5358, "\"", 5366, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                        <label for=""dineIn"" class=""font-13 font-bold""> Dine-In</label><br>
                                    </div>
                                </div>
                                <div class=""col-12 col-sm-12 col-md-4"">
                                    <label>Table Number</label>
                                    <input type=""text"" class=""form-control"" id=""tableNumber"" />
                                </div>
                            </div>
                            <hr />

                            <div class=""row mt-4"">
                                <div class=""col-12"">
                                    <h5>Customer Info</h5>
                                </div>
                                <div class=""col-12 col-sm-12 col-md-4"">
                                    <div class=""form-group form-float"">
                                        <label>Name</label>
                                        <input type=""text"" class=""f");
            WriteLiteral(@"orm-control mt-1"" id=""customer_name"" placeholder=""Name"" required>
                                    </div>
                                </div>
                                <div class=""col-12 col-sm-12 col-md-4"">
                                    <div class=""form-group form-float"">
                                        <label>E-mail</label>
                                        <input type=""email"" class=""form-control mt-1"" id=""customer_email"" placeholder=""E-mail"" required>
                                    </div>
                                </div>
                                <div class=""col-12 col-sm-12 col-md-4"">
                                    <div class=""form-group form-float"">
                                        <label>Phone Number</label>
                                        <input type=""number"" class=""form-control mt-1"" id=""customer_phone"" placeholder=""Phone Number"" required>
                                    </div>
                                </div>");
            WriteLiteral(@"
                            </div>

                            <div class=""d-flex flex-row float-right"">
                                <button onclick=""back()"" class=""btn btn-raised btn-secondary btn-round waves-effect mb-4 mt-4"" style=""float:right"">Previous</button>
                                <button onclick=""PlaceOrder()"" class=""btn btn-raised btn-primary btn-round waves-effect mb-4 mt-4"" style=""float:right"" type=""submit"">Place Order</button>
                            </div>
                        </div>
                    </div>
                </div>
            </div>

");
            WriteLiteral(@"
            <div id=""confirmation"" class=""col-lg-12 col-md-12 col-sm-12 d-none"">
                <div class=""card"">
                    <div class=""body"">
                        <div id=""form_validation"" method=""POST"">

                            <div class=""row mt-4"">
                                <div class=""col-12"">
                                    <img src=""/admin-assets/images/piano/cooking.png"" class=""d-flex m-auto"" height=""100"" />
                                    <span class=""font-22 d-flex justify-content-center"">Your have successfully added a new order received!</span>
                                    <br />
                                    <p id=""OrderId"" class=""text-center font-18"">Your Order Number: #123456 </p>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div style=""display:none"">
        <select id=""C");
            WriteLiteral("ategorySelect\">\r\n");
#nullable restore
#line 231 "D:\repos\piano-pizza\piano-pizza\Areas\Receptionist\Views\Orders\PlaceOrder.cshtml"
             foreach (var i in (IEnumerable<SelectListItem>)ViewBag.Categories)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <option");
            BeginWriteAttribute("value", " value=\"", 9211, "\"", 9227, 1);
#nullable restore
#line 233 "D:\repos\piano-pizza\piano-pizza\Areas\Receptionist\Views\Orders\PlaceOrder.cshtml"
WriteAttributeValue("", 9219, i.Value, 9219, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 233 "D:\repos\piano-pizza\piano-pizza\Areas\Receptionist\Views\Orders\PlaceOrder.cshtml"
                                    Write(i.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 234 "D:\repos\piano-pizza\piano-pizza\Areas\Receptionist\Views\Orders\PlaceOrder.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </select>\r\n        <select id=\"ProductSelect\">\r\n");
#nullable restore
#line 237 "D:\repos\piano-pizza\piano-pizza\Areas\Receptionist\Views\Orders\PlaceOrder.cshtml"
             foreach (var i in (IEnumerable<Entities.ProductDtos>)ViewBag.Products)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <optgroup");
            BeginWriteAttribute("label", " label=\"", 9443, "\"", 9464, 1);
#nullable restore
#line 239 "D:\repos\piano-pizza\piano-pizza\Areas\Receptionist\Views\Orders\PlaceOrder.cshtml"
WriteAttributeValue("", 9451, i.CategoryId, 9451, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <option data-price=\"");
#nullable restore
#line 240 "D:\repos\piano-pizza\piano-pizza\Areas\Receptionist\Views\Orders\PlaceOrder.cshtml"
                                   Write(i.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"");
            BeginWriteAttribute("value", " value=\"", 9517, "\"", 9530, 1);
#nullable restore
#line 240 "D:\repos\piano-pizza\piano-pizza\Areas\Receptionist\Views\Orders\PlaceOrder.cshtml"
WriteAttributeValue("", 9525, i.Id, 9525, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 240 "D:\repos\piano-pizza\piano-pizza\Areas\Receptionist\Views\Orders\PlaceOrder.cshtml"
                                                           Write(i.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n                </optgroup>\r\n");
#nullable restore
#line 242 "D:\repos\piano-pizza\piano-pizza\Areas\Receptionist\Views\Orders\PlaceOrder.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </select>\r\n        <div id=\"AllIngredients\">\r\n");
#nullable restore
#line 245 "D:\repos\piano-pizza\piano-pizza\Areas\Receptionist\Views\Orders\PlaceOrder.cshtml"
             foreach (var i in (List<Entities.IngredientListVms>)ViewBag.Ingredients)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div");
            BeginWriteAttribute("class", " class=\"", 9770, "\"", 9800, 3);
            WriteAttributeValue("", 9778, "row", 9778, 3, true);
            WriteAttributeValue(" ", 9781, "ml-3", 9782, 5, true);
#nullable restore
#line 247 "D:\repos\piano-pizza\piano-pizza\Areas\Receptionist\Views\Orders\PlaceOrder.cshtml"
WriteAttributeValue(" ", 9786, i.CategoryId, 9787, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <div class=\"col-md-3\">\r\n                        <div class=\"checkbox\" style=\"margin-bottom: 0;line-height: 2.4;\">\r\n                            <input");
            BeginWriteAttribute("id", " id=\"", 9973, "\"", 9985, 2);
            WriteAttributeValue("", 9978, "i-", 9978, 2, true);
#nullable restore
#line 250 "D:\repos\piano-pizza\piano-pizza\Areas\Receptionist\Views\Orders\PlaceOrder.cshtml"
WriteAttributeValue("", 9980, i.Id, 9980, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-id=\"");
#nullable restore
#line 250 "D:\repos\piano-pizza\piano-pizza\Areas\Receptionist\Views\Orders\PlaceOrder.cshtml"
                                                    Write(i.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-price=\"");
#nullable restore
#line 250 "D:\repos\piano-pizza\piano-pizza\Areas\Receptionist\Views\Orders\PlaceOrder.cshtml"
                                                                       Write(i.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"ingredient_name\" type=\"checkbox\">\r\n                            <label");
            BeginWriteAttribute("for", " for=\"", 10101, "\"", 10114, 2);
            WriteAttributeValue("", 10107, "i-", 10107, 2, true);
#nullable restore
#line 251 "D:\repos\piano-pizza\piano-pizza\Areas\Receptionist\Views\Orders\PlaceOrder.cshtml"
WriteAttributeValue("", 10109, i.Id, 10109, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"line-height: 1.5;\">");
#nullable restore
#line 251 "D:\repos\piano-pizza\piano-pizza\Areas\Receptionist\Views\Orders\PlaceOrder.cshtml"
                                                                      Write(i.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</label>
                        </div>
                    </div>
                    <div class=""col-md-2"">
                        <div class=""quantity btn-quantity style-1 m-auto"">
                            <div class=""input-group  bootstrap-touchspin bootstrap-touchspin-injected"">
                                <input id=""demo_vertical2"" type=""text"" value=""0"" name=""demo_vertical2"" class=""form-control"">
                                <span class=""input-group-btn-vertical"">
                                    <button onclick=""IngredientUpFunction(this)"" class=""btn btn-primary bootstrap-touchspin-up "" type=""button"">+</button>
                                    <button onclick=""IngredientDownFunction(this)"" class=""btn btn-primary bootstrap-touchspin-down "" type=""button"">-</button>
                                </span>
                            </div>
                        </div>
                    </div>
                </div>
");
#nullable restore
#line 266 "D:\repos\piano-pizza\piano-pizza\Areas\Receptionist\Views\Orders\PlaceOrder.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
    </div>
</section>

<div class=""row ml-3"" id=""IngrdientClone"" style=""display:none;"">
    <div class=""col-md-3"">
        <div class=""checkbox"" style=""margin-bottom: 0;line-height: 2.4;"">
            <input id=""remember_me"" type=""checkbox"">
            <label for=""remember_me"" style=""line-height: 1.5;"">Olives</label>
        </div>
    </div>
    <div class=""col-md-2"">
        <div class=""quantity btn-quantity style-1 m-auto"">
            <div class=""input-group  bootstrap-touchspin bootstrap-touchspin-injected"">
                <input id=""demo_vertical2"" type=""text"" value=""0"" name=""demo_vertical2"" class=""form-control"">
                <span class=""input-group-btn-vertical"">
                    <button onclick=""UpFunction(this)"" class=""btn btn-primary bootstrap-touchspin-up "" type=""button"">+</button>
                    <button onclick=""DownFunction(this)"" class=""btn btn-primary bootstrap-touchspin-down "" type=""button"">-</button>
                </span>
            </div>
 ");
            WriteLiteral("       </div>\r\n    </div>\r\n</div>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "19afc8d5f8bdd97dd073e33cc2f25fac2b9a596725642", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "19afc8d5f8bdd97dd073e33cc2f25fac2b9a596726682", async() => {
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

<script>
    $(document).ready(function () {
        $('input[type=""radio""]').click(function () {
            if ($('#card').prop(""checked"") == true) {
                $('#cardDiv').css(""display"", ""flex"");
            }
            else if ($('#card').prop(""checked"") == false) {
                $('#cardDiv').css(""display"", ""none"");
            }
        });
    });
    $('#num1').on('click', function () {
        //$(""#targetDIV"").empty();
        var targetDiv = $(""#targetDIV"");
        var cats = ShowCategories();
        var timestamp = new Date().getTime().toString();
        targetDiv.append('<div class=""p-2 mt-1 sectionClone"">' +
            '<div class=""form-row"">' +
            '<div class=""col-md-3""><label>Select Category</label>' +
            '<select onchange=""ChangeProducts(this)"" id=""a-' + timestamp+'"" class=""form-float show-tick w-100"">' +
            '<option value="""" disabled selected>-- Select Category</option>' +
            '</select>' +
            '</div>' +
  ");
            WriteLiteral(@"          '<div class= ""col-md-3"" > <label>Select Product</label>' +
            '<select id=""p-' + timestamp +'"" class= ""form-float show-tick w-100"" > ' +
            '<option value = """" disabled selected > --Select Product</option > ' +
            '</select> ' +
            '</div> ' +
            '<div class=""col-md-2"">' +
            '<div class=""quantity btn-quantity style-1 m-auto"">' +
            '<label>Quantity</label>' +
            '<div class=""input-group  bootstrap-touchspin bootstrap-touchspin-injected""><input id=""demo_vertical2"" type=""text"" value=""1"" name=""demo_vertical2"" class=""form-control""><span class=""input-group-btn-vertical""><button onclick=""UpFunction(this)"" class=""btn btn-primary bootstrap-touchspin-up "" type=""button"">+</button><button onclick=""DownFunction(this)"" class=""btn btn-primary bootstrap-touchspin-down "" type=""button"">-</button></span></div>' +
            '</div>' +
            '</div>' +
            '<div class=""col-md-12 mt-4 mb-3"" id=""Ingredients"">' +
         ");
            WriteLiteral(@"   '</div>' +
            '<div class=""col-md-12 m-auto"">' +
            '<button onclick=""RemoveSection(this)"" class=""btn btn-primary"">Remove</button>' +
            '</div> ' +
            '</div>' +
            '<hr>' +
            '</div>');
        $('#a-' + timestamp).selectpicker('destroy');
        $('#a-' + timestamp).html(cats);
        $('#a-' + timestamp).selectpicker();
        var Id = 'a-' + timestamp;
        var Id2 = 'p-' + timestamp;
        ShowProducts(Id, Id2);
        $('#a-' + timestamp).attr('id', 'CategoryId');
        $('#p-' + timestamp).attr('id','ProductId');
    });
    function ChangeProducts(element) {
        var select = $(element).closest('.col-md-3').next().find('select');
        $(select).selectpicker('destroy');
        ShowChangeProducts(element, select);
        $(select).selectpicker();
    }
    function UpFunction(element) {
        var input = $(element).parent().siblings('#demo_vertical2');
        var itemCount = $(element).parent().sibli");
            WriteLiteral(@"ngs('#demo_vertical2').val();
        var itemCount = parseInt(itemCount);
        itemCount += 1;
        if (itemCount <= 99) {
            $(input).val(itemCount);
        }
    }
    function DownFunction(element) {
        var input = $(element).parent().siblings('#demo_vertical2');
        var itemCount = $(element).parent().siblings('#demo_vertical2').val();
        var itemCount = parseInt(itemCount);
        itemCount -= 1;
        if (itemCount > 0) {
            $(input).val(itemCount);
        }
    }
    function RemoveSection(element) {
        $(element).closest('.sectionClone').remove();
    }
    function next() {
        var getProductsData = OrderCheck();
        $('#TotalPrice').html(""$"" + getProductsData.price);
        $(""#AddItem"").addClass(""d-none"");
        $(""#pay"").removeClass(""d-none"");
    }
    function ShowCategories() {
        var options = $('#CategorySelect > option').clone();
        return options;
    }
    function ShowIngredients(catId,eleme");
            WriteLiteral(@"nt) {
        var clone = $('#AllIngredients').find('.' + catId).clone();
        clone.each(function () {
            var Id = $(this).find('input[type=""checkbox""]').attr('data-id');
            var timestamp = new Date().getTime().toString();
            $(this).find('input[type=""checkbox""]').attr('id', timestamp + ""-"" + Id);
            $(this).find('label').attr('for', timestamp + ""-"" + Id);
        })
        var check = $(element).closest('.col-md-3').siblings('#Ingredients');
        console.log(check);
        $(element).closest('.col-md-3').siblings('#Ingredients').html(clone);

        $('.ingredient_name').on('click', function () {
            if ($(this).prop('checked')) {
                $(this).closest('.col-md-3').siblings('.col-md-2').find('#demo_vertical2').val(1);
            }
            else {
                $(this).closest('.col-md-3').siblings('.col-md-2').find('#demo_vertical2').val(0);
            }
        })
    }
    function IngredientUpFunction(element) {
       ");
            WriteLiteral(@" var input = $(element).parent().siblings('#demo_vertical2');
        var itemCount = $(element).parent().siblings('#demo_vertical2').val();
        var itemCount = parseInt(itemCount);
        itemCount += 1;
        if (itemCount <= 99) {
            $(input).val(itemCount);
        }
        $(element).closest('.col-md-2').prev('.col-md-3').find('input').prop('checked', true);
    }
    function IngredientDownFunction(element) {
        var input = $(element).parent().siblings('#demo_vertical2');
        var itemCount = $(element).parent().siblings('#demo_vertical2').val();
        var itemCount = parseInt(itemCount);
        itemCount -= 1;
        if (itemCount >= 0) {
            $(input).val(itemCount);
        }
        if (itemCount == 0) {
            $(element).closest('.col-md-2').prev('.col-md-3').find('input').prop('checked', false);
        }
    }
    function ShowProducts(Id, Id2) {
        var s = $('#' + Id).val();
        var element = $('#' + Id);
        ShowIngre");
            WriteLiteral(@"dients(s, element);
        $('#' + Id2).selectpicker('destroy');
        var options = $('#ProductSelect > optgroup[label=""' + s + '""] > option').clone();
        $('#' + Id2).html("""");
        $('#' + Id2).append(options);
        $('#' + Id2).selectpicker();
    }
    function ShowChangeProducts(element, element2) {
        var s = $(element).val();
        ShowIngredients(s, element);
        $(element2).selectpicker('destroy');
        var options = $('#ProductSelect > optgroup[label=""' + s + '""] > option').clone();
        $(element2).html("""");
        $(element2).append(options);
        $(element2).selectpicker();
    }
    function back() {
        $(""#pay"").addClass('d-none');
        $(""#AddItem"").removeClass('d-none');
    }

    function PlaceOrder() {
        if ($('#Takeaway').prop(""checked"")) {
            var orderType = 1;
        }
        else {
            var orderType = 2;
        }
        var tableNumber = $('#tableNumber').val();
        var customer_name");
            WriteLiteral(@" = $('#customer_name').val();
        var customer_email = $('#customer_email').val();
        var customer_phone = $('#customer_phone').val();
        var getProductsData = OrderCheck();
        getProductsData.orderType = orderType;
        getProductsData.table_num = tableNumber;
        getProductsData.customer_name = customer_name;
        getProductsData.customer_email = customer_email;
        getProductsData.customer_phone = customer_phone;
        console.log(""collected"",getProductsData);
        var data = JSON.stringify({
            'orderType': orderType,
            'customer_name': customer_name,
            'customer_email': customer_email,
            'customer_phone': customer_phone,
            'table_num': tableNumber,
            'AllProducts': getProductsData.AllProducts,
            'price': getProductsData.price,
        });
        console.log(""data"",data);
        $.ajax({
            type: 'POST',
            url: '/Receptionist/Orders/PlaceOrder',
           ");
            WriteLiteral(@" data: data,
            async: true,
            contentType: 'application/json; charset=utf-8',
            dataType: 'json',
            success: function (data) {
                console.log(""Api"",data);
                if (data.code == 200) {
                    TimerSweet(""Order Placed!"", """", ""success"", 2000);
                    $(""#pay"").addClass('d-none');
                    $(""#confirmation"").removeClass('d-none');
                    $('#OrderId').html(""Your Order Number: #"" + data.shortMessage);
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
</script>
<script>
    function OrderCheck() {
        var allData = [];
        var Allprice = 0;
        $('.sectionClone').each(function (index) {
            var categoryId = $(this).find('#CategoryId').val();
            var produ");
            WriteLiteral(@"ctId = $(this).find('#ProductId').val();
            var price = $(this).find('#ProductId').find('option[value=""' + productId + '""]').attr('data-price');
            var quantity = $(this).find('#demo_vertical2').val();
            var total_price = parseFloat(price) * parseInt(quantity);
            var ingredients = $(this).find('#Ingredients').find('input:checked');
            var listIn = [];
            var IngredientsPrice = 0;
            ingredients.each(function (index2) {
                var Id = $(this).attr('id');
                Id = Id.split('-');
                var price2 = $(this).attr('data-price');
                var Inquantity = $(this).closest('.col-md-3').siblings('.col-md-2').find('#demo_vertical2').val();
                var finalPrice = parseFloat(price2) * parseInt(Inquantity);
                var list = {
                    Id: Id[1],
                    quantity: Inquantity,
                    Price: finalPrice,
                }
                listIn.push(li");
            WriteLiteral(@"st);
                IngredientsPrice += finalPrice;
            })
            total_price += IngredientsPrice;
            var data = {
                categoryId: categoryId,
                productId: productId,
                quantity: quantity,
                ingredientList: listIn,
                total_price: total_price,
            };
            allData.push(data);
            Allprice += total_price;
        });
        var data2 = {
            AllProducts: allData,
            price: Allprice,
        }
        return data2;
    }
    function OrderCheck2() {
        $(""#pay"").addClass('d-none');
        $(""#confirmation"").removeClass('d-none');
        if ($('#Takeaway').prop(""checked"")) {
            var orderType = 1;
        }
        else {
            var orderType = 2;
        }
        var tableNumber = $('#tableNumber').val();
        var customer_name = $('#customer_name').val();
        var customer_email = $('#customer_email').val();
        var cust");
            WriteLiteral(@"omer_phone = $('#customer_phone').val();
        var getProductsData = OrderCheck();
        getProductsData.orderType = orderType;
        getProductsData.table_num = tableNumber;
        getProductsData.customer_name = customer_name;
        getProductsData.customer_email = customer_email;
        getProductsData.customer_phone = customer_phone;
        console.log(getProductsData);
    }
</script>");
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
