#pragma checksum "C:\Users\sayit\source\repos\CoreAndFood\CoreAndFood\Views\Default\Components\CategoryGetList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a1f7341b949cd26e1c03d985c1d6c19793d33cde"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Default_Components_CategoryGetList_Default), @"mvc.1.0.view", @"/Views/Default/Components/CategoryGetList/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1f7341b949cd26e1c03d985c1d6c19793d33cde", @"/Views/Default/Components/CategoryGetList/Default.cshtml")]
    #nullable restore
    public class Views_Default_Components_CategoryGetList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CoreAndFood.Data.Models.Category>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n\r\n<div class=\"collapse navbar-collapse\" id=\"bs-megadropdown-tabs\">\r\n\r\n    <ul class=\"nav navbar-nav nav_1\">\r\n");
#nullable restore
#line 9 "C:\Users\sayit\source\repos\CoreAndFood\CoreAndFood\Views\Default\Components\CategoryGetList\Default.cshtml"
         foreach(var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li><a href=\"#\">");
#nullable restore
#line 11 "C:\Users\sayit\source\repos\CoreAndFood\CoreAndFood\Views\Default\Components\CategoryGetList\Default.cshtml"
                       Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 12 "C:\Users\sayit\source\repos\CoreAndFood\CoreAndFood\Views\Default\Components\CategoryGetList\Default.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CoreAndFood.Data.Models.Category>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
