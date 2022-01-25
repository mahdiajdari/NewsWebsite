#pragma checksum "E:\NewsWebsite\NewsWebsite\Areas\Admin\Views\Video\_VideoTable.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e1b05e6d335b4bfb5d6e90ae72e108f52b65e4c2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Video__VideoTable), @"mvc.1.0.view", @"/Areas/Admin/Views/Video/_VideoTable.cshtml")]
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
#line 1 "E:\NewsWebsite\NewsWebsite\Areas\Admin\Views\Video\_VideoTable.cshtml"
using NewsWebsite.Services.Contracts;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1b05e6d335b4bfb5d6e90ae72e108f52b65e4c2", @"/Areas/Admin/Views/Video/_VideoTable.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"263f5f7032912694fc818ebb6bd514c8d5a64492", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Video__VideoTable : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div id=\"toolbar\">\r\n    <button type=\"button\" class=\"btn btn-success\" data-toggle=\"ajax-modal\" data-url=\"");
#nullable restore
#line 5 "E:\NewsWebsite\NewsWebsite\Areas\Admin\Views\Video\_VideoTable.cshtml"
                                                                                Write(Url.Action("RenderVideo","Video"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n        <i class=\"fa fa-plus\"></i> | افزودن ویدیو جدید\r\n    </button>\r\n    <button type=\"button\" class=\"btn btn-danger\" data-toggle=\"ajax-modal\" data-url=\"");
#nullable restore
#line 8 "E:\NewsWebsite\NewsWebsite\Areas\Admin\Views\Video\_VideoTable.cshtml"
                                                                               Write(Url.Action("DeleteGroup","Video"));

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
       data-url=""/Admin/Video/GetVideos""
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
            WriteLiteral(@"        limit: p.limit,
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
        var posterUrl;
        var videoUrl;
        $.each(row, function (key, value) {
            if (key == ""poster"")
               posterUrl ='");
#nullable restore
#line 65 "E:\NewsWebsite\NewsWebsite\Areas\Admin\Views\Video\_VideoTable.cshtml"
                      Write(string.Format("{0}://{1}", Context.Request.Scheme, Context.Request.Host));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"' + '/posters/' + value;
            if (key != ""state"" && key != ""Id"" && key != ""ردیف"" && key != ""poster"" && key!=""url"")
                html.push('<p><b>' + key + ':</b> ' + value + '</p>')
            if (key == ""url"")
                videoUrl = value;
        })
            html.push('<video height=""240"" poster=""' + posterUrl + '"" controls><source src=""' + videoUrl + '"">Your browser does not support the video tag.</video>')
            return html.join('')
        }


    function operateFormatter(value, row, index) {
        var access = """";
        if ('");
#nullable restore
#line 78 "E:\NewsWebsite\NewsWebsite\Areas\Admin\Views\Video\_VideoTable.cshtml"
        Write(securityTrimmingService.CanUserAccess(User,"Admin","Tag","RenderTag"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\' == \'True\') {\r\n            access = access + \'<button type=\"button\" class=\"btn-link text-success\" data-toggle=\"ajax-modal\" data-url=");
#nullable restore
#line 79 "E:\NewsWebsite\NewsWebsite\Areas\Admin\Views\Video\_VideoTable.cshtml"
                                                                                                                Write(Url.Action("RenderVideo", "Video"));

#line default
#line hidden
#nullable disable
            WriteLiteral("?videoId=\' + row.Id + \' title=\"ویرایش\"><i class=\"fa fa-edit\"></i></button >\';\r\n        }\r\n        if (\'");
#nullable restore
#line 81 "E:\NewsWebsite\NewsWebsite\Areas\Admin\Views\Video\_VideoTable.cshtml"
        Write(securityTrimmingService.CanUserAccess(User,"Admin","Tag","Delete"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\' == \'True\') {\r\n            access = access + \'<button type=\"button\" class=\"btn-link text-danger\" data-toggle=\"ajax-modal\" data-url=");
#nullable restore
#line 82 "E:\NewsWebsite\NewsWebsite\Areas\Admin\Views\Video\_VideoTable.cshtml"
                                                                                                               Write(Url.Action("Delete", "Video"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"/?videoId=' + row.Id + ' title=""حذف""><i class=""fa fa-trash""></i></button >';
        }
        return access;
    }

     function checkBoxFormat(value, row) {
       return '<input type=""checkbox"" name=""btSelectItem"" value=""' + row.Id + '"" />';
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
          ");
            WriteLiteral(@"              rowspan: 2,
                        align: 'center',
                        valign: 'middle',
                        footerFormatter: totalTextFormatter
                    }, {
                        title: 'جزئیات اطلاعات ویدیو ها',
                        colspan: 3,
                        align: 'center'
                    }],
                    [{
                        field: 'عنوان ویدیو',
                        title: 'عنوان ویدیو',
                        sortable: true,
                        footerFormatter: totalNameFormatter,
                    },{
                        field: 'تاریخ انتشار',
                        title: 'تاریخ انتشار',
                        sortable: true,
                        align: 'center'
                    }, {
                        field: 'operate',
                        title: 'عملیات',
                        align: 'center',
                        events: window.operateEvents,
                        formatt");
            WriteLiteral("er: operateFormatter\r\n                    }]\r\n                ]\r\n            })\r\n        }\r\n\r\n        $(function () {\r\n            initTable()\r\n            $(\'#locale\').change(initTable)\r\n        })</script>");
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