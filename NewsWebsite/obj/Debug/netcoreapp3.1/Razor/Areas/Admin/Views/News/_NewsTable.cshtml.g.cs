#pragma checksum "E:\NewsWebsite\NewsWebsite\Areas\Admin\Views\News\_NewsTable.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e29b8f3f6353a3ef54e4a62b5dca20edb8e25687"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_News__NewsTable), @"mvc.1.0.view", @"/Areas/Admin/Views/News/_NewsTable.cshtml")]
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
#line 1 "E:\NewsWebsite\NewsWebsite\Areas\Admin\Views\News\_NewsTable.cshtml"
using NewsWebsite.Services.Contracts;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e29b8f3f6353a3ef54e4a62b5dca20edb8e25687", @"/Areas/Admin/Views/News/_NewsTable.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"263f5f7032912694fc818ebb6bd514c8d5a64492", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_News__NewsTable : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success text-white"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateOrUpdate", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<style>\r\n    .fixed-table-header {\r\n        margin-right: 0px !important;\r\n    }\r\n</style>\r\n<div id=\"toolbar\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e29b8f3f6353a3ef54e4a62b5dca20edb8e256873754", async() => {
                WriteLiteral("\r\n        <i class=\"fa fa-plus\"></i> | افزودن خبر جدید\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n    <button type=\"button\" class=\"btn btn-danger\" data-toggle=\"ajax-modal\" data-url=\"");
#nullable restore
#line 13 "E:\NewsWebsite\NewsWebsite\Areas\Admin\Views\News\_NewsTable.cshtml"
                                                                               Write(Url.Action("DeleteGroup","Category"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""">
        <i class=""fa fa-trash""></i> | حذف گروهی
    </button>
</div>
<table id=""table""
       data-toolbar=""#toolbar""
       data-search=""true""
       data-show-refresh=""true""
       data-show-toggle=""true""
       data-show-fullscreen=""true""
       data-show-columns=""true""
       data-detail-view=""true""
       data-show-export=""true""
       data-click-to-select=""true""
       data-detail-formatter=""detailFormatter""
       data-minimum-count-columns=""2""
       data-show-pagination-switch=""true""
       data-pagination=""true""
       data-id-field=""id""
       data-page-list=""[10, 25, 50, 100, all]""
       data-show-footer=""true""
       data-side-pagination=""server""
       data-url=""/Admin/News/GetNews""
       data-response-handler=""responseHandler""></table>


<script>
        var $table = $('#table')
        var selections = []


  function get_query_params(p) {
    return {
        extraParam: 'abc',
        search: p.title,
        sort: p.sort,
        order: p.order,
   ");
            WriteLiteral(@"     limit: p.limit,
        offset: p.offset
    }
}


        function responseHandler(res) {
            $.each(res.rows, function (i, row) {
                row.state = $.inArray(row.id, selections) !== -1
            })
            return res
        }

         function detailFormatter(index, row) {
            var html = []
            $.each(row, function (key, value) {
                if (key != ""state"" && key != ""Id"" && key!='آدرس' && key!=""ردیف"" && key!=""متن خبر"" && key!=""NumberOfLike"" && key!=""NumberOfDisLike"" && key!=""ShortTitle"" && key!=""Status"" && key!=""NumberOfComments"")
                    html.push('<p><b>' + key + ':</b> ' + value + '</p>')
                if (key == 'آدرس') {
                    var url = '");
#nullable restore
#line 69 "E:\NewsWebsite\NewsWebsite\Areas\Admin\Views\News\_NewsTable.cshtml"
                          Write(string.Format("{0}://{1}", Context.Request.Scheme, Context.Request.Host));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"' + '/News/' + row.Id + '/' + value;
                    html.push('<p><b style=""float:right"">' + key + ':</b> ' + '<a href=""' + url +'"" style=""float:right;direction:ltr;margin-right:2px;"">'  + url + '</a>' + '</p>')
                }
                if(key == 'متن خبر'){
                    html.push('<br><hr/><p><b>' + key + ':</b>' + value + '</p>')
                }
            })
            return html.join('')
        }


    function isPublishFormatter(value, row, index) {
    return [
        '<span class=""badge badge-primary"">' + row.Status + '</span>'
      ].join('')
    }


    function operateFormatter(value, row, index) {
        var access = """";
        if ('");
#nullable restore
#line 89 "E:\NewsWebsite\NewsWebsite\Areas\Admin\Views\News\_NewsTable.cshtml"
        Write(securityTrimmingService.CanUserAccess(User,"Admin","News","CreateOrUpdate"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\' == \'True\') {\r\n            access = access + \'<a class=\"text-success\" href=\"/Admin/News/CreateOrUpdate?newsId=\' + row.Id + \'\" title=\"ویرایش\"><i class=\"fa fa-edit\"></i></a>\';\r\n        }\r\n        if (\'");
#nullable restore
#line 92 "E:\NewsWebsite\NewsWebsite\Areas\Admin\Views\News\_NewsTable.cshtml"
        Write(securityTrimmingService.CanUserAccess(User,"Admin","News","Delete"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\' == \'True\') {\r\n            access = access + \'<button type=\"button\" class=\"btn-link text-danger\" data-toggle=\"ajax-modal\" data-url=");
#nullable restore
#line 93 "E:\NewsWebsite\NewsWebsite\Areas\Admin\Views\News\_NewsTable.cshtml"
                                                                                                               Write(Url.Action("Delete", "News"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"/?newsId=' + row.Id + ' title=""حذف""><i class=""fa fa-trash""></i></button>';
        }
        return access;
    }


      function likeFormatter(value, row, index) {
        return [
            '<a class=""btn btn-success btn-sm text-white text-success"">',
            row.NumberOfLike,'<i class=""fa fa-thumbs-up mr-1""></i>',
            '</a >'
        ].join('')
    }

     function dislikeFormatter(value, row, index) {
        return [
            '<a class=""btn btn-danger btn-sm text-white"">',
            row.NumberOfDisLike,'<i class=""fa fa-thumbs-down mr-1""></i>',
            '</a >'
        ].join('')
    }

    function commentFormatter(value, row, index) {
        return [
            '<a href=""/Admin/Comments/Index?newsId=' + row.Id + '"" class=""btn btn-primary btn-sm text-white"">',
            row.NumberOfComments,'<i class=""fa fa-comments mr-1""></i>',
            '</a >'
        ].join('')
    }



     function checkBoxFormat(value, row) {
       return '<input type=");
            WriteLiteral(@"""checkbox"" name=""btSelectItem"" value=""' + row.Id + '"" />';
    }

        function totalTextFormatter(data) {
            return 'تعداد'
        }

        function totalNameFormatter(data) {
            return data.length
        }


        function initTable() {
            $table.bootstrapTable('destroy').bootstrapTable({
                height: 600,
                locale: 'fa-IR',
                columns: [
                    [{
                        field: 'state',
                        checkbox: true,
                        rowspan: 2,
                        align: 'center',
                        valign: 'middle',
                        formatter: checkBoxFormat
                    }, {
                        title: 'ردیف',
                        field: 'ردیف',
                        rowspan: 2,
                        align: 'center',
                        valign: 'middle',
                        footerFormatter: totalTextFormatter
                    },");
            WriteLiteral(@" {
                        title: 'جزئیات اطلاعات اخبار',
                        colspan: 9,
                        align: 'center'
                    }],
                    [{
                        field: 'ShortTitle',
                        title: 'عنوان خبر',
                        sortable: true,
                        footerFormatter: totalNameFormatter,
                    },{
                        field: 'بازدید',
                        title: 'بازدید',
                        sortable: true,
                        align: 'center'
                    },{
                        field: 'لایک',
                        title: 'لایک',
                        sortable: true,
                        align: 'center',
                        formatter:likeFormatter
                    },{
                        field: 'دیس لایک',
                        title: 'دیس لایک',
                        sortable: true,
                        align: 'center',
                   ");
            WriteLiteral(@"     formatter:dislikeFormatter
                    },{
                        field: 'نظرات',
                        title: 'نظرات',
                        sortable: true,
                        align: 'center',
                        formatter:commentFormatter
                    },{
                        field: 'تاریخ انتشار',
                        title: 'تاریخ انتشار',
                        sortable: true,
                        align: 'center'
                    },{
                        field: 'وضعیت',
                        title: 'وضعیت',
                        align: 'center',
                        formatter: isPublishFormatter
                    }, {
                        field: 'operate',
                        title: 'عملیات',
                        align: 'center',
                        events: window.operateEvents,
                        formatter: operateFormatter
                    }]
                ]
            })
        }

        $");
            WriteLiteral("(function () {\r\n            initTable()\r\n            $(\'#locale\').change(initTable)\r\n        })</script>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public ISecurityTrimmingService securityTrimmingService { get; private set; }
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
