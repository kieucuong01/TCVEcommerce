#pragma checksum "D:\Vuong\TCVEcommerce\TCV\TCVWeb\Areas\Admin\Views\HomeAdmin\EnableAuthenticator.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "12b4fe23f415c165788bf6aa28a102bcbaba354f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_HomeAdmin_EnableAuthenticator), @"mvc.1.0.view", @"/Areas/Admin/Views/HomeAdmin/EnableAuthenticator.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/HomeAdmin/EnableAuthenticator.cshtml", typeof(AspNetCore.Areas_Admin_Views_HomeAdmin_EnableAuthenticator))]
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
#line 1 "D:\Vuong\TCVEcommerce\TCV\TCVWeb\Areas\Admin\Views\HomeAdmin\EnableAuthenticator.cshtml"
using TCVWeb.Areas.Admin.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12b4fe23f415c165788bf6aa28a102bcbaba354f", @"/Areas/Admin/Views/HomeAdmin/EnableAuthenticator.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2518695664784e874a378dfe02102f8182c393ac", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_HomeAdmin_EnableAuthenticator : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EnableAuthenticatorViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("autocomplete", new global::Microsoft.AspNetCore.Html.HtmlString("off"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_PartialValidation", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/qrcode.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "D:\Vuong\TCVEcommerce\TCV\TCVWeb\Areas\Admin\Views\HomeAdmin\EnableAuthenticator.cshtml"
  
    ViewBag.Icon = "fa-check";
    ViewBag.Title = "Tạo mã Authenticator";

#line default
#line hidden
            BeginContext(155, 94, true);
            WriteLiteral("\r\n<section role=\"main\" class=\"content-body\">\r\n    <header class=\"page-header\">\r\n        <h2><i");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 249, "\"", 273, 2);
            WriteAttributeValue("", 257, "fa", 257, 2, true);
