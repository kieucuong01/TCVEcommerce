#pragma checksum "D:\Vuong\TCVEcommerce\TCV\TCVWeb\Areas\Admin\Views\BlogPost\PostCatDelete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c10a0ee0f71e6bca394652569c5c5c90f93a3c7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_BlogPost_PostCatDelete), @"mvc.1.0.view", @"/Areas/Admin/Views/BlogPost/PostCatDelete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/BlogPost/PostCatDelete.cshtml", typeof(AspNetCore.Areas_Admin_Views_BlogPost_PostCatDelete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c10a0ee0f71e6bca394652569c5c5c90f93a3c7", @"/Areas/Admin/Views/BlogPost/PostCatDelete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2518695664784e874a378dfe02102f8182c393ac", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_BlogPost_PostCatDelete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Taxonomy>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/wait.gif"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("waiting..."), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("modalForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PostCatDelete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("autocomplete", new global::Microsoft.AspNetCore.Html.HtmlString("off"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\Vuong\TCVEcommerce\TCV\TCVWeb\Areas\Admin\Views\BlogPost\PostCatDelete.cshtml"
  
    Layout = null;
    ViewBag.Title = "Xóa phân loại";

#line default
#line hidden
            BeginContext(82, 1684, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "28e880b22d3a4873bfec5418089965ab", async() => {
                BeginContext(166, 232, true);
                WriteLiteral("\r\n    <section class=\"card\">\r\n        <div class=\"modal-header\">\r\n            <button type=\"button\" class=\"close\" data-dismiss=\"modal\" aria-hidden=\"true\">×</button>\r\n            <h3 class=\"modal-title\"><i class=\"fa fa-windows\"></i> ");
                EndContext();
                BeginContext(399, 13, false);
#line 10 "D:\Vuong\TCVEcommerce\TCV\TCVWeb\Areas\Admin\Views\BlogPost\PostCatDelete.cshtml"
                                                             Write(ViewBag.Title);

#line default
#line hidden
                EndContext();
                BeginContext(412, 116, true);
                WriteLiteral("</h3>\r\n        </div>\r\n        <div class=\"modal-body\">\r\n            <div class=\"form-horizontal\">\r\n                ");
                EndContext();
                BeginContext(529, 58, false);
#line 14 "D:\Vuong\TCVEcommerce\TCV\TCVWeb\Areas\Admin\Views\BlogPost\PostCatDelete.cshtml"
           Write(Html.ValidationSummary("", new { @class = "text-danger" }));

#line default
#line hidden
                EndContext();
                BeginContext(587, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(606, 25, false);
#line 15 "D:\Vuong\TCVEcommerce\TCV\TCVWeb\Areas\Admin\Views\BlogPost\PostCatDelete.cshtml"
           Write(Html.HiddenFor(m => m.Id));

#line default
#line hidden
                EndContext();
                BeginContext(631, 64, true);
                WriteLiteral("\r\n                <div class=\"form-group\">\r\n                    ");
                EndContext();
                BeginContext(696, 69, false);
#line 17 "D:\Vuong\TCVEcommerce\TCV\TCVWeb\Areas\Admin\Views\BlogPost\PostCatDelete.cshtml"
               Write(Html.LabelFor(m => m.Name, new { @class = "col-sm-3 control-label" }));

#line default
#line hidden
                EndContext();
                BeginContext(765, 70, true);
                WriteLiteral("\r\n                    <div class=\"col-sm-6\">\r\n                        ");
                EndContext();
                BeginContext(836, 28, false);
#line 19 "D:\Vuong\TCVEcommerce\TCV\TCVWeb\Areas\Admin\Views\BlogPost\PostCatDelete.cshtml"
                   Write(Html.DisplayFor(m => m.Name));

#line default
#line hidden
                EndContext();
                BeginContext(864, 116, true);
                WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    ");
                EndContext();
                BeginContext(981, 75, false);
#line 23 "D:\Vuong\TCVEcommerce\TCV\TCVWeb\Areas\Admin\Views\BlogPost\PostCatDelete.cshtml"
               Write(Html.LabelFor(m => m.ParentName, new { @class = "col-sm-3 control-label" }));

#line default
#line hidden
                EndContext();
                BeginContext(1056, 70, true);
                WriteLiteral("\r\n                    <div class=\"col-sm-6\">\r\n                        ");
                EndContext();
                BeginContext(1127, 34, false);
#line 25 "D:\Vuong\TCVEcommerce\TCV\TCVWeb\Areas\Admin\Views\BlogPost\PostCatDelete.cshtml"
                   Write(Html.DisplayFor(m => m.ParentName));

#line default
#line hidden
                EndContext();
                BeginContext(1161, 290, true);
                WriteLiteral(@"
                    </div>
                </div>
            </div>
            <h3 class=""text-danger text-center"">Bạn thực sự muốn xóa???</h3>
        </div>
        <div class=""modal-footer text-right"">
            <span id=""progress"" class=""text-center"" style=""display: none;"">");
                EndContext();
                BeginContext(1451, 45, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1e7db590ba5b41f381f1d4c949ce94b3", async() => {
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
                EndContext();
                BeginContext(1496, 263, true);
                WriteLiteral(@"Saving...</span>
            <button class=""btn btn-danger"" type=""submit""><i class=""fa fa-times""></i> Xóa luôn</button>
            <button class=""btn btn-warning"" data-dismiss=""modal""><i class=""fa fa-undo""></i> Hủy bỏ</button>
        </div>
    </section>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1766, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Taxonomy> Html { get; private set; }
    }
}
#pragma warning restore 1591
