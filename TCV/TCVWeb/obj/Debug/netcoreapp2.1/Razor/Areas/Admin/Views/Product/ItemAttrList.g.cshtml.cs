#pragma checksum "D:\Vuong\TCVEcommerce\TCV\TCVWeb\Areas\Admin\Views\Product\ItemAttrList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "99f16a3d9c23a007bcef2931357ff5e8a90969b4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Product_ItemAttrList), @"mvc.1.0.view", @"/Areas/Admin/Views/Product/ItemAttrList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Product/ItemAttrList.cshtml", typeof(AspNetCore.Areas_Admin_Views_Product_ItemAttrList))]
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
#line 1 "D:\Vuong\TCVEcommerce\TCV\TCVWeb\Areas\Admin\Views\_ViewImports.cshtml"
using TCVWeb;

#line default
#line hidden
#line 2 "D:\Vuong\TCVEcommerce\TCV\TCVWeb\Areas\Admin\Views\_ViewImports.cshtml"
using TCVWeb.Models;

#line default
#line hidden
#line 3 "D:\Vuong\TCVEcommerce\TCV\TCVWeb\Areas\Admin\Views\_ViewImports.cshtml"
using TCVShared.Data;

#line default
#line hidden
#line 4 "D:\Vuong\TCVEcommerce\TCV\TCVWeb\Areas\Admin\Views\_ViewImports.cshtml"
using TCVShared.Helpers;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99f16a3d9c23a007bcef2931357ff5e8a90969b4", @"/Areas/Admin/Views/Product/ItemAttrList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2518695664784e874a378dfe02102f8182c393ac", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Product_ItemAttrList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PagedList<ShopAttrib>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_PartialDataFilter", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("css-style", "pagination pagination-sm", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::TCVShared.Helpers.PaginationTagHelper __TCVShared_Helpers_PaginationTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 4 "D:\Vuong\TCVEcommerce\TCV\TCVWeb\Areas\Admin\Views\Product\ItemAttrList.cshtml"
  
    ViewBag.Icon = "fa-cubes";
    ViewBag.Title = "Thuộc tính Sản phẩm";

#line default
#line hidden
            BeginContext(216, 106, true);
            WriteLiteral("\r\n    <section role=\"main\" class=\"content-body\">\r\n        <header class=\"page-header\">\r\n            <h2><i");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 322, "\"", 346, 2);
            WriteAttributeValue("", 330, "fa", 330, 2, true);
