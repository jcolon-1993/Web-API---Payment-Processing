#pragma checksum "C:\Users\mainza\source\repos\SeniorProject\MVCProject1\ViewApi\Views\Home\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f86b68773747f76496cd98b63c46a0ac11afa33c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Edit), @"mvc.1.0.view", @"/Views/Home/Edit.cshtml")]
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
#nullable restore
#line 1 "C:\Users\mainza\source\repos\SeniorProject\MVCProject1\ViewApi\Views\_ViewImports.cshtml"
using ViewApi;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mainza\source\repos\SeniorProject\MVCProject1\ViewApi\Views\_ViewImports.cshtml"
using ViewApi.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f86b68773747f76496cd98b63c46a0ac11afa33c", @"/Views/Home/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d82ac1e86d4df845f7e0ee4295084142e151b26b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ViewApi.Models.UserInfo>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\Users\mainza\source\repos\SeniorProject\MVCProject1\ViewApi\Views\Home\Edit.cshtml"
  
    ViewData["Title"] = "Edit";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Edit</h1>\r\n\r\n\r\n");
#nullable restore
#line 11 "C:\Users\mainza\source\repos\SeniorProject\MVCProject1\ViewApi\Views\Home\Edit.cshtml"
 using (Html.BeginForm("Edit", "Home", FormMethod.Post))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\mainza\source\repos\SeniorProject\MVCProject1\ViewApi\Views\Home\Edit.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\mainza\source\repos\SeniorProject\MVCProject1\ViewApi\Views\Home\Edit.cshtml"
Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 16 "C:\Users\mainza\source\repos\SeniorProject\MVCProject1\ViewApi\Views\Home\Edit.cshtml"
   Write(Html.LabelFor(model => model.firstName, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
#nullable restore
#line 18 "C:\Users\mainza\source\repos\SeniorProject\MVCProject1\ViewApi\Views\Home\Edit.cshtml"
       Write(Html.EditorFor(model => model.firstName, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 19 "C:\Users\mainza\source\repos\SeniorProject\MVCProject1\ViewApi\Views\Home\Edit.cshtml"
       Write(Html.ValidationMessageFor(model => model.firstName, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 24 "C:\Users\mainza\source\repos\SeniorProject\MVCProject1\ViewApi\Views\Home\Edit.cshtml"
   Write(Html.LabelFor(model => model.lastName, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
#nullable restore
#line 26 "C:\Users\mainza\source\repos\SeniorProject\MVCProject1\ViewApi\Views\Home\Edit.cshtml"
       Write(Html.EditorFor(model => model.lastName, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 27 "C:\Users\mainza\source\repos\SeniorProject\MVCProject1\ViewApi\Views\Home\Edit.cshtml"
       Write(Html.ValidationMessageFor(model => model.lastName, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
            WriteLiteral("    <div class=\"form-group\">\r\n    ");
#nullable restore
#line 32 "C:\Users\mainza\source\repos\SeniorProject\MVCProject1\ViewApi\Views\Home\Edit.cshtml"
Write(Html.LabelFor(model => model.password, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div class=\"col-md-10\">\r\n        ");
#nullable restore
#line 34 "C:\Users\mainza\source\repos\SeniorProject\MVCProject1\ViewApi\Views\Home\Edit.cshtml"
   Write(Html.PasswordFor(model => model.password, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 35 "C:\Users\mainza\source\repos\SeniorProject\MVCProject1\ViewApi\Views\Home\Edit.cshtml"
   Write(Html.ValidationMessageFor(model => model.password, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    </div>\r\n");
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 40 "C:\Users\mainza\source\repos\SeniorProject\MVCProject1\ViewApi\Views\Home\Edit.cshtml"
   Write(Html.LabelFor(model => model.creditCardNumber, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
#nullable restore
#line 42 "C:\Users\mainza\source\repos\SeniorProject\MVCProject1\ViewApi\Views\Home\Edit.cshtml"
       Write(Html.EditorFor(model => model.creditCardNumber, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 43 "C:\Users\mainza\source\repos\SeniorProject\MVCProject1\ViewApi\Views\Home\Edit.cshtml"
       Write(Html.ValidationMessageFor(model => model.creditCardNumber, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 48 "C:\Users\mainza\source\repos\SeniorProject\MVCProject1\ViewApi\Views\Home\Edit.cshtml"
   Write(Html.LabelFor(model => model.ccv, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
#nullable restore
#line 50 "C:\Users\mainza\source\repos\SeniorProject\MVCProject1\ViewApi\Views\Home\Edit.cshtml"
       Write(Html.PasswordFor(model => model.ccv, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 51 "C:\Users\mainza\source\repos\SeniorProject\MVCProject1\ViewApi\Views\Home\Edit.cshtml"
       Write(Html.ValidationMessageFor(model => model.ccv, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 56 "C:\Users\mainza\source\repos\SeniorProject\MVCProject1\ViewApi\Views\Home\Edit.cshtml"
   Write(Html.LabelFor(model => model.expirationDate, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n\r\n            ");
#nullable restore
#line 59 "C:\Users\mainza\source\repos\SeniorProject\MVCProject1\ViewApi\Views\Home\Edit.cshtml"
       Write(Html.EditorFor(model => model.expirationDate, new { htmlAttributes = new { @class = "form-control", type = "date" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 60 "C:\Users\mainza\source\repos\SeniorProject\MVCProject1\ViewApi\Views\Home\Edit.cshtml"
       Write(Html.ValidationMessageFor(model => model.expirationDate, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 65 "C:\Users\mainza\source\repos\SeniorProject\MVCProject1\ViewApi\Views\Home\Edit.cshtml"
   Write(Html.LabelFor(model => model.amount, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
#nullable restore
#line 67 "C:\Users\mainza\source\repos\SeniorProject\MVCProject1\ViewApi\Views\Home\Edit.cshtml"
       Write(Html.EditorFor(model => model.amount, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 68 "C:\Users\mainza\source\repos\SeniorProject\MVCProject1\ViewApi\Views\Home\Edit.cshtml"
       Write(Html.ValidationMessageFor(model => model.amount, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 73 "C:\Users\mainza\source\repos\SeniorProject\MVCProject1\ViewApi\Views\Home\Edit.cshtml"
   Write(Html.LabelFor(model => model.Name, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
#nullable restore
#line 75 "C:\Users\mainza\source\repos\SeniorProject\MVCProject1\ViewApi\Views\Home\Edit.cshtml"
       Write(Html.EditorFor(model => model.Name, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 76 "C:\Users\mainza\source\repos\SeniorProject\MVCProject1\ViewApi\Views\Home\Edit.cshtml"
       Write(Html.ValidationMessageFor(model => model.Name, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <button type=\"submit\" value=\"Save\" class=\"btn btn-outline-dark\">Save</button>\r\n    </div>\r\n");
#nullable restore
#line 82 "C:\Users\mainza\source\repos\SeniorProject\MVCProject1\ViewApi\Views\Home\Edit.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f86b68773747f76496cd98b63c46a0ac11afa33c13504", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 89 "C:\Users\mainza\source\repos\SeniorProject\MVCProject1\ViewApi\Views\Home\Edit.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ViewApi.Models.UserInfo> Html { get; private set; }
    }
}
#pragma warning restore 1591