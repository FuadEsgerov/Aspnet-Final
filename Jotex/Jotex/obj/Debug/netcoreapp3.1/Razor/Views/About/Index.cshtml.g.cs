#pragma checksum "C:\Users\Darklight\Documents\Aspnet-Final\Jotex\Jotex\Views\About\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eefeb930f870e7728ddb09d0c61ec646db9a5f9e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_About_Index), @"mvc.1.0.view", @"/Views/About/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eefeb930f870e7728ddb09d0c61ec646db9a5f9e", @"/Views/About/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"007a8a708fee568af5869014feea2cc25da98431", @"/Views/_ViewImports.cshtml")]
    public class Views_About_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AboutViewModel>
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
        private global::AspNetCore.Views_About_Index.__Generated__TestimonialViewComponentTagHelper __TestimonialViewComponentTagHelper;
        private global::AspNetCore.Views_About_Index.__Generated__BrandViewComponentTagHelper __BrandViewComponentTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Darklight\Documents\Aspnet-Final\Jotex\Jotex\Views\About\Index.cshtml"
   ViewData["Title"] = "Haqqımızda"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<!-- start page-title -->\n");
#nullable restore
#line 5 "C:\Users\Darklight\Documents\Aspnet-Final\Jotex\Jotex\Views\About\Index.cshtml"
Write(await Html.PartialAsync("../Shared/Page/_BreadCrumb"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- end page-title -->
<!-- start about-section-s4 -->
<section class=""about-section-s4 section-padding"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col col-md-3"">
                <div class=""section-title mt"">
                    <span>About us</span>
                    <img src=""images/logo-3.png""");
            BeginWriteAttribute("alt", " alt=\"", 480, "\"", 486, 0);
            EndWriteAttribute();
            WriteLiteral(">\n                </div>\n                <div class=\"info\">\n                    <h3>");
#nullable restore
#line 17 "C:\Users\Darklight\Documents\Aspnet-Final\Jotex\Jotex\Views\About\Index.cshtml"
                   Write(Model.Settings.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n                    <h4>");
#nullable restore
#line 18 "C:\Users\Darklight\Documents\Aspnet-Final\Jotex\Jotex\Views\About\Index.cshtml"
                   Write(Model.Settings.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n                    <a href=\"#\" class=\"theme-btn\">More About Us</a>\n                </div>\n            </div>\n            <div class=\"col col-md-5\">\n                <div class=\"details-text mt\">\n                    <h4>");
#nullable restore
#line 24 "C:\Users\Darklight\Documents\Aspnet-Final\Jotex\Jotex\Views\About\Index.cshtml"
                   Write(Model.Abouts.ElementAt(0).Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n                    <p>");
#nullable restore
#line 25 "C:\Users\Darklight\Documents\Aspnet-Final\Jotex\Jotex\Views\About\Index.cshtml"
                  Write(Model.Abouts.ElementAt(0).Text);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                </div>
            </div>
            <div class=""col col-md-4"">
                <div class=""features-grid clearfix"">
                    <div class=""grid"">
                        <div class=""icon"">
                            <i class=""fi flaticon-money-bag""></i>
                        </div>
                        <h3>Make a Claim</h3>
                        <p>You can claim you money</p>
                    </div>
                    <div class=""grid"">
                        <div class=""icon"">
                            <i class=""fi flaticon-agent""></i>
                        </div>
                        <h3>Find an Agent</h3>
                        <p>Want an agent?</p>
                    </div>
                    <div class=""grid"">
                        <div class=""icon"">
                            <i class=""fi flaticon-cost""></i>
                        </div>
                        <h3>Pay Premium</h3>
                        <p>Pay your premium now</p>
            ");
            WriteLiteral(@"        </div>
                </div>
            </div>
        </div>
    </div> <!-- end container -->
</section>
<!-- end about-section-s4 -->
<!-- stat fun-fact-section -->
<section class=""fun-fact-section"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col col-xs-12"">
                <div class=""fun-fact-area"">
                    <div class=""fun-fact-grids clearfix"">
                        <div class=""grid"">
                            <div class=""info"">
                                <h3><span class=""odometer"" data-count=""10,50,000"">00</span>+</h3>
                                <p>Insurance Policies Issued</p>
                                <p>A collection of textile samples lay spread out on the table samsa was a travelling</p>
                                <a href=""#"" class=""theme-btn-s3"">Become a customer</a>
                            </div>
                        </div>
                        <div class=""grid"">
                            <div class=""info");
            WriteLiteral(@""">
                                <h3><span class=""odometer"" data-count=""98.75"">00</span>%</h3>
                                <p>Claims paid during FY</p>
                                <p>A collection of textile samples lay spread out on the table samsa was a travelling</p>
                                <a href=""#"" class=""theme-btn-s3"">Make a claim</a>
                            </div>
                        </div>
                        <div class=""grid"">
                            <div class=""info"">
                                <h3><span class=""odometer"" data-count=""245"">00</span></h3>
                                <p>Offices arround the world</p>
                                <p>A collection of textile samples lay spread out on the table samsa was a travelling</p>
                                <a href=""#"" class=""theme-btn-s3"">Locate a branch</a>
                            </div>
                        </div>
                    </div>
                </div>

            </div>
       ");
            WriteLiteral(@" </div>
    </div> <!-- end container -->
</section>
<!-- end fun-fact-section -->
<!-- start agents-section -->
<section class=""agents-section p-b-0 section-padding"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col col-xs-12"">
                <div class=""agents-area-with-title"">
                    <div class=""agents-grids clearfix"">
                        <div class=""grid"">
                            <div class=""section-title"">
                                <span>Agents</span>
                                <h2>Our Agents</h2>
                            </div>
                            <div class=""info"">
                                <h3>");
#nullable restore
#line 109 "C:\Users\Darklight\Documents\Aspnet-Final\Jotex\Jotex\Views\About\Index.cshtml"
                               Write(Model.Settings.NeedHelpNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n                                <h4>");
#nullable restore
#line 110 "C:\Users\Darklight\Documents\Aspnet-Final\Jotex\Jotex\Views\About\Index.cshtml"
                               Write(Model.Settings.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n                                <a href=\"#\" class=\"theme-btn\">More About Us</a>\n                            </div>\n                        </div>\n");
#nullable restore
#line 114 "C:\Users\Darklight\Documents\Aspnet-Final\Jotex\Jotex\Views\About\Index.cshtml"
                         foreach (var item in Model.Agents)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"grid\">\n                <div class=\"img-holder\">\n                    <img");
            BeginWriteAttribute("src", " src=\"", 5151, "\"", 5182, 2);
            WriteAttributeValue("", 5157, "images/agents/", 5157, 14, true);
#nullable restore
#line 118 "C:\Users\Darklight\Documents\Aspnet-Final\Jotex\Jotex\Views\About\Index.cshtml"
WriteAttributeValue("", 5171, item.Image, 5171, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 5183, "\"", 5189, 0);
            EndWriteAttribute();
            WriteLiteral(">\n                </div>\n                <div class=\"agent-info\">\n                    <h4>");
#nullable restore
#line 121 "C:\Users\Darklight\Documents\Aspnet-Final\Jotex\Jotex\Views\About\Index.cshtml"
                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 121 "C:\Users\Darklight\Documents\Aspnet-Final\Jotex\Jotex\Views\About\Index.cshtml"
                              Write(item.SurName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n                    <p>");
#nullable restore
#line 122 "C:\Users\Darklight\Documents\Aspnet-Final\Jotex\Jotex\Views\About\Index.cshtml"
                  Write(item.Job);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                </div>\n            </div>");
#nullable restore
#line 124 "C:\Users\Darklight\Documents\Aspnet-Final\Jotex\Jotex\Views\About\Index.cshtml"
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
<!-- end agents-section -->
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
                <div class=""testimonials-slider-holder"">
                   ");
            WriteLiteral(" <div class=\"testimonials-slider-s2\">\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("vc:testimonial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eefeb930f870e7728ddb09d0c61ec646db9a5f9e13540", async() => {
            }
            );
            __TestimonialViewComponentTagHelper = CreateTagHelper<global::AspNetCore.Views_About_Index.__Generated__TestimonialViewComponentTagHelper>();
            __tagHelperExecutionContext.Add(__TestimonialViewComponentTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                    </div>\n                </div>\n            </div>\n        </div>\n    </div> <!-- end container -->\n</section>\n<!-- end testimonials-section-s2 -->\n<!-- start partners-section -->\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("vc:brand", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eefeb930f870e7728ddb09d0c61ec646db9a5f9e14658", async() => {
            }
            );
            __BrandViewComponentTagHelper = CreateTagHelper<global::AspNetCore.Views_About_Index.__Generated__BrandViewComponentTagHelper>();
            __tagHelperExecutionContext.Add(__BrandViewComponentTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n<!-- end partners-section -->\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AboutViewModel> Html { get; private set; }
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
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("vc:brand")]
        public class __Generated__BrandViewComponentTagHelper : Microsoft.AspNetCore.Razor.TagHelpers.TagHelper
        {
            private readonly global::Microsoft.AspNetCore.Mvc.IViewComponentHelper __helper = null;
            public __Generated__BrandViewComponentTagHelper(global::Microsoft.AspNetCore.Mvc.IViewComponentHelper helper)
            {
                __helper = helper;
            }
            [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNotBoundAttribute, global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewContextAttribute]
            public global::Microsoft.AspNetCore.Mvc.Rendering.ViewContext ViewContext { get; set; }
            public override async global::System.Threading.Tasks.Task ProcessAsync(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext __context, Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput __output)
            {
                (__helper as global::Microsoft.AspNetCore.Mvc.ViewFeatures.IViewContextAware)?.Contextualize(ViewContext);
                var __helperContent = await __helper.InvokeAsync("Brand", new {  });
                __output.TagName = null;
                __output.Content.SetHtmlContent(__helperContent);
            }
        }
    }
}
#pragma warning restore 1591
