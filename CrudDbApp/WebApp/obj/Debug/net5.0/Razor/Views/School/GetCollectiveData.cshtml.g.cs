#pragma checksum "F:\CrudDbApp\WebApp\Views\School\GetCollectiveData.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2dc15931ca4484461d9883bc7e9fa33270106467"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_School_GetCollectiveData), @"mvc.1.0.view", @"/Views/School/GetCollectiveData.cshtml")]
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
#line 1 "F:\CrudDbApp\WebApp\Views\_ViewImports.cshtml"
using WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\CrudDbApp\WebApp\Views\_ViewImports.cshtml"
using WebApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "F:\CrudDbApp\WebApp\Views\School\GetCollectiveData.cshtml"
using WebAppEntities.CustomEntities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2dc15931ca4484461d9883bc7e9fa33270106467", @"/Views/School/GetCollectiveData.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc48f17eb9bac3476d8060730298bf398eb2fa5e", @"/Views/_ViewImports.cshtml")]
    public class Views_School_GetCollectiveData : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CollectiveData>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "F:\CrudDbApp\WebApp\Views\School\GetCollectiveData.cshtml"
  
    var PageNo = ViewBag.PageNumber;
    var totalPages = ViewBag.TotalPages;

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container-fluid\">\r\n    <h1 style=\"text-align:center\">Student Data</h1>\r\n    <hr />\r\n    <div class=\"row container\">\r\n");
#nullable restore
#line 11 "F:\CrudDbApp\WebApp\Views\School\GetCollectiveData.cshtml"
         using (@Html.BeginForm("GetCollectiveData", "School", FormMethod.Get))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""form-inline row"">
                <div class=""form-group"">
                    <label class=""lead""><b>Search: </b></label>
                </div>
                <div class=""col-md-6"">
                    <input type=""text"" name=""search"" class=""form-control"" style=""max-width:100%"" placeholder=""Enter your text here"" />
                </div>
                <div class=""col-md-3"">
                    <button class=""btn btn-outline-primary"" type=""submit"">Search</button>
                </div>
            </div>
");
#nullable restore
#line 24 "F:\CrudDbApp\WebApp\Views\School\GetCollectiveData.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </div>
    <hr />


    <div class=""row"">
        <div class=""col=md=12"">
            <table class=""table table-striped table-bordered"">
                <thead>
                    <tr>
                        <th>
                            ");
