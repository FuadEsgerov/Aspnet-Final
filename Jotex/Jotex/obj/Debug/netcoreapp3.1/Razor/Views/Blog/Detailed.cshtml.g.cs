#pragma checksum "C:\Users\Darklight\Documents\Aspnet-Final\Jotex\Jotex\Views\Blog\Detailed.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "93e3ec04a3e65c8e33c4249939f9708e79fceae1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Detailed), @"mvc.1.0.view", @"/Views/Blog/Detailed.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93e3ec04a3e65c8e33c4249939f9708e79fceae1", @"/Views/Blog/Detailed.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"007a8a708fee568af5869014feea2cc25da98431", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_Detailed : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BlogViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/blog-details/author.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("comment"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Rəy yazın..."), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Name"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("commentform"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("comment-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/blog/about-widget.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/recent-posts/img-1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/recent-posts/img-2.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/recent-posts/img-3.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/blog/ad-img.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Darklight\Documents\Aspnet-Final\Jotex\Jotex\Views\Blog\Detailed.cshtml"
   ViewData["Title"] = "Blog Ətraflı"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\Darklight\Documents\Aspnet-Final\Jotex\Jotex\Views\Blog\Detailed.cshtml"
Write(await Html.PartialAsync("../Shared/Page/_BreadCrumb"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<section class=""blog-single-section section-padding"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col col-md-8"">
                <div class=""blog-content"">
                    <div class=""post format-standard-image"">
");
#nullable restore
#line 13 "C:\Users\Darklight\Documents\Aspnet-Final\Jotex\Jotex\Views\Blog\Detailed.cshtml"
                         foreach (var item in Model.OurBlogs)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"entry-media\">\r\n\r\n                                <img");
            BeginWriteAttribute("src", " src=\"", 631, "\"", 677, 1);
#nullable restore
#line 17 "C:\Users\Darklight\Documents\Aspnet-Final\Jotex\Jotex\Views\Blog\Detailed.cshtml"
WriteAttributeValue("", 637, _cloudinaryServise.BuildUrl(item.Image), 637, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 678, "\"", 724, 1);
#nullable restore
#line 17 "C:\Users\Darklight\Documents\Aspnet-Final\Jotex\Jotex\Views\Blog\Detailed.cshtml"
WriteAttributeValue("", 684, _cloudinaryServise.BuildUrl(item.Image), 684, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            </div>\r\n                            <ul class=\"entry-meta\">\r\n                                <li><a href=\"#\"><i class=\"fi flaticon-user\"></i> By: ");
#nullable restore
#line 20 "C:\Users\Darklight\Documents\Aspnet-Final\Jotex\Jotex\Views\Blog\Detailed.cshtml"
                                                                                Write(item.AddedBy);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                                <li><a href=\"#\"><i class=\"fi flaticon-tag-1\"></i> ");
#nullable restore
#line 21 "C:\Users\Darklight\Documents\Aspnet-Final\Jotex\Jotex\Views\Blog\Detailed.cshtml"
                                                                             Write(item.Tag);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                                <li><a href=\"#\"><i class=\"fi flaticon-calendar\"></i>");
