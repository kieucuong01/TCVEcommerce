#pragma checksum "D:\Vuong\TCVEcommerce\TCV\TCVWeb\Areas\Admin\Views\HomeAdmin\GenerateRecoveryCodes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "634646c0e91ff619d3ed3889f2771a5eaf4ef7e3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_HomeAdmin_GenerateRecoveryCodes), @"mvc.1.0.view", @"/Areas/Admin/Views/HomeAdmin/GenerateRecoveryCodes.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/HomeAdmin/GenerateRecoveryCodes.cshtml", typeof(AspNetCore.Areas_Admin_Views_HomeAdmin_GenerateRecoveryCodes))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"634646c0e91ff619d3ed3889f2771a5eaf4ef7e3", @"/Areas/Admin/Views/HomeAdmin/GenerateRecoveryCodes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2518695664784e874a378dfe02102f8182c393ac", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_HomeAdmin_GenerateRecoveryCodes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ResetAuthenticatorWarning", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GenerateRecoveryCodes", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-group"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\Vuong\TCVEcommerce\TCV\TCVWeb\Areas\Admin\Views\HomeAdmin\GenerateRecoveryCodes.cshtml"
  
    ViewBag.Title = "Sinh mã cứu hộ";

#line default
#line hidden
            BeginContext(46, 92, true);
            WriteLiteral("<section role=\"main\" class=\"content-body\">\r\n    <header class=\"page-header\">\r\n        <h2><i");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 138, "\"", 162, 2);
            WriteAttributeValue("", 146, "fa", 146, 2, true);
#line 6 "D:\Vuong\TCVEcommerce\TCV\TCVWeb\Areas\Admin\Views\HomeAdmin\GenerateRecoveryCodes.cshtml"
WriteAttributeValue(" ", 148, ViewBag.Icon, 149, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(163, 6, true);
            WriteLiteral("></i> ");
            EndContext();
            BeginContext(170, 13, false);
#line 6 "D:\Vuong\TCVEcommerce\TCV\TCVWeb\Areas\Admin\Views\HomeAdmin\GenerateRecoveryCodes.cshtml"
                                        Write(ViewBag.Title);

#line default
#line hidden
            EndContext();
            BeginContext(183, 137, true);
            WriteLiteral("</h2>\r\n        <div class=\"right-wrapper pull-right\">\r\n            <ol class=\"breadcrumbs\">\r\n                <li>\r\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 320, "\"", 355, 1);
#line 10 "D:\Vuong\TCVEcommerce\TCV\TCVWeb\Areas\Admin\Views\HomeAdmin\GenerateRecoveryCodes.cshtml"
WriteAttributeValue("", 327, Url.Action("Index", "Home"), 327, 28, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(356, 410, true);
            WriteLiteral(@">
                        <i class=""fa fa-home""></i>
                    </a>
                </li>
                <li><span>Authenticator</span></li>
            </ol>
            <a class=""sidebar-right-toggle"" data-open=""sidebar-right""><i class=""fa fa-chevron-left""></i></a>
        </div>
    </header>
    <div class=""row"">
        <div class=""col-sm-4"">
            <a class=""btn btn-primary""");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 766, "\"", 793, 1);
#line 21 "D:\Vuong\TCVEcommerce\TCV\TCVWeb\Areas\Admin\Views\HomeAdmin\GenerateRecoveryCodes.cshtml"
WriteAttributeValue("", 773, Url.Action("Index"), 773, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(794, 682, true);
            WriteLiteral(@"><i class=""fa fa-undo""></i> Quay lại</a>
        </div>
        <div class=""col-sm-8 text-right"">
        </div>
    </div>
    <div class=""mt-md"">
        <div class=""alert alert-warning"" role=""alert"">
            <p>
                <span class=""glyphicon glyphicon-warning-sign""></span>
                <b>Thao tác này sẽ reset lại mã cứu hộ.</b>
            </p>
            <p>
                Nếu bạn mất thiết bị Authenticator, bạn có thể sử dụng mã cứu hộ để đăng nhập Tài khoản
            </p>
            <p>
                Reset mã cứu hộ không làm thay đổi key của ứng dụng Authenticator. Nếu bạn muốn thay đổi key của ứng dụng Authenticator bạn có thể ");
            EndContext();
            BeginContext(1476, 70, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2191e561f08f43ac914c279c4d2f5c16", async() => {
                BeginContext(1518, 24, true);
                WriteLiteral(" Reset mã Authenticator.");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1546, 63, true);
            WriteLiteral("\r\n            </p>\r\n        </div>\r\n        <div>\r\n            ");
            EndContext();
            BeginContext(1609, 207, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3d1088b613174df08807ec184940dd57", async() => {
                BeginContext(1683, 126, true);
                WriteLiteral("\r\n                <button class=\"btn btn-danger\" type=\"submit\"><i class=\"fa fa-check\"></i> Reset lại mã</button>\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1816, 42, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</section>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591