#pragma checksum "D:\repos\piano-pizza\piano-pizza\Areas\SuperAdmin\Views\Main\Queries.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bb4c138de62e020f8423576d8e62d535da702c17"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_SuperAdmin_Views_Main_Queries), @"mvc.1.0.view", @"/Areas/SuperAdmin/Views/Main/Queries.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb4c138de62e020f8423576d8e62d535da702c17", @"/Areas/SuperAdmin/Views/Main/Queries.cshtml")]
    public class Areas_SuperAdmin_Views_Main_Queries : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("rounded shadow"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/images/sm/avatar1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("35"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/images/sm/avatar1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/images/sm/avatar2.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/images/sm/avatar2.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\repos\piano-pizza\piano-pizza\Areas\SuperAdmin\Views\Main\Queries.cshtml"
  
    ViewBag.Title = "Queries";
    Layout = "~/Areas/SuperAdmin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<section class=\"content\">\r\n    <div class=\"block-header\">\r\n        <div class=\"row\">\r\n            <div class=\"col-12\">\r\n                <h5>");
#nullable restore
#line 11 "D:\repos\piano-pizza\piano-pizza\Areas\SuperAdmin\Views\Main\Queries.cshtml"
               Write(local.GetLocalizedHtmlString("QueriesDetail"));

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
                    <div class=""header"">
                        <div>
                            <button id=""all"" class=""btn-sm btn-primary rounded font-12 mt-2"">");
#nullable restore
#line 23 "D:\repos\piano-pizza\piano-pizza\Areas\SuperAdmin\Views\Main\Queries.cshtml"
                                                                                        Write(local.GetLocalizedHtmlString("All"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</button>
                            <button id=""pending"" class=""btn-sm btn-primary FilterButton rounded font-12 mt-2"">Pending</button>
                            <button id=""resolved"" class=""btn-sm btn-primary FilterButton rounded font-12 mt-2"">Resolved</button>
                        </div>
                    </div>
                    <div class=""body"">
                        <div class=""table-responsive"">
                            <div class=""table-responsive"">
                                <table class=""table table-bordered js-basic-example dataTable"">
                                    <thead style=""white-space:nowrap"">
                                        <tr>
                                            <th>Sr#</th>
                                            <th>Name</th>
                                            <th>Email</th>
                                            <th>Message</th>
                                            <th>Action</th>
                        ");
            WriteLiteral(@"                </tr>
                                    </thead>

                                    <tbody style=""white-space:nowrap"">

                                        <tr data-attribute=""1"" class=""no-wrap"">
                                            <td>1</td>
                                            <td class=""align-middle"">
                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bb4c138de62e020f8423576d8e62d535da702c177695", async() => {
                WriteLiteral("\r\n                                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "bb4c138de62e020f8423576d8e62d535da702c178002", async() => {
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


                                            <td class=""align-middle"">
                                                text123@gmail.com
                                            </td>
                                            <td class=""align-middle"">
                                                <a class=""btn-sm btn-primary description"" data-toggle=""modal"" data-target=""#des""><i class=""zmdi zmdi-eye text-white""></i></a>
                                            </td>
                                            <td>

                                                <div class=""badge badge-warning badge-shadow rounded"">Pending</div>
                                                <a onclick=""Resolve()"" class=""bg-white text-secondary border-0  rounded far fa-edit text-white""></a>

                                            </td>

          ");
            WriteLiteral(@"                              </tr>

                                        <tr data-attribute=""2"" class=""no-wrap"">
                                            <td>1</td>
                                            <td class=""align-middle"">
                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bb4c138de62e020f8423576d8e62d535da702c1711503", async() => {
                WriteLiteral("\r\n                                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "bb4c138de62e020f8423576d8e62d535da702c1711811", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
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
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
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
                                            <td class=""align-middle"">
                                                text@gmail.com
                                            </td>

                                            <td class=""align-middle"">
                                                <a class=""btn-sm btn-primary description"" data-toggle=""modal"" data-target=""#des""><i class=""zmdi zmdi-eye text-white""></i></a>
                                            </td>
                                            <td>
                                                <div class=""badge badge-success badge-shadow rounded"">Resolved</div>
                                            </td>

                                        </tr>

                                    </tbody>
                                </table>
                            </d");
            WriteLiteral(@"iv>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <!-- #END# Exportable Table -->
        <div class=""modal fade bs-example-modal-md mt-5"" id=""des"" tabindex=""-1"" role=""dialog"" aria-labelledby=""des"" aria-hidden=""true"">
            <div class=""modal-dialog modal-md"">
                <div class=""modal-content"">
                    <div class=""modal-header"">
                        <h5 class=""modal-title"" id=""formModal"">Details</h5>
                        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                            <span aria-hidden=""true"">×</span>
                        </button>
                    </div>
                    <div class=""modal-body"">
                        <div class=""row"">
                            <div class=""col-md-12"">
                                <textarea readonly class=""w-100 border-0"" style=""outline:none"">Sample Details</textarea>
          ");
            WriteLiteral(@"                  </div>
                        </div>

                    </div>
                </div>
            </div><!-- /.modal -->
        </div>
    </div>

</section>


<script>
    $('#Query').addClass('active');





    $(""#all"").click(function () {
        var table = $('.js-basic-example').DataTable();
        $.fn.dataTable.ext.search.pop();
        table.draw();
        $.fn.dataTable.ext.search.push(
            function (settings, data, dataIndex) {
                return $(table.row(dataIndex).node()).attr('data-attribute') == 1 || 2;
            }
        );
        table.draw();
        $('#all').siblings().addClass('FilterButton'); $('#all').removeClass('FilterButton');
    });


    $(""#pending"").click(function () {
        var table = $('.js-basic-example').DataTable();
        $.fn.dataTable.ext.search.pop();
        table.draw();
        $.fn.dataTable.ext.search.push(
            function (settings, data, dataIndex) {
                return");
            WriteLiteral(@" $(table.row(dataIndex).node()).attr('data-attribute') == 1;

            }
        );
        table.draw();
        $('#pending').siblings().addClass('FilterButton'); $('#pending').removeClass('FilterButton');
    });

    $(""#resolved"").click(function () {

        var table = $('.js-basic-example').DataTable();
        $.fn.dataTable.ext.search.pop();
        table.draw();
        $.fn.dataTable.ext.search.push(
            function (settings, data, dataIndex) {
                return $(table.row(dataIndex).node()).attr('data-attribute') == 2;
            }
        );
        table.draw();
        $('#resolved').siblings().addClass('FilterButton'); $('#resolved').removeClass('FilterButton');
    });


    function Resolve(elem) {

         var UnRemoveid = elem;

        swal.fire({
                title: 'Are you sure, you want to resolve the query?',
                icon: 'warning',
            allowOutsideClick: false,
            showCloseButton: true,
                co");
            WriteLiteral(@"nfirmButtonColor: '#3085d6',
                cancelButtonColor: '#d33',
                confirmButtonText: 'Yes, Resolve it!'

            })
                .then((result) => {
                    if (result.isConfirmed) {

                        console.log(""in Action"");

                        $.ajax({
                            type: ""POST"",
                            url: '");
#nullable restore
#line 197 "D:\repos\piano-pizza\piano-pizza\Areas\SuperAdmin\Views\Main\Queries.cshtml"
                             Write(Url.Action("QueryStatus", "Main"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"?id=' + UnRemoveid,
                            async: false,
                            processData: false,
                            contentType: false,
                            success: function () {
                                swal.fire('Resolved!',
                                    'Query is resolved.',
                                    'success').then(function () {
                                        location.reload();
                                    });
                            },
                            failure: function () {
                                swal.fire(""Faliure faliure!"", ""Please try again"", ""error"");
                            },
                            error: function () {
                                swal.fire(""Faliure deleting!"", ""Please try again"", ""error"");
                            }
                        });

                   }



                });
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