#pragma checksum "C:\Users\emret\source\repos\NKUOtomayon\NKUOtomayon.WebUI\Views\Admin\RoleEdit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "76772dd1401537285deb93ab6b501b0888da54ce"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_RoleEdit), @"mvc.1.0.view", @"/Views/Admin/RoleEdit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/RoleEdit.cshtml", typeof(AspNetCore.Views_Admin_RoleEdit))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76772dd1401537285deb93ab6b501b0888da54ce", @"/Views/Admin/RoleEdit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1554a7218df22155fe29bd049877e15b3f16a5b", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_RoleEdit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RoleDetails>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RoleEdit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(20, 94, true);
            WriteLiteral("<h1 class=\"h3\">Edit Role</h1>\r\n<hr/>\r\n<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n        ");
            EndContext();
            BeginContext(114, 1997, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "76772dd1401537285deb93ab6b501b0888da54ce4577", async() => {
                BeginContext(165, 48, true);
                WriteLiteral("\r\n            <input type=\"hidden\" name=\"RoleId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 213, "\"", 235, 1);
#line 7 "C:\Users\emret\source\repos\NKUOtomayon\NKUOtomayon.WebUI\Views\Admin\RoleEdit.cshtml"
WriteAttributeValue("", 221, Model.Role.Id, 221, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(236, 53, true);
                WriteLiteral(" />\r\n            <input type=\"hidden\" name=\"RoleName\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 289, "\"", 313, 1);
#line 8 "C:\Users\emret\source\repos\NKUOtomayon\NKUOtomayon.WebUI\Views\Admin\RoleEdit.cshtml"
WriteAttributeValue("", 297, Model.Role.Name, 297, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(314, 54, true);
                WriteLiteral(" />\r\n\r\n            <h6 class=\"bg-info text-white p-1\">");
                EndContext();
                BeginContext(369, 15, false);
#line 10 "C:\Users\emret\source\repos\NKUOtomayon\NKUOtomayon.WebUI\Views\Admin\RoleEdit.cshtml"
                                          Write(Model.Role.Name);

#line default
#line hidden
                EndContext();
                BeginContext(384, 66, true);
                WriteLiteral("</h6>\r\n            <table class=\"table table-bordered table-sm\">\r\n");
                EndContext();
#line 12 "C:\Users\emret\source\repos\NKUOtomayon\NKUOtomayon.WebUI\Views\Admin\RoleEdit.cshtml"
                 if (Model.NonMembers.Count() == 0)
                {

#line default
#line hidden
                BeginContext(522, 127, true);
                WriteLiteral("                    <tr>\r\n                        <td colspan=\"2\">Bütün kullanıcılar role ait</td>\r\n                    </tr>\r\n");
                EndContext();
#line 17 "C:\Users\emret\source\repos\NKUOtomayon\NKUOtomayon.WebUI\Views\Admin\RoleEdit.cshtml"
                }
                else
                {
                    

#line default
#line hidden
#line 20 "C:\Users\emret\source\repos\NKUOtomayon\NKUOtomayon.WebUI\Views\Admin\RoleEdit.cshtml"
                     foreach (var user in Model.NonMembers)
                    {

#line default
#line hidden
                BeginContext(793, 62, true);
                WriteLiteral("                        <tr>\r\n                            <td>");
                EndContext();
                BeginContext(856, 13, false);
#line 23 "C:\Users\emret\source\repos\NKUOtomayon\NKUOtomayon.WebUI\Views\Admin\RoleEdit.cshtml"
                           Write(user.UserName);

#line default
#line hidden
                EndContext();
                BeginContext(869, 133, true);
                WriteLiteral("</td>\r\n                            <td style=\"width: 150px;\">\r\n                                <input type=\"checkbox\" name=\"IdsToAdd\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1002, "\"", 1018, 1);
#line 25 "C:\Users\emret\source\repos\NKUOtomayon\NKUOtomayon.WebUI\Views\Admin\RoleEdit.cshtml"
WriteAttributeValue("", 1010, user.Id, 1010, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1019, 71, true);
                WriteLiteral(" />\r\n                            </td>\r\n                        </tr>\r\n");
                EndContext();
#line 28 "C:\Users\emret\source\repos\NKUOtomayon\NKUOtomayon.WebUI\Views\Admin\RoleEdit.cshtml"
                    }

#line default
#line hidden
#line 28 "C:\Users\emret\source\repos\NKUOtomayon\NKUOtomayon.WebUI\Views\Admin\RoleEdit.cshtml"
                     
                }

#line default
#line hidden
                BeginContext(1132, 105, true);
                WriteLiteral("            </table>\r\n\r\n            <hr />\r\n\r\n            <h6 class=\"bg-info text-white p-1\">Remove from ");
                EndContext();
                BeginContext(1238, 15, false);
#line 34 "C:\Users\emret\source\repos\NKUOtomayon\NKUOtomayon.WebUI\Views\Admin\RoleEdit.cshtml"
                                                      Write(Model.Role.Name);

#line default
#line hidden
                EndContext();
                BeginContext(1253, 66, true);
                WriteLiteral("</h6>\r\n            <table class=\"table table-bordered table-sm\">\r\n");
                EndContext();
#line 36 "C:\Users\emret\source\repos\NKUOtomayon\NKUOtomayon.WebUI\Views\Admin\RoleEdit.cshtml"
                 if (Model.Members.Count() == 0)
                {

#line default
#line hidden
                BeginContext(1388, 122, true);
                WriteLiteral("                    <tr>\r\n                        <td colspan=\"2\">Role ait kullanıcı yok</td>\r\n                    </tr>\r\n");
                EndContext();
#line 41 "C:\Users\emret\source\repos\NKUOtomayon\NKUOtomayon.WebUI\Views\Admin\RoleEdit.cshtml"
                }
                else
                {
                    

#line default
#line hidden
#line 44 "C:\Users\emret\source\repos\NKUOtomayon\NKUOtomayon.WebUI\Views\Admin\RoleEdit.cshtml"
                     foreach (var user in Model.Members)
                    {

#line default
#line hidden
                BeginContext(1651, 62, true);
                WriteLiteral("                        <tr>\r\n                            <td>");
                EndContext();
                BeginContext(1714, 13, false);
#line 47 "C:\Users\emret\source\repos\NKUOtomayon\NKUOtomayon.WebUI\Views\Admin\RoleEdit.cshtml"
                           Write(user.UserName);

#line default
#line hidden
                EndContext();
                BeginContext(1727, 136, true);
                WriteLiteral("</td>\r\n                            <td style=\"width: 150px;\">\r\n                                <input type=\"checkbox\" name=\"IdsToDelete\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1863, "\"", 1879, 1);
#line 49 "C:\Users\emret\source\repos\NKUOtomayon\NKUOtomayon.WebUI\Views\Admin\RoleEdit.cshtml"
WriteAttributeValue("", 1871, user.Id, 1871, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1880, 71, true);
                WriteLiteral(" />\r\n                            </td>\r\n                        </tr>\r\n");
                EndContext();
#line 52 "C:\Users\emret\source\repos\NKUOtomayon\NKUOtomayon.WebUI\Views\Admin\RoleEdit.cshtml"
                    }

#line default
#line hidden
#line 52 "C:\Users\emret\source\repos\NKUOtomayon\NKUOtomayon.WebUI\Views\Admin\RoleEdit.cshtml"
                     
                }

#line default
#line hidden
                BeginContext(1993, 111, true);
                WriteLiteral("            </table>\r\n            <button type=\"submit\" class=\"btn btn-primary\">Save Changes</button>\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2111, 34, true);
            WriteLiteral("\r\n        \r\n\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RoleDetails> Html { get; private set; }
    }
}
#pragma warning restore 1591
