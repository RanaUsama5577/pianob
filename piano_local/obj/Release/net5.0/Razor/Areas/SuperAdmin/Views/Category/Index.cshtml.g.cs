#pragma checksum "D:\repos\piano_local\piano_local\Areas\SuperAdmin\Views\Category\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e2b8e9ccc93a8dc84de479388543af1eb83109b6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_SuperAdmin_Views_Category_Index), @"mvc.1.0.view", @"/Areas/SuperAdmin/Views/Category/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e2b8e9ccc93a8dc84de479388543af1eb83109b6", @"/Areas/SuperAdmin/Views/Category/Index.cshtml")]
    public class Areas_SuperAdmin_Views_Category_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Entities.CategoryVms>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/plugins/jquery-datatable/dataTables.bootstrap4.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\repos\piano_local\piano_local\Areas\SuperAdmin\Views\Category\Index.cshtml"
  
    Layout = "~/Areas/SuperAdmin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e2b8e9ccc93a8dc84de479388543af1eb83109b63609", async() => {
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
            WriteLiteral("\r\n<section class=\"content\">\r\n    <div class=\"block-header\">\r\n        <div class=\"row\">\r\n            <div class=\"col-12\">\r\n                <h2>\r\n                    ");
#nullable restore
#line 12 "D:\repos\piano_local\piano_local\Areas\SuperAdmin\Views\Category\Index.cshtml"
               Write(local.GetLocalizedHtmlString("Categories Detail"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </h2>
            </div>
        </div>
    </div>
    <div class=""container-fluid"">

        <!-- Exportable Table -->
        <div class=""row clearfix"">
            <div class=""col-lg-12"">
                <div class=""card"">
                    <div class=""header"">
                        <div style=""display: inline-block;"">
                            <button id=""all"" class=""btn-sm btn-primary rounded font-12 mt-2"">");
#nullable restore
#line 25 "D:\repos\piano_local\piano_local\Areas\SuperAdmin\Views\Category\Index.cshtml"
                                                                                        Write(local.GetLocalizedHtmlString("All"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n                            <button id=\"active\" class=\"btn-sm btn-primary FilterButton rounded font-12 mt-2\">");
#nullable restore
#line 26 "D:\repos\piano_local\piano_local\Areas\SuperAdmin\Views\Category\Index.cshtml"
                                                                                                        Write(local.GetLocalizedHtmlString("Active"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n                            <button id=\"block\" class=\"btn-sm btn-primary FilterButton rounded font-12 mt-2\">");
#nullable restore
#line 27 "D:\repos\piano_local\piano_local\Areas\SuperAdmin\Views\Category\Index.cshtml"
                                                                                                       Write(local.GetLocalizedHtmlString("Blocked"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n                        </div>\r\n                        <div style=\"float: right;\">\r\n                            <button onclick=\"addNewModal()\" class=\"btn btn-default waves-effect m-r-20\">");
#nullable restore
#line 30 "D:\repos\piano_local\piano_local\Areas\SuperAdmin\Views\Category\Index.cshtml"
                                                                                                   Write(local.GetLocalizedHtmlString("Add New Category"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</button>
                        </div>
                    </div>
                    <div class=""body"">
                        <div class=""table-responsive"">
                            <table id=""table-1"" class=""table table-bordered js-basic-example dataTable"">
                                <thead class=""no-wrap"">
                                    <tr>
                                        <th>");
#nullable restore
#line 38 "D:\repos\piano_local\piano_local\Areas\SuperAdmin\Views\Category\Index.cshtml"
                                       Write(local.GetLocalizedHtmlString("Branch"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                        <th>");
#nullable restore
#line 39 "D:\repos\piano_local\piano_local\Areas\SuperAdmin\Views\Category\Index.cshtml"
                                       Write(local.GetLocalizedHtmlString("Name"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                        <th>");
#nullable restore
#line 40 "D:\repos\piano_local\piano_local\Areas\SuperAdmin\Views\Category\Index.cshtml"
                                       Write(local.GetLocalizedHtmlString("Created At"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                        <th>");
#nullable restore
#line 41 "D:\repos\piano_local\piano_local\Areas\SuperAdmin\Views\Category\Index.cshtml"
                                       Write(local.GetLocalizedHtmlString("Status"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                        <th>");
#nullable restore
#line 42 "D:\repos\piano_local\piano_local\Areas\SuperAdmin\Views\Category\Index.cshtml"
                                       Write(local.GetLocalizedHtmlString("Action"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                    </tr>\r\n                                </thead>\r\n                                <tbody class=\"no-wrap\">\r\n");
#nullable restore
#line 46 "D:\repos\piano_local\piano_local\Areas\SuperAdmin\Views\Category\Index.cshtml"
                                     foreach (var i in Model)
                                    {
                                        if (i.Status == Entities.Enum.EntityStatus.Active)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <tr data-row=\"1\">\r\n                                                <td>\r\n                                                    ");
#nullable restore
#line 52 "D:\repos\piano_local\piano_local\Areas\SuperAdmin\Views\Category\Index.cshtml"
                                               Write(i.BranchName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </td>\r\n                                                <td>\r\n                                                    ");
#nullable restore
#line 55 "D:\repos\piano_local\piano_local\Areas\SuperAdmin\Views\Category\Index.cshtml"
                                               Write(i.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </td>\r\n\r\n                                                <td>");
#nullable restore
#line 58 "D:\repos\piano_local\piano_local\Areas\SuperAdmin\Views\Category\Index.cshtml"
                                               Write(i.CreatedAt);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                                                <td>
                                                    <div class=""badge badge-success badge-shadow badge_width_height"">Active</div>
                                                </td>
                                                <td class=""text-center"">
                                                    <div style=""display:flex;flex-direction:row"">
                                                        <a");
            BeginWriteAttribute("onclick", " onclick=\"", 3690, "\"", 3722, 3);
            WriteAttributeValue("", 3700, "showEditModal(\'", 3700, 15, true);
#nullable restore
#line 64 "D:\repos\piano_local\piano_local\Areas\SuperAdmin\Views\Category\Index.cshtml"
WriteAttributeValue("", 3715, i.Id, 3715, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3720, "\')", 3720, 2, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn-sm btn-default waves-effect waves-float waves-black\"><i class=\"fas fa-edit\"></i></a>\r\n                                                        <a");
            BeginWriteAttribute("onclick", " onclick=\"", 3879, "\"", 3912, 3);
            WriteAttributeValue("", 3889, "showBlockModal(\'", 3889, 16, true);
#nullable restore
#line 65 "D:\repos\piano_local\piano_local\Areas\SuperAdmin\Views\Category\Index.cshtml"
WriteAttributeValue("", 3905, i.Id, 3905, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3910, "\')", 3910, 2, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn-sm btn-default waves-effect waves-float waves-black\"><i class=\"fas fa-ban\"></i></a>\r\n                                                    </div>\r\n                                                    <input type=\"hidden\"");
            BeginWriteAttribute("id", " id=\"", 4142, "\"", 4154, 2);
            WriteAttributeValue("", 4147, "n-", 4147, 2, true);
#nullable restore
#line 67 "D:\repos\piano_local\piano_local\Areas\SuperAdmin\Views\Category\Index.cshtml"
WriteAttributeValue("", 4149, i.Id, 4149, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 4155, "\"", 4170, 1);
#nullable restore
#line 67 "D:\repos\piano_local\piano_local\Areas\SuperAdmin\Views\Category\Index.cshtml"
WriteAttributeValue("", 4163, i.Name, 4163, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                                    <input type=\"hidden\"");
            BeginWriteAttribute("id", " id=\"", 4248, "\"", 4260, 2);
            WriteAttributeValue("", 4253, "b-", 4253, 2, true);
#nullable restore
#line 68 "D:\repos\piano_local\piano_local\Areas\SuperAdmin\Views\Category\Index.cshtml"
WriteAttributeValue("", 4255, i.Id, 4255, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 4261, "\"", 4280, 1);
#nullable restore
#line 68 "D:\repos\piano_local\piano_local\Areas\SuperAdmin\Views\Category\Index.cshtml"
WriteAttributeValue("", 4269, i.BranchId, 4269, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                                    <input type=\"hidden\"");
            BeginWriteAttribute("id", " id=\"", 4358, "\"", 4371, 2);
            WriteAttributeValue("", 4363, "bn-", 4363, 3, true);
#nullable restore
#line 69 "D:\repos\piano_local\piano_local\Areas\SuperAdmin\Views\Category\Index.cshtml"
WriteAttributeValue("", 4366, i.Id, 4366, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 4372, "\"", 4393, 1);
#nullable restore
#line 69 "D:\repos\piano_local\piano_local\Areas\SuperAdmin\Views\Category\Index.cshtml"
WriteAttributeValue("", 4380, i.BranchName, 4380, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                                </td>\r\n                                            </tr>\r\n");
#nullable restore
#line 72 "D:\repos\piano_local\piano_local\Areas\SuperAdmin\Views\Category\Index.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <tr data-row=\"2\">\r\n                                                <td>\r\n                                                    ");
#nullable restore
#line 77 "D:\repos\piano_local\piano_local\Areas\SuperAdmin\Views\Category\Index.cshtml"
                                               Write(i.BranchName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </td>\r\n                                                <td>\r\n                                                    ");
#nullable restore
#line 80 "D:\repos\piano_local\piano_local\Areas\SuperAdmin\Views\Category\Index.cshtml"
                                               Write(i.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </td>\r\n\r\n                                                <td>");
#nullable restore
#line 83 "D:\repos\piano_local\piano_local\Areas\SuperAdmin\Views\Category\Index.cshtml"
                                               Write(i.CreatedAt);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                                                <td>
                                                    <div class=""badge badge-danger badge-shadow badge_width_height"">Blocked</div>
                                                </td>
                                                <td class=""text-center"">
                                                    <div style=""display:flex;flex-direction:row"">
                                                        <a");
            BeginWriteAttribute("onclick", " onclick=\"", 5590, "\"", 5625, 3);
            WriteAttributeValue("", 5600, "showUnBlockModal(\'", 5600, 18, true);
#nullable restore
#line 89 "D:\repos\piano_local\piano_local\Areas\SuperAdmin\Views\Category\Index.cshtml"
WriteAttributeValue("", 5618, i.Id, 5618, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5623, "\')", 5623, 2, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn-sm btn-default waves-effect waves-float waves-black\"><i class=\"fas fa-check-circle\"></i></a>\r\n                                                    </div>\r\n                                                    <input type=\"hidden\"");
            BeginWriteAttribute("id", " id=\"", 5864, "\"", 5876, 2);
            WriteAttributeValue("", 5869, "n-", 5869, 2, true);
#nullable restore
#line 91 "D:\repos\piano_local\piano_local\Areas\SuperAdmin\Views\Category\Index.cshtml"
WriteAttributeValue("", 5871, i.Id, 5871, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 5877, "\"", 5892, 1);
#nullable restore
#line 91 "D:\repos\piano_local\piano_local\Areas\SuperAdmin\Views\Category\Index.cshtml"
WriteAttributeValue("", 5885, i.Name, 5885, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                                    <input type=\"hidden\"");
            BeginWriteAttribute("id", " id=\"", 5970, "\"", 5982, 2);
            WriteAttributeValue("", 5975, "b-", 5975, 2, true);
#nullable restore
#line 92 "D:\repos\piano_local\piano_local\Areas\SuperAdmin\Views\Category\Index.cshtml"
WriteAttributeValue("", 5977, i.Id, 5977, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 5983, "\"", 6002, 1);
#nullable restore
#line 92 "D:\repos\piano_local\piano_local\Areas\SuperAdmin\Views\Category\Index.cshtml"
WriteAttributeValue("", 5991, i.BranchId, 5991, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                                    <input type=\"hidden\"");
            BeginWriteAttribute("id", " id=\"", 6080, "\"", 6093, 2);
            WriteAttributeValue("", 6085, "bn-", 6085, 3, true);
#nullable restore
#line 93 "D:\repos\piano_local\piano_local\Areas\SuperAdmin\Views\Category\Index.cshtml"
WriteAttributeValue("", 6088, i.Id, 6088, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 6094, "\"", 6115, 1);
#nullable restore
#line 93 "D:\repos\piano_local\piano_local\Areas\SuperAdmin\Views\Category\Index.cshtml"
WriteAttributeValue("", 6102, i.BranchName, 6102, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                                </td>\r\n                                            </tr>\r\n");
#nullable restore
#line 96 "D:\repos\piano_local\piano_local\Areas\SuperAdmin\Views\Category\Index.cshtml"
                                        }
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </tbody>
                            </table>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <!-- #END# Exportable Table -->
        <div class=""modal fade mt-5"" id=""addcategory"" tabindex=""-1"" role=""dialog"">
            <div class=""modal-dialog"" role=""document"">
                <div class=""modal-content"">
                    <div class=""modal-header"">
                        <h4 class=""title"" id=""defaultModalLabel"">");
#nullable restore
#line 110 "D:\repos\piano_local\piano_local\Areas\SuperAdmin\Views\Category\Index.cshtml"
                                                            Write(local.GetLocalizedHtmlString("Add Category"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4>
                    </div>
                    <div class=""modal-body"">
                        <form class=""needs-validation"" novalidate id=""Form"">
                            <input type=""hidden"" id=""form_type"" />
                            <input type=""hidden"" id=""doc_id"" />
                            <div class=""row"">
                                <div id=""SelectBranch"" class=""col-md-12"">
                                    <div class=""form-group"">
                                        <label>");
#nullable restore
#line 119 "D:\repos\piano_local\piano_local\Areas\SuperAdmin\Views\Category\Index.cshtml"
                                          Write(local.GetLocalizedHtmlString("Select Branch"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                                        ");
#nullable restore
#line 120 "D:\repos\piano_local\piano_local\Areas\SuperAdmin\Views\Category\Index.cshtml"
                                   Write(Html.DropDownList("BranchId", (IEnumerable<SelectListItem>)ViewBag.Branches, new { @class = "form-group form-float show-tick w-100 border-light" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </div>\r\n                                </div>\r\n                                <div class=\"col-md-12\">\r\n                                    <div class=\"form-group\">\r\n                                        <label>");
#nullable restore
#line 125 "D:\repos\piano_local\piano_local\Areas\SuperAdmin\Views\Category\Index.cshtml"
                                          Write(local.GetLocalizedHtmlString("Name"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</label>
                                        <input type=""text"" id=""Name"" name=""Name"" class=""form-control"" placeholder=""Name..."">
                                    </div>
                                </div>
                            </div>
                            <div style=""float:right"">
                                <button type=""button"" class=""btn btn-danger btn-round waves-effect"" data-dismiss=""modal"">");
#nullable restore
#line 131 "D:\repos\piano_local\piano_local\Areas\SuperAdmin\Views\Category\Index.cshtml"
                                                                                                                    Write(local.GetLocalizedHtmlString("Cancel"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n                                <button onclick=\"AddCategory()\" type=\"submit\" class=\"btn btn-default btn-round waves-effect\">");
#nullable restore
#line 132 "D:\repos\piano_local\piano_local\Areas\SuperAdmin\Views\Category\Index.cshtml"
                                                                                                                        Write(local.GetLocalizedHtmlString("Save"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</button>
                            </div>
                        </form>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>


<script>
    $('#Category').addClass('active');

    $(""#active"").click(function () {
        $('#active').removeClass('FilterButton');
        $('#active').siblings().addClass('FilterButton');
        var table = $('#table-1').DataTable();
        $.fn.dataTable.ext.search.pop();
        table.draw();
        $.fn.dataTable.ext.search.push(
            function (settings, data, dataIndex) {
                return $(table.row(dataIndex).node()).attr('data-row') == ""1"";
            }
        );
        table.draw();
    });
    $(""#all"").click(function () {
        $('#all').removeClass('FilterButton');
        $('#all').siblings().addClass('FilterButton');
        var table = $('#table-1').DataTable();
        $.fn.dataTable.ext.search.pop();
        table.draw();
    });
    $(""#block"").click(");
            WriteLiteral(@"function () {
        $('#block').removeClass('FilterButton');
        $('#block').siblings().addClass('FilterButton');
        var table = $('#table-1').DataTable();
        $.fn.dataTable.ext.search.pop();
        table.draw();
        $.fn.dataTable.ext.search.push(
            function (settings, data, dataIndex) {
                return $(table.row(dataIndex).node()).attr('data-row') == ""2"";
            }
        );
        table.draw();

    });
</script>
<script>
    function showBlockModal(doc_id) {
        Swal.fire({
            title: 'Are you sure you want to block?',
            text: """",
            icon: 'warning',
            showCancelButton: true,
            confirmButtonColor: '#3085d6',
            cancelButtonColor: '#d33',
            confirmButtonText: 'Confirm!',
            showLoaderOnConfirm: true,
            preConfirm: (ref) => {
                return new Promise(async function (resolve, reject) {
                    var response = getResponseFromUrl");
            WriteLiteral(@"('GET', '/SuperAdmin/Category/BlockEntity?id=' + doc_id);
                    if (response.code == 200) {
                        TimerSweet(""Category Blocked!"", 'Category is successfully blocked', ""success"", 2000);
                        setTimeout(function () {
                            location.reload();
                        }, 2000);
                    }
                    else {
                        sweetMessage(""Error!"", response.shortMessage, ""error"");
                    }
                })
            },
        }).then((result) => {
            if (result.isConfirmed) {

            }
        })
    }
    function showUnBlockModal(doc_id) {
        Swal.fire({
            title: 'Are you sure you want to unblock?',
            text: """",
            icon: 'warning',
            showCancelButton: true,
            confirmButtonColor: '#3085d6',
            cancelButtonColor: '#d33',
            confirmButtonText: 'Confirm!',
            showLoaderOnConfirm: true,");
            WriteLiteral(@"
            preConfirm: (ref) => {
                return new Promise(async function (resolve, reject) {
                    var response = getResponseFromUrl('GET', '/SuperAdmin/Category/UnBlockEntity?id=' + doc_id);
                    if (response.code == 200) {
                        TimerSweet(""Category Unblocked!"", 'Category is successfully unblocked', ""success"", 2000);
                        setTimeout(function () {
                            location.reload();
                        }, 2000);
                    }
                    else {
                        sweetMessage(""Error!"", response.shortMessage, ""error"");
                    }
                })
            },
        }).then((result) => {
            if (result.isConfirmed) {

            }
        })
    }
</script>
<script>
    $('#Form').submit(function (e) {
        e.preventDefault();
    })
    function addNewModal() {
        $(""#Form"")[0].reset();
        $('#SelectBranch').show();
        $('#a");
            WriteLiteral(@"ddcategory').modal(""show"");
        $('#form_type').val(""1"");
        $('#myModalLabel').html(""Add Category"");
    }
    function AddCategory() {

        var bool = true;
        var GetAllValues = [];
        var form_type = $('#form_type').val();
        $('#Form').find(('.form-control')).each(function (i, obj) {
            var values = getDataFromSimpleField($(obj));
            GetAllValues.push(values);
            if (GetAllValues.includes(false)) {
                bool = false;
            }
        })
        if (bool == false) {
            MixinSweet(""Please fill all the required fields"", """", ""error"", 2000);
        }
        else {
            $('#add_btn').addClass('btn-progress');
            var formdata = new FormData(document.getElementById('Form'));
            if (form_type == '1') {
            }
            else {
                var doc_id = $('#doc_id').val();
                formdata.append(""catId"", doc_id);
            }
            $.ajax({
             ");
            WriteLiteral(@"   type: 'POST',
                url: '/SuperAdmin/Category/AddCategory',
                data: formdata,
                async: true,
                processData: false,
                contentType: false,
                success: function (data) {
                    console.log(data);
                    if (data.code == 200) {
                        if (form_type == '1') {
                            TimerSweet(""Category Added!"", 'Category is successfully added', ""success"", 2000);
                        }
                        else {
                            TimerSweet(""Category Updated!"", 'Category is successfully updated', ""success"", 2000);
                        }
                        $('#addcategory').modal('hide');
                        setTimeout(function () {
                            location.reload();
                        }, 1000);
                    }
                    else {
                        sweetMessage(""Error!"", data.shortMessage, ""error"");
  ");
            WriteLiteral(@"                  }
                },
                error: function (error) {
                    return error;
                },
            });
        }
    }
    function getDataFromSimpleField(element) {
        var s = false;
        var value = $(element).val();

        if (value == """" || value == null || value == undefined) {
            s = false;
            $(element).addClass('is-invalid');
            $(element).removeClass('is-valid');
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
<script>
    function showEditModal(id) {
        $(""#Form"")[0].reset();
        $('#SelectBra");
            WriteLiteral(@"nch').hide();
        $('#doc_id').val(id);
        $('#form_type').val('2');
        var name = $('#n-' + id).val();
        var branchId = $('#b-' + id).val();
        var branchName = $('#bn-' + id).val();
        $('#Name').val(name);
        $('#BranchId').find('[option=""' + branchId+'""]').attr('selected');
        $('#myModalLabel').html(""Edit Category"");
        $('#addcategory').modal(""show"");
    }
</script>
<!--Ajax-->
<script>
    var getResponseFromUrl = function (requestType, requestUrl, requestData) {
        var response;
        $.ajax({
            type: requestType,
            url: requestUrl,
            data: requestData,
            data: requestData,
            async: false,
            processData: false,
            contentType: false,
            success: function (data) {
                response = data;
                console.log(data);
            },
            error: function (error) {
                return error;
            },
        });
   ");
            WriteLiteral("     return response;\r\n    }\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Entities.CategoryVms>> Html { get; private set; }
    }
}
#pragma warning restore 1591