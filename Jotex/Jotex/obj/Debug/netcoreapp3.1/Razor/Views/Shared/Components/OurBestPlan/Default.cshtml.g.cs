#pragma checksum "C:\Users\Darklight\Documents\Aspnet-Final\Jotex\Jotex\Views\Shared\Components\OurBestPlan\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3348e27cd30b34738e0c09ea157159cbdbc97e5b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_OurBestPlan_Default), @"mvc.1.0.view", @"/Views/Shared/Components/OurBestPlan/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3348e27cd30b34738e0c09ea157159cbdbc97e5b", @"/Views/Shared/Components/OurBestPlan/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"440c41082d826c4ec5c7406764186cad7c7720ab", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_OurBestPlan_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<OurBestPlanViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n\r\n<div class=\"row\">\r\n    <div class=\"col col-xs-12\">\r\n        <div class=\"policy-grids\">\r\n");
#nullable restore
#line 9 "C:\Users\Darklight\Documents\Aspnet-Final\Jotex\Jotex\Views\Shared\Components\OurBestPlan\Default.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"grid\">\r\n");
#nullable restore
#line 12 "C:\Users\Darklight\Documents\Aspnet-Final\Jotex\Jotex\Views\Shared\Components\OurBestPlan\Default.cshtml"
                     if (item.Label.Id==2)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"hilight-tag\">");
#nullable restore
#line 13 "C:\Users\Darklight\Documents\Aspnet-Final\Jotex\Jotex\Views\Shared\Components\OurBestPlan\Default.cshtml"
                                         Write(item.Label.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
#nullable restore
#line 13 "C:\Users\Darklight\Documents\Aspnet-Final\Jotex\Jotex\Views\Shared\Components\OurBestPlan\Default.cshtml"
                                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                    <div class=\"policy-header\">\r\n                        <h5>");
#nullable restore
#line 17 "C:\Users\Darklight\Documents\Aspnet-Final\Jotex\Jotex\Views\Shared\Components\OurBestPlan\Default.cshtml"
                       Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                        <i class=\"fi flaticon-umbrella\"></i>\r\n                    </div>\r\n                    <div class=\"policy-body\">\r\n                        <ul>\r\n                            <li>");
#nullable restore
#line 22 "C:\Users\Darklight\Documents\Aspnet-Final\Jotex\Jotex\Views\Shared\Components\OurBestPlan\Default.cshtml"
                           Write(item.Detail1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                            <li>");
#nullable restore
#line 23 "C:\Users\Darklight\Documents\Aspnet-Final\Jotex\Jotex\Views\Shared\Components\OurBestPlan\Default.cshtml"
                           Write(item.Detail2);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </li>\r\n                            <li>");
#nullable restore
#line 24 "C:\Users\Darklight\Documents\Aspnet-Final\Jotex\Jotex\Views\Shared\Components\OurBestPlan\Default.cshtml"
                           Write(item.Detail3);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                            <li>");
#nullable restore
#line 25 "C:\Users\Darklight\Documents\Aspnet-Final\Jotex\Jotex\Views\Shared\Components\OurBestPlan\Default.cshtml"
                           Write(item.Detail4);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                        </ul>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 878, "\"", 899, 1);
#nullable restore
#line 27 "C:\Users\Darklight\Documents\Aspnet-Final\Jotex\Jotex\Views\Shared\Components\OurBestPlan\Default.cshtml"
WriteAttributeValue("", 885, item.EndPoint, 885, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"theme-btn-s3\">");
#nullable restore
#line 27 "C:\Users\Darklight\Documents\Aspnet-Final\Jotex\Jotex\Views\Shared\Components\OurBestPlan\Default.cshtml"
                                                                 Write(item.ActionText);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 30 "C:\Users\Darklight\Documents\Aspnet-Final\Jotex\Jotex\Views\Shared\Components\OurBestPlan\Default.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<OurBestPlanViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
