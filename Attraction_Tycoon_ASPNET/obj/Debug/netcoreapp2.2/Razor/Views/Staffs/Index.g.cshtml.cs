#pragma checksum "C:\Users\gigabyte\Documents\Informatique_2018-2019\Git\Attraction-Tycoon-ASPNET\Attraction_Tycoon_ASPNET\Views\Staffs\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "948ecc7ea78b16bb0f58d026978293984df15e7f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Staffs_Index), @"mvc.1.0.view", @"/Views/Staffs/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Staffs/Index.cshtml", typeof(AspNetCore.Views_Staffs_Index))]
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
#line 1 "C:\Users\gigabyte\Documents\Informatique_2018-2019\Git\Attraction-Tycoon-ASPNET\Attraction_Tycoon_ASPNET\Views\_ViewImports.cshtml"
using Attraction_Tycoon_ASPNET;

#line default
#line hidden
#line 2 "C:\Users\gigabyte\Documents\Informatique_2018-2019\Git\Attraction-Tycoon-ASPNET\Attraction_Tycoon_ASPNET\Views\_ViewImports.cshtml"
using Attraction_Tycoon_ASPNET.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"948ecc7ea78b16bb0f58d026978293984df15e7f", @"/Views/Staffs/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df9e7b4cfcd39c0e3286d2bec78e48f98a4fb3fb", @"/Views/_ViewImports.cshtml")]
    public class Views_Staffs_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Attraction_Tycoon_ASPNET.Models.Staff>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(59, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\gigabyte\Documents\Informatique_2018-2019\Git\Attraction-Tycoon-ASPNET\Attraction_Tycoon_ASPNET\Views\Staffs\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(102, 29, true);
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(131, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "948ecc7ea78b16bb0f58d026978293984df15e7f4956", async() => {
                BeginContext(154, 10, true);
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
            BeginContext(168, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(261, 43, false);
#line 16 "C:\Users\gigabyte\Documents\Informatique_2018-2019\Git\Attraction-Tycoon-ASPNET\Attraction_Tycoon_ASPNET\Views\Staffs\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.id_user));

#line default
#line hidden
            EndContext();
            BeginContext(304, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(360, 40, false);
#line 19 "C:\Users\gigabyte\Documents\Informatique_2018-2019\Git\Attraction-Tycoon-ASPNET\Attraction_Tycoon_ASPNET\Views\Staffs\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.name));

#line default
#line hidden
            EndContext();
            BeginContext(400, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(456, 40, false);
#line 22 "C:\Users\gigabyte\Documents\Informatique_2018-2019\Git\Attraction-Tycoon-ASPNET\Attraction_Tycoon_ASPNET\Views\Staffs\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.type));

#line default
#line hidden
            EndContext();
            BeginContext(496, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(552, 42, false);
#line 25 "C:\Users\gigabyte\Documents\Informatique_2018-2019\Git\Attraction-Tycoon-ASPNET\Attraction_Tycoon_ASPNET\Views\Staffs\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.salary));

#line default
#line hidden
            EndContext();
            BeginContext(594, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(650, 41, false);
#line 28 "C:\Users\gigabyte\Documents\Informatique_2018-2019\Git\Attraction-Tycoon-ASPNET\Attraction_Tycoon_ASPNET\Views\Staffs\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.hours));

#line default
#line hidden
            EndContext();
            BeginContext(691, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(747, 42, false);
#line 31 "C:\Users\gigabyte\Documents\Informatique_2018-2019\Git\Attraction-Tycoon-ASPNET\Attraction_Tycoon_ASPNET\Views\Staffs\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.status));

#line default
#line hidden
            EndContext();
            BeginContext(789, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 37 "C:\Users\gigabyte\Documents\Informatique_2018-2019\Git\Attraction-Tycoon-ASPNET\Attraction_Tycoon_ASPNET\Views\Staffs\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(907, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(956, 42, false);
#line 40 "C:\Users\gigabyte\Documents\Informatique_2018-2019\Git\Attraction-Tycoon-ASPNET\Attraction_Tycoon_ASPNET\Views\Staffs\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.id_user));

#line default
#line hidden
            EndContext();
            BeginContext(998, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1054, 39, false);
#line 43 "C:\Users\gigabyte\Documents\Informatique_2018-2019\Git\Attraction-Tycoon-ASPNET\Attraction_Tycoon_ASPNET\Views\Staffs\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.name));

#line default
#line hidden
            EndContext();
            BeginContext(1093, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1149, 39, false);
#line 46 "C:\Users\gigabyte\Documents\Informatique_2018-2019\Git\Attraction-Tycoon-ASPNET\Attraction_Tycoon_ASPNET\Views\Staffs\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.type));

#line default
#line hidden
            EndContext();
            BeginContext(1188, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1244, 41, false);
#line 49 "C:\Users\gigabyte\Documents\Informatique_2018-2019\Git\Attraction-Tycoon-ASPNET\Attraction_Tycoon_ASPNET\Views\Staffs\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.salary));

#line default
#line hidden
            EndContext();
            BeginContext(1285, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1341, 40, false);
#line 52 "C:\Users\gigabyte\Documents\Informatique_2018-2019\Git\Attraction-Tycoon-ASPNET\Attraction_Tycoon_ASPNET\Views\Staffs\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.hours));

#line default
#line hidden
            EndContext();
            BeginContext(1381, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1437, 41, false);
#line 55 "C:\Users\gigabyte\Documents\Informatique_2018-2019\Git\Attraction-Tycoon-ASPNET\Attraction_Tycoon_ASPNET\Views\Staffs\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.status));

#line default
#line hidden
            EndContext();
            BeginContext(1478, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1533, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "948ecc7ea78b16bb0f58d026978293984df15e7f12441", async() => {
                BeginContext(1578, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 58 "C:\Users\gigabyte\Documents\Informatique_2018-2019\Git\Attraction-Tycoon-ASPNET\Attraction_Tycoon_ASPNET\Views\Staffs\Index.cshtml"
                                       WriteLiteral(item.id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1586, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1606, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "948ecc7ea78b16bb0f58d026978293984df15e7f14838", async() => {
                BeginContext(1654, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 59 "C:\Users\gigabyte\Documents\Informatique_2018-2019\Git\Attraction-Tycoon-ASPNET\Attraction_Tycoon_ASPNET\Views\Staffs\Index.cshtml"
                                          WriteLiteral(item.id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1665, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1685, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "948ecc7ea78b16bb0f58d026978293984df15e7f17241", async() => {
                BeginContext(1732, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 60 "C:\Users\gigabyte\Documents\Informatique_2018-2019\Git\Attraction-Tycoon-ASPNET\Attraction_Tycoon_ASPNET\Views\Staffs\Index.cshtml"
                                         WriteLiteral(item.id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1742, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 63 "C:\Users\gigabyte\Documents\Informatique_2018-2019\Git\Attraction-Tycoon-ASPNET\Attraction_Tycoon_ASPNET\Views\Staffs\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1781, 24, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Attraction_Tycoon_ASPNET.Models.Staff>> Html { get; private set; }
    }
}
#pragma warning restore 1591
