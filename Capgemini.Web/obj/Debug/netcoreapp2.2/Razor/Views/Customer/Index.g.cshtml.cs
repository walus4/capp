#pragma checksum "C:\Users\micha\source\repos\Capgemini\Capgemini.Web\Views\Customer\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "32df7c6e18dcc7b483d330d7dd80873aef5c841d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_Index), @"mvc.1.0.view", @"/Views/Customer/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Customer/Index.cshtml", typeof(AspNetCore.Views_Customer_Index))]
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
#line 1 "C:\Users\micha\source\repos\Capgemini\Capgemini.Web\Views\_ViewImports.cshtml"
using Capgemini.Web;

#line default
#line hidden
#line 2 "C:\Users\micha\source\repos\Capgemini\Capgemini.Web\Views\_ViewImports.cshtml"
using Capgemini.Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32df7c6e18dcc7b483d330d7dd80873aef5c841d", @"/Views/Customer/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6652e88d128884ae7f2b72af3c99482ab0a95df5", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Capgemini.Domain.DTO.CustormerDTO>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddNew", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(55, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\micha\source\repos\Capgemini\Capgemini.Web\Views\Customer\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(98, 29, true);
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(127, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "32df7c6e18dcc7b483d330d7dd80873aef5c841d3831", async() => {
                BeginContext(150, 10, true);
                WriteLiteral("Create New");
                EndContext();
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
            EndContext();
            BeginContext(164, 80, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n    <tr>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(245, 38, false);
#line 16 "C:\Users\micha\source\repos\Capgemini\Capgemini.Web\Views\Customer\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(283, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(327, 40, false);
#line 19 "C:\Users\micha\source\repos\Capgemini\Capgemini.Web\Views\Customer\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(367, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(411, 43, false);
#line 22 "C:\Users\micha\source\repos\Capgemini\Capgemini.Web\Views\Customer\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Surname));

#line default
#line hidden
            EndContext();
            BeginContext(454, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(498, 47, false);
#line 25 "C:\Users\micha\source\repos\Capgemini\Capgemini.Web\Views\Customer\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.CompanyName));

#line default
#line hidden
            EndContext();
            BeginContext(545, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(589, 39, false);
#line 28 "C:\Users\micha\source\repos\Capgemini\Capgemini.Web\Views\Customer\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.NIP));

#line default
#line hidden
            EndContext();
            BeginContext(628, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(672, 40, false);
#line 31 "C:\Users\micha\source\repos\Capgemini\Capgemini.Web\Views\Customer\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.City));

#line default
#line hidden
            EndContext();
            BeginContext(712, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(756, 46, false);
#line 34 "C:\Users\micha\source\repos\Capgemini\Capgemini.Web\Views\Customer\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.PostalCode));

#line default
#line hidden
            EndContext();
            BeginContext(802, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(846, 42, false);
#line 37 "C:\Users\micha\source\repos\Capgemini\Capgemini.Web\Views\Customer\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Street));

#line default
#line hidden
            EndContext();
            BeginContext(888, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(932, 43, false);
#line 40 "C:\Users\micha\source\repos\Capgemini\Capgemini.Web\Views\Customer\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.HauseNo));

#line default
#line hidden
            EndContext();
            BeginContext(975, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(1019, 49, false);
#line 43 "C:\Users\micha\source\repos\Capgemini\Capgemini.Web\Views\Customer\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.AppartamentNo));

#line default
#line hidden
            EndContext();
            BeginContext(1068, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(1112, 47, false);
#line 46 "C:\Users\micha\source\repos\Capgemini\Capgemini.Web\Views\Customer\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.SalesActive));

#line default
#line hidden
            EndContext();
            BeginContext(1159, 74, true);
            WriteLiteral("\r\n        </th>\r\n        <th></th>\r\n    </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 52 "C:\Users\micha\source\repos\Capgemini\Capgemini.Web\Views\Customer\Index.cshtml"
     if (Model.Count() > 0)
    {
        foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(1317, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1378, 37, false);
#line 58 "C:\Users\micha\source\repos\Capgemini\Capgemini.Web\Views\Customer\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(1415, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1483, 39, false);
#line 61 "C:\Users\micha\source\repos\Capgemini\Capgemini.Web\Views\Customer\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1522, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1590, 42, false);
#line 64 "C:\Users\micha\source\repos\Capgemini\Capgemini.Web\Views\Customer\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Surname));

#line default
#line hidden
            EndContext();
            BeginContext(1632, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1700, 46, false);
#line 67 "C:\Users\micha\source\repos\Capgemini\Capgemini.Web\Views\Customer\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.CompanyName));

#line default
#line hidden
            EndContext();
            BeginContext(1746, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1814, 38, false);
#line 70 "C:\Users\micha\source\repos\Capgemini\Capgemini.Web\Views\Customer\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.NIP));

#line default
#line hidden
            EndContext();
            BeginContext(1852, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1920, 39, false);
#line 73 "C:\Users\micha\source\repos\Capgemini\Capgemini.Web\Views\Customer\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.City));

#line default
#line hidden
            EndContext();
            BeginContext(1959, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2027, 45, false);
#line 76 "C:\Users\micha\source\repos\Capgemini\Capgemini.Web\Views\Customer\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.PostalCode));

#line default
#line hidden
            EndContext();
            BeginContext(2072, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2140, 41, false);
#line 79 "C:\Users\micha\source\repos\Capgemini\Capgemini.Web\Views\Customer\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Street));

#line default
#line hidden
            EndContext();
            BeginContext(2181, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2249, 42, false);
#line 82 "C:\Users\micha\source\repos\Capgemini\Capgemini.Web\Views\Customer\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.HauseNo));

#line default
#line hidden
            EndContext();
            BeginContext(2291, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2359, 48, false);
#line 85 "C:\Users\micha\source\repos\Capgemini\Capgemini.Web\Views\Customer\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.AppartamentNo));

#line default
#line hidden
            EndContext();
            BeginContext(2407, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2475, 46, false);
#line 88 "C:\Users\micha\source\repos\Capgemini\Capgemini.Web\Views\Customer\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.SalesActive));

#line default
#line hidden
            EndContext();
            BeginContext(2521, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2589, 51, false);
#line 91 "C:\Users\micha\source\repos\Capgemini\Capgemini.Web\Views\Customer\Index.cshtml"
               Write(Html.ActionLink("Edit", "Edit", new {id = item.Id}));

#line default
#line hidden
            EndContext();
            BeginContext(2640, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(2665, 55, false);
#line 92 "C:\Users\micha\source\repos\Capgemini\Capgemini.Web\Views\Customer\Index.cshtml"
               Write(Html.ActionLink("Delete", "Delete", new {id = item.Id}));

#line default
#line hidden
            EndContext();
            BeginContext(2720, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 95 "C:\Users\micha\source\repos\Capgemini\Capgemini.Web\Views\Customer\Index.cshtml"
        }
    }

#line default
#line hidden
            BeginContext(2782, 24, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Capgemini.Domain.DTO.CustormerDTO>> Html { get; private set; }
    }
}
#pragma warning restore 1591
