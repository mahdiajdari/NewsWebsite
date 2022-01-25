#pragma checksum "E:\ASP.NET Core Training\NewsWebsite-Publish\NewsWebsite\Areas\Admin\Views\UserManager\_UserTable.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5ea9af73817ff00882c90f9e813094007ad6a791"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_UserManager__UserTable), @"mvc.1.0.view", @"/Areas/Admin/Views/UserManager/_UserTable.cshtml")]
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
#line 1 "E:\ASP.NET Core Training\NewsWebsite-Publish\NewsWebsite\Areas\Admin\Views\UserManager\_UserTable.cshtml"
using NewsWebsite.Services.Contracts;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ea9af73817ff00882c90f9e813094007ad6a791", @"/Areas/Admin/Views/UserManager/_UserTable.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"263f5f7032912694fc818ebb6bd514c8d5a64492", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_UserManager__UserTable : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div id=\"toolbar\">\r\n    <button type=\"button\" class=\"btn btn-success\" data-toggle=\"ajax-modal\" data-url=\"");
#nullable restore
#line 5 "E:\ASP.NET Core Training\NewsWebsite-Publish\NewsWebsite\Areas\Admin\Views\UserManager\_UserTable.cshtml"
                                                                                Write(Url.Action("RenderUser","UserManager"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n        <i class=\"fa fa-plus\"></i> | افزودن کاربر جدید\r\n    </button>\r\n    <button type=\"button\" class=\"btn btn-danger\" data-toggle=\"ajax-modal\" data-url=\"");
#nullable restore
#line 8 "E:\ASP.NET Core Training\NewsWebsite-Publish\NewsWebsite\Areas\Admin\Views\UserManager\_UserTable.cshtml"
                                                                               Write(Url.Action("DeleteGroup","UserManager"));

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
       data-url=""/Admin/UserManager/GetUsers""
       data-response-handler=""responseHandler""></table>


<script>
        var $table = $('#table')
        var selections = []


  function get_query_params(p) {
    return {
        extraParam: 'abc',
        search: p.title,
        sort: p.sort,
        order: p.o");
            WriteLiteral(@"rder,
        limit: p.limit,
        offset: p.offset
    }
}



        function responseHandler(res) {
            $.each(res.rows, function (i, row) {
                row.state = $.inArray(row.id, selections) !== -1
            })
            return res
        }

    function isActiveFormatter(value, row, index) {
    var spanClass = ""badge badge-success"";
    var IsActive = ""فعال"";
    if (!row.IsActive) {
        IsActive = ""غیرفعال"";
        spanClass = ""badge badge-danger"";
    }

    return [
        '<span class=""' + spanClass + '"">' + IsActive + '</span>'
    ].join('')
    }


    function roleFormatter(value, row, index) {
        return [
            '<span class=""badge badge-primary"">' + value + '</span>'
    ].join('')
  }


         function detailFormatter(index, row) {
            var html = []
            $.each(row, function (key, value) {
                if (key != ""state"" && key != ""Id"" && key!=""ردیف"" && key!=""تصویر"" && key!=""IsActive"")
         ");
            WriteLiteral("           html.push(\'<p><b>\' + key + \':</b> \' + value + \'</p>\')\r\n\r\n                if (key == \"تصویر\") {\r\n                    var url = \'");
#nullable restore
#line 88 "E:\ASP.NET Core Training\NewsWebsite-Publish\NewsWebsite\Areas\Admin\Views\UserManager\_UserTable.cshtml"
                          Write(string.Format("{0}://{1}", Context.Request.Scheme, Context.Request.Host));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"' + '/avatars/' + value;
                    html.push('<p><b>' + key + ':</b> <img src=""' + url + '"" height=""50"" />')
                }


            })
            return html.join('')
        }


      function operateFormatter(value, row, index) {
        var access = """";
        if ('");
#nullable restore
#line 100 "E:\ASP.NET Core Training\NewsWebsite-Publish\NewsWebsite\Areas\Admin\Views\UserManager\_UserTable.cshtml"
        Write(securityTrimmingService.CanUserAccess(User,"Admin","UserManager","Details"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\' == \'True\') {\r\n            access = access + \'<a class=\"btn btn btn-primary btn-sm\" href=");
#nullable restore
#line 101 "E:\ASP.NET Core Training\NewsWebsite-Publish\NewsWebsite\Areas\Admin\Views\UserManager\_UserTable.cshtml"
                                                                     Write(Url.Action("Details","UserManager"));

#line default
#line hidden
#nullable disable
            WriteLiteral("?userId=\' + row.Id + \' title=\"مدیریت\"><i class=\"fa fa-user\"></i> | مدیریت </a>\';\r\n        }\r\n        if (\'");
#nullable restore
#line 103 "E:\ASP.NET Core Training\NewsWebsite-Publish\NewsWebsite\Areas\Admin\Views\UserManager\_UserTable.cshtml"
        Write(securityTrimmingService.CanUserAccess(User,"Admin","DynamicAccess","Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\' == \'True\') {\r\n            access = access + \'<a class=\"btn btn btn-success mr-1 btn-sm\" href=");
#nullable restore
#line 104 "E:\ASP.NET Core Training\NewsWebsite-Publish\NewsWebsite\Areas\Admin\Views\UserManager\_UserTable.cshtml"
                                                                          Write(Url.Action("Index","DynamicAccess"));

#line default
#line hidden
#nullable disable
            WriteLiteral("?userId=\' + row.Id + \'> سطح دسترسی </a>\';\r\n        }\r\n        if (\'");
#nullable restore
#line 106 "E:\ASP.NET Core Training\NewsWebsite-Publish\NewsWebsite\Areas\Admin\Views\UserManager\_UserTable.cshtml"
        Write(securityTrimmingService.CanUserAccess(User,"Admin","UserManager","RenderUser"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\' == \'True\') {\r\n            access = access + \'<button type=\"button\" class=\"btn-link text-success\" data-toggle=\"ajax-modal\" data-url=");
#nullable restore
#line 107 "E:\ASP.NET Core Training\NewsWebsite-Publish\NewsWebsite\Areas\Admin\Views\UserManager\_UserTable.cshtml"
                                                                                                                Write(Url.Action("RenderUser", "UserManager"));

#line default
#line hidden
#nullable disable
            WriteLiteral("?userId=\' + row.Id + \' title=\"ویرایش\"><i class=\"fa fa-edit\"></i></button >\';\r\n        }\r\n        if (\'");
#nullable restore
#line 109 "E:\ASP.NET Core Training\NewsWebsite-Publish\NewsWebsite\Areas\Admin\Views\UserManager\_UserTable.cshtml"
        Write(securityTrimmingService.CanUserAccess(User,"Admin","UserManager","Delete"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\' == \'True\') {\r\n            access = access + \'<button type=\"button\" class=\"btn-link text-danger\" data-toggle=\"ajax-modal\" data-url=");
#nullable restore
#line 110 "E:\ASP.NET Core Training\NewsWebsite-Publish\NewsWebsite\Areas\Admin\Views\UserManager\_UserTable.cshtml"
                                                                                                               Write(Url.Action("Delete", "UserManager"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"/?userId=' + row.Id + ' title=""حذف""><i class=""fa fa-trash""></i></button >';
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
            WriteLiteral(@"               rowspan: 2,
                        align: 'center',
                        valign: 'middle',
                        footerFormatter: totalTextFormatter
                    }, {
                        title: 'جزئیات اطلاعات کاربران',
                        colspan: 8,
                        align: 'center'
                    }],
                    [{
                        field: 'نام',
                        title: 'نام',
                        sortable: true,
                        footerFormatter: totalNameFormatter,
                        align: 'center'
                    },{
                        field: 'نام خانوادگی',
                        title: 'نام خانوادگی',
                        sortable: true,
                        align: 'center'
                    },{
                        field: 'ایمیل',
                        title: 'ایمیل',
                        sortable: true,
                        align: 'center'
                    },{
");
            WriteLiteral(@"                        field: 'نام کاربری',
                        title: 'نام کاربری',
                        sortable: true,
                        align: 'center'
                    },{
                        field: 'تاریخ عضویت',
                        title: 'تاریخ عضویت',
                        sortable: true,
                        align: 'center'
                    },{
                        field: 'نقش',
                        title: 'نقش',
                        align: 'center',
                        formatter: roleFormatter
                    },{
                    field: '',
                    title: 'وضعیت',
                    align: 'center',
                    formatter: isActiveFormatter
                   },{
                        field: 'operate',
                        title: 'عملیات',
                        align: 'center',
                        events: window.operateEvents,
                        formatter: operateFormatter
             ");
            WriteLiteral("       }]\r\n                ]\r\n            })\r\n        }\r\n\r\n        $(function () {\r\n            initTable()\r\n            $(\'#locale\').change(initTable)\r\n        })</script>");
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
