#pragma checksum "C:\Users\Dad S. Wonkulah Jr\source\repos\Vidly\Views\Customers\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3581d016ededf1b21782b89dcdf1a9d2af67cdd0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customers_Details), @"mvc.1.0.view", @"/Views/Customers/Details.cshtml")]
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
#line 1 "C:\Users\Dad S. Wonkulah Jr\source\repos\Vidly\Views\_ViewImports.cshtml"
using Vidly;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Dad S. Wonkulah Jr\source\repos\Vidly\Views\_ViewImports.cshtml"
using Vidly.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Dad S. Wonkulah Jr\source\repos\Vidly\Views\_ViewImports.cshtml"
using Vidly.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Dad S. Wonkulah Jr\source\repos\Vidly\Views\_ViewImports.cshtml"
using Vidly.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3581d016ededf1b21782b89dcdf1a9d2af67cdd0", @"/Views/Customers/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"480ba70930f12651f882582f91b7d90dd502a88a", @"/Views/_ViewImports.cshtml")]
    public class Views_Customers_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Customer>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\Dad S. Wonkulah Jr\source\repos\Vidly\Views\Customers\Details.cshtml"
  
    ViewData["Title"] = "Customer details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>\r\n    ");
#nullable restore
#line 7 "C:\Users\Dad S. Wonkulah Jr\source\repos\Vidly\Views\Customers\Details.cshtml"
Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</h2>\r\n<ul>\r\n    <li>Membership Type: ");
#nullable restore
#line 10 "C:\Users\Dad S. Wonkulah Jr\source\repos\Vidly\Views\Customers\Details.cshtml"
                    Write(Model.MembershipType.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 11 "C:\Users\Dad S. Wonkulah Jr\source\repos\Vidly\Views\Customers\Details.cshtml"
     if (Model.BirthDate.HasValue)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>BirthDate: ");
#nullable restore
#line 13 "C:\Users\Dad S. Wonkulah Jr\source\repos\Vidly\Views\Customers\Details.cshtml"
                  Write(Model.BirthDate.Value.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 14 "C:\Users\Dad S. Wonkulah Jr\source\repos\Vidly\Views\Customers\Details.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <li>Gender: ");
#nullable restore
#line 15 "C:\Users\Dad S. Wonkulah Jr\source\repos\Vidly\Views\Customers\Details.cshtml"
           Write(Model.Gender.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n</ul>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3581d016ededf1b21782b89dcdf1a9d2af67cdd05779", async() => {
                WriteLiteral("\r\n    <i class=\"fa fa-arrow-alt-circle-left\"></i>&nbsp;Back to List\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Customer> Html { get; private set; }
    }
}
#pragma warning restore 1591