#pragma checksum "C:\Users\Darklight\Documents\Aspnet-Final\Jotex\Jotex\Views\Service\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ed3660cb78bad6fc57439072668b692dc9579121"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Service_Index), @"mvc.1.0.view", @"/Views/Service/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed3660cb78bad6fc57439072668b692dc9579121", @"/Views/Service/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"007a8a708fee568af5869014feea2cc25da98431", @"/Views/_ViewImports.cshtml")]
    public class Views_Service_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ServiceViewModel>
    {
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
        private global::AspNetCore.Views_Service_Index.__Generated__TestimonialViewComponentTagHelper __TestimonialViewComponentTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Darklight\Documents\Aspnet-Final\Jotex\Jotex\Views\Service\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!-- start page-title -->
<section class=""page-title"">
    <div class=""page-title-container"">
        <div class=""page-title-wrapper"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col col-xs-12"">
                        <h2>Service single</h2>
                        <ol class=""breadcrumb"">
                            <li><a href=""index.html"">Home</a></li>
                            <li>Service single</li>
                        </ol>
                    </div>
                </div> <!-- end row -->
            </div> <!-- end container -->
        </div>
    </div>
</section>
<!-- end page-title -->
<!-- start service-single-section -->
<section class=""service-single-section section-padding"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col col-xs-12"">
                <div class=""service-single-tab"">
                    <ul class=""nav tab-links clearfix"">
");
#nullable restore
#line 31 "C:\Users\Darklight\Documents\Aspnet-Final\Jotex\Jotex\Views\Service\Index.cshtml"
                         foreach (var item in Model.Services)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li >\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1205, "\"", 1221, 2);
            WriteAttributeValue("", 1212, "#", 1212, 1, true);
#nullable restore
#line 34 "C:\Users\Darklight\Documents\Aspnet-Final\Jotex\Jotex\Views\Service\Index.cshtml"
WriteAttributeValue("", 1213, item.Id, 1213, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-toggle=\"tab\">\r\n                                <i");
            BeginWriteAttribute("class", " class=\"", 1277, "\"", 1295, 1);
#nullable restore
#line 35 "C:\Users\Darklight\Documents\Aspnet-Final\Jotex\Jotex\Views\Service\Index.cshtml"
WriteAttributeValue("", 1285, item.Logo, 1285, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i>\r\n                                <h3>");
#nullable restore
#line 36 "C:\Users\Darklight\Documents\Aspnet-Final\Jotex\Jotex\Views\Service\Index.cshtml"
                               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                            </a>\r\n                        </li>");
#nullable restore
#line 38 "C:\Users\Darklight\Documents\Aspnet-Final\Jotex\Jotex\Views\Service\Index.cshtml"
                             }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </ul>\r\n\r\n                    <div class=\"tab-content\">\r\n");
#nullable restore
#line 43 "C:\Users\Darklight\Documents\Aspnet-Final\Jotex\Jotex\Views\Service\Index.cshtml"
                         foreach (var item in Model.Services)

                        { 


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"tab-pane fade in active\"");
            BeginWriteAttribute("id", " id=\"", 1651, "\"", 1664, 1);
#nullable restore
#line 47 "C:\Users\Darklight\Documents\Aspnet-Final\Jotex\Jotex\Views\Service\Index.cshtml"
WriteAttributeValue("", 1656, item.Id, 1656, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <div class=\"content-area clearfix\">\r\n                            <div class=\"grid info-grid\">\r\n                                <h3>");
#nullable restore
#line 50 "C:\Users\Darklight\Documents\Aspnet-Final\Jotex\Jotex\Views\Service\Index.cshtml"
                               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                                <p>");
