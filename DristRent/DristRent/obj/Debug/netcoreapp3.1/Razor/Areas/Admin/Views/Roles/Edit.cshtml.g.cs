#pragma checksum "C:\Users\RYZEN\source\repos\CarRentalSystemManagement\DristRent\DristRent\Areas\Admin\Views\Roles\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e4b817822d71317eaa78f56dea4b280ca1ca96a9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Roles_Edit), @"mvc.1.0.view", @"/Areas/Admin/Views/Roles/Edit.cshtml")]
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
#line 1 "C:\Users\RYZEN\source\repos\CarRentalSystemManagement\DristRent\DristRent\Areas\Admin\Views\_ViewImports.cshtml"
using DristRent;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\RYZEN\source\repos\CarRentalSystemManagement\DristRent\DristRent\Areas\Admin\Views\_ViewImports.cshtml"
using DristRent.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4b817822d71317eaa78f56dea4b280ca1ca96a9", @"/Areas/Admin/Views/Roles/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed03f83e4daa5ec7c6e8d875f98d0c457a0defe7", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Roles_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RoleEdit>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\RYZEN\source\repos\CarRentalSystemManagement\DristRent\DristRent\Areas\Admin\Views\Roles\Edit.cshtml"
  
    ViewData["Title"] = "Edit Roles";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>Edit Roles</h1>\r\n<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e4b817822d71317eaa78f56dea4b280ca1ca96a94953", async() => {
                WriteLiteral("\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e4b817822d71317eaa78f56dea4b280ca1ca96a95223", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 10 "C:\Users\RYZEN\source\repos\CarRentalSystemManagement\DristRent\DristRent\Areas\Admin\Views\Roles\Edit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            <input type=\"hidden\" name=\"RoleName\"");
                BeginWriteAttribute("value", " value=\"", 296, "\"", 320, 1);
#nullable restore
#line 11 "C:\Users\RYZEN\source\repos\CarRentalSystemManagement\DristRent\DristRent\Areas\Admin\Views\Roles\Edit.cshtml"
WriteAttributeValue("", 304, Model.Role.Name, 304, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n            <div class=\"row\">\r\n                <div class=\"col-6\">\r\n                    <h2>Add users to <span class=\"badge badge-primary\">");
#nullable restore
#line 14 "C:\Users\RYZEN\source\repos\CarRentalSystemManagement\DristRent\DristRent\Areas\Admin\Views\Roles\Edit.cshtml"
                                                                  Write(Model.Role.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </span>Role</h2>\r\n                    <table class=\"table table-bordered\">\r\n");
#nullable restore
#line 16 "C:\Users\RYZEN\source\repos\CarRentalSystemManagement\DristRent\DristRent\Areas\Admin\Views\Roles\Edit.cshtml"
                         if (Model.NonMembers.Count() == 0)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <tr><td>All users are members.</td></tr>\r\n");
#nullable restore
#line 19 "C:\Users\RYZEN\source\repos\CarRentalSystemManagement\DristRent\DristRent\Areas\Admin\Views\Roles\Edit.cshtml"
                        }
                        else
                        {
                            foreach (ApplicationUser user in Model.NonMembers)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <tr>\r\n                                    <td>");
#nullable restore
#line 25 "C:\Users\RYZEN\source\repos\CarRentalSystemManagement\DristRent\DristRent\Areas\Admin\Views\Roles\Edit.cshtml"
                                   Write(user.UserName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                    <td>\r\n                                        <input type=\"checkbox\" name=\"AddIds\"");
                BeginWriteAttribute("value", " value=\"", 1128, "\"", 1144, 1);
#nullable restore
#line 27 "C:\Users\RYZEN\source\repos\CarRentalSystemManagement\DristRent\DristRent\Areas\Admin\Views\Roles\Edit.cshtml"
WriteAttributeValue("", 1136, user.Id, 1136, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n\r\n                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 31 "C:\Users\RYZEN\source\repos\CarRentalSystemManagement\DristRent\DristRent\Areas\Admin\Views\Roles\Edit.cshtml"

                            }
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </table>\r\n                </div>\r\n                <div class=\"col-6\">\r\n                    <h2>Remove users from <span class=\"badge badge-primary\">");
#nullable restore
#line 37 "C:\Users\RYZEN\source\repos\CarRentalSystemManagement\DristRent\DristRent\Areas\Admin\Views\Roles\Edit.cshtml"
                                                                       Write(Model.Role.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </span>Role</h2>\r\n                    <table class=\"table table-bordered\">\r\n");
#nullable restore
#line 39 "C:\Users\RYZEN\source\repos\CarRentalSystemManagement\DristRent\DristRent\Areas\Admin\Views\Roles\Edit.cshtml"
                         if (Model.Members.Count() == 0)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <tr><td>No users are members.</td></tr>\r\n");
#nullable restore
#line 42 "C:\Users\RYZEN\source\repos\CarRentalSystemManagement\DristRent\DristRent\Areas\Admin\Views\Roles\Edit.cshtml"
                        }
                        else
                        {
                            foreach (ApplicationUser user in Model.Members)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <tr>\r\n                                    <td>");
#nullable restore
#line 48 "C:\Users\RYZEN\source\repos\CarRentalSystemManagement\DristRent\DristRent\Areas\Admin\Views\Roles\Edit.cshtml"
                                   Write(user.UserName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                    <td>\r\n                                        <input type=\"checkbox\" name=\"DeleteIds\"");
                BeginWriteAttribute("value", " value=\"", 2120, "\"", 2136, 1);
#nullable restore
#line 50 "C:\Users\RYZEN\source\repos\CarRentalSystemManagement\DristRent\DristRent\Areas\Admin\Views\Roles\Edit.cshtml"
WriteAttributeValue("", 2128, user.Id, 2128, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n\r\n                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 54 "C:\Users\RYZEN\source\repos\CarRentalSystemManagement\DristRent\DristRent\Areas\Admin\Views\Roles\Edit.cshtml"

                            }
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </table>\r\n                </div>\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <input type=\"submit\" value=\"Save\" class=\"btn btn-primary\" />\r\n            </div>\r\n\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e4b817822d71317eaa78f56dea4b280ca1ca96a914143", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RoleEdit> Html { get; private set; }
    }
}
#pragma warning restore 1591
