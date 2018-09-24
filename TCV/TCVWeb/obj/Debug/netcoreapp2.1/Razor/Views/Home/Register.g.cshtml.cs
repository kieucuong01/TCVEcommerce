#pragma checksum "/Users/mac/Downloads/project/TCVEcommerce/TCV/TCVWeb/Views/Home/Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aeb05be5cd0822ef7280196eca61074e22eeb598"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Register), @"mvc.1.0.view", @"/Views/Home/Register.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Register.cshtml", typeof(AspNetCore.Views_Home_Register))]
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
#line 1 "/Users/mac/Downloads/project/TCVEcommerce/TCV/TCVWeb/Views/_ViewImports.cshtml"
using TCVWeb;

#line default
#line hidden
#line 2 "/Users/mac/Downloads/project/TCVEcommerce/TCV/TCVWeb/Views/_ViewImports.cshtml"
using TCVWeb.Models;

#line default
#line hidden
#line 3 "/Users/mac/Downloads/project/TCVEcommerce/TCV/TCVWeb/Views/_ViewImports.cshtml"
using TCVShared.Data;

#line default
#line hidden
#line 4 "/Users/mac/Downloads/project/TCVEcommerce/TCV/TCVWeb/Views/_ViewImports.cshtml"
using TCVShared.Helpers;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aeb05be5cd0822ef7280196eca61074e22eeb598", @"/Views/Home/Register.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf9121a4081b5ebb992b4900a8f96fbe0f68a483", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/mac/Downloads/project/TCVEcommerce/TCV/TCVWeb/Views/Home/Register.cshtml"
  
    ViewData["Title"] = "Register";

#line default
#line hidden
            BeginContext(44, 391, true);
            WriteLiteral(@"
<div role=""main"" class=""main"">

    <section class=""form-section register-form"">
        <div class=""container"">
            <h1 class=""h2 heading-primary font-weight-normal mb-md mt-xlg"">Create an Account</h1>

            <div class=""featured-box featured-box-primary featured-box-flat featured-box-text-left mt-md"">
                <div class=""box-content"">
                    ");
            EndContext();
            BeginContext(435, 3805, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f368a654e3ce4d648c5714f8530feaf9", async() => {
                BeginContext(452, 3781, true);
                WriteLiteral(@"

                        <h4 class=""heading-primary text-uppercase mb-lg"">PERSONAL INFORMATION</h4>
                        <div class=""row"">
                            <div class=""col-sm-4 col-md-3"">
                                <div class=""form-group"">
                                    <label class=""font-weight-normal"">First Name <span class=""required"">*</span></label>
                                    <input type=""text"" class=""form-control"" required>
                                </div>
                            </div>
                            <div class=""col-sm-4 col-md-3"">
                                <div class=""form-group"">
                                    <label class=""font-weight-normal"">Middle Name</label>
                                    <input type=""text"" class=""form-control"">
                                </div>
                            </div>
                            <div class=""col-sm-4 col-md-5"">
                                <div class=""form");
                WriteLiteral(@"-group"">
                                    <label class=""font-weight-normal"">Last Name <span class=""required"">*</span></label>
                                    <input type=""text"" class=""form-control"" required>
                                </div>
                            </div>
                        </div>

                        <div class=""row"">
                            <div class=""col-xs-12"">
                                <div class=""form-group"">
                                    <label class=""font-weight-normal"">Email Address <span class=""required"">*</span></label>
                                    <input type=""email"" class=""form-control"" required>
                                </div>

                                <div class=""checkbox mb-xlg"">
                                    <label>
                                        <input type=""checkbox"" value=""1"">
                                        Sign Up for Newsletter
                                    </la");
                WriteLiteral(@"bel>
                                </div>

                                <h4 class=""heading-primary text-uppercase mb-lg"">LOGIN INFORMATION</h4>
                            </div>
                        </div>

                        <div class=""row"">
                            <div class=""col-sm-6"">
                                <div class=""form-group"">
                                    <label class=""font-weight-normal"">Password <span class=""required"">*</span></label>
                                    <input type=""password"" class=""form-control"" required>
                                </div>
                            </div>

                            <div class=""col-sm-6"">
                                <div class=""form-group"">
                                    <label class=""font-weight-normal"">Confirm Password <span class=""required"">*</span></label>
                                    <input type=""password"" class=""form-control"" required>
                              ");
                WriteLiteral(@"  </div>
                            </div>
                        </div>

                        <div class=""row"">
                            <div class=""col-xs-12"">
                                <p class=""required mt-lg mb-none"">* Required Fields</p>

                                <div class=""form-action clearfix mt-none"">
                                    <a href=""demo-shop-14-login.html"" class=""pull-left""><i class=""fa fa-angle-double-left""></i> Back</a>

                                    <input type=""submit"" class=""btn btn-primary"" value=""Submit"">
                                </div>
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
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4240, 88, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </section>\r\n\r\n</div>\r\n");
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