#nullable restore
#line 22 "C:\Users\Darklight\Documents\Aspnet-Final\Jotex\Jotex\Views\Blog\Detailed.cshtml"
                                                                               Write(item.AddedDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                            </ul>\r\n                            <h2>");
#nullable restore
#line 24 "C:\Users\Darklight\Documents\Aspnet-Final\Jotex\Jotex\Views\Blog\Detailed.cshtml"
                           Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                            <p>");
#nullable restore
#line 25 "C:\Users\Darklight\Documents\Aspnet-Final\Jotex\Jotex\Views\Blog\Detailed.cshtml"
                          Write(item.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
            WriteLiteral(@"                            <blockquote>
                                The game triple h out on the table Samsa was a travelling salesman and above it there hung a picture that he had recently cut out of an
                                <span class=""quoter"">- Michel dow</span>
                            </blockquote>
                            <h3>");
#nullable restore
#line 31 "C:\Users\Darklight\Documents\Aspnet-Final\Jotex\Jotex\Views\Blog\Detailed.cshtml"
                           Write(item.SubTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h3>\r\n                            <p>");
#nullable restore
#line 32 "C:\Users\Darklight\Documents\Aspnet-Final\Jotex\Jotex\Views\Blog\Detailed.cshtml"
                          Write(item.SubText);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 33 "C:\Users\Darklight\Documents\Aspnet-Final\Jotex\Jotex\Views\Blog\Detailed.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </div>

                    <div class=""tag-share clearfix"">
                        <div class=""tag"">
                            <span>Tags: </span>
                            <ul>
                                <li><a href=""#"">Life insurance</a></li>
                                <li><a href=""#"">Biker</a></li>
                            </ul>
                        </div>
                        <div class=""share"">
                            <span>Share: </span>
                            <ul>
                                <li><a href=""#""><i class=""ti-facebook""></i></a></li>
                                <li><a href=""#""><i class=""ti-twitter-alt""></i></a></li>
                                <li><a href=""#""><i class=""ti-linkedin""></i></a></li>
                                <li><a href=""#""><i class=""ti-instagram""></i></a></li>
                            </ul>
                        </div>
                    </div> <!-- end tag-share -->

             ");
            WriteLiteral("       <div class=\"author-box\">\r\n                        <div class=\"author-avatar\">\r\n                            <a href=\"#\" target=\"_blank\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "93e3ec04a3e65c8e33c4249939f9708e79fceae114834", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</a>
                        </div>
                        <div class=""author-content"">
                            <a href=""#"" class=""author-name"">Michel Don</a>
                            <p>Doing right hat and fur boa who sat upright, raising a heavy fur muff that covered the whole of her lower arm towards the viewer. Gregor then turned to look out the window at the dull weather.</p>
                            <div class=""socials"">
                                <ul class=""social-link"">
                                    <li><a href=""#""><i class=""ti-facebook""></i></a></li>
                                    <li><a href=""#""><i class=""ti-twitter-alt""></i></a></li>
                                    <li><a href=""#""><i class=""ti-linkedin""></i></a></li>
                                    <li><a href=""#""><i class=""ti-instagram""></i></a></li>
                                </ul>
                            </div>
                        </div>
                    </div> <!-- end author-box ");
            WriteLiteral(@"-->

                    <div class=""more-posts"">
                        <div class=""previous-post"">
                            <a href=""#"">
                                <span class=""post-control-link"">Previous Post</span>
                                <span class=""post-name"">Covered Mechin  the whole of her lower arm towards the armes</span>
                            </a>
                        </div>
                        <div class=""next-post"">
                            <a href=""0"">
                                <span class=""post-control-link"">Next Post</span>
                                <span class=""post-name""> Tomar name was then turned to lwindow at the dull weather.</span>
                            </a>
                        </div>
                    </div>

                    <div class=""comments-area"">
                        <div class=""comments-section"">
                            <h3 class=""comments-title"">");
#nullable restore
#line 90 "C:\Users\Darklight\Documents\Aspnet-Final\Jotex\Jotex\Views\Blog\Detailed.cshtml"
                                                  Write(Model.Reviews.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral(" Rəy</h3>\r\n                            <ol class=\"comments\">\r\n                                <li class=\"comment even thread-even depth-1\" id=\"comment-1\">\r\n                                    <div id=\"div-comment-1\">\r\n\r\n");
#nullable restore
#line 95 "C:\Users\Darklight\Documents\Aspnet-Final\Jotex\Jotex\Views\Blog\Detailed.cshtml"
                                         foreach (var item in Model.Reviews)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                            <div class=""comment-main-area"">
                                                <div class=""comment-wrapper"">
                                                    <div class=""comments-meta"">
                                                        <br />
                                                        <h4>");
#nullable restore
#line 101 "C:\Users\Darklight\Documents\Aspnet-Final\Jotex\Jotex\Views\Blog\Detailed.cshtml"
                                                       Write(item.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" <span class=""comments-date"">says Jan 05, 2020 at 9:00am</span></h4>
                                                    </div>

                                                    <div class=""comment-area"">
                                                        <p>");
#nullable restore
#line 105 "C:\Users\Darklight\Documents\Aspnet-Final\Jotex\Jotex\Views\Blog\Detailed.cshtml"
                                                      Write(item.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                                        <div class=""comments-reply"">
                                                            <br />
                                                            <a class=""comment-reply-link"" href=""#""><span>Cavabla</span></a>

                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
");
#nullable restore
#line 114 "C:\Users\Darklight\Documents\Aspnet-Final\Jotex\Jotex\Views\Blog\Detailed.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    </div>

                                </li>


                            </ol>
                        </div> <!-- end comments-section -->

                        <div class=""comment-respond"">
                            <h3 class=""comment-reply-title"">Add your comment</h3>
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "93e3ec04a3e65c8e33c4249939f9708e79fceae121161", async() => {
                WriteLiteral("\r\n                                <div class=\"form-textarea\">\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("textarea", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "93e3ec04a3e65c8e33c4249939f9708e79fceae121521", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
#nullable restore
#line 127 "C:\Users\Darklight\Documents\Aspnet-Final\Jotex\Jotex\Views\Blog\Detailed.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Reviews.ElementAt(0).Text);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                </div>\r\n                                <div class=\"form-inputs\">\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "93e3ec04a3e65c8e33c4249939f9708e79fceae123367", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 130 "C:\Users\Darklight\Documents\Aspnet-Final\Jotex\Jotex\Views\Blog\Detailed.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Reviews.ElementAt(0).Username);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                </div>
                                <div class=""form-submit"">
                                    <input id=""submit"" value=""Post Comment"" type=""submit"">
                                </div>
                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </div>
                    </div> <!-- end comments-area -->
                </div>
            </div>
            <div class=""col col-md-4"">
                <div class=""blog-sidebar"">
                    <div class=""widget about-widget"">
                        <h3>About us</h3>
                        <div class=""img-holder"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "93e3ec04a3e65c8e33c4249939f9708e79fceae127185", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </div>
                        <p>Samples lay spread out on the Samsa was a travelling salesman and above it there hung and null about  that he</p>
                        <div class=""social"">
                            <ul class=""clearfix"">
                                <li><a href=""#""><i class=""ti-facebook""></i></a></li>
                                <li><a href=""#""><i class=""ti-twitter-alt""></i></a></li>
                                <li><a href=""#""><i class=""ti-linkedin""></i></a></li>
                                <li><a href=""#""><i class=""ti-pinterest""></i></a></li>
                            </ul>
                        </div>
                    </div>
                    <div class=""widget search-widget"">
                        <h3>Search</h3>
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "93e3ec04a3e65c8e33c4249939f9708e79fceae129156", async() => {
                WriteLiteral(@"
                            <div>
                                <input type=""text"" class=""form-control"" placeholder=""Search Post.."">
                                <button type=""submit""><i class=""ti-search""></i></button>
                            </div>
                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"widget category-widget\">\r\n                        <h3>Categories</h3>\r\n                        <ul>\r\n");
#nullable restore
#line 169 "C:\Users\Darklight\Documents\Aspnet-Final\Jotex\Jotex\Views\Blog\Detailed.cshtml"
                             foreach (var item in Model.Services)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li><a href=\"/Service\">");
#nullable restore
#line 171 "C:\Users\Darklight\Documents\Aspnet-Final\Jotex\Jotex\Views\Blog\Detailed.cshtml"
                                                  Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a></li>\r\n");
#nullable restore
#line 172 "C:\Users\Darklight\Documents\Aspnet-Final\Jotex\Jotex\Views\Blog\Detailed.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </ul>
                    </div>
                    <div class=""widget recent-post-widget"">
                        <h3>Recent post</h3>
                        <div class=""posts"">
                            <div class=""post"">
                                <div class=""img-holder"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "93e3ec04a3e65c8e33c4249939f9708e79fceae132068", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                </div>
                                <div class=""details"">
                                    <h4><a href=""#"">For your insurance business, employees, or clients</a></h4>
                                    <span class=""date"">11 March 2020</span>
                                </div>
                            </div>
                            <div class=""post"">
                                <div class=""img-holder"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "93e3ec04a3e65c8e33c4249939f9708e79fceae133696", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                </div>
                                <div class=""details"">
                                    <h4><a href=""#"">Once you’ve picked your vorite, be sure to outfit your</a></h4>
                                    <span class=""date"">11 March 2020</span>
                                </div>
                            </div>
                            <div class=""post"">
                                <div class=""img-holder"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "93e3ec04a3e65c8e33c4249939f9708e79fceae135328", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                </div>
                                <div class=""details"">
                                    <h4><a href=""#"">Be prepared for life’s Once you’ve picked your vorite</a></h4>
                                    <span class=""date"">11 March 2020</span>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""widget tag-widget"">
                        <h3>Tags</h3>
                        <ul>
                            <li><a href=""#"">People</a></li>
                            <li><a href=""#"">Business</a></li>
                            <li><a href=""#"">Life insurance</a></li>
                            <li><a href=""#"">Poll insurance</a></li>
                            <li><a href=""#"">Car insurance</a></li>
                            <li><a href=""#"">Manfacturing</a></li>
                        </ul>
                    </div>
                    ");
            WriteLiteral("<div class=\"widget ad-widget\">\r\n                        <h3>Advertising Spot</h3>\r\n                        <div class=\"img-holder\">\r\n                            <a href=\"#\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "93e3ec04a3e65c8e33c4249939f9708e79fceae137701", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_13);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</a>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div> <!-- end container -->\r\n</section>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Repository.Services.ICloudinaryService _cloudinaryServise { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BlogViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
