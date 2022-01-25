#pragma checksum "E:\ASP.NET Core Training\NewsWebsite-Publish\NewsWebsite\Views\Home\Videos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fb1e49b959da77b735e5a11493427b26464a9fa7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Videos), @"mvc.1.0.view", @"/Views/Home/Videos.cshtml")]
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
#line 2 "E:\ASP.NET Core Training\NewsWebsite-Publish\NewsWebsite\Views\Home\Videos.cshtml"
using NewsWebsite.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\ASP.NET Core Training\NewsWebsite-Publish\NewsWebsite\Views\Home\Videos.cshtml"
using NewsWebsite.ViewModels.Newsletter;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb1e49b959da77b735e5a11493427b26464a9fa7", @"/Views/Home/Videos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"263f5f7032912694fc818ebb6bd514c8d5a64492", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Videos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<NewsWebsite.Entities.Video>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "E:\ASP.NET Core Training\NewsWebsite-Publish\NewsWebsite\Views\Home\Videos.cshtml"
  
    ViewData["Title"] = "Videos";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""vizew-breadcrumb"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-12"">
                <nav aria-label=""breadcrumb"">
                    <ol class=""breadcrumb"">
                        <li class=""breadcrumb-item""><a href=""/""><i class=""fa fa-home"" aria-hidden=""true""></i> خانه</a></li>
                        <li class=""breadcrumb-item active"" aria-current=""page"">ویدیوها</li>
                    </ol>
                </nav>
            </div>
        </div>
    </div>
</div>

<div class=""vizew-grid-posts-area mb-80"">
    <div class=""container"">
        <div class=""row justify-content-center"">
            <div class=""col-12 col-lg-8"">
                <div class=""archive-catagory-view mb-30 d-flex align-items-center justify-content-between"">
                    <!-- Catagory -->
                    <div class=""archive-catagory"">
                        <h4><i class=""fa fa-video"" aria-hidden=""true""></i>ویدیوها</h4>
                    </div>");
            WriteLiteral(@"
                    <!-- View Options -->
                    <div class=""view-options"">
                        <a href=""archive-grid.html"" class=""active""><i class=""fa fa-th-large"" aria-hidden=""true""></i></a>
                        <a href=""archive-list.html""><i class=""fa fa-list-ul"" aria-hidden=""true""></i></a>
                    </div>
                </div>

                <div class=""row"">
");
#nullable restore
#line 42 "E:\ASP.NET Core Training\NewsWebsite-Publish\NewsWebsite\Views\Home\Videos.cshtml"
                     if (Model.Count() != 0)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "E:\ASP.NET Core Training\NewsWebsite-Publish\NewsWebsite\Views\Home\Videos.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <div class=""col-12 col-md-6"">
                                <div class=""single-post-area mb-50 border"">
                                    <div class=""post-thumbnail"">
                                        <video width=""100%""");
            BeginWriteAttribute("poster", " poster=\"", 2044, "\"", 2079, 1);
#nullable restore
#line 49 "E:\ASP.NET Core Training\NewsWebsite-Publish\NewsWebsite\Views\Home\Videos.cshtml"
WriteAttributeValue("", 2053, "/posters/"+item.Poster, 2053, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" controls><source");
            BeginWriteAttribute("src", " src=\"", 2097, "\"", 2112, 1);
#nullable restore
#line 49 "E:\ASP.NET Core Training\NewsWebsite-Publish\NewsWebsite\Views\Home\Videos.cshtml"
WriteAttributeValue("", 2103, item.Url, 2103, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">Your browser does not support the video tag.</video>
                                       
                                    </div>

                                    <div class=""mt-0 p-1"">
                                        <span style=""font-size: 12px;"" class=""video-duration"">");
#nullable restore
#line 54 "E:\ASP.NET Core Training\NewsWebsite-Publish\NewsWebsite\Views\Home\Videos.cshtml"
                                                                                         Write(item.PublishDateTime.ConvertMiladiToShamsi("dd MMMM yyyy ساعت HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                        <br />\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 2578, "\"", 2605, 2);
            WriteAttributeValue("", 2585, "/Video/", 2585, 7, true);
#nullable restore
#line 56 "E:\ASP.NET Core Training\NewsWebsite-Publish\NewsWebsite\Views\Home\Videos.cshtml"
WriteAttributeValue("", 2592, item.VideoId, 2592, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"post-title\">");
#nullable restore
#line 56 "E:\ASP.NET Core Training\NewsWebsite-Publish\NewsWebsite\Views\Home\Videos.cshtml"
                                                                                     Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 60 "E:\ASP.NET Core Training\NewsWebsite-Publish\NewsWebsite\Views\Home\Videos.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "E:\ASP.NET Core Training\NewsWebsite-Publish\NewsWebsite\Views\Home\Videos.cshtml"
                         
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p class=\"alert alert-info w-100 text-center\">ویدیویی یافت نشد...</p>\r\n");
#nullable restore
#line 65 "E:\ASP.NET Core Training\NewsWebsite-Publish\NewsWebsite\Views\Home\Videos.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n\r\n            </div>\r\n\r\n            <div class=\"col-12 col-md-6 col-lg-4\">\r\n                <div class=\"sidebar-area\">\r\n                    ");
#nullable restore
#line 72 "E:\ASP.NET Core Training\NewsWebsite-Publish\NewsWebsite\Views\Home\Videos.cshtml"
               Write(await Html.PartialAsync("_RegisterInNewsletter", new NewsletterViewModel()));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<NewsWebsite.Entities.Video>> Html { get; private set; }
    }
}
#pragma warning restore 1591
