#pragma checksum "D:\Vuong\TCVEcommerce\TCV\TCVWeb\Areas\Admin\Views\BlogPost\PostCatEdit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "164cd92fde5e6a93ad7f29810cec1750b4980d8d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_BlogPost_PostCatEdit), @"mvc.1.0.view", @"/Areas/Admin/Views/BlogPost/PostCatEdit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/BlogPost/PostCatEdit.cshtml", typeof(AspNetCore.Areas_Admin_Views_BlogPost_PostCatEdit))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"164cd92fde5e6a93ad7f29810cec1750b4980d8d", @"/Areas/Admin/Views/BlogPost/PostCatEdit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2518695664784e874a378dfe02102f8182c393ac", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_BlogPost_PostCatEdit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Taxonomy>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/wait.gif"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("waiting..."), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\Vuong\TCVEcommerce\TCV\TCVWeb\Areas\Admin\Views\BlogPost\PostCatEdit.cshtml"
  
    Layout = null;
    string formTitle = Model.Id == 0 ? "Tạo Phân loại mới" : "Cập nhật Phân loại";

#line default
#line hidden
#line 6 "D:\Vuong\TCVEcommerce\TCV\TCVWeb\Areas\Admin\Views\BlogPost\PostCatEdit.cshtml"
 using (Html.BeginForm(null, null, FormMethod.Post, new { @class = "modalForm", @autocomplete = "off" }))
{
    

#line default
#line hidden
            BeginContext(243, 23, false);
#line 8 "D:\Vuong\TCVEcommerce\TCV\TCVWeb\Areas\Admin\Views\BlogPost\PostCatEdit.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(268, 190, true);
            WriteLiteral("    <div class=\"modal-header\">\r\n        <button type=\"button\" class=\"close\" data-dismiss=\"modal\" aria-hidden=\"true\">×</button>\r\n        <h3 class=\"modal-title\"><i class=\"fa fa-windows\"></i> ");
            EndContext();
            BeginContext(459, 9, false);
#line 11 "D:\Vuong\TCVEcommerce\TCV\TCVWeb\Areas\Admin\Views\BlogPost\PostCatEdit.cshtml"
                                                         Write(formTitle);

#line default
#line hidden
            EndContext();
            BeginContext(468, 100, true);
            WriteLiteral("</h3>\r\n    </div>\r\n    <div class=\"modal-body\">\r\n        <div class=\"form-horizontal\">\r\n            ");
            EndContext();
            BeginContext(569, 58, false);
#line 15 "D:\Vuong\TCVEcommerce\TCV\TCVWeb\Areas\Admin\Views\BlogPost\PostCatEdit.cshtml"
       Write(Html.ValidationSummary("", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(627, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(642, 25, false);
#line 16 "D:\Vuong\TCVEcommerce\TCV\TCVWeb\Areas\Admin\Views\BlogPost\PostCatEdit.cshtml"
       Write(Html.HiddenFor(m => m.Id));

#line default
#line hidden
            EndContext();
            BeginContext(667, 56, true);
            WriteLiteral("\r\n            <div class=\"form-group\">\r\n                ");
            EndContext();
            BeginContext(724, 73, false);
#line 18 "D:\Vuong\TCVEcommerce\TCV\TCVWeb\Areas\Admin\Views\BlogPost\PostCatEdit.cshtml"
           Write(Html.LabelFor(m => m.ParentId, new { @class = "col-sm-3 control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(797, 62, true);
            WriteLiteral("\r\n                <div class=\"col-sm-6\">\r\n                    ");
            EndContext();
            BeginContext(860, 104, false);
#line 20 "D:\Vuong\TCVEcommerce\TCV\TCVWeb\Areas\Admin\Views\BlogPost\PostCatEdit.cshtml"
               Write(Html.DropDownListFor(m => m.ParentId, null, "== Phân loại cấp trên ==", new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(964, 164, true);
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-sm-3\">\r\n                </div>\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
            EndContext();
            BeginContext(1129, 69, false);
#line 26 "D:\Vuong\TCVEcommerce\TCV\TCVWeb\Areas\Admin\Views\BlogPost\PostCatEdit.cshtml"
           Write(Html.LabelFor(m => m.Name, new { @class = "col-sm-3 control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(1198, 62, true);
            WriteLiteral("\r\n                <div class=\"col-sm-6\">\r\n                    ");
            EndContext();
            BeginContext(1261, 76, false);
#line 28 "D:\Vuong\TCVEcommerce\TCV\TCVWeb\Areas\Admin\Views\BlogPost\PostCatEdit.cshtml"
               Write(Html.TextBoxFor(m => m.Name, new { @class = "form-control", required = "" }));

#line default
#line hidden
            EndContext();
            BeginContext(1337, 283, true);
            WriteLiteral(@"
                </div>
                <div class=""col-sm-3"">
                    <i>Tên phân loại</i>
                </div>
            </div>
        </div>
    </div>
    <div class=""modal-footer"">
        <span id=""progress"" class=""text-center"" style=""display: none;"">");
            EndContext();
            BeginContext(1620, 45, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2673552f816440029066d517707ba26f", async() => {
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
            BeginContext(1665, 234, true);
            WriteLiteral("Saving...</span>\r\n        <button class=\"btn btn-primary\" type=\"submit\"><i class=\"fa fa-save\"></i> Lưu lại</button>\r\n        <button class=\"btn btn-warning\" data-dismiss=\"modal\"><i class=\"fa fa-undo\"></i> Hủy bỏ</button>\r\n    </div>\r\n");
            EndContext();
#line 41 "D:\Vuong\TCVEcommerce\TCV\TCVWeb\Areas\Admin\Views\BlogPost\PostCatEdit.cshtml"
}

#line default
#line hidden
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