#line 10 "D:\Vuong\TCVEcommerce\TCV\TCVWeb\Areas\Admin\Views\HomeAdmin\EnableAuthenticator.cshtml"
WriteAttributeValue(" ", 259, ViewBag.Icon, 260, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(274, 6, true);
            WriteLiteral("></i> ");
            EndContext();
            BeginContext(281, 13, false);
#line 10 "D:\Vuong\TCVEcommerce\TCV\TCVWeb\Areas\Admin\Views\HomeAdmin\EnableAuthenticator.cshtml"
                                        Write(ViewBag.Title);

#line default
#line hidden
            EndContext();
            BeginContext(294, 137, true);
            WriteLiteral("</h2>\r\n        <div class=\"right-wrapper pull-right\">\r\n            <ol class=\"breadcrumbs\">\r\n                <li>\r\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 431, "\"", 466, 1);
#line 14 "D:\Vuong\TCVEcommerce\TCV\TCVWeb\Areas\Admin\Views\HomeAdmin\EnableAuthenticator.cshtml"
WriteAttributeValue("", 438, Url.Action("Index", "Home"), 438, 28, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(467, 410, true);
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
            BeginWriteAttribute("href", " href=\"", 877, "\"", 904, 1);
#line 25 "D:\Vuong\TCVEcommerce\TCV\TCVWeb\Areas\Admin\Views\HomeAdmin\EnableAuthenticator.cshtml"
WriteAttributeValue("", 884, Url.Action("Index"), 884, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(905, 1461, true);
            WriteLiteral(@"><i class=""fa fa-undo""></i> Quay lại</a>
        </div>
        <div class=""col-sm-8 text-right"">
        </div>
    </div>
    <div class=""mt-md"">
        <p>Các bước thực hiện liên kết với ứng dụng Authenticator:</p>
        <ol class=""list"">
            <li>
                Tải một trong các ứng dụng Authenticator như sau:
                <p>
                    <b>Google Authenticator</b>
                    <ul>
                        <li><a href=""https://play.google.com/store/apps/details?id=com.google.android.apps.authenticator2&amp;hl=en"" target=""_blank"">Phiên bản Android</a></li>
                        <li><a href=""https://itunes.apple.com/us/app/google-authenticator/id388497605?mt=8"" target=""_blank"">Phiên bản iOS</a></li>
                    </ul>
                </p>
                <p>
                    <b>Microsoft Authenticator</b>
                    <ul>
                        <li><a href=""https://go.microsoft.com/fwlink/?Linkid=825071"" target=""_blank"">Phiên bản Window");
            WriteLiteral(@"s Phone</a></li>
                        <li><a href=""https://go.microsoft.com/fwlink/?Linkid=825072"" target=""_blank"">Phiên bản Android</a></li>
                        <li><a href=""https://go.microsoft.com/fwlink/?Linkid=825073"" target=""_blank"">Phiên bản iOS</a></li>
                    </ul>
                </p>
            </li>
            <li>
                <p>Mở ứng dụng rồi quét QRCode dưới đây hoặc nhập đoạn mã <kbd>");
            EndContext();
            BeginContext(2367, 15, false);
#line 52 "D:\Vuong\TCVEcommerce\TCV\TCVWeb\Areas\Admin\Views\HomeAdmin\EnableAuthenticator.cshtml"
                                                                          Write(Model.SharedKey);

#line default
#line hidden
            EndContext();
            BeginContext(2382, 100, true);
            WriteLiteral("</kbd></p>\r\n                <div id=\"qrCode\"></div>\r\n                <div id=\"qrCodeData\" data-url=\"");
            EndContext();
            BeginContext(2483, 22, false);
#line 54 "D:\Vuong\TCVEcommerce\TCV\TCVWeb\Areas\Admin\Views\HomeAdmin\EnableAuthenticator.cshtml"
                                          Write(Model.AuthenticatorUri);

#line default
#line hidden
            EndContext();
            BeginContext(2505, 293, true);
            WriteLiteral(@"""></div>
            </li>
            <li>
                <p>
                    Cuối cùng, nhập mã số nhận được từ ứng dụng Authenticator để hoàn tất liên kết
                </p>
                <div class=""row"">
                    <div class=""col-md-6"">
                        ");
            EndContext();
            BeginContext(2798, 1003, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "416c6764f9514d1796675d961e452155", async() => {
                BeginContext(2818, 30, true);
                WriteLiteral("\r\n                            ");
                EndContext();
                BeginContext(2848, 66, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1c17a9eba60b47f3ac2a5fc429c9e45a", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#line 63 "D:\Vuong\TCVEcommerce\TCV\TCVWeb\Areas\Admin\Views\HomeAdmin\EnableAuthenticator.cshtml"
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
                BeginContext(2914, 88, true);
                WriteLiteral("\r\n                            <div class=\"form-group\">\r\n                                ");
                EndContext();
                BeginContext(3002, 30, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "65d089017079420f9ae04458fe4bd7d9", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 65 "D:\Vuong\TCVEcommerce\TCV\TCVWeb\Areas\Admin\Views\HomeAdmin\EnableAuthenticator.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Code);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3032, 34, true);
                WriteLiteral("\r\n                                ");
                EndContext();
                BeginContext(3066, 64, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7202a27dec084802a302aa536e391af0", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 66 "D:\Vuong\TCVEcommerce\TCV\TCVWeb\Areas\Admin\Views\HomeAdmin\EnableAuthenticator.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Code);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3130, 34, true);
                WriteLiteral("\r\n                                ");
                EndContext();
                BeginContext(3164, 59, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "81319ddd5567493992337b84cd70c5c7", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#line 67 "D:\Vuong\TCVEcommerce\TCV\TCVWeb\Areas\Admin\Views\HomeAdmin\EnableAuthenticator.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Code);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3223, 571, true);
                WriteLiteral(@"
                            </div>
                            <div class=""form-group"">
                                <div class=""col-sm-6 text-right"">
                                    <button type=""submit"" class=""btn btn-primary btn-block hidden-xs""><i class=""fa fa-check""></i> Xác nhận</button>
                                    <button type=""submit"" class=""btn btn-primary btn-block btn-lg visible-xs mt-lg""><i class=""fa fa-check""></i> Xác nhận</button>
                                </div>
                            </div>
                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3801, 112, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </li>\r\n        </ol>\r\n    </div>\r\n</section>\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(3931, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(3937, 37, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ccff2210347149c890b45b9ca0b0f7a9", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3974, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(3980, 65, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "68fcae8bc216414cbd73ebb6af3ccd5a", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4045, 132, true);
                WriteLiteral("\r\n    <script type=\"text/javascript\">\r\n        new QRCode(document.getElementById(\"qrCode\"),\r\n            {\r\n                text: \"");
                EndContext();
                BeginContext(4178, 32, false);
#line 88 "D:\Vuong\TCVEcommerce\TCV\TCVWeb\Areas\Admin\Views\HomeAdmin\EnableAuthenticator.cshtml"
                  Write(Html.Raw(Model.AuthenticatorUri));

#line default
#line hidden
                EndContext();
                BeginContext(4210, 94, true);
                WriteLiteral("\",\r\n                width: 150,\r\n                height: 150\r\n            });\r\n    </script>\r\n");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EnableAuthenticatorViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
