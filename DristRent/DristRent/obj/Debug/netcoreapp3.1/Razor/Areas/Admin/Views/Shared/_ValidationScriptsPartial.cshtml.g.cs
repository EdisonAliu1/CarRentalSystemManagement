#pragma checksum "C:\Users\RYZEN\source\repos\CarRentalSystemManagement\DristRent\DristRent\Areas\Admin\Views\Shared\_ValidationScriptsPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "843acbaf33a1404d34c08837cb4ee5050ab98afe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared__ValidationScriptsPartial), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/_ValidationScriptsPartial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"843acbaf33a1404d34c08837cb4ee5050ab98afe", @"/Areas/Admin/Views/Shared/_ValidationScriptsPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"557ab666e1aa8a926bf6a7ba4ad5ab6fd534e2b7", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Shared__ValidationScriptsPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\RYZEN\source\repos\CarRentalSystemManagement\DristRent\DristRent\Areas\Admin\Views\Shared\_ValidationScriptsPartial.cshtml"
 if (TempData["Success"] != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"alert alert-success\">\r\n                    ");
#nullable restore
#line 4 "C:\Users\RYZEN\source\repos\CarRentalSystemManagement\DristRent\DristRent\Areas\Admin\Views\Shared\_ValidationScriptsPartial.cshtml"
               Write(TempData["Success"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n");
#nullable restore
#line 6 "C:\Users\RYZEN\source\repos\CarRentalSystemManagement\DristRent\DristRent\Areas\Admin\Views\Shared\_ValidationScriptsPartial.cshtml"
            }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