#line 11 "D:\Vuong\TCVEcommerce\TCV\TCVWeb\Areas\Admin\Views\Product\ItemAttrList.cshtml"
WriteAttributeValue(" ", 332, ViewBag.Icon, 333, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(347, 6, true);
            WriteLiteral("></i> ");
            EndContext();
            BeginContext(354, 13, false);
#line 11 "D:\Vuong\TCVEcommerce\TCV\TCVWeb\Areas\Admin\Views\Product\ItemAttrList.cshtml"
                                            Write(ViewBag.Title);

#line default
#line hidden
            EndContext();
            BeginContext(367, 153, true);
            WriteLiteral("</h2>\r\n            <div class=\"right-wrapper pull-right\">\r\n                <ol class=\"breadcrumbs\">\r\n                    <li>\r\n                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 520, "\"", 557, 1);
#line 15 "D:\Vuong\TCVEcommerce\TCV\TCVWeb\Areas\Admin\Views\Product\ItemAttrList.cshtml"
WriteAttributeValue("", 527, Url.Action(" Index", "Home" ), 527, 30, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(558, 501, true);
            WriteLiteral(@">
                            <i class=""fa fa-home""></i>
                        </a>
                    </li>
                    <li><span>Tin tức</span></li>
                    <li><span>Phân loại</span></li>
                </ol>
                <a class=""sidebar-right-toggle"" data-open=""sidebar-right""><i class=""fa fa-chevron-left""></i></a>
            </div>
        </header>
        <div class=""row"">
            <div class=""col-sm-4"">
                <a class=""btn btn-primary""");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1059, "\"", 1095, 1);
#line 27 "D:\Vuong\TCVEcommerce\TCV\TCVWeb\Areas\Admin\Views\Product\ItemAttrList.cshtml"
WriteAttributeValue("", 1066, Url.Action("ItemAttrCreate"), 1066, 29, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1096, 148, true);
            WriteLiteral(" data-modal=\"\"><i class=\"fa fa-plus\"></i> Tạo Phân loại mới</a>\r\n            </div>\r\n            <div class=\"col-sm-8 text-right\">\r\n                ");
            EndContext();
            BeginContext(1244, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6a3d22e8540d4a3297dca3010c48099d", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1281, 90, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"table-responsive\">\r\n            ");
            EndContext();
            BeginContext(1371, 121, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("pagination", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "055d5c1d73474b15b3d4f17301b745a1", async() => {
            }
            );
            __TCVShared_Helpers_PaginationTagHelper = CreateTagHelper<global::TCVShared.Helpers.PaginationTagHelper>();
            __tagHelperExecutionContext.Add(__TCVShared_Helpers_PaginationTagHelper);
#line 34 "D:\Vuong\TCVEcommerce\TCV\TCVWeb\Areas\Admin\Views\Product\ItemAttrList.cshtml"
__TCVShared_Helpers_PaginationTagHelper.Model = Model;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __TCVShared_Helpers_PaginationTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 34 "D:\Vuong\TCVEcommerce\TCV\TCVWeb\Areas\Admin\Views\Product\ItemAttrList.cshtml"
__TCVShared_Helpers_PaginationTagHelper.QueryString = Context.Request.QueryString;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("query-string", __TCVShared_Helpers_PaginationTagHelper.QueryString, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __TCVShared_Helpers_PaginationTagHelper.CssStyle = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1492, 375, true);
            WriteLiteral(@"
            <table class=""table table-striped table-bordered table-hover"">
                <thead>
                    <tr>
                        <th>Mã Id</th>
                        <th>Cấp trên</th>
                        <th>Tên gọi</th>
                        <th>Thao tác</th>
                    </tr>
                </thead>
                <tbody>
");
            EndContext();
#line 45 "D:\Vuong\TCVEcommerce\TCV\TCVWeb\Areas\Admin\Views\Product\ItemAttrList.cshtml"
                     foreach (var item in Model.Content)
                    {

#line default
#line hidden
            BeginContext(1948, 54, true);
            WriteLiteral("                    <tr>\r\n                        <td>");
            EndContext();
            BeginContext(2003, 29, false);
#line 48 "D:\Vuong\TCVEcommerce\TCV\TCVWeb\Areas\Admin\Views\Product\ItemAttrList.cshtml"
                       Write(Html.DisplayFor(m => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(2032, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(2068, 31, false);
#line 49 "D:\Vuong\TCVEcommerce\TCV\TCVWeb\Areas\Admin\Views\Product\ItemAttrList.cshtml"
                       Write(Html.DisplayFor(m => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(2099, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(2135, 32, false);
#line 50 "D:\Vuong\TCVEcommerce\TCV\TCVWeb\Areas\Admin\Views\Product\ItemAttrList.cshtml"
                       Write(Html.DisplayFor(m => item.Title));

#line default
#line hidden
            EndContext();
            BeginContext(2167, 65, true);
            WriteLiteral("</td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2233, 61, false);
#line 52 "D:\Vuong\TCVEcommerce\TCV\TCVWeb\Areas\Admin\Views\Product\ItemAttrList.cshtml"
                       Write(Html.UpdateLink("ItemAttrUpdate", new { id = item.Id }, true));

#line default
#line hidden
            EndContext();
            BeginContext(2294, 60, true);
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 55 "D:\Vuong\TCVEcommerce\TCV\TCVWeb\Areas\Admin\Views\Product\ItemAttrList.cshtml"
                    }

#line default
#line hidden
            BeginContext(2377, 80, true);
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </section>\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Http.IHttpContextAccessor HttpContextAccessor { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PagedList<ShopAttrib>> Html { get; private set; }
    }
}
#pragma warning restore 1591
