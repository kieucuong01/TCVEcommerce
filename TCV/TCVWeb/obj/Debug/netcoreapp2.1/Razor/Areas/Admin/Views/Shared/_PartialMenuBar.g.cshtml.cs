#pragma checksum "/Users/mac/Downloads/project/TCVEcommerce/TCV/TCVWeb/Areas/Admin/Views/Shared/_PartialMenuBar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "719b671723412f6459b3dbd3127712d63dcc7deb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared__PartialMenuBar), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/_PartialMenuBar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Shared/_PartialMenuBar.cshtml", typeof(AspNetCore.Areas_Admin_Views_Shared__PartialMenuBar))]
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
#line 1 "/Users/mac/Downloads/project/TCVEcommerce/TCV/TCVWeb/Areas/Admin/Views/_ViewImports.cshtml"
using TCVWeb;

#line default
#line hidden
#line 2 "/Users/mac/Downloads/project/TCVEcommerce/TCV/TCVWeb/Areas/Admin/Views/_ViewImports.cshtml"
using TCVWeb.Models;

#line default
#line hidden
#line 3 "/Users/mac/Downloads/project/TCVEcommerce/TCV/TCVWeb/Areas/Admin/Views/_ViewImports.cshtml"
using TCVShared.Data;

#line default
#line hidden
#line 4 "/Users/mac/Downloads/project/TCVEcommerce/TCV/TCVWeb/Areas/Admin/Views/_ViewImports.cshtml"
using TCVShared.Helpers;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"719b671723412f6459b3dbd3127712d63dcc7deb", @"/Areas/Admin/Views/Shared/_PartialMenuBar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf9121a4081b5ebb992b4900a8f96fbe0f68a483", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Shared__PartialMenuBar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("logo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/logo.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Logo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(0, 258, true);
            WriteLiteral(@"<header class=""header fixed clearfix"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-3"">
                <div class=""header-left clearfix"">
                    <div class=""logo"">
                        <a href=""/Home"">");
            EndContext();
            BeginContext(258, 47, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0aff70a336e149a3b208f43c8f5ea67d", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
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
            BeginContext(305, 1170, true);
            WriteLiteral(@"</a>
                    </div>
                    <div class=""site-slogan"">
                    </div>
                </div>
            </div>
            <div class=""col-md-9"">
                <div class=""header-right clearfix"">
                    <div class=""main-navigation animated"">
                        <nav class=""navbar navbar-default"" role=""navigation"">
                            <div class=""container-fluid"">
                                <div class=""navbar-header"">
                                    <button type=""button"" class=""navbar-toggle"" data-toggle=""collapse"" data-target=""#mainMenuBar"">
                                        <span class=""sr-only"">Toggle navigation</span>
                                        <span class=""icon-bar""></span>
                                        <span class=""icon-bar""></span>
                                        <span class=""icon-bar""></span>
                                    </button>
                                </div>
                   ");
            WriteLiteral("             <div class=\"collapse navbar-collapse\" id=\"mainMenuBar\">\n                                    <ul class=\"nav navbar-nav navbar-right\">\n");
            EndContext();
            BeginContext(2367, 252, true);
            WriteLiteral("                                    </ul>\n                                </div>\n                            </div>\n                        </nav>\n                    </div>\n                </div>\n            </div>\n        </div>\n    </div>\n</header>\n");
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
