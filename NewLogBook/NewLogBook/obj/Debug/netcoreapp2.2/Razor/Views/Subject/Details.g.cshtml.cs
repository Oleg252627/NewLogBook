#pragma checksum "E:\git\NewLogBook\NewLogBook\NewLogBook\Views\Subject\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "acd95a957fae7f227b6d81a465380ac0042601ad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Subject_Details), @"mvc.1.0.view", @"/Views/Subject/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Subject/Details.cshtml", typeof(AspNetCore.Views_Subject_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"acd95a957fae7f227b6d81a465380ac0042601ad", @"/Views/Subject/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed44a3dcfc4f762dcb4c6ad54d57d46bf6e5a390", @"/Views/_ViewImports.cshtml")]
    public class Views_Subject_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NewLogBook.Entities.Subject>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-primary btn btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(36, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\git\NewLogBook\NewLogBook\NewLogBook\Views\Subject\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(128, 129, true);
            WriteLiteral("\r\n<h1>Details Subject</h1>\r\n\r\n<div>\r\n    <h4></h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(258, 40, false);
#line 15 "E:\git\NewLogBook\NewLogBook\NewLogBook\Views\Subject\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(298, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(360, 36, false);
#line 18 "E:\git\NewLogBook\NewLogBook\NewLogBook\Views\Subject\Details.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(396, 17, true);
            WriteLiteral("\r\n        </dd>\r\n");
            EndContext();
#line 20 "E:\git\NewLogBook\NewLogBook\NewLogBook\Views\Subject\Details.cshtml"
         foreach (var VARIABLE in Model.TeachersSubjects)
        {
            if (Model.Id == VARIABLE.SubjectId)
            {

#line default
#line hidden
            BeginContext(547, 151, true);
            WriteLiteral("                <dt class=\"col-sm-2\">\r\n                    Teacher\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
            EndContext();
            BeginContext(699, 26, false);
#line 28 "E:\git\NewLogBook\NewLogBook\NewLogBook\Views\Subject\Details.cshtml"
               Write(VARIABLE.Teacher.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(725, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(727, 25, false);
#line 28 "E:\git\NewLogBook\NewLogBook\NewLogBook\Views\Subject\Details.cshtml"
                                           Write(VARIABLE.Teacher.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(752, 25, true);
            WriteLiteral("\r\n                </dd>\r\n");
            EndContext();
#line 30 "E:\git\NewLogBook\NewLogBook\NewLogBook\Views\Subject\Details.cshtml"
            }
        }

#line default
#line hidden
            BeginContext(803, 152, true);
            WriteLiteral("\r\n    </dl>\r\n    <div class=\"row\">\r\n        <div class=\"col-sm-12\">\r\n            <h4>List Marks</h4>\r\n        </div>\r\n    </div>\r\n    <dl class=\"row\">\r\n");
            EndContext();
#line 40 "E:\git\NewLogBook\NewLogBook\NewLogBook\Views\Subject\Details.cshtml"
         foreach (var VARIABLE in Model.TeachersSubjects)
        {
            if (Model.Id == VARIABLE.SubjectId)
            {
                foreach (var VAR in VARIABLE.Marks)
                {

#line default
#line hidden
            BeginContext(1161, 170, true);
            WriteLiteral("                    <dt class=\"col-sm-2\">\r\n                        Student\r\n                    </dt>\r\n                    <dd class=\"col-sm-4\">\r\n                        ");
            EndContext();
            BeginContext(1332, 21, false);
#line 50 "E:\git\NewLogBook\NewLogBook\NewLogBook\Views\Subject\Details.cshtml"
                   Write(VAR.Student.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(1353, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1355, 20, false);
#line 50 "E:\git\NewLogBook\NewLogBook\NewLogBook\Views\Subject\Details.cshtml"
                                          Write(VAR.Student.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(1375, 196, true);
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-2\">\r\n                        Mark\r\n                    </dt>\r\n                    <dd class=\"col-sm-4\">\r\n                        ");
            EndContext();
            BeginContext(1572, 9, false);
#line 56 "E:\git\NewLogBook\NewLogBook\NewLogBook\Views\Subject\Details.cshtml"
                   Write(VAR.Value);

#line default
#line hidden
            EndContext();
            BeginContext(1581, 29, true);
            WriteLiteral("\r\n                    </dd>\r\n");
            EndContext();
#line 58 "E:\git\NewLogBook\NewLogBook\NewLogBook\Views\Subject\Details.cshtml"
                }

            }
        }

#line default
#line hidden
            BeginContext(1657, 32, true);
            WriteLiteral("\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1690, 95, false);
#line 66 "E:\git\NewLogBook\NewLogBook\NewLogBook\Views\Subject\Details.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { id = Model.Id }, new {@class = "btn-success btn btn-sm"}));

#line default
#line hidden
            EndContext();
            BeginContext(1785, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1793, 69, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "acd95a957fae7f227b6d81a465380ac0042601ad9257", async() => {
                BeginContext(1846, 12, true);
                WriteLiteral("Back to List");
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
            BeginContext(1862, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NewLogBook.Entities.Subject> Html { get; private set; }
    }
}
#pragma warning restore 1591
