#pragma checksum "E:\NewsWebsite\NewsWebsite\Views\Home\_NewsPaginate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aa7d4cc06a3b0e254cbeb9e501dd5cdfc9163a15"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home__NewsPaginate), @"mvc.1.0.view", @"/Views/Home/_NewsPaginate.cshtml")]
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
#line 2 "E:\NewsWebsite\NewsWebsite\Views\Home\_NewsPaginate.cshtml"
using NewsWebsite.Common;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa7d4cc06a3b0e254cbeb9e501dd5cdfc9163a15", @"/Views/Home/_NewsPaginate.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"263f5f7032912694fc818ebb6bd514c8d5a64492", @"/Views/_ViewImports.cshtml")]
    public class Views_Home__NewsPaginate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NewsWebsite.ViewModels.Home.NewsPaginateViewModel>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "E:\NewsWebsite\NewsWebsite\Views\Home\_NewsPaginate.cshtml"
 foreach (var item in Model.News)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <!-- Single Post Area -->
    <div class=""single-post-area mb-30"">
        <div class=""row align-items-center"">
            <div class=""col-12 col-lg-6"">
                <!-- Post Thumbnail -->
                <div class=""post-thumbnail"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "aa7d4cc06a3b0e254cbeb9e501dd5cdfc9163a153429", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 404, "~/newsImage/", 404, 12, true);
#nullable restore
#line 12 "E:\NewsWebsite\NewsWebsite\Views\Home\_NewsPaginate.cshtml"
AddHtmlAttributeValue("", 416, item.ImageName, 416, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 12 "E:\NewsWebsite\NewsWebsite\Views\Home\_NewsPaginate.cshtml"
AddHtmlAttributeValue("", 438, item.ImageName, 438, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                    <!-- Video Duration -->\r\n                    <span class=\"video-duration\">");
#nullable restore
#line 15 "E:\NewsWebsite\NewsWebsite\Views\Home\_NewsPaginate.cshtml"
                                            Write(item.PublishDateTime.Value.ToString("HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                </div>\r\n            </div>\r\n            <div class=\"col-12 col-lg-6\">\r\n                <!-- Post Content -->\r\n                <div class=\"post-content mt-0\">\r\n                    <a href=\"#\" class=\"post-cata cata-sm cata-success\">");
#nullable restore
#line 21 "E:\NewsWebsite\NewsWebsite\Views\Home\_NewsPaginate.cshtml"
                                                                  Write(item.NameOfCategories);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 903, "\"", 938, 4);
            WriteAttributeValue("", 910, "/News/", 910, 6, true);
#nullable restore
#line 22 "E:\NewsWebsite\NewsWebsite\Views\Home\_NewsPaginate.cshtml"
WriteAttributeValue("", 916, item.NewsId, 916, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 928, "/", 928, 1, true);
#nullable restore
#line 22 "E:\NewsWebsite\NewsWebsite\Views\Home\_NewsPaginate.cshtml"
WriteAttributeValue("", 929, item.Url, 929, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"post-title mb-2\">\r\n                        ");
#nullable restore
#line 23 "E:\NewsWebsite\NewsWebsite\Views\Home\_NewsPaginate.cshtml"
                   Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </a>\r\n                    <div class=\"post-meta d-flex align-items-center mb-2\">\r\n                        <a href=\"#\" class=\"post-author\">");
#nullable restore
#line 26 "E:\NewsWebsite\NewsWebsite\Views\Home\_NewsPaginate.cshtml"
                                                   Write(item.AuthorName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                        <i class=\"fa fa-circle\" aria-hidden=\"true\"></i>\r\n                        <a href=\"#\" class=\"post-date\">");
#nullable restore
#line 28 "E:\NewsWebsite\NewsWebsite\Views\Home\_NewsPaginate.cshtml"
                                                 Write(item.PublishDateTime.ConvertMiladiToShamsi("dd MMMM yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                    </div>\r\n                    <p class=\"mb-2\">\r\n                        ");
#nullable restore
#line 31 "E:\NewsWebsite\NewsWebsite\Views\Home\_NewsPaginate.cshtml"
                   Write(item.Abstract);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n                    <div class=\"post-meta d-flex float-left\">\r\n                        <a href=\"#\"><i class=\"fa fa-comments-o\" aria-hidden=\"true\"></i> ");
#nullable restore
#line 34 "E:\NewsWebsite\NewsWebsite\Views\Home\_NewsPaginate.cshtml"
                                                                                   Write(item.NumberOfComments);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                        <a href=\"#\"><i class=\"fa fa-eye\" aria-hidden=\"true\"></i> ");
#nullable restore
#line 35 "E:\NewsWebsite\NewsWebsite\Views\Home\_NewsPaginate.cshtml"
                                                                            Write(item.NumberOfVisit);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                        <a href=\"#\"><i class=\"fa fa-thumbs-o-up\" aria-hidden=\"true\"></i> ");
#nullable restore
#line 36 "E:\NewsWebsite\NewsWebsite\Views\Home\_NewsPaginate.cshtml"
                                                                                    Write(item.NumberOfLike);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                        <a href=\"#\"><i class=\"fa fa-thumbs-o-down\" aria-hidden=\"true\"></i> ");
#nullable restore
#line 37 "E:\NewsWebsite\NewsWebsite\Views\Home\_NewsPaginate.cshtml"
                                                                                      Write(item.NumberOfDisLike);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 43 "E:\NewsWebsite\NewsWebsite\Views\Home\_NewsPaginate.cshtml"

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NewsWebsite.ViewModels.Home.NewsPaginateViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
