#pragma checksum "E:\ASP.NET Core Training\NewsWebsite - Copy\NewsWebsite\Areas\Admin\Views\Newsletter\_DeleteConfirmation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "63da1ce4298519e6e78413717aa657a262394d19"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Newsletter__DeleteConfirmation), @"mvc.1.0.view", @"/Areas/Admin/Views/Newsletter/_DeleteConfirmation.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Newsletter/_DeleteConfirmation.cshtml", typeof(AspNetCore.Areas_Admin_Views_Newsletter__DeleteConfirmation))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"63da1ce4298519e6e78413717aa657a262394d19", @"/Areas/Admin/Views/Newsletter/_DeleteConfirmation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"263f5f7032912694fc818ebb6bd514c8d5a64492", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Newsletter__DeleteConfirmation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NewsWebsite.Entities.Newsletter>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("alert alert-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(41, 447, true);
            WriteLiteral(@"
<div class=""modal fade"" tabindex=""-1"" role=""dialog"" aria-hidden=""true"">
        <div class=""modal-dialog"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h3 id=""modal-title"">حذف اطلاعات</h3>
                    <button type=""button"" class=""close btn-link"" data-dismiss=""modal"" aria-hidden=""true"">×</button>
                </div>
                <div class=""modal-body clearfix"">
");
            EndContext();
#line 11 "E:\ASP.NET Core Training\NewsWebsite - Copy\NewsWebsite\Areas\Admin\Views\Newsletter\_DeleteConfirmation.cshtml"
                     if (Model==null)
                    {

#line default
#line hidden
            BeginContext(550, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(574, 73, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "63da1ce4298519e6e78413717aa657a262394d195341", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#line 13 "E:\ASP.NET Core Training\NewsWebsite - Copy\NewsWebsite\Areas\Admin\Views\Newsletter\_DeleteConfirmation.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(647, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 14 "E:\ASP.NET Core Training\NewsWebsite - Copy\NewsWebsite\Areas\Admin\Views\Newsletter\_DeleteConfirmation.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(721, 65, true);
            WriteLiteral("                        <h4>آیا شما می خواهید این کاربر با ایمیل ");
            EndContext();
            BeginContext(787, 11, false);
#line 17 "E:\ASP.NET Core Training\NewsWebsite - Copy\NewsWebsite\Areas\Admin\Views\Newsletter\_DeleteConfirmation.cshtml"
                                                            Write(Model.Email);

#line default
#line hidden
            EndContext();
            BeginContext(798, 56, true);
            WriteLiteral(" را از خبرنامه حذف کنید ؟</h4>\r\n                        ");
            EndContext();
            BeginContext(854, 208, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "63da1ce4298519e6e78413717aa657a262394d197937", async() => {
                BeginContext(880, 111, true);
                WriteLiteral("\r\n                            <input name=\"IsValid\" type=\"hidden\" value=\"True\" />\r\n                            ");
                EndContext();
                BeginContext(991, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "63da1ce4298519e6e78413717aa657a262394d198437", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#line 20 "E:\ASP.NET Core Training\NewsWebsite - Copy\NewsWebsite\Areas\Admin\Views\Newsletter\_DeleteConfirmation.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Email);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1029, 26, true);
                WriteLiteral("\r\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1062, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 22 "E:\ASP.NET Core Training\NewsWebsite - Copy\NewsWebsite\Areas\Admin\Views\Newsletter\_DeleteConfirmation.cshtml"
                    }

#line default
#line hidden
            BeginContext(1087, 70, true);
            WriteLiteral("                </div>\r\n\r\n                <div class=\"modal-footer\">\r\n");
            EndContext();
#line 26 "E:\ASP.NET Core Training\NewsWebsite - Copy\NewsWebsite\Areas\Admin\Views\Newsletter\_DeleteConfirmation.cshtml"
                     if (Model != null)
                    {

#line default
#line hidden
            BeginContext(1221, 177, true);
            WriteLiteral("                        <button type=\"submit\" class=\"btn btn-sm btn-labeled btn-success\" data-save=\"modal\">\r\n                            بله\r\n                        </button>\r\n");
            EndContext();
#line 31 "E:\ASP.NET Core Training\NewsWebsite - Copy\NewsWebsite\Areas\Admin\Views\Newsletter\_DeleteConfirmation.cshtml"
                    }

#line default
#line hidden
            BeginContext(1421, 138, true);
            WriteLiteral("                    <button type=\"button\" class=\"btn btn-sm btn-labeled  btn-danger  mr-1\" data-dismiss=\"modal\">\r\n                        ");
            EndContext();
            BeginContext(1561, 30, false);
#line 33 "E:\ASP.NET Core Training\NewsWebsite - Copy\NewsWebsite\Areas\Admin\Views\Newsletter\_DeleteConfirmation.cshtml"
                    Write(Model != null ? "خیر" : "بستن");

#line default
#line hidden
            EndContext();
            BeginContext(1592, 103, true);
            WriteLiteral("\r\n                    </button>\r\n\r\n                </div>\r\n            </div>\r\n        </div>\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NewsWebsite.Entities.Newsletter> Html { get; private set; }
    }
}
#pragma warning restore 1591
