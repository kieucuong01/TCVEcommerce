#pragma checksum "D:\Vuong\TCVEcommerce\TCV\TCVWeb\Views\Home\Cart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6a095ac4db39d5f544642f792f05f9de4fce87e9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Cart), @"mvc.1.0.view", @"/Views/Home/Cart.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Cart.cshtml", typeof(AspNetCore.Views_Home_Cart))]
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
#line 1 "D:\Vuong\TCVEcommerce\TCV\TCVWeb\Views\_ViewImports.cshtml"
using TCVWeb;

#line default
#line hidden
#line 2 "D:\Vuong\TCVEcommerce\TCV\TCVWeb\Views\_ViewImports.cshtml"
using TCVWeb.Models;

#line default
#line hidden
#line 3 "D:\Vuong\TCVEcommerce\TCV\TCVWeb\Views\_ViewImports.cshtml"
using TCVShared.Data;

#line default
#line hidden
#line 4 "D:\Vuong\TCVEcommerce\TCV\TCVWeb\Views\_ViewImports.cshtml"
using TCVShared.Helpers;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a095ac4db39d5f544642f792f05f9de4fce87e9", @"/Views/Home/Cart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2518695664784e874a378dfe02102f8182c393ac", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Cart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "United States", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "United Kingdon", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "China", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Russia", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Alabama", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Alaska", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 6061, true);
            WriteLiteral(@"<div role=""main"" class=""main"">
    <div class=""cart"">
        <div class=""container"">
            <h1 class=""h2 heading-primary mt-lg clearfix"">
                <span>Shopping Cart</span>
                <a href=""#"" class=""btn btn-primary pull-right"">Proceed to Checkout</a>
            </h1>
            <div class=""row"">
                <div class=""col-md-8 col-lg-9"">
                    <div class=""cart-table-wrap"">
                        <table class=""cart-table"">
                            <thead>
                                <tr>
                                    <th></th>
                                    <th></th>
                                    <th>Product Name</th>
                                    <th>Unit Price</th>
                                    <th>Qty</th>
                                    <th>Subtotal</th>
                                </tr>
                            </thead>
                            <tbody>
                                <tr>");
            WriteLiteral(@"
                                    <td class=""product-action-td"">
                                        <a href=""#"" title=""Remove product"" class=""btn-remove""><i class=""fa fa-times""></i></a>
                                    </td>
                                    <td class=""product-image-td"">
                                        <a href=""#"" title=""Product Name"">
                                            <img src=""../img/demos/shop/products/cart-product1.jpg"" alt=""Product Name"">
                                        </a>
                                    </td>
                                    <td class=""product-name-td"">
                                        <h2 class=""product-name""><a href=""#"" title=""Product Name"">Women Fashion Blouse</a></h2>
                                    </td>
                                    <td>$120.00</td>
                                    <td>
                                        <div class=""qty-holder"">
                                 ");
            WriteLiteral(@"           <a href=""#"" class=""qty-dec-btn"" title=""Dec"">-</a>
                                            <input type=""text"" class=""qty-input"" value=""1"">
                                            <a href=""#"" class=""qty-inc-btn"" title=""Inc"">+</a>
                                            <a href=""#"" class=""edit-qty""><i class=""fa fa-pencil""></i></a>
                                        </div>
                                    </td>
                                    <td>
                                        <span class=""text-primary"">$120.00</span>
                                    </td>
                                </tr>
                                <tr>
                                    <td class=""product-action-td"">
                                        <a href=""#"" title=""Remove product"" class=""btn-remove""><i class=""fa fa-times""></i></a>
                                    </td>
                                    <td class=""product-image-td"">
                          ");
            WriteLiteral(@"              <a href=""#"" title=""Product Name"">
                                            <img src=""../img/demos/shop/products/cart-product2.jpg"" alt=""Product Name"">
                                        </a>
                                    </td>
                                    <td class=""product-name-td"">
                                        <h2 class=""product-name""><a href=""#"" title=""Product Name"">Black Utility Top</a></h2>
                                    </td>
                                    <td>$49.00</td>
                                    <td>
                                        <div class=""qty-holder"">
                                            <a href=""#"" class=""qty-dec-btn"" title=""Dec"">-</a>
                                            <input type=""text"" class=""qty-input"" value=""1"">
                                            <a href=""#"" class=""qty-inc-btn"" title=""Inc"">+</a>
                                            <a href=""#"" class=""edit-qty""><i class=""fa ");
            WriteLiteral(@"fa-pencil""></i></a>
                                        </div>
                                    </td>
                                    <td>
                                        <span class=""text-primary"">$49.00</span>
                                    </td>
                                </tr>
                            </tbody>
                            <tfoot>
                                <tr>
                                    <td colspan=""6"" class=""clearfix"">
                                        <button class=""btn btn-default hover-primary btn-continue"">Continue Shopping</button>
                                        <button class=""btn btn-default hover-primary btn-update"">Update Shopping Cart</button>
                                        <button class=""btn btn-default hover-primary btn-clear"">Clear Shopping Cart</button>
                                    </td>
                                </tr>
                            </tfoot>
                     ");
            WriteLiteral(@"   </table>
                    </div>
                </div>
                <aside class=""col-md-4 col-lg-3 sidebar shop-sidebar"">
                    <div class=""panel-group"">
                        <div class=""panel panel-default"">
                            <div class=""panel-heading"">
                                <h4 class=""panel-title"">
                                    <a class=""accordion-toggle collapsed"" data-toggle=""collapse"" href=""#panel-cart-discount"">
                                        Discount Code
                                    </a>
                                </h4>
                            </div>
                            <div id=""panel-cart-discount"" class=""accordion-body collapse"">
                                <div class=""panel-body"">
                                    <p class=""mb-sm"">Enter your coupon code if you have one.</p>
                                    ");
            EndContext();
            BeginContext(6061, 389, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4605d91afa244a41a87f04aae868a92e", async() => {
                BeginContext(6078, 365, true);
                WriteLiteral(@"
                                        <div class=""form-group"">
                                            <input type=""text"" class=""form-control"" required>
                                        </div>
                                        <input type=""submit"" class=""btn btn-primary btn-block"" value=""Apply Coupon"">
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
            BeginContext(6450, 882, true);
            WriteLiteral(@"
                                </div>
                            </div>
                        </div>
                        <div class=""panel panel-default"">
                            <div class=""panel-heading"">
                                <h4 class=""panel-title"">
                                    <a class=""accordion-toggle collapsed"" data-toggle=""collapse"" href=""#panel-cart-ship"">
                                        ESTIMATE SHIPPING AND TAX
                                    </a>
                                </h4>
                            </div>
                            <div id=""panel-cart-ship"" class=""accordion-body collapse"">
                                <div class=""panel-body"">
                                    <p class=""mb-sm"">Enter your destination to get a shipping estimate.</p>
                                    ");
            EndContext();
            BeginContext(7332, 1802, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a51f1666474b466fa394e60ca81cf06d", async() => {
                BeginContext(7349, 299, true);
                WriteLiteral(@"
                                        <div class=""form-group"">
                                            <label>Contry <span class=""required"">*</span></label>
                                            <select name=""#"" class=""form-control"">
                                                ");
                EndContext();
                BeginContext(7648, 52, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "444819a497f74ff890a7178b112a3964", async() => {
                    BeginContext(7678, 13, true);
                    WriteLiteral("United States");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(7700, 50, true);
                WriteLiteral("\r\n                                                ");
                EndContext();
                BeginContext(7750, 54, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "08e9a56854224cbcb3a5de23167f1f8c", async() => {
                    BeginContext(7781, 14, true);
                    WriteLiteral("United Kingdon");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(7804, 50, true);
                WriteLiteral("\r\n                                                ");
                EndContext();
                BeginContext(7854, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c2e3f61318774123857b3f36b494c8b7", async() => {
                    BeginContext(7876, 5, true);
                    WriteLiteral("China");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(7890, 50, true);
                WriteLiteral("\r\n                                                ");
                EndContext();
                BeginContext(7940, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b003462effae4a4f8f337bd8bb0ab9f2", async() => {
                    BeginContext(7963, 6, true);
                    WriteLiteral("Russia");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(7978, 378, true);
                WriteLiteral(@"
                                            </select>
                                        </div>
                                        <div class=""form-group"">
                                            <label>State/Province</label>
                                            <select name=""#"" class=""form-control"">
                                                ");
                EndContext();
                BeginContext(8356, 66, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f289f95807743d2bb16deeba2c4605e", async() => {
                    BeginContext(8386, 27, true);
                    WriteLiteral("Please select region, state");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(8422, 50, true);
                WriteLiteral("\r\n                                                ");
                EndContext();
                BeginContext(8472, 40, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "66d702c9e1e74afe9c5249813e56c390", async() => {
                    BeginContext(8496, 7, true);
                    WriteLiteral("Alabama");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(8512, 50, true);
                WriteLiteral("\r\n                                                ");
                EndContext();
                BeginContext(8562, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "16d0b22afa16420e99d26421b3114823", async() => {
                    BeginContext(8585, 6, true);
                    WriteLiteral("Alaska");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(8600, 527, true);
                WriteLiteral(@"
                                            </select>
                                        </div>
                                        <div class=""form-group"">
                                            <label>Zip Code</label>
                                            <input type=""text"" class=""form-control"">
                                        </div>
                                        <input type=""submit"" class=""btn btn-primary btn-block"" value=""Get a Quote"">
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
            BeginContext(9134, 6629, true);
            WriteLiteral(@"
                                </div>
                            </div>
                        </div>
                        <div class=""panel panel-default"">
                            <div class=""panel-heading"">
                                <h4 class=""panel-title"">
                                    <a class=""accordion-toggle"" data-toggle=""collapse"" href=""#panel-cart-total"">
                                        Cart Totals
                                    </a>
                                </h4>
                            </div>
                            <div id=""panel-cart-total"" class=""accordion-body collapse in"">
                                <div class=""panel-body"">
                                    <table class=""totals-table"">
                                        <tbody>
                                            <tr>
                                                <td>Subtotal</td>
                                                <td>$159.00</td>
        ");
            WriteLiteral(@"                                    </tr>
                                            <tr>
                                                <td>Grand Total</td>
                                                <td>$159.00</td>
                                            </tr>
                                        </tbody>
                                    </table>
                                    <div class=""totals-table-action"">
                                        <a href=""#"" class=""btn btn-primary btn-block"">Proceed to Checkout</a>
                                        <a href=""#"" class=""btn btn-link btn-block"">Checkout with Multiple Addresses</a>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </aside>
            </div>
            <div class=""crosssell-products"">
                <h2 class=""h4""><strong>Based on your selection, you may b");
            WriteLiteral(@"e interested in the following items:</strong></h2>
                <div class=""row"">
                    <div class=""col-sm-6 col-md-3"">
                        <div class=""product product-sm"">
                            <figure class=""product-image-area"">
                                <a href=""#"" title=""Product Name"" class=""product-image"">
                                    <img src=""../img/demos/shop/products/cart-product3.jpg"" alt=""Product Name"">
                                </a>
                            </figure>
                            <div class=""product-details-area"">
                                <h2 class=""product-name""><a href=""#"" title=""Product Name"">Jane Dress</a></h2>
                                <div class=""product-price-box"">
                                    <span class=""old-price"">$120.00</span>
                                    <span class=""product-price"">$90.00</span>
                                </div>
                                <a href=""#"" cla");
            WriteLiteral(@"ss=""btn btn-default hover-primary"">Add to Cart</a>
                            </div>
                        </div>
                    </div>
                    <div class=""col-sm-6 col-md-3"">
                        <div class=""product product-sm"">
                            <figure class=""product-image-area"">
                                <a href=""#"" title=""Product Name"" class=""product-image"">
                                    <img src=""../img/demos/shop/products/cart-product4.jpg"" alt=""Product Name"">
                                </a>
                            </figure>
                            <div class=""product-details-area"">
                                <h2 class=""product-name""><a href=""#"" title=""Product Name"">Jane Dress - S</a></h2>
                                <div class=""product-price-box"">
                                    <span class=""old-price"">$100.00</span>
                                    <span class=""product-price"">$89.00</span>
                      ");
            WriteLiteral(@"          </div>
                                <a href=""#"" class=""btn btn-default hover-primary"">Add to Cart</a>
                            </div>
                        </div>
                    </div>
                    <div class=""clearfix visible-sm""></div>
                    <div class=""col-sm-6 col-md-3"">
                        <div class=""product product-sm"">
                            <figure class=""product-image-area"">
                                <a href=""#"" title=""Product Name"" class=""product-image"">
                                    <img src=""../img/demos/shop/products/cart-product1.jpg"" alt=""Product Name"">
                                </a>
                            </figure>
                            <div class=""product-details-area"">
                                <h2 class=""product-name""><a href=""#"" title=""Product Name"">Jane Dress - XL</a></h2>
                                <div class=""product-price-box"">
                                    <span class=""o");
            WriteLiteral(@"ld-price"">$100.00</span>
                                    <span class=""product-price"">$69.00</span>
                                </div>
                                <a href=""#"" class=""btn btn-default hover-primary"">Add to Cart</a>
                            </div>
                        </div>
                    </div>
                    <div class=""col-sm-6 col-md-3"">
                        <div class=""product product-sm"">
                            <figure class=""product-image-area"">
                                <a href=""#"" title=""Product Name"" class=""product-image"">
                                    <img src=""../img/demos/shop/products/cart-product2.jpg"" alt=""Product Name"">
                                </a>
                            </figure>
                            <div class=""product-details-area"">
                                <h2 class=""product-name""><a href=""#"" title=""Product Name"">Jane Dress - M</a></h2>
                                <div class=""produc");
            WriteLiteral(@"t-price-box"">
                                    <span class=""old-price"">$110.00</span>
                                    <span class=""product-price"">$79.00</span>
                                </div>
                                <a href=""#"" class=""btn btn-default hover-primary"">Add to Cart</a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
");
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
