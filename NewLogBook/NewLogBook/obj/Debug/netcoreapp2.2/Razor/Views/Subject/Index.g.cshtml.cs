#pragma checksum "E:\git\NewLogBook\NewLogBook\NewLogBook\Views\Subject\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "64ae8061ddc3c0925f9172eafa61315e969ca5a7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Subject_Index), @"mvc.1.0.view", @"/Views/Subject/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Subject/Index.cshtml", typeof(AspNetCore.Views_Subject_Index))]
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
#line 1 "E:\git\NewLogBook\NewLogBook\NewLogBook\Views\_ViewImports.cshtml"
using NewLogBook;

#line default
#line hidden
#line 2 "E:\git\NewLogBook\NewLogBook\NewLogBook\Views\_ViewImports.cshtml"
using NewLogBook.Models;

#line default
#line hidden
#line 1 "E:\git\NewLogBook\NewLogBook\NewLogBook\Views\Subject\Index.cshtml"
using NewLogBook.Entities;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64ae8061ddc3c0925f9172eafa61315e969ca5a7", @"/Views/Subject/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed44a3dcfc4f762dcb4c6ad54d57d46bf6e5a390", @"/Views/_ViewImports.cshtml")]
    public class Views_Subject_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<NewLogBook.Entities.Subject>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-primary btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(77, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "E:\git\NewLogBook\NewLogBook\NewLogBook\Views\Subject\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(167, 36, true);
            WriteLiteral("\r\n<h1>List Subject</h1>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(203, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "64ae8061ddc3c0925f9172eafa61315e969ca5a74310", async() => {
                BeginContext(250, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(264, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(357, 40, false);
#line 18 "E:\git\NewLogBook\NewLogBook\NewLogBook\Views\Subject\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(397, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(453, 32, false);
#line 21 "E:\git\NewLogBook\NewLogBook\NewLogBook\Views\Subject\Index.cshtml"
           Write(Html.DisplayName("Teacher name"));

#line default
#line hidden
            EndContext();
            BeginContext(485, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 27 "E:\git\NewLogBook\NewLogBook\NewLogBook\Views\Subject\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(603, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(652, 39, false);
#line 30 "E:\git\NewLogBook\NewLogBook\NewLogBook\Views\Subject\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(691, 39, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n");
            EndContext();
#line 33 "E:\git\NewLogBook\NewLogBook\NewLogBook\Views\Subject\Index.cshtml"
                 foreach (TeacherSubject VARIABLE in item.TeachersSubjects)
                {
                    if (item.Id == VARIABLE.SubjectId)
                    {

#line default
#line hidden
            BeginContext(905, 29, true);
            WriteLiteral("                        <div>");
            EndContext();
            BeginContext(935, 26, false);
#line 37 "E:\git\NewLogBook\NewLogBook\NewLogBook\Views\Subject\Index.cshtml"
                        Write(VARIABLE.Teacher.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(961, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(963, 25, false);
#line 37 "E:\git\NewLogBook\NewLogBook\NewLogBook\Views\Subject\Index.cshtml"
                                                    Write(VARIABLE.Teacher.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(988, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
#line 38 "E:\git\NewLogBook\NewLogBook\NewLogBook\Views\Subject\Index.cshtml"
                    }
                }

#line default
#line hidden
            BeginContext(1038, 53, true);
            WriteLiteral("            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1092, 94, false);
#line 42 "E:\git\NewLogBook\NewLogBook\NewLogBook\Views\Subject\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { id = item.Id }, new {@class = "btn-success btn btn-sm"}));

#line default
#line hidden
            EndContext();
            BeginContext(1186, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1207, 99, false);
#line 43 "E:\git\NewLogBook\NewLogBook\NewLogBook\Views\Subject\Index.cshtml"
           Write(Html.ActionLink("Details", "Details", new { id = item.Id }, new { @class = "btn-info btn btn-sm" }));

#line default
#line hidden
            EndContext();
            BeginContext(1306, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1327, 99, false);
#line 44 "E:\git\NewLogBook\NewLogBook\NewLogBook\Views\Subject\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { id = item.Id }, new { @class = "btn-danger btn btn-sm" }));

#line default
#line hidden
            EndContext();
            BeginContext(1426, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 47 "E:\git\NewLogBook\NewLogBook\NewLogBook\Views\Subject\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1465, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<NewLogBook.Entities.Subject>> Html { get; private set; }
    }
}
#pragma warning restore 1591
