#pragma checksum "C:\Users\RYZEN\Source\Repos\CarRentalSystemManagement\DristRent\DristRent\Views\Pages\Page.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "86c6cba4573ac494781c42d794a2fffc50a74726"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pages_Page), @"mvc.1.0.view", @"/Views/Pages/Page.cshtml")]
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
#line 1 "C:\Users\RYZEN\Source\Repos\CarRentalSystemManagement\DristRent\DristRent\Views\_ViewImports.cshtml"
using DristRent;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\RYZEN\Source\Repos\CarRentalSystemManagement\DristRent\DristRent\Views\_ViewImports.cshtml"
using DristRent.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"86c6cba4573ac494781c42d794a2fffc50a74726", @"/Views/Pages/Page.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed03f83e4daa5ec7c6e8d875f98d0c457a0defe7", @"/Views/_ViewImports.cshtml")]
    public class Views_Pages_Page : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Page>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\RYZEN\Source\Repos\CarRentalSystemManagement\DristRent\DristRent\Views\Pages\Page.cshtml"
  
    ViewData["Title"] = "DristRent";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Page</h1>\r\n\r\n\r\n");
#nullable restore
#line 10 "C:\Users\RYZEN\Source\Repos\CarRentalSystemManagement\DristRent\DristRent\Views\Pages\Page.cshtml"
Write(Html.Raw(Model.Content));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Page> Html { get; private set; }
    }
}
#pragma warning restore 1591
