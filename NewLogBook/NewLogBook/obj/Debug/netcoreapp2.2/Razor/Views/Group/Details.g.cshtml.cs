#pragma checksum "E:\git\NewLogBook\NewLogBook\NewLogBook\Views\Group\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "97a287ccf99c235a5c94a5ff63520533f5632a28"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Group_Details), @"mvc.1.0.view", @"/Views/Group/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Group/Details.cshtml", typeof(AspNetCore.Views_Group_Details))]
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
#line 1 "E:\git\NewLogBook\NewLogBook\NewLogBook\Views\Group\Details.cshtml"
using NewLogBook.Entities;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"97a287ccf99c235a5c94a5ff63520533f5632a28", @"/Views/Group/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed44a3dcfc4f762dcb4c6ad54d57d46bf6e5a390", @"/Views/_ViewImports.cshtml")]
    public class Views_Group_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NewLogBook.Entities.Group>
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
            BeginContext(62, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "E:\git\NewLogBook\NewLogBook\NewLogBook\Views\Group\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(154, 114, true);
            WriteLiteral("\r\n<h1>Details Group</h1>\r\n\r\n<div>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(269, 30, false);
#line 15 "E:\git\NewLogBook\NewLogBook\NewLogBook\Views\Group\Details.cshtml"
       Write(Html.DisplayName("Name Group"));

#line default
#line hidden
            EndContext();
            BeginContext(299, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(363, 36, false);
#line 18 "E:\git\NewLogBook\NewLogBook\NewLogBook\Views\Group\Details.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(399, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(462, 32, false);
#line 21 "E:\git\NewLogBook\NewLogBook\NewLogBook\Views\Group\Details.cshtml"
       Write(Html.DisplayName("Name Faculty"));

#line default
#line hidden
            EndContext();
            BeginContext(494, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(558, 44, false);
#line 24 "E:\git\NewLogBook\NewLogBook\NewLogBook\Views\Group\Details.cshtml"
       Write(Html.DisplayFor(model => model.Faculty.Name));

#line default
#line hidden
            EndContext();
            BeginContext(602, 170, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    <div class=\"row\">\r\n        <div class=\"col-md-12\">\r\n            <h3>List Students</h3>\r\n        </div>\r\n    </div>\r\n    <dl class=\"row\">\r\n");
            EndContext();
#line 33 "E:\git\NewLogBook\NewLogBook\NewLogBook\Views\Group\Details.cshtml"
         if (Model.Students.Count != 0)
        {
            foreach (Student VARIABLE in Model.Students)
            {

#line default
#line hidden
            BeginContext(897, 94, true);
            WriteLiteral("                <dt class=\"col-sm-3\">Name student:</dt>\r\n                <dd class=\"col-sm-9\">");
            EndContext();
            BeginContext(992, 17, false);
#line 38 "E:\git\NewLogBook\NewLogBook\NewLogBook\Views\Group\Details.cshtml"
                                Write(VARIABLE.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(1009, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1011, 18, false);
#line 38 "E:\git\NewLogBook\NewLogBook\NewLogBook\Views\Group\Details.cshtml"
                                                   Write(VARIABLE.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(1029, 7, true);
            WriteLiteral("</dd>\r\n");
            EndContext();
#line 39 "E:\git\NewLogBook\NewLogBook\NewLogBook\Views\Group\Details.cshtml"
            }
        }
        else
        {

#line default
#line hidden
            BeginContext(1087, 127, true);
            WriteLiteral("            <div class=\"col-md-12\">\r\n                <p class=\"text-info\">This group is not students!</p>\r\n            </div>\r\n");
            EndContext();
#line 46 "E:\git\NewLogBook\NewLogBook\NewLogBook\Views\Group\Details.cshtml"
        }

#line default
#line hidden
            BeginContext(1225, 34, true);
            WriteLiteral("\r\n\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1260, 94, false);
#line 52 "E:\git\NewLogBook\NewLogBook\NewLogBook\Views\Group\Details.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { id = Model.Id },new {@class = "btn-success btn btn-sm"}));

#line default
#line hidden
            EndContext();
            BeginContext(1354, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1362, 69, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "97a287ccf99c235a5c94a5ff63520533f5632a288335", async() => {
                BeginContext(1415, 12, true);
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
            BeginContext(1431, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NewLogBook.Entities.Group> Html { get; private set; }
    }
}
#pragma warning restore 1591
