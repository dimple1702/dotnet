#pragma checksum "E:\dotnet\Food Ordering App\FoodAppMain\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "579397f623816516eb820d08fba353c08c1f3f71"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"579397f623816516eb820d08fba353c08c1f3f71", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e3c35c50b24a2132e40c3b7bf976c241198dfe4d", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/animate.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/icomoon.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/bootstrap.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/flexslider.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/CustomStyleSheet.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/modernizr-2.6.2.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "579397f623816516eb820d08fba353c08c1f3f716245", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <title>Food Ordering App</title>
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <meta name=""description"" content=""Free HTML5 Website Template by freehtml5.co"" />
    <meta name=""keywords"" content=""free website templates, free html5, free template, free bootstrap, free website template, html5, css3, mobile first, responsive"" />
    <meta name=""author"" content=""freehtml5.co"" />


    <!-- Facebook and Twitter integration -->
    <meta property=""og:title""");
                BeginWriteAttribute("content", " content=\"", 628, "\"", 638, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <meta property=\"og:image\"");
                BeginWriteAttribute("content", " content=\"", 673, "\"", 683, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <meta property=\"og:url\"");
                BeginWriteAttribute("content", " content=\"", 716, "\"", 726, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <meta property=\"og:site_name\"");
                BeginWriteAttribute("content", " content=\"", 765, "\"", 775, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <meta property=\"og:description\"");
                BeginWriteAttribute("content", " content=\"", 816, "\"", 826, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <meta name=\"twitter:title\"");
                BeginWriteAttribute("content", " content=\"", 862, "\"", 872, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <meta name=\"twitter:image\"");
                BeginWriteAttribute("content", " content=\"", 908, "\"", 918, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <meta name=\"twitter:url\"");
                BeginWriteAttribute("content", " content=\"", 952, "\"", 962, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <meta name=\"twitter:card\"");
                BeginWriteAttribute("content", " content=\"", 997, "\"", 1007, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n\r\n    <link href=\"https://fonts.googleapis.com/css?family=Cormorant+Garamond:300,300i,400,400i,500,600i,700\" rel=\"stylesheet\">\r\n    <link href=\"https://fonts.googleapis.com/css?family=Satisfy\" rel=\"stylesheet\">\r\n\r\n    <!-- Animate.css -->\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "579397f623816516eb820d08fba353c08c1f3f719098", async() => {
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
                WriteLiteral("\r\n    <!-- Icomoon Icon Fonts-->\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "579397f623816516eb820d08fba353c08c1f3f7110310", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <!-- Bootstrap  -->\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "579397f623816516eb820d08fba353c08c1f3f7111516", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <!-- Flexslider  -->\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "579397f623816516eb820d08fba353c08c1f3f7112723", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <!--Custom Style Sheet-->\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "579397f623816516eb820d08fba353c08c1f3f7113936", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <!-- Theme style  -->\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "579397f623816516eb820d08fba353c08c1f3f7115144", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n    <!-- Modernizr JS -->\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "579397f623816516eb820d08fba353c08c1f3f7116357", async() => {
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
                WriteLiteral("\r\n    <!-- FOR IE9 below -->\r\n    <!--[if lt IE 9]>\r\n    <script src=\"js/respond.min.js\"></script>\r\n    <![endif]-->\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "579397f623816516eb820d08fba353c08c1f3f7118287", async() => {
                WriteLiteral(@"
    <nav class=""fh5co-nav"" role=""navigation"">
        <!-- <div class=""top-menu""> -->
        <div class=""container"">
            <div class=""row"">
                <div class=""col-xs-12 text-center logo-wrap"">
                    <div id=""fh5co-logo"">");
#nullable restore
#line 53 "E:\dotnet\Food Ordering App\FoodAppMain\Views\Shared\_Layout.cshtml"
                                    Write(Html.ActionLink("Tasty", "Index", "Home"));

#line default
#line hidden
#nullable disable
                WriteLiteral("<span>.</span></div>\r\n                </div>\r\n                <div class=\"col-xs-12 text-center menu-1 menu-wrap\">\r\n                    <ul>\r\n                        <li");
                BeginWriteAttribute("class", " class=\"", 2424, "\"", 2478, 1);
#nullable restore
#line 57 "E:\dotnet\Food Ordering App\FoodAppMain\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2432, ViewBag.Selected == "Index" ? "active" : "", 2432, 46, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                            ");
#nullable restore
#line 58 "E:\dotnet\Food Ordering App\FoodAppMain\Views\Shared\_Layout.cshtml"
                       Write(Html.ActionLink("Home", "Index", "Home"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </li>\r\n                        <li");
                BeginWriteAttribute("class", " class=\"", 2611, "\"", 2664, 1);
#nullable restore
#line 60 "E:\dotnet\Food Ordering App\FoodAppMain\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2619, ViewBag.Selected == "Menu" ? "active" : "", 2619, 45, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                            ");
#nullable restore
#line 61 "E:\dotnet\Food Ordering App\FoodAppMain\Views\Shared\_Layout.cshtml"
                       Write(Html.ActionLink("Menu", "Menu", "Home"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </li>\r\n                        <li");
                BeginWriteAttribute("class", " class=\"", 2796, "\"", 2877, 1);
#nullable restore
#line 63 "E:\dotnet\Food Ordering App\FoodAppMain\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2804, ViewBag.Selected == "Gallery" ? "active has-dropdown" : "has-dropdown", 2804, 73, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                            ");
#nullable restore
#line 64 "E:\dotnet\Food Ordering App\FoodAppMain\Views\Shared\_Layout.cshtml"
                       Write(Html.ActionLink("Gallery", "Gallery", "Home"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                            <ul class=""dropdown"">
                                <li><a href=""#"">Events</a></li>
                                <li><a href=""#"">Food</a></li>
                                <li><a href=""#"">Coffees</a></li>
                            </ul>
                        </li>
                        <li");
                BeginWriteAttribute("class", " class=\"", 3295, "\"", 3355, 1);
#nullable restore
#line 71 "E:\dotnet\Food Ordering App\FoodAppMain\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 3303, ViewBag.Selected == "Reservation" ? "active" : "", 3303, 52, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                            ");
#nullable restore
#line 72 "E:\dotnet\Food Ordering App\FoodAppMain\Views\Shared\_Layout.cshtml"
                       Write(Html.ActionLink("Reservation", "Reservation", "Home"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </li>\r\n                        <li");
                BeginWriteAttribute("class", " class=\"", 3501, "\"", 3555, 1);
#nullable restore
#line 74 "E:\dotnet\Food Ordering App\FoodAppMain\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 3509, ViewBag.Selected == "About" ? "active" : "", 3509, 46, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                            ");
#nullable restore
#line 75 "E:\dotnet\Food Ordering App\FoodAppMain\Views\Shared\_Layout.cshtml"
                       Write(Html.ActionLink("About", "About", "Home"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </li>\r\n                        <li");
                BeginWriteAttribute("class", " class=\"", 3689, "\"", 3745, 1);
#nullable restore
#line 77 "E:\dotnet\Food Ordering App\FoodAppMain\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 3697, ViewBag.Selected == "Contact" ? "active" : "", 3697, 48, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                            ");
#nullable restore
#line 78 "E:\dotnet\Food Ordering App\FoodAppMain\Views\Shared\_Layout.cshtml"
                       Write(Html.ActionLink("Contact", "Contact", "Home"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </li>\r\n                        <li");
                BeginWriteAttribute("class", " class=\"", 3883, "\"", 3938, 1);
#nullable restore
#line 80 "E:\dotnet\Food Ordering App\FoodAppMain\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 3891, ViewBag.Selected == "Logout" ? "active" : "", 3891, 47, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                            ");
#nullable restore
#line 81 "E:\dotnet\Food Ordering App\FoodAppMain\Views\Shared\_Layout.cshtml"
                       Write(Html.ActionLink("Logout", "Logout", "Account"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </li>\r\n                    </ul>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </nav>\r\n    ");
#nullable restore
#line 88 "E:\dotnet\Food Ordering App\FoodAppMain\Views\Shared\_Layout.cshtml"
Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
#nullable restore
#line 89 "E:\dotnet\Food Ordering App\FoodAppMain\Views\Shared\_Layout.cshtml"
Write(RenderSection("Scripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
    <footer id=""fh5co-footer"" role=""contentinfo"" class=""fh5co-section"">
        <div class=""container"">
            <div class=""row row-pb-md"">
                <div class=""col-md-4 fh5co-widget"">
                    <h4>Tasty</h4>
                    <p>Facilis ipsum reprehenderit nemo molestias. Aut cum mollitia reprehenderit. Eos cumque dicta adipisci architecto culpa amet.</p>
                </div>
                <div class=""col-md-2 col-md-push-1 fh5co-widget"">
                    <h4>Links</h4>
                    <ul class=""fh5co-footer-links"">
                        <li><a href=""#"">Home</a></li>
                        <li><a href=""#"">Portfolio</a></li>
                        <li><a href=""#"">Blog</a></li>
                        <li><a href=""#"">About</a></li>
                    </ul>
                </div>

                <div class=""col-md-2 col-md-push-1 fh5co-widget"">
                    <h4>Categories</h4>
                    <ul class=""fh5co-footer-links"">
             ");
                WriteLiteral(@"           <li><a href=""#"">Landing Page</a></li>
                        <li><a href=""#"">Real Estate</a></li>
                        <li><a href=""#"">Personal</a></li>
                        <li><a href=""#"">Business</a></li>
                        <li><a href=""#"">e-Commerce</a></li>
                    </ul>
                </div>

                <div class=""col-md-4 col-md-push-1 fh5co-widget"">
                    <h4>Contact Information</h4>
                    <ul class=""fh5co-footer-links"">
                        <li>198 West 21th Street, <br> Suite 721 New York NY 10016</li>
                        <li><a href=""tel://1234567920"">+ 1235 2355 98</a></li>
                        <li><a href=""mailto:info@yoursite.com"">info@yoursite.com</a></li>
                        <li><a href=""http://https://freehtml5.co"">freehtml5.co</a></li>
                    </ul>
                </div>

            </div>

            <div class=""row copyright"">
                <div class=""col-md-12 text-ce");
                WriteLiteral(@"nter"">
                    <p>
                        <small class=""block"">&copy; 2016 Free HTML5. All Rights Reserved.</small>
                        <small class=""block"">Designed by <a href=""http://freehtml5.co/"" target=""_blank"">FreeHTML5.co</a> Demo Images: <a href=""http://unsplash.co/"" target=""_blank"">Unsplash</a></small>
                    </p>
                    <p>
                        <ul class=""fh5co-social-icons"">
                            <li><a href=""#""><i class=""icon-twitter2""></i></a></li>
                            <li><a href=""#""><i class=""icon-facebook2""></i></a></li>
                            <li><a href=""#""><i class=""icon-linkedin2""></i></a></li>
                            <li><a href=""#""><i class=""icon-dribbble2""></i></a></li>
                        </ul>
                    </p>
                </div>
            </div>
        </div>
    </footer>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
