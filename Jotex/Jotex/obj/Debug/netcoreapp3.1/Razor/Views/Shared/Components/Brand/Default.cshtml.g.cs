#pragma checksum "C:\Users\Darklight\Documents\Aspnet-Final\Jotex\Jotex\Views\Shared\Components\Brand\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a64b469b37742d0a71f922addcb92850d6c7f19a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Brand_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Brand/Default.cshtml")]
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
#line 1 "C:\Users\Darklight\Documents\Aspnet-Final\Jotex\Jotex\Views\_ViewImports.cshtml"
using Jotex;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Darklight\Documents\Aspnet-Final\Jotex\Jotex\Views\_ViewImports.cshtml"
using Jotex.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Darklight\Documents\Aspnet-Final\Jotex\Jotex\Views\_ViewImports.cshtml"
using Repository.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a64b469b37742d0a71f922addcb92850d6c7f19a", @"/Views/Shared/Components/Brand/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"007a8a708fee568af5869014feea2cc25da98431", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Brand_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BrandViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<!-- start partners-section -->
<section class=""partners-section"">
    <h2 class=""hidden"">Partnyorlarr</h2>
    <div class=""container"">
        <div class=""row"">
            <div class=""col col-xs-12"">
                <div class=""partner-grids partners-slider"">
");
#nullable restore
#line 10 "C:\Users\Darklight\Documents\Aspnet-Final\Jotex\Jotex\Views\Shared\Components\Brand\Default.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"grid\">\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 456, "\"", 488, 2);
            WriteAttributeValue("", 462, "images/partners/", 462, 16, true);
#nullable restore
#line 13 "C:\Users\Darklight\Documents\Aspnet-Final\Jotex\Jotex\Views\Shared\Components\Brand\Default.cshtml"
WriteAttributeValue("", 478, item.Logo, 478, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 489, "\"", 495, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        </div>\r\n");
#nullable restore
#line 15 "C:\Users\Darklight\Documents\Aspnet-Final\Jotex\Jotex\Views\Shared\Components\Brand\Default.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div> <!-- end container -->\r\n</section>\r\n<!-- end partners-section -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BrandViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