#nullable restore
#line 51 "C:\Users\Darklight\Documents\Aspnet-Final\Jotex\Jotex\Views\Service\Index.cshtml"
                              Write(item.Details.ElementAt(0).Detail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                <p><strong>");
#nullable restore
#line 52 "C:\Users\Darklight\Documents\Aspnet-Final\Jotex\Jotex\Views\Service\Index.cshtml"
                                      Write(item.Details.ElementAt(0).SubDetail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></p>\r\n                                <table>\r\n                                    <tbody>\r\n\r\n");
#nullable restore
#line 56 "C:\Users\Darklight\Documents\Aspnet-Final\Jotex\Jotex\Views\Service\Index.cshtml"
                                         foreach (var spec in item.Specs)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <tr>\r\n                                                <td>");
#nullable restore
#line 59 "C:\Users\Darklight\Documents\Aspnet-Final\Jotex\Jotex\Views\Service\Index.cshtml"
                                               Write(spec.Key);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td>");
#nullable restore
#line 60 "C:\Users\Darklight\Documents\Aspnet-Final\Jotex\Jotex\Views\Service\Index.cshtml"
                                               Write(spec.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            </tr>\r\n");
#nullable restore
#line 62 "C:\Users\Darklight\Documents\Aspnet-Final\Jotex\Jotex\Views\Service\Index.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </tbody>\r\n                                </table>\r\n                            </div>\r\n                            <div class=\"grid\">\r\n                                <img");
            BeginWriteAttribute("src", " src=\"", 2706, "\"", 2751, 2);
            WriteAttributeValue("", 2712, "images/", 2712, 7, true);
#nullable restore
#line 68 "C:\Users\Darklight\Documents\Aspnet-Final\Jotex\Jotex\Views\Service\Index.cshtml"
WriteAttributeValue("", 2719, item.Details.ElementAt(0).Image, 2719, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Image\">\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"bottom-info\">\r\n                            <div class=\"text\">\r\n                                <h4>");
#nullable restore
#line 73 "C:\Users\Darklight\Documents\Aspnet-Final\Jotex\Jotex\Views\Service\Index.cshtml"
                               Write(item.Details.ElementAt(0).Information);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4>
                                <p>Samsa was a travelling salesman - and above it there hung a picture that he had recently cut out of an illustrated magazine and housed in a nice, gilded frame. It showed a lady fitted out with a fur hat and fur boa who sat upright, raising a heavy fur muff that covered the whole of her lower arm towards the viewer. Gregor then turned to look out the window at the dull weather</p>
                            </div>
                            <div class=""pdf-dwn-area"">
                                <a");
            BeginWriteAttribute("href", " href=\"", 3560, "\"", 3602, 1);
#nullable restore
#line 77 "C:\Users\Darklight\Documents\Aspnet-Final\Jotex\Jotex\Views\Service\Index.cshtml"
WriteAttributeValue("", 3567, item.Details.ElementAt(0).Document, 3567, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                    <i class=""ti-receipt""></i>
                                    <h5>General Insurance Conditions</h5>
                                    <p>Document size: 34kb</p>
                                </a>
                            </div>
                        </div>
                        <div class=""features-grid clearfix"">
                            <div class=""grid"">
                                <div class=""icon"">
                                    <i class=""fi flaticon-house""></i>
                                </div>
                                <h3>House protected</h3>
                                <p>Window at the dull weather</p>
                            </div>
                            <div class=""grid"">
                                <div class=""icon"">
                                    <i class=""fi flaticon-umbrella-1""></i>
                                </div>
                                <h3>Helth protected</h3>
    ");
            WriteLiteral(@"                            <p>Window at the dull weather</p>
                            </div>
                            <div class=""grid"">
                                <div class=""icon"">
                                    <i class=""fi flaticon-cost""></i>
                                </div>
                                <h3>Small Premium</h3>
                                <p>Window at the dull weather</p>
                            </div>
                        </div>
                    </div>
");
#nullable restore
#line 108 "C:\Users\Darklight\Documents\Aspnet-Final\Jotex\Jotex\Views\Service\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                      
                                </div>
                </div>
            </div>
        </div>
    </div> <!-- end container -->
</section>
<!-- end service-single-section -->
<!-- start testimonials-section-s2 -->
<section class=""testimonials-section-s2 section-padding"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-4"">
                <div class=""section-title"">
                    <span>Testimonials</span>
                    <h2>What People Says About Us</h2>
                </div>

                <div class=""testimonials-s2-nav"">
                    <div class=""slider-s2-arrows"">
                        <div class=""slider-prev""><i class=""fi flaticon-left-arrow-angle-big-gross-symbol""></i></div>
                        <div class=""slider-next""><i class=""fi flaticon-arrow-angle-pointing-to-right""></i></div>
                    </div>
                </div>
            </div>
            <div class=""col-lg-8"">
        ");
            WriteLiteral("        <div class=\"testimonials-slider-holder\">\r\n                    <div class=\"testimonials-slider-s2\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("vc:testimonial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ed3660cb78bad6fc57439072668b692dc957912114648", async() => {
            }
            );
            __TestimonialViewComponentTagHelper = CreateTagHelper<global::AspNetCore.Views_Service_Index.__Generated__TestimonialViewComponentTagHelper>();
            __tagHelperExecutionContext.Add(__TestimonialViewComponentTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div> <!-- end container -->\r\n</section>\r\n<!-- end testimonials-section-s2 -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ServiceViewModel> Html { get; private set; }
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("vc:testimonial")]
        public class __Generated__TestimonialViewComponentTagHelper : Microsoft.AspNetCore.Razor.TagHelpers.TagHelper
        {
            private readonly global::Microsoft.AspNetCore.Mvc.IViewComponentHelper __helper = null;
            public __Generated__TestimonialViewComponentTagHelper(global::Microsoft.AspNetCore.Mvc.IViewComponentHelper helper)
            {
                __helper = helper;
            }
            [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNotBoundAttribute, global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewContextAttribute]
            public global::Microsoft.AspNetCore.Mvc.Rendering.ViewContext ViewContext { get; set; }
            public override async global::System.Threading.Tasks.Task ProcessAsync(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext __context, Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput __output)
            {
                (__helper as global::Microsoft.AspNetCore.Mvc.ViewFeatures.IViewContextAware)?.Contextualize(ViewContext);
                var __helperContent = await __helper.InvokeAsync("Testimonial", new {  });
                __output.TagName = null;
                __output.Content.SetHtmlContent(__helperContent);
            }
        }
    }
}
#pragma warning restore 1591
