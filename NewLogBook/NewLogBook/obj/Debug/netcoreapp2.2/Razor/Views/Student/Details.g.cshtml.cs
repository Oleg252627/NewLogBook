#pragma checksum "E:\git\NewLogBook\NewLogBook\NewLogBook\Views\Student\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b4813ba15d253a2db5b27ee3ffb53b0254d14015"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_Details), @"mvc.1.0.view", @"/Views/Student/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Student/Details.cshtml", typeof(AspNetCore.Views_Student_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4813ba15d253a2db5b27ee3ffb53b0254d14015", @"/Views/Student/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed44a3dcfc4f762dcb4c6ad54d57d46bf6e5a390", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NewLogBook.Entities.Student>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "E:\git\NewLogBook\NewLogBook\NewLogBook\Views\Student\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(128, 116, true);
            WriteLiteral("\r\n<h1>Details Student</h1>\r\n\r\n<div>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(245, 45, false);
#line 14 "E:\git\NewLogBook\NewLogBook\NewLogBook\Views\Student\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(290, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(354, 41, false);
#line 17 "E:\git\NewLogBook\NewLogBook\NewLogBook\Views\Student\Details.cshtml"
       Write(Html.DisplayFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(395, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(458, 44, false);
#line 20 "E:\git\NewLogBook\NewLogBook\NewLogBook\Views\Student\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(502, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(566, 40, false);
#line 23 "E:\git\NewLogBook\NewLogBook\NewLogBook\Views\Student\Details.cshtml"
       Write(Html.DisplayFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(606, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(669, 25, false);
#line 26 "E:\git\NewLogBook\NewLogBook\NewLogBook\Views\Student\Details.cshtml"
       Write(Html.DisplayName("Group"));

#line default
#line hidden
            EndContext();
            BeginContext(694, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(758, 42, false);
#line 29 "E:\git\NewLogBook\NewLogBook\NewLogBook\Views\Student\Details.cshtml"
       Write(Html.DisplayFor(model => model.Group.Name));

#line default
#line hidden
            EndContext();
            BeginContext(800, 151, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n        <h4>List Mark</h4>\r\n    </div>\r\n</div>\r\n<div class=\"row\">\r\n");
            EndContext();
#line 39 "E:\git\NewLogBook\NewLogBook\NewLogBook\Views\Student\Details.cshtml"
     if (Model.Marks.Count != 0)
    {
        foreach (var VARIABLE in Model.Marks)
        {

#line default
#line hidden
            BeginContext(1050, 51, true);
            WriteLiteral("            <dt class=\"col-sm-3\">\r\n                ");
            EndContext();
            BeginContext(1102, 36, false);
#line 44 "E:\git\NewLogBook\NewLogBook\NewLogBook\Views\Student\Details.cshtml"
           Write(VARIABLE.TeacherSubject.Subject.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1138, 72, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-9\">\r\n                ");
            EndContext();
            BeginContext(1211, 14, false);
#line 47 "E:\git\NewLogBook\NewLogBook\NewLogBook\Views\Student\Details.cshtml"
           Write(VARIABLE.Value);

#line default
#line hidden
            EndContext();
            BeginContext(1225, 21, true);
            WriteLiteral("\r\n            </dd>\r\n");
            EndContext();
#line 49 "E:\git\NewLogBook\NewLogBook\NewLogBook\Views\Student\Details.cshtml"
        }
    }
    else
    {

#line default
#line hidden
            BeginContext(1281, 82, true);
            WriteLiteral("        <div class=\"col-sm-12\">\r\n            <h5>Not Marks!</h5>\r\n        </div>\r\n");
            EndContext();
#line 56 "E:\git\NewLogBook\NewLogBook\NewLogBook\Views\Student\Details.cshtml"
    }

#line default
#line hidden
            BeginContext(1370, 21, true);
            WriteLiteral("</div>\r\n\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1392, 95, false);
#line 60 "E:\git\NewLogBook\NewLogBook\NewLogBook\Views\Student\Details.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { id = Model.Id }, new {@class = "btn-success btn btn-sm"}));

#line default
#line hidden
            EndContext();
            BeginContext(1487, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1495, 69, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b4813ba15d253a2db5b27ee3ffb53b0254d140158953", async() => {
                BeginContext(1548, 12, true);
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
            BeginContext(1564, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NewLogBook.Entities.Student> Html { get; private set; }
    }
}
#pragma warning restore 1591
