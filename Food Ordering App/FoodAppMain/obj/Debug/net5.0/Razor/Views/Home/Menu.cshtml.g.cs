#pragma checksum "E:\dotnet\Food Ordering App\FoodAppMain\Views\Home\Menu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6de756ac8c41e288849565366a2cd8ccb1da54d6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Menu), @"mvc.1.0.view", @"/Views/Home/Menu.cshtml")]
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
#line 1 "E:\dotnet\Food Ordering App\FoodAppMain\Views\_ViewImports.cshtml"
using FoodAppMain;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\dotnet\Food Ordering App\FoodAppMain\Views\_ViewImports.cshtml"
using FoodAppMain.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6de756ac8c41e288849565366a2cd8ccb1da54d6", @"/Views/Home/Menu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e3c35c50b24a2132e40c3b7bf976c241198dfe4d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Menu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FoodAppEntity.Entities.Menu>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-responsive"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jquery.easing.1.3.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/bootstrap.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jquery.waypoints.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jquery.stellar.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jquery.flexslider-min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/main.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\dotnet\Food Ordering App\FoodAppMain\Views\Home\Menu.cshtml"
  
    var PageNo = ViewBag.PageNumber;
    var totalPages = ViewBag.TotalPages;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""fh5co-loader""></div>

<div id=""page"">
    <header id=""fh5co-header"" class=""fh5co-cover js-fullheight"" role=""banner"" style=""background-image: url(~/wwwroot/images/hero_1.jpg);"" data-stellar-background-ratio=""0.5"">
        <div class=""overlay""></div>
        <div class=""container"">
            <div class=""row"">
                <div class=""col-md-12 text-center"">
                    <div class=""display-t js-fullheight"">
                        <div class=""display-tc js-fullheight animate-box"" data-animate-effect=""fadeIn"">
                            <h1>See <em>Our</em> Menu</h1>
                            <h2>Brought to you by <a href=""http://freehtml5.co/"" target=""_blank"">freehtml5.co</a></h2>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </header>

    <div id=""fh5co-featured-menu"" class=""fh5co-section"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-md-12 ");
            WriteLiteral(@"fh5co-heading animate-box"">
                    <h2>Our Delicous Menu</h2>
                    <div class=""row"">
                        <div class=""col-md-6"">
                            <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Reiciendis ab debitis sit itaque totam, a maiores nihil, nulla magnam porro minima officiis! Doloribus aliquam voluptates corporis et tempora consequuntur ipsam, itaque, nesciunt similique commodi omnis. Ad magni perspiciatis, voluptatum repellat.</p>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""row"">
");
#nullable restore
#line 38 "E:\dotnet\Food Ordering App\FoodAppMain\Views\Home\Menu.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-md-3 margin-set\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6de756ac8c41e288849565366a2cd8ccb1da54d68376", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 41 "E:\dotnet\Food Ordering App\FoodAppMain\Views\Home\Menu.cshtml"
                                              WriteLiteral("~/MenuImage/" + item.ItemImage);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 41 "E:\dotnet\Food Ordering App\FoodAppMain\Views\Home\Menu.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        <h3 class=\"color-white margin-set\">");
#nullable restore
#line 42 "E:\dotnet\Food Ordering App\FoodAppMain\Views\Home\Menu.cshtml"
                                                      Write(Html.DisplayFor(modelItem => item.ItemName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                        <span class=\"fh5co-price color-white\">$");
#nullable restore
#line 43 "E:\dotnet\Food Ordering App\FoodAppMain\Views\Home\Menu.cshtml"
                                                          Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        <p class=\"margin-set\">");
