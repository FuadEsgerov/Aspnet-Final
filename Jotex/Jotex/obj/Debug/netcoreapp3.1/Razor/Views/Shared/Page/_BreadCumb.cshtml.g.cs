#pragma checksum "C:\Users\Darklight\Documents\Aspnet-Final\Jotex\Jotex\Views\Shared\Page\_BreadCumb.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "66df1123af34f8d056a7a8bde779cdba9c7f0c6a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Page__BreadCumb), @"mvc.1.0.view", @"/Views/Shared/Page/_BreadCumb.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66df1123af34f8d056a7a8bde779cdba9c7f0c6a", @"/Views/Shared/Page/_BreadCumb.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"007a8a708fee568af5869014feea2cc25da98431", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Page__BreadCumb : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<!-- start page-title -->
<section class=""page-title"" style=""background-image: url(uploads/page-title.jpg);"">
    <div class=""page-title-container"">
        <div class=""page-title-wrapper"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col col-xs-12"">
                        <h2>");
#nullable restore
#line 8 "C:\Users\Darklight\Documents\Aspnet-Final\Jotex\Jotex\Views\Shared\Page\_BreadCumb.cshtml"
                       Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n                        <ol class=\"breadcrumb\">\n                            <li><a href=\"index.html\">Home</a></li>\n                            <li>");
#nullable restore
#line 11 "C:\Users\Darklight\Documents\Aspnet-Final\Jotex\Jotex\Views\Shared\Page\_BreadCumb.cshtml"
                           Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n                        </ol>\n                    </div>\n                </div> <!-- end row -->\n            </div> <!-- end container -->\n        </div>\n    </div>\n</section>\n<!-- end page-title -->");
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