#nullable restore
#line 35 "F:\CrudDbApp\WebApp\Views\School\GetCollectiveData.cshtml"
                       Write(Html.DisplayNameFor(model => model.StudentFname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 38 "F:\CrudDbApp\WebApp\Views\School\GetCollectiveData.cshtml"
                       Write(Html.DisplayNameFor(model => model.StudentLname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 41 "F:\CrudDbApp\WebApp\Views\School\GetCollectiveData.cshtml"
                       Write(Html.DisplayNameFor(model => model.StudentEmail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 44 "F:\CrudDbApp\WebApp\Views\School\GetCollectiveData.cshtml"
                       Write(Html.DisplayNameFor(model => model.TeacherName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 47 "F:\CrudDbApp\WebApp\Views\School\GetCollectiveData.cshtml"
                       Write(Html.DisplayNameFor(model => model.TeacherEmail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 50 "F:\CrudDbApp\WebApp\Views\School\GetCollectiveData.cshtml"
                       Write(Html.DisplayNameFor(model => model.DeptName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 53 "F:\CrudDbApp\WebApp\Views\School\GetCollectiveData.cshtml"
                       Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n");
#nullable restore
#line 58 "F:\CrudDbApp\WebApp\Views\School\GetCollectiveData.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
#nullable restore
#line 62 "F:\CrudDbApp\WebApp\Views\School\GetCollectiveData.cshtml"
                           Write(Html.DisplayFor(modelItem => item.StudentFname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 65 "F:\CrudDbApp\WebApp\Views\School\GetCollectiveData.cshtml"
                           Write(Html.DisplayFor(modelItem => item.StudentLname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 68 "F:\CrudDbApp\WebApp\Views\School\GetCollectiveData.cshtml"
                           Write(Html.DisplayFor(modelItem => item.StudentEmail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 71 "F:\CrudDbApp\WebApp\Views\School\GetCollectiveData.cshtml"
                           Write(Html.DisplayFor(modelItem => item.TeacherName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 74 "F:\CrudDbApp\WebApp\Views\School\GetCollectiveData.cshtml"
                           Write(Html.DisplayFor(modelItem => item.TeacherEmail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 77 "F:\CrudDbApp\WebApp\Views\School\GetCollectiveData.cshtml"
                           Write(Html.DisplayFor(modelItem => item.DeptName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 80 "F:\CrudDbApp\WebApp\Views\School\GetCollectiveData.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 83 "F:\CrudDbApp\WebApp\Views\School\GetCollectiveData.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n");
            WriteLiteral("                <ul class=\"pagination d\">\r\n");
#nullable restore
#line 89 "F:\CrudDbApp\WebApp\Views\School\GetCollectiveData.cshtml"
                     if (PageNo == 1)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li class=\"disabled p-2\">\r\n                                ");
#nullable restore
#line 92 "F:\CrudDbApp\WebApp\Views\School\GetCollectiveData.cshtml"
                           Write(Html.ActionLink("Previous", "GetCollectiveData", new { search = ViewBag.Search, PageNumber = PageNo }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </li>\r\n");
#nullable restore
#line 94 "F:\CrudDbApp\WebApp\Views\School\GetCollectiveData.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li class=\"p-2\">\r\n                                ");
#nullable restore
#line 98 "F:\CrudDbApp\WebApp\Views\School\GetCollectiveData.cshtml"
                           Write(Html.ActionLink("Previous", "GetCollectiveData", new { search = ViewBag.Search, PageNumber = PageNo - 1 }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </li>\r\n");
#nullable restore
#line 100 "F:\CrudDbApp\WebApp\Views\School\GetCollectiveData.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 101 "F:\CrudDbApp\WebApp\Views\School\GetCollectiveData.cshtml"
                     for (int i = 1; i < totalPages; i++)
                    {
                        if (i == PageNo)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li class=\"active p-2\">\r\n                                ");
#nullable restore
#line 106 "F:\CrudDbApp\WebApp\Views\School\GetCollectiveData.cshtml"
                           Write(Html.ActionLink(i.ToString(), "GetCollectiveData", new { search = ViewBag.Search, PageNumber = i }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </li>\r\n");
#nullable restore
#line 108 "F:\CrudDbApp\WebApp\Views\School\GetCollectiveData.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li class=\"p-2\">\r\n                                ");
#nullable restore
#line 112 "F:\CrudDbApp\WebApp\Views\School\GetCollectiveData.cshtml"
                           Write(Html.ActionLink(i.ToString(), "GetCollectiveData", new { search = ViewBag.Search, PageNumber = i }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </li>\r\n");
#nullable restore
#line 114 "F:\CrudDbApp\WebApp\Views\School\GetCollectiveData.cshtml"
                        }
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 116 "F:\CrudDbApp\WebApp\Views\School\GetCollectiveData.cshtml"
                    if (PageNo == totalPages)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li class=\"disabled p-2\">\r\n                                ");
#nullable restore
#line 119 "F:\CrudDbApp\WebApp\Views\School\GetCollectiveData.cshtml"
                           Write(Html.ActionLink("Next", "GetCollectiveData", new { PageNumber = PageNo }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </li>\r\n");
#nullable restore
#line 121 "F:\CrudDbApp\WebApp\Views\School\GetCollectiveData.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li class=\"p-2\">\r\n                                ");
#nullable restore
#line 125 "F:\CrudDbApp\WebApp\Views\School\GetCollectiveData.cshtml"
                           Write(Html.ActionLink("Next", "GetCollectiveData", new { search = ViewBag.Search, PageNumber = PageNo + 1 }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </li>\r\n");
#nullable restore
#line 127 "F:\CrudDbApp\WebApp\Views\School\GetCollectiveData.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    \r\n                </ul>\r\n");
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CollectiveData>> Html { get; private set; }
    }
}
#pragma warning restore 1591
