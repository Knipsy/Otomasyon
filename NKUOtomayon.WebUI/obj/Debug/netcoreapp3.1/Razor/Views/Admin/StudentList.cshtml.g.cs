#pragma checksum "C:\Users\emret\source\repos\NKUOtomayon\NKUOtomayon.WebUI\Views\Admin\StudentList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fadbfac27624fbfad2a959185f687dfe0f84546e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_StudentList), @"mvc.1.0.view", @"/Views/Admin/StudentList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/StudentList.cshtml", typeof(AspNetCore.Views_Admin_StudentList))]
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
#line 1 "C:\Users\emret\source\repos\NKUOtomayon\NKUOtomayon.WebUI\Views\_ViewImports.cshtml"
using NKUOtomayon.WebUI;

#line default
#line hidden
#line 2 "C:\Users\emret\source\repos\NKUOtomayon\NKUOtomayon.WebUI\Views\_ViewImports.cshtml"
using NKUOtomayon.WebUI.Models;

#line default
#line hidden
#line 4 "C:\Users\emret\source\repos\NKUOtomayon\NKUOtomayon.WebUI\Views\_ViewImports.cshtml"
using NKUOtomayon.WebUI.Extensions;

#line default
#line hidden
#line 5 "C:\Users\emret\source\repos\NKUOtomayon\NKUOtomayon.WebUI\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 6 "C:\Users\emret\source\repos\NKUOtomayon\NKUOtomayon.WebUI\Views\_ViewImports.cshtml"
using NKUOtomayon.WebUI.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fadbfac27624fbfad2a959185f687dfe0f84546e", @"/Views/Admin/StudentList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1554a7218df22155fe29bd049877e15b3f16a5b", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_StudentList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<System.Collections.Generic.List<nkuotomasyon.entity.Student>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Register", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/admin/role/delete"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display: inline;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(69, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Css", async() => {
                BeginContext(86, 109, true);
                WriteLiteral("\r\n    <link rel=\"stylesheet\" href=\"https://cdn.datatables.net/1.10.22/css/dataTables.bootstrap4.min.css\" />\r\n");
                EndContext();
            }
            );
            DefineSection("Scripts", async() => {
                BeginContext(217, 303, true);
                WriteLiteral(@"
    <script src=""//cdn.datatables.net/1.10.22/js/jquery.dataTables.min.js""></script>
    <script src=""https://cdn.datatables.net/1.10.22/js/dataTables.bootstrap4.min.js""></script>
    <script>
        $(document).ready(function () {
            $('#myTable').DataTable();
        });</script>

");
                EndContext();
            }
            );
            BeginContext(686, 109, true);
            WriteLiteral("<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n        <h1 class=\"h3\">User List</h1>\r\n        <hr>\r\n        ");
            EndContext();
            BeginContext(795, 96, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fadbfac27624fbfad2a959185f687dfe0f84546e7080", async() => {
                BeginContext(876, 11, true);
                WriteLiteral("Create User");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(891, 388, true);
            WriteLiteral(@"
        <hr />
        <table id=""myTable"" class=""table table-bordered mt-3"">
            <thead>
                <tr>
                    <td>Student Number</td>
                    <td>T.C. Number</td>
                    <td>Email</td>
                   
                    <td style=""width: 160px;""></td>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 35 "C:\Users\emret\source\repos\NKUOtomayon\NKUOtomayon.WebUI\Views\Admin\StudentList.cshtml"
                 if (Model.Any())
                {
                    

#line default
#line hidden
#line 37 "C:\Users\emret\source\repos\NKUOtomayon\NKUOtomayon.WebUI\Views\Admin\StudentList.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
            BeginContext(1406, 113, true);
            WriteLiteral("                        <tr @*class=\"@(item.EmailConfirmed?\"\":\"bg-warning\")\"*@>\r\n                            <td>");
            EndContext();
            BeginContext(1520, 17, false);
#line 40 "C:\Users\emret\source\repos\NKUOtomayon\NKUOtomayon.WebUI\Views\Admin\StudentList.cshtml"
                           Write(item.SchoolNumber);

#line default
#line hidden
            EndContext();
            BeginContext(1537, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1577, 13, false);
#line 41 "C:\Users\emret\source\repos\NKUOtomayon\NKUOtomayon.WebUI\Views\Admin\StudentList.cshtml"
                           Write(item.TcNumber);

#line default
#line hidden
            EndContext();
            BeginContext(1590, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1630, 10, false);
#line 42 "C:\Users\emret\source\repos\NKUOtomayon\NKUOtomayon.WebUI\Views\Admin\StudentList.cshtml"
                           Write(item.Email);

#line default
#line hidden
            EndContext();
            BeginContext(1640, 103, true);
            WriteLiteral("</td>\r\n                          \r\n                            <td>\r\n                                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1743, "\"", 1770, 2);
            WriteAttributeValue("", 1750, "/admin/user/", 1750, 12, true);
#line 45 "C:\Users\emret\source\repos\NKUOtomayon\NKUOtomayon.WebUI\Views\Admin\StudentList.cshtml"
WriteAttributeValue("", 1762, item.Id, 1762, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1771, 81, true);
            WriteLiteral(" class=\"btn btn-primary btn-sm mr-2\">Edit</a>\r\n\r\n                                ");
            EndContext();
            BeginContext(1852, 309, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fadbfac27624fbfad2a959185f687dfe0f84546e11592", async() => {
                BeginContext(1925, 72, true);
                WriteLiteral("\r\n                                    <input type=\"hidden\" name=\"UserId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1997, "\"", 2013, 1);
#line 48 "C:\Users\emret\source\repos\NKUOtomayon\NKUOtomayon.WebUI\Views\Admin\StudentList.cshtml"
WriteAttributeValue("", 2005, item.Id, 2005, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2014, 140, true);
                WriteLiteral(">\r\n                                    <button type=\"submit\" class=\"btn btn-danger btn-sm\">Delete</button>\r\n                                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2161, 68, true);
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 53 "C:\Users\emret\source\repos\NKUOtomayon\NKUOtomayon.WebUI\Views\Admin\StudentList.cshtml"
                    }

#line default
#line hidden
#line 53 "C:\Users\emret\source\repos\NKUOtomayon\NKUOtomayon.WebUI\Views\Admin\StudentList.cshtml"
                     
                }
                else
                {

#line default
#line hidden
            BeginContext(2312, 126, true);
            WriteLiteral("                    <div class=\"alert alert-warning\">\r\n                        <h3>No Users</h3>\r\n                    </div>\r\n");
            EndContext();
#line 60 "C:\Users\emret\source\repos\NKUOtomayon\NKUOtomayon.WebUI\Views\Admin\StudentList.cshtml"
                }

#line default
#line hidden
            BeginContext(2457, 62, true);
            WriteLiteral("\r\n\r\n            </tbody>\r\n        </table>\r\n    </div>\r\n</div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<System.Collections.Generic.List<nkuotomasyon.entity.Student>> Html { get; private set; }
    }
}
#pragma warning restore 1591
