#pragma checksum "D:\Vuong\TCVEcommerce\TCV\TCVWeb\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5790c2505a69d7da16d932d0cbffeeac65514ffd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5790c2505a69d7da16d932d0cbffeeac65514ffd", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2518695664784e874a378dfe02102f8182c393ac", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PagedList<ShopItem>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/banner/banner1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("slide bg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-bgposition", new global::Microsoft.AspNetCore.Html.HtmlString("center center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-bgfit", new global::Microsoft.AspNetCore.Html.HtmlString("cover"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-bgrepeat", new global::Microsoft.AspNetCore.Html.HtmlString("no-repeat"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("rev-slidebg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/banner/banner4.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/banner/banner3.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\Vuong\TCVEcommerce\TCV\TCVWeb\Views\Home\Index.cshtml"
   
    var categories = ViewData["categories"] as String[];
    var brands = ViewData["brands"] as Supplier[];

#line default
#line hidden
            BeginContext(168, 385, true);
            WriteLiteral(@"    <div class=""body"">
        <div role=""main"" class=""main"">
            <div class=""container"">
                <div class=""slider-container rev_slider_wrapper"" style=""height: 521px;"">
                    <div id=""revolutionSlider"" class=""slider rev_slider manual"">
                        <ul>
                            <li data-transition=""fade"">
                                ");
            EndContext();
            BeginContext(553, 333, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d1e0a9e4dacc4161810f53b6481075bd", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(886, 1868, true);
            WriteLiteral(@"
                                <div class=""tp-caption""
                                     data-x=""center""
                                     data-y=""194""
                                     data-start=""1000""
                                     data-whitespace=""nowrap""
                                     data-transform_in=""y:[100%];s:500;""
                                     data-transform_out=""opacity:0;s:500;""
                                     data-mask_in=""x:0px;y:0px;"" style=""font-size: 79px; line-height:1; font-weight:800; color: #fff;"">Nông sản VN</div>
                                <div class=""tp-caption""
                                     data-x=""center"" data-hoffset=""-220""
                                     data-y=""293""
                                     data-start=""1200""
                                     data-transform_in=""x:[-300%];opacity:0;s:500;""><img src=""/img/slides/slide-title-border.png"" alt=""Border""></div>
                                <div class=""tp-caption""
      ");
            WriteLiteral(@"                               data-x=""center""
                                     data-y=""285""
                                     data-start=""1500""
                                     data-transform_in=""y:[100%];opacity:0;s:500;"" style=""font-size: 23px; line-height:1; font-weight:300; color: #fff;"">Mua nông sản chất lượng cao.</div>
                                <div class=""tp-caption""
                                     data-x=""center"" data-hoffset=""220""
                                     data-y=""293""
                                     data-start=""1200""
                                     data-transform_in=""x:[300%];opacity:0;s:500;""><img src=""/img/slides/slide-title-border.png"" alt=""Border""></div>
                            </li>
                            <li data-transition=""fade"">
                                ");
            EndContext();
            BeginContext(2754, 333, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4826a8be836a4446a114a561aabf2a2d", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3087, 2677, true);
            WriteLiteral(@"
                                <div class=""tp-caption""
                                     data-x=""480""
                                     data-y=""130""
                                     data-start=""500""
                                     data-whitespace=""nowrap""
                                     data-transform_in=""y:[100%];s:500;""
                                     data-transform_out=""opacity:0;s:500;""
                                     style=""z-index: 5; font-size: 26px; font-weight:300; line-height:1.5; color: #fff;""
                                     data-mask_in=""x:0px;y:0px;"">Ưu đãi đến <span style=""font-weight: 600;"">50%</span></div>
                                <div class=""tp-caption""
                                     data-x=""475""
                                     data-y=""164""
                                     data-start=""900""
                                     data-whitespace=""nowrap""
                                     data-transform_in=""y:[100%];s:500;""
            ");
            WriteLiteral(@"                         data-transform_out=""opacity:0;s:500;""
                                     style=""z-index: 5; font-size: 82px; text-transform: uppercase; font-weight:600; line-height:1;color: #fff;""
                                     data-mask_in=""x:0px;y:0px;"">Huge<span style=""font-weight: 800;"">Sale</span></div>
                                <div class=""tp-caption tp-resizeme""
                                     data-x=""480""
                                     data-y=""256""
                                     data-start=""1300""
                                     style=""z-index: 5; font-size: 18px; font-weight: 600; line-height:1;color: #fff;""
                                     data-transform_in=""y:[100%];opacity:0;s:500;"">Hạt<span style=""margin-left:13px;margin-right:13px;"">-</span>Rau củ tươi<span style=""margin-left:13px;margin-right:13px;"">-</span>Trái cây nhập khẩu<span style=""margin-left:13px;margin-right:13px;"">-</span>Trái cây trong nước</div>
                                <div cla");
            WriteLiteral(@"ss=""tp-caption tp-resizeme""
                                     data-x=""784""
                                     data-y=""300""
                                     data-start=""1800""
                                     style=""z-index: 5; font-size: 16px; font-weight: 300; line-height:1;""
                                     data-transform_in=""y:[100%];opacity:0;s:500;""><a href=""#"" class=""btn btn-default"" style=""border:none; font-weight: 600; padding-top: 10px; padding-bottom:10px;"">MUA NGAY</a></div>
                            </li>
                            <li data-transition=""fade"">
                                ");
            EndContext();
            BeginContext(5764, 333, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c9b4a039893a49019343a33eb666fa51", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6097, 3695, true);
            WriteLiteral(@"
                                <div class=""tp-caption""
                                     data-x=""170""
                                     data-y=""180""
                                     data-start=""500""
                                     data-whitespace=""nowrap""
                                     data-transform_in=""y:[100%];s:500;""
                                     data-transform_out=""opacity:0;s:500;""
                                     style=""z-index: 5; font-size: 26px; font-weight:300; line-height:1; color: #fff;""
                                     data-mask_in=""x:0px;y:0px;"">Hàng đạt tiêu chuẩn cao</div>
                                <div class=""tp-caption""
                                     data-x=""170""
                                     data-y=""214""
                                     data-start=""900""
                                     data-whitespace=""nowrap""
                                     data-transform_in=""y:[100%];s:500;""
                                     data-tr");
            WriteLiteral(@"ansform_out=""opacity:0;s:500;""
                                     style=""z-index: 5; font-size: 82px; text-transform: uppercase; font-weight:600; line-height:1;color: #fff;""
                                     data-mask_in=""x:0px;y:0px;"">Mua<span style=""font-weight: 800;""> Ngay</span></div>
                                <div class=""tp-caption tp-resizeme""
                                     data-x=""508""
                                     data-y=""308""
                                     data-start=""1300""
                                     style=""z-index: 5; font-size: 16px; font-weight: 300; line-height:1;""
                                     data-transform_in=""y:[100%];opacity:0;s:500;""><a href=""#"" class=""btn btn-default"" style=""border:none; font-weight: 600; padding-top: 10px; padding-bottom:10px;"">Tìm kiếm</a></div>
                            </li>
                        </ul>
                    </div>
                </div>
            </div>
            <div class=""container"">
             ");
            WriteLiteral(@"   <div class=""homepage-bar"">
                    <div class=""row"">
                        <div class=""col-md-4"">
                            <i class=""fa fa-truck bar-icon""></i>
                            <div class=""bar-textarea"">
                                <h3>MIỄN PHÍ GIAO HÀNG & NHANH CHÓNG</h3>
                                <p> Miễn phí giao hàng vơi tất cả đơn hàng trên 30$.</p>
                            </div>
                        </div>
                        <div class=""col-md-4"">
                            <i class=""fa fa-support bar-icon""></i>
                            <div class=""bar-textarea"">
                                <h3>MUA HÀNG DỄ DÀNG</h3>
                                <p>Mua trực tiếp trên nền tảng thương mại điện tử.</p>
                            </div>
                        </div>
                        <div class=""col-md-4"">
                            <i class=""fa fa-dollar bar-icon""></i>
                            <div class=""bar-textarea"">
            ");
            WriteLiteral(@"                    <h3>THANH TOÁN AN TOÀN</h3>
                                <p>Có thể  thanh toán trực tiếp khi nhận được hàng.</p>
                             </div>
                        </div>

                    </div>
                </div>
            </div>
            <div class=""home-products-seciton"">
                <div class=""container"">
                    <div class=""row"">
                        <div class=""col-md-9 col-lg-9 col-md-push-3 col-lg-push-3"">
                            <h2 class=""slider-title"">SẢN PHẨM NỔI BẬT</h2>
                            <ul class=""products-grid columns4"">
");
            EndContext();
#line 152 "D:\Vuong\TCVEcommerce\TCV\TCVWeb\Views\Home\Index.cshtml"
                                 foreach (var item in Model.Content)
                                {


#line default
#line hidden
            BeginContext(9898, 204, true);
            WriteLiteral("                            <li>\r\n                                <div class=\"product\">\r\n                                    <figure class=\"product-image-area\">\r\n                                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 10102, "\"", 10161, 1);
#line 158 "D:\Vuong\TCVEcommerce\TCV\TCVWeb\Views\Home\Index.cshtml"
WriteAttributeValue("", 10109, Url.Action("Detail","Product",new { id = item.Id }), 10109, 52, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 10162, "\"", 10180, 1);
#line 158 "D:\Vuong\TCVEcommerce\TCV\TCVWeb\Views\Home\Index.cshtml"
WriteAttributeValue("", 10170, item.Name, 10170, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(10181, 73, true);
            WriteLiteral(" class=\"product-image\">\r\n                                            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 10254, "\"", 10271, 1);
#line 159 "D:\Vuong\TCVEcommerce\TCV\TCVWeb\Views\Home\Index.cshtml"
WriteAttributeValue("", 10260, item.Image, 10260, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(10272, 103, true);
            WriteLiteral(" alt=\"Product Name\" style=\"width:100%; height:200px\">\r\n                                            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 10375, "\"", 10394, 1);
#line 160 "D:\Vuong\TCVEcommerce\TCV\TCVWeb\Views\Home\Index.cshtml"
WriteAttributeValue("", 10381, item.Preview, 10381, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(10395, 406, true);
            WriteLiteral(@" alt=""Product Name"" class=""product-hover-image"" style=""width:100%; height:200px"">
                                        </a>
                                        <a href=""#"" class=""product-quickview"">
                                            <i class=""fa fa-share-square-o""></i>
                                            <span>Quick View</span>
                                        </a>

");
            EndContext();
#line 167 "D:\Vuong\TCVEcommerce\TCV\TCVWeb\Views\Home\Index.cshtml"
                                         if (item.SalePrice != item.RegularPrice) {

#line default
#line hidden
            BeginContext(10885, 108, true);
            WriteLiteral("                                        <div class=\"product-label\"><span class=\"discount\">-10%</span></div>\n");
            EndContext();
#line 169 "D:\Vuong\TCVEcommerce\TCV\TCVWeb\Views\Home\Index.cshtml"
                                        }

#line default
#line hidden
            BeginContext(11035, 40, true);
            WriteLiteral("                                        ");
            EndContext();
#line 170 "D:\Vuong\TCVEcommerce\TCV\TCVWeb\Views\Home\Index.cshtml"
                                         if (item.NewProduct)
                                        {

#line default
#line hidden
            BeginContext(11139, 106, true);
            WriteLiteral("                                            <div class=\"product-label\"><span class=\"new\">New</span></div>\n");
            EndContext();
#line 173 "D:\Vuong\TCVEcommerce\TCV\TCVWeb\Views\Home\Index.cshtml"
                                        }

#line default
#line hidden
            BeginContext(11287, 770, true);
            WriteLiteral(@"

                                        <div class=""product-actions"">
                                            <a href=""#"" class=""addtowishlist"" title=""Add to Wishlist"">
                                                <i class=""fa fa-heart""></i>
                                            </a>
                                            <a href=""#"" class=""addtocart"" title=""Add to Cart"">
                                                <i class=""fa fa-shopping-cart""></i>
                                            </a>
                                        </div>
                                    </figure>
                                    <div class=""product-details-area"">
                                        <h2 class=""product-name""><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 12057, "\"", 12116, 1);
#line 186 "D:\Vuong\TCVEcommerce\TCV\TCVWeb\Views\Home\Index.cshtml"
WriteAttributeValue("", 12064, Url.Action("Detail","Product",new { id = item.Id }), 12064, 52, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 12117, "\"", 12135, 1);
#line 186 "D:\Vuong\TCVEcommerce\TCV\TCVWeb\Views\Home\Index.cshtml"
WriteAttributeValue("", 12125, item.Name, 12125, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(12136, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(12138, 9, false);
#line 186 "D:\Vuong\TCVEcommerce\TCV\TCVWeb\Views\Home\Index.cshtml"
                                                                                                                                              Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(12147, 419, true);
            WriteLiteral(@"</a></h2>
                                        <div class=""product-ratings"">
                                            <div class=""ratings-box"">
                                                <div class=""rating"" style=""width:60%""></div>
                                            </div>
                                        </div>
                                        <div class=""product-price-box"">
");
            EndContext();
#line 193 "D:\Vuong\TCVEcommerce\TCV\TCVWeb\Views\Home\Index.cshtml"
                                             if (item.SalePrice != item.RegularPrice) {

#line default
#line hidden
            BeginContext(12654, 68, true);
            WriteLiteral("                                            <span class=\"old-price\">");
            EndContext();
            BeginContext(12723, 17, false);
#line 194 "D:\Vuong\TCVEcommerce\TCV\TCVWeb\Views\Home\Index.cshtml"
                                                               Write(item.RegularPrice);

#line default
#line hidden
            EndContext();
            BeginContext(12740, 8, true);
            WriteLiteral("</span>\n");
            EndContext();
#line 195 "D:\Vuong\TCVEcommerce\TCV\TCVWeb\Views\Home\Index.cshtml"
                                            }

#line default
#line hidden
            BeginContext(12794, 74, true);
            WriteLiteral("\r\n                                            <span class=\"product-price\">");
            EndContext();
            BeginContext(12869, 17, false);
#line 197 "D:\Vuong\TCVEcommerce\TCV\TCVWeb\Views\Home\Index.cshtml"
                                                                   Write(item.CurrentPrice);

#line default
#line hidden
            EndContext();
            BeginContext(12886, 176, true);
            WriteLiteral("</span>\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n                            </li>\r\n");
            EndContext();
#line 202 "D:\Vuong\TCVEcommerce\TCV\TCVWeb\Views\Home\Index.cshtml"
                                }

#line default
#line hidden
            BeginContext(13097, 382, true);
            WriteLiteral(@"                            </ul>
                        </div>
                        <aside class=""col-md-3 col-lg-3 col-md-pull-9 col-lg-pull-9 sidebar home-sidebar shop-sidebar"">
                            <div class=""side-block"">
                                <h4><i class=""fa fa-bars""></i>DANH MỤC SẢN PHẨM</h4>
                                <ul class=""category-list"">
");
            EndContext();
#line 209 "D:\Vuong\TCVEcommerce\TCV\TCVWeb\Views\Home\Index.cshtml"
                                     for(var i = 0; i < categories.Length; i++)
                                    {

#line default
#line hidden
            BeginContext(13597, 83, true);
            WriteLiteral("                                    <li>\n                                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 13680, "\"", 13734, 1);
#line 212 "D:\Vuong\TCVEcommerce\TCV\TCVWeb\Views\Home\Index.cshtml"
WriteAttributeValue("", 13687, Url.Action("Category","Product", new { id =i}), 13687, 47, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(13735, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(13737, 13, false);
#line 212 "D:\Vuong\TCVEcommerce\TCV\TCVWeb\Views\Home\Index.cshtml"
                                                                                             Write(categories[i]);

#line default
#line hidden
            EndContext();
            BeginContext(13750, 47, true);
            WriteLiteral("</a>\n                                    </li>\n");
            EndContext();
#line 214 "D:\Vuong\TCVEcommerce\TCV\TCVWeb\Views\Home\Index.cshtml"
                                    }

#line default
#line hidden
            BeginContext(13835, 447, true);
            WriteLiteral(@"                                </ul>
                            </div>
                            <div class=""side-block side-feature"">
                                <h4><i class=""fa fa-star""></i>DỊCH VỤ TẬN NƠI</h4>
                                <p>
                                    Tham khảo chính sách vận chuyển của chúng tôi để được trợ giúp về đơn đặt hàng.
                                </p>
                                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 14282, "\"", 14318, 1);
#line 222 "D:\Vuong\TCVEcommerce\TCV\TCVWeb\Views\Home\Index.cshtml"
WriteAttributeValue("", 14289, Url.Action("Privacy","Home"), 14289, 29, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(14319, 374, true);
            WriteLiteral(@">Chính sách vận chuyển></a>
                            </div>
                            <div class=""side-block side-feature"">
                                <h4><i class=""fa fa-reply""></i>ĐỔI TRẢ MIỄN PHÍ</h4>
                                <p>Chúng tôi đứng đằng sau hàng hóa và dịch vụ của chúng tôi và muốn bạn hài lòng với họ.</p>
                                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 14693, "\"", 14729, 1);
#line 227 "D:\Vuong\TCVEcommerce\TCV\TCVWeb\Views\Home\Index.cshtml"
WriteAttributeValue("", 14700, Url.Action("Privacy","Home"), 14700, 29, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(14730, 460, true);
            WriteLiteral(@">Chính sách đổi trả ></a>
                            </div>
                        </aside>
                    </div>
                </div>
            </div>
            <div class=""container mb-xs"">
                <h2 class=""slider-title"">
                    <span class=""inline-title"">THƯƠNG HIỆU</span>
                    <span class=""line""></span>
                </h2>
                <div class=""owl-carousel owl-theme manual clients-carousel"">
");
            EndContext();
#line 239 "D:\Vuong\TCVEcommerce\TCV\TCVWeb\Views\Home\Index.cshtml"
                     foreach (var brand in brands)
                {

#line default
#line hidden
            BeginContext(15261, 27, true);
            WriteLiteral("                <a href=\"#\"");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 15288, "\"", 15307, 1);
#line 241 "D:\Vuong\TCVEcommerce\TCV\TCVWeb\Views\Home\Index.cshtml"
WriteAttributeValue("", 15296, brand.Name, 15296, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(15308, 65, true);
            WriteLiteral(" class=\"client\">\r\n                    <img class=\"img-responsive\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 15373, "\"", 15393, 1);
#line 242 "D:\Vuong\TCVEcommerce\TCV\TCVWeb\Views\Home\Index.cshtml"
WriteAttributeValue("", 15379, brand.Address, 15379, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(15394, 59, true);
            WriteLiteral(" alt=\"Brand\", style=\"height:120px\">\r\n                </a>\r\n");
            EndContext();
#line 244 "D:\Vuong\TCVEcommerce\TCV\TCVWeb\Views\Home\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(15472, 361, true);
            WriteLiteral(@"                </div>
            </div>
            <div class=""container mb-sm"">
                <h2 class=""slider-title"">
                    <span class=""inline-title"">SẢN PHẨM MỚI</span>
                    <span class=""line""></span>
                </h2>
                <div class=""owl-carousel owl-theme manual new-products-carousel hide-addtolinks"">
");
            EndContext();
#line 253 "D:\Vuong\TCVEcommerce\TCV\TCVWeb\Views\Home\Index.cshtml"
                     foreach (var item in Model.Content)
                    {


#line default
#line hidden
            BeginContext(15915, 122, true);
            WriteLiteral("                <div class=\"product\">\r\n                    <figure class=\"product-image-area\">\r\n                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 16037, "\"", 16096, 1);
#line 258 "D:\Vuong\TCVEcommerce\TCV\TCVWeb\Views\Home\Index.cshtml"
WriteAttributeValue("", 16044, Url.Action("Detail","Product",new { id = item.Id }), 16044, 52, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 16097, "\"", 16115, 1);
#line 258 "D:\Vuong\TCVEcommerce\TCV\TCVWeb\Views\Home\Index.cshtml"
WriteAttributeValue("", 16105, item.Name, 16105, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(16116, 57, true);
            WriteLiteral(" class=\"product-image\">\r\n                            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 16173, "\"", 16190, 1);
#line 259 "D:\Vuong\TCVEcommerce\TCV\TCVWeb\Views\Home\Index.cshtml"
WriteAttributeValue("", 16179, item.Image, 16179, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(16191, 523, true);
            WriteLiteral(@" alt=""Product Name"" style=""width:100%; height:200px"">
                        </a>
                        <a href=""#"" class=""product-quickview"">
                            <i class=""fa fa-share-square-o""></i>
                            <span>Quick View</span>
                        </a>
                        <div class=""product-label""><span class=""new"">New</span></div>

                    </figure>
                    <div class=""product-details-area"">
                        <h2 class=""product-name""><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 16714, "\"", 16773, 1);
#line 269 "D:\Vuong\TCVEcommerce\TCV\TCVWeb\Views\Home\Index.cshtml"
WriteAttributeValue("", 16721, Url.Action("Detail","Product",new { id = item.Id }), 16721, 52, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 16774, "\"", 16792, 1);
#line 269 "D:\Vuong\TCVEcommerce\TCV\TCVWeb\Views\Home\Index.cshtml"
WriteAttributeValue("", 16782, item.Name, 16782, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(16793, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(16795, 9, false);
#line 269 "D:\Vuong\TCVEcommerce\TCV\TCVWeb\Views\Home\Index.cshtml"
                                                                                                                              Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(16804, 380, true);
            WriteLiteral(@"</a></h2>
                        <div class=""product-ratings"">
                            <div class=""ratings-box"">
                                <div class=""rating"" style=""width:60%""></div>
                            </div>
                        </div>
                        <div class=""product-price-box"">
                            <span class=""product-price"">");
            EndContext();
            BeginContext(17185, 17, false);
#line 276 "D:\Vuong\TCVEcommerce\TCV\TCVWeb\Views\Home\Index.cshtml"
                                                   Write(item.CurrentPrice);

#line default
#line hidden
            EndContext();
            BeginContext(17202, 93, true);
            WriteLiteral("</span>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
            EndContext();
#line 280 "D:\Vuong\TCVEcommerce\TCV\TCVWeb\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(17318, 389, true);
            WriteLiteral(@"
                </div>
            </div>


            <div class=""newsletter-popup mfp-hide"" id=""newsletter-popup-form"" style=""background-image: url(/img/demos/shop/newsletter_popup_bg.jpg)"">
                <div class=""newsletter-popup-content"">
                </div><!-- End .newsletter-popup-content -->
            </div><!-- End .newsletter-popup -->
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PagedList<ShopItem>> Html { get; private set; }
    }
}
#pragma warning restore 1591
