#pragma checksum "C:\Users\emret\source\repos\NKUOtomayon\NKUOtomayon.WebUI\Views\Home\GetLessonsByStudent.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f1f26ef5d7e64e98abf6b8a7331dc95b619e535"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_GetLessonsByStudent), @"mvc.1.0.view", @"/Views/Home/GetLessonsByStudent.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/GetLessonsByStudent.cshtml", typeof(AspNetCore.Views_Home_GetLessonsByStudent))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f1f26ef5d7e64e98abf6b8a7331dc95b619e535", @"/Views/Home/GetLessonsByStudent.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1554a7218df22155fe29bd049877e15b3f16a5b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_GetLessonsByStudent : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LessonListModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PdfByLesson", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color: blanchedalmond"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(26, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Css", async() => {
                BeginContext(43, 109, true);
                WriteLiteral("\r\n    <link rel=\"stylesheet\" href=\"https://cdn.datatables.net/1.10.22/css/dataTables.bootstrap4.min.css\" />\r\n");
                EndContext();
            }
            );
            DefineSection("Scripts", async() => {
                BeginContext(174, 303, true);
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
            BeginContext(643, 437, true);
            WriteLiteral(@"<div class=""row"">
    <div class=""col-md-12"">
        <h1 class=""h3"">Lessons</h1>
        <hr />
        <table id=""myTable"" class=""table table-bordered mt-3 col-md-12"">
            <thead>
                <tr>
                    <td>Code</td>
                    <td>Lesson Name</td>
                    <td>AKTS</td>
                    <td>T</td>
                    <td>U</td>
                    <td>Teacher Name</td>
");
            EndContext();
#line 32 "C:\Users\emret\source\repos\NKUOtomayon\NKUOtomayon.WebUI\Views\Home\GetLessonsByStudent.cshtml"
                     if (Model.Grades.Count > 0)
                    {

#line default
#line hidden
            BeginContext(1153, 129, true);
            WriteLiteral("                        <td>Average</td>\r\n                        <td>Letter</td>\r\n                        <td>Absenteeism</td>\r\n");
            EndContext();
#line 37 "C:\Users\emret\source\repos\NKUOtomayon\NKUOtomayon.WebUI\Views\Home\GetLessonsByStudent.cshtml"
                    }

#line default
#line hidden
            BeginContext(1305, 68, true);
            WriteLiteral("\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
            EndContext();
#line 42 "C:\Users\emret\source\repos\NKUOtomayon\NKUOtomayon.WebUI\Views\Home\GetLessonsByStudent.cshtml"
                 if (Model.Lesson.Count > 0)
                {
                    

#line default
#line hidden
#line 44 "C:\Users\emret\source\repos\NKUOtomayon\NKUOtomayon.WebUI\Views\Home\GetLessonsByStudent.cshtml"
                     for (int i = 0; i < Model.Lesson.Count; i++)
                    {

#line default
#line hidden
            BeginContext(1528, 66, true);
            WriteLiteral("                        <tr>\r\n\r\n\r\n                            <td>");
            EndContext();
            BeginContext(1595, 26, false);
#line 49 "C:\Users\emret\source\repos\NKUOtomayon\NKUOtomayon.WebUI\Views\Home\GetLessonsByStudent.cshtml"
                           Write(Model.Lesson[i].LessonCode);

#line default
#line hidden
            EndContext();
            BeginContext(1621, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1660, 202, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f1f26ef5d7e64e98abf6b8a7331dc95b619e5358752", async() => {
                BeginContext(1832, 26, false);
#line 50 "C:\Users\emret\source\repos\NKUOtomayon\NKUOtomayon.WebUI\Views\Home\GetLessonsByStudent.cshtml"
                                                                                                                                                                                                      Write(Model.Lesson[i].LessonName);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-lessonCode", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 50 "C:\Users\emret\source\repos\NKUOtomayon\NKUOtomayon.WebUI\Views\Home\GetLessonsByStudent.cshtml"
                                                                                            WriteLiteral(Model.Lesson[i].LessonCode);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["lessonCode"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-lessonCode", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["lessonCode"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            EndContext();
            BeginContext(1862, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1902, 20, false);
#line 51 "C:\Users\emret\source\repos\NKUOtomayon\NKUOtomayon.WebUI\Views\Home\GetLessonsByStudent.cshtml"
                           Write(Model.Lesson[i].Akts);

#line default
#line hidden
            EndContext();
            BeginContext(1922, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1962, 26, false);
#line 52 "C:\Users\emret\source\repos\NKUOtomayon\NKUOtomayon.WebUI\Views\Home\GetLessonsByStudent.cshtml"
                           Write(Model.Lesson[i].TheoryTime);

#line default
#line hidden
            EndContext();
            BeginContext(1988, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(2028, 28, false);
#line 53 "C:\Users\emret\source\repos\NKUOtomayon\NKUOtomayon.WebUI\Views\Home\GetLessonsByStudent.cshtml"
                           Write(Model.Lesson[i].PracticeTime);

#line default
#line hidden
            EndContext();
            BeginContext(2056, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(2096, 33, false);
#line 54 "C:\Users\emret\source\repos\NKUOtomayon\NKUOtomayon.WebUI\Views\Home\GetLessonsByStudent.cshtml"
                           Write(Model.Lesson[i].Teacher.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(2129, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(2131, 32, false);
#line 54 "C:\Users\emret\source\repos\NKUOtomayon\NKUOtomayon.WebUI\Views\Home\GetLessonsByStudent.cshtml"
                                                              Write(Model.Lesson[i].Teacher.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(2163, 9, true);
            WriteLiteral("</td>\r\n\r\n");
            EndContext();
#line 56 "C:\Users\emret\source\repos\NKUOtomayon\NKUOtomayon.WebUI\Views\Home\GetLessonsByStudent.cshtml"
                             if (Model.Grades.Count > i)
                            {

#line default
#line hidden
            BeginContext(2261, 36, true);
            WriteLiteral("                                <td>");
            EndContext();
            BeginContext(2298, 23, false);
#line 58 "C:\Users\emret\source\repos\NKUOtomayon\NKUOtomayon.WebUI\Views\Home\GetLessonsByStudent.cshtml"
                               Write(Model.Grades[i].Average);

#line default
#line hidden
            EndContext();
            BeginContext(2321, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(2365, 27, false);
#line 59 "C:\Users\emret\source\repos\NKUOtomayon\NKUOtomayon.WebUI\Views\Home\GetLessonsByStudent.cshtml"
                               Write(Model.Grades[i].GradeLetter);

#line default
#line hidden
            EndContext();
            BeginContext(2392, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(2436, 33, false);
#line 60 "C:\Users\emret\source\repos\NKUOtomayon\NKUOtomayon.WebUI\Views\Home\GetLessonsByStudent.cshtml"
                               Write(Model.Grades[i].FailedAbsenteeism);

#line default
#line hidden
            EndContext();
            BeginContext(2469, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 61 "C:\Users\emret\source\repos\NKUOtomayon\NKUOtomayon.WebUI\Views\Home\GetLessonsByStudent.cshtml"
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(2572, 129, true);
            WriteLiteral("                                <td></td>\r\n                                <td></td>\r\n                                <td></td>\r\n");
            EndContext();
#line 67 "C:\Users\emret\source\repos\NKUOtomayon\NKUOtomayon.WebUI\Views\Home\GetLessonsByStudent.cshtml"
                            }

#line default
#line hidden
            BeginContext(2732, 39, true);
            WriteLiteral("\r\n\r\n\r\n\r\n                        </tr>\r\n");
            EndContext();
#line 73 "C:\Users\emret\source\repos\NKUOtomayon\NKUOtomayon.WebUI\Views\Home\GetLessonsByStudent.cshtml"
                    }

#line default
#line hidden
#line 73 "C:\Users\emret\source\repos\NKUOtomayon\NKUOtomayon.WebUI\Views\Home\GetLessonsByStudent.cshtml"
                     
                }
                else
                {

#line default
#line hidden
            BeginContext(2854, 126, true);
            WriteLiteral("                    <div class=\"alert alert-warning\">\r\n                        <h3>No Users</h3>\r\n                    </div>\r\n");
            EndContext();
#line 80 "C:\Users\emret\source\repos\NKUOtomayon\NKUOtomayon.WebUI\Views\Home\GetLessonsByStudent.cshtml"
                }

#line default
#line hidden
            BeginContext(2999, 62, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LessonListModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