#nullable restore
#line 44 "E:\dotnet\Food Ordering App\FoodAppMain\Views\Home\Menu.cshtml"
                                         Write(Html.DisplayFor(modelItem => item.ItemDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <button class=\"btn btn-primary btn-outline\">");
#nullable restore
#line 45 "E:\dotnet\Food Ordering App\FoodAppMain\Views\Home\Menu.cshtml"
                                                               Write(Html.ActionLink("Order Now", "OrderView", new { menuId = item.MenuId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n                    </div>\r\n");
#nullable restore
#line 47 "E:\dotnet\Food Ordering App\FoodAppMain\Views\Home\Menu.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n");
            WriteLiteral("                <ul class=\"pagination justify-content-center\">\r\n");
#nullable restore
#line 51 "E:\dotnet\Food Ordering App\FoodAppMain\Views\Home\Menu.cshtml"
                     if (PageNo == 1)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li class=\"disabled p-2\">\r\n                            ");
#nullable restore
#line 54 "E:\dotnet\Food Ordering App\FoodAppMain\Views\Home\Menu.cshtml"
                       Write(Html.ActionLink("Previous", "Menu", new { PageNumber = PageNo }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </li>\r\n");
#nullable restore
#line 56 "E:\dotnet\Food Ordering App\FoodAppMain\Views\Home\Menu.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li class=\"p-2\">\r\n                            ");
#nullable restore
#line 60 "E:\dotnet\Food Ordering App\FoodAppMain\Views\Home\Menu.cshtml"
                       Write(Html.ActionLink("Previous", "Menu", new { PageNumber = PageNo - 1 }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </li>\r\n");
#nullable restore
#line 62 "E:\dotnet\Food Ordering App\FoodAppMain\Views\Home\Menu.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 63 "E:\dotnet\Food Ordering App\FoodAppMain\Views\Home\Menu.cshtml"
                     for (int i = 1; i <= totalPages; i++)
                    {
                        if (i == PageNo)  // to show active page number-- Not working RN
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li class=\"active p-2\">\r\n                                ");
#nullable restore
#line 68 "E:\dotnet\Food Ordering App\FoodAppMain\Views\Home\Menu.cshtml"
                           Write(Html.ActionLink(i.ToString(), "Menu", new { PageNumber = i }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </li>\r\n");
#nullable restore
#line 70 "E:\dotnet\Food Ordering App\FoodAppMain\Views\Home\Menu.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li class=\"p-2\">\r\n                                ");
#nullable restore
#line 74 "E:\dotnet\Food Ordering App\FoodAppMain\Views\Home\Menu.cshtml"
                           Write(Html.ActionLink(i.ToString(), "Menu", new { PageNumber = i }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </li>\r\n");
#nullable restore
#line 76 "E:\dotnet\Food Ordering App\FoodAppMain\Views\Home\Menu.cshtml"
                        }
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 78 "E:\dotnet\Food Ordering App\FoodAppMain\Views\Home\Menu.cshtml"
                     if (PageNo == totalPages)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li class=\"disabled p-2\">\r\n                            ");
#nullable restore
#line 81 "E:\dotnet\Food Ordering App\FoodAppMain\Views\Home\Menu.cshtml"
                       Write(Html.ActionLink("Next", "Menu", new { PageNumber = PageNo }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </li>\r\n");
#nullable restore
#line 83 "E:\dotnet\Food Ordering App\FoodAppMain\Views\Home\Menu.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li class=\"p-2\">\r\n                            ");
#nullable restore
#line 87 "E:\dotnet\Food Ordering App\FoodAppMain\Views\Home\Menu.cshtml"
                       Write(Html.ActionLink("Next", "Menu", new { PageNumber = PageNo + 1 }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </li>\r\n");
#nullable restore
#line 89 "E:\dotnet\Food Ordering App\FoodAppMain\Views\Home\Menu.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </ul>\r\n");
            WriteLiteral(@"        </div>
    </div>
</div>


<div id=""fh5co-featured-testimony"" class=""fh5co-section"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-12 fh5co-heading animate-box"">
                <h2>Testimony</h2>
                <div class=""row"">
                    <div class=""col-md-6"">
                        <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Reiciendis ab debitis sit itaque totam, a maiores nihil, nulla magnam porro minima officiis! Doloribus aliquam voluptates corporis et tempora consequuntur ipsam, itaque, nesciunt similique commodi omnis.</p>
                    </div>
                </div>
            </div>

            <div class=""col-md-5 animate-box img-to-responsive"">
                <img src=""images/person_1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 5227, "\"", 5233, 0);
            EndWriteAttribute();
            WriteLiteral(@">
            </div>
            <div class=""col-md-7 animate-box"">
                <blockquote>
                    <p> &ldquo; Quantum ipsum dolor sit amet, consectetur adipisicing elit. Reiciendis ab debitis sit itaque totam, a maiores nihil, nulla magnam porro minima officiis! Doloribus aliquam voluptates corporis et tempora consequuntur ipsam. &rdquo;</p>
                    <p class=""author""><cite>&mdash; Jane Smith</cite></p>
                </blockquote>
            </div>
        </div>
    </div>
</div>


<div id=""fh5co-started"" class=""fh5co-section animate-box"" style=""background-image: url(images/hero_1.jpeg);"" data-stellar-background-ratio=""0.5"">
    <div class=""overlay""></div>
    <div class=""container"">
        <div class=""row animate-box"">
            <div class=""col-md-8 col-md-offset-2 text-center fh5co-heading"">
                <h2>Book a Table</h2>
                <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Recusandae enim quae vitae cupiditate, sequi qua");
            WriteLiteral(@"m ea id dolor reiciendis consectetur repudiandae. Rem quam, repellendus veniam ipsa fuga maxime odio? Eaque!</p>
                <p><a href=""reservation.html"" class=""btn btn-primary btn-outline"">Book Now</a></p>
            </div>
        </div>
    </div>
</div>

<div class=""gototop js-top"">
    <a href=""#"" class=""js-gotop""><i class=""icon-arrow-up22""></i></a>
</div>

<!-- jQuery -->
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6de756ac8c41e288849565366a2cd8ccb1da54d619317", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<!-- jQuery Easing -->\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6de756ac8c41e288849565366a2cd8ccb1da54d620383", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<!-- Bootstrap -->\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6de756ac8c41e288849565366a2cd8ccb1da54d621445", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<!-- Waypoints -->\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6de756ac8c41e288849565366a2cd8ccb1da54d622507", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<!-- Waypoints -->\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6de756ac8c41e288849565366a2cd8ccb1da54d623569", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<!-- Flexslider -->\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6de756ac8c41e288849565366a2cd8ccb1da54d624632", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<!-- Main -->\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6de756ac8c41e288849565366a2cd8ccb1da54d625689", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<FoodAppEntity.Entities.Menu>> Html { get; private set; }
    }
}
#pragma warning restore 1591
