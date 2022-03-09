#pragma checksum "C:\Users\Elvin\source\repos\ComplaintModule\UI\Views\Account\CategoryList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b4d3c88ca1c8e9bd4a3f5f30c28e16ce417dbd19"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_CategoryList), @"mvc.1.0.view", @"/Views/Account/CategoryList.cshtml")]
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
#line 1 "C:\Users\Elvin\source\repos\ComplaintModule\UI\Views\_ViewImports.cshtml"
using UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Elvin\source\repos\ComplaintModule\UI\Views\_ViewImports.cshtml"
using UI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Elvin\source\repos\ComplaintModule\UI\Views\_ViewImports.cshtml"
using Entity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4d3c88ca1c8e9bd4a3f5f30c28e16ce417dbd19", @"/Views/Account/CategoryList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2152411017d56b9cfbbe846c6b6acea3a060f1a", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_CategoryList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<FeedbackCategories>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Elvin\source\repos\ComplaintModule\UI\Views\Account\CategoryList.cshtml"
  
    ViewData["Title"] = "CategoryList";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""post d-flex flex-column-fluid"" id=""kt_post"">

    <div id=""kt_content_container"" class=""container-xxl"">
        <div class=""createBtn"" style=""margin-bottom:30px"">
            <a href=""/account/createcategory"" class=""btn btn-primary"">Kateqoriya yarat</a>

        </div>

        <div class=""card"">

            <div class=""card-header border-0 pt-6"">

                <div class=""card-title"">

                    <h2>Kateqoriyaların siyahısı</h2>

                </div>

            </div>

            <div class=""card-body pt-0"">

");
#nullable restore
#line 29 "C:\Users\Elvin\source\repos\ComplaintModule\UI\Views\Account\CategoryList.cshtml"
                 if (TempData["EditCategory"] != null)
                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"badge badge-lg badge-light-success\" id=\"temp-message\">\r\n                        <strong></strong> ");
#nullable restore
#line 33 "C:\Users\Elvin\source\repos\ComplaintModule\UI\Views\Account\CategoryList.cshtml"
                                     Write(TempData["EditCategory"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        <div class=""btn btn-sm btn-icon btn-active-color-primary"" id=""close-btn"">
                            <span class=""svg-icon svg-icon-1"">
                                <svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24"" viewBox=""0 0 24 24"" fill=""none"">
                                    <rect opacity=""0.5"" x=""6"" y=""17.3137"" width=""16"" height=""2"" rx=""1"" transform=""rotate(-45 6 17.3137)"" fill=""black""></rect>
                                    <rect x=""7.41422"" y=""6"" width=""16"" height=""2"" rx=""1"" transform=""rotate(45 7.41422 6)"" fill=""black""></rect>
                                </svg>
                            </span>
                            <!--end::Svg Icon-->
                        </div>
                    </div>
");
#nullable restore
#line 44 "C:\Users\Elvin\source\repos\ComplaintModule\UI\Views\Account\CategoryList.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "C:\Users\Elvin\source\repos\ComplaintModule\UI\Views\Account\CategoryList.cshtml"
                 if (TempData["CategorySuccess"] != null)
                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"badge badge-lg badge-light-success\" id=\"temp-message\">\r\n                        <strong></strong> ");
#nullable restore
#line 49 "C:\Users\Elvin\source\repos\ComplaintModule\UI\Views\Account\CategoryList.cshtml"
                                     Write(TempData["CategorySuccess"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        <div class=""btn btn-sm btn-icon btn-active-color-primary"" id=""close-btn"">
                            <span class=""svg-icon svg-icon-1"">
                                <svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24"" viewBox=""0 0 24 24"" fill=""none"">
                                    <rect opacity=""0.5"" x=""6"" y=""17.3137"" width=""16"" height=""2"" rx=""1"" transform=""rotate(-45 6 17.3137)"" fill=""black""></rect>
                                    <rect x=""7.41422"" y=""6"" width=""16"" height=""2"" rx=""1"" transform=""rotate(45 7.41422 6)"" fill=""black""></rect>
                                </svg>
                            </span>
                        </div>
                    </div>
");
#nullable restore
#line 59 "C:\Users\Elvin\source\repos\ComplaintModule\UI\Views\Account\CategoryList.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "C:\Users\Elvin\source\repos\ComplaintModule\UI\Views\Account\CategoryList.cshtml"
                 if (TempData["DeletedCategory"] != null)
                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"badge badge-lg badge-light-danger\" id=\"temp-message\">\r\n                        <strong></strong>");
#nullable restore
#line 64 "C:\Users\Elvin\source\repos\ComplaintModule\UI\Views\Account\CategoryList.cshtml"
                                    Write(TempData["DeletedCategory"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        <div class=""btn btn-sm btn-icon btn-active-color-primary"" id=""close-btn"">
                            <span class=""svg-icon svg-icon-1"">
                                <svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24"" viewBox=""0 0 24 24"" fill=""none"">
                                    <rect opacity=""0.5"" x=""6"" y=""17.3137"" width=""16"" height=""2"" rx=""1"" transform=""rotate(-45 6 17.3137)"" fill=""black""></rect>
                                    <rect x=""7.41422"" y=""6"" width=""16"" height=""2"" rx=""1"" transform=""rotate(45 7.41422 6)"" fill=""black""></rect>
                                </svg>
                            </span>
                        </div>
                    </div>
");
#nullable restore
#line 74 "C:\Users\Elvin\source\repos\ComplaintModule\UI\Views\Account\CategoryList.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                <table class=""table align-middle table-row-dashed fs-6 gy-5"" id=""kt_subscriptions_table secretary-table"">

                    <thead>

                        <tr class=""text-start text-muted fw-bolder fs-7 text-uppercase gs-0"">
                            <th class=""min-w-100px"">ID</th>
                            <th class=""min-w-125px"">Kateqoriya adı</th>
                            <th class=""min-w-125px"">Aid olduğu şöbə</th>
                            <th class=""min-w-125px"">yaranma VAXTI</th>
                            <th class=""text-end min-w-70px"">FUNKSİYALAR</th>
                        </tr>

                    </thead>


                    <tbody class=""text-gray-600 fw-bold"">
");
#nullable restore
#line 93 "C:\Users\Elvin\source\repos\ComplaintModule\UI\Views\Account\CategoryList.cshtml"
                         foreach (FeedbackCategories category in Model)
                        {


#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td style=\"font-weight:bold;\" class=\"text-gray-800 text-hover-primary mb-1\">");
#nullable restore
#line 97 "C:\Users\Elvin\source\repos\ComplaintModule\UI\Views\Account\CategoryList.cshtml"
                                                                                                   Write(category.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td class=\"text-gray-800 text-hover-primary mb-1\">\r\n                                ");
#nullable restore
#line 99 "C:\Users\Elvin\source\repos\ComplaintModule\UI\Views\Account\CategoryList.cshtml"
                           Write(category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td class=\"text-gray-800 text-hover-primary mb-1\">\r\n                                ");
#nullable restore
#line 102 "C:\Users\Elvin\source\repos\ComplaintModule\UI\Views\Account\CategoryList.cshtml"
                           Write(category.Department.DepName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td class=\"text-gray-800 text-hover-primary mb-1\">");
#nullable restore
#line 104 "C:\Users\Elvin\source\repos\ComplaintModule\UI\Views\Account\CategoryList.cshtml"
                                                                         Write(category.CreatedDate.ToString("MMM dd yyyy, HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>

                            <td class=""text-end"">
                                <a href=""#"" class=""btn btn-light btn-active-light-primary btn-sm"" data-kt-menu-trigger=""click"" data-kt-menu-placement=""bottom-end"">
                                    Seç
                                    <span class=""svg-icon svg-icon-5 m-0"">
                                        <svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24"" viewBox=""0 0 24 24"" fill=""none"">
                                            <path d=""M11.4343 12.7344L7.25 8.55005C6.83579 8.13583 6.16421 8.13584 5.75 8.55005C5.33579 8.96426 5.33579 9.63583 5.75 10.05L11.2929 15.5929C11.6834 15.9835 12.3166 15.9835 12.7071 15.5929L18.25 10.05C18.6642 9.63584 18.6642 8.96426 18.25 8.55005C17.8358 8.13584 17.1642 8.13584 16.75 8.55005L12.5657 12.7344C12.2533 13.0468 11.7467 13.0468 11.4343 12.7344Z"" fill=""black"" />
                                        </svg>
                                    </span>

                            ");
            WriteLiteral(@"    </a>

                                <div class=""menu menu-sub menu-sub-dropdown menu-column menu-rounded menu-gray-600 menu-state-bg-light-primary fw-bold fs-7 w-125px py-4"" data-kt-menu=""true"">

                                    <div class=""menu-item px-3"">
                                        <a");
            BeginWriteAttribute("href", " href=\"", 6529, "\"", 6572, 2);
            WriteAttributeValue("", 6536, "/account/UpdateCategory/", 6536, 24, true);
#nullable restore
#line 120 "C:\Users\Elvin\source\repos\ComplaintModule\UI\Views\Account\CategoryList.cshtml"
WriteAttributeValue("", 6560, category.ID, 6560, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"menu-link px-3\">Yenilə</a>\r\n                                    </div>\r\n\r\n                                    <div class=\"menu-item px-3\">\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 6763, "\"", 6806, 2);
            WriteAttributeValue("", 6770, "/account/DeleteCategory/", 6770, 24, true);
#nullable restore
#line 124 "C:\Users\Elvin\source\repos\ComplaintModule\UI\Views\Account\CategoryList.cshtml"
WriteAttributeValue("", 6794, category.ID, 6794, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"menu-link px-3\">Sil</a>\r\n                                    </div>\r\n\r\n\r\n\r\n                                </div>\r\n\r\n                            </td>\r\n\r\n                        </tr>\r\n");
#nullable restore
#line 134 "C:\Users\Elvin\source\repos\ComplaintModule\UI\Views\Account\CategoryList.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                    </tbody>\r\n\r\n                </table>\r\n\r\n            </div>\r\n\r\n        </div>\r\n\r\n    </div>\r\n\r\n</div>\r\n\r\n");
            DefineSection("AdminScripts", async() => {
                WriteLiteral("\r\n\r\n    <script type=\"text/javascript\">\r\n        $(\"#close-btn\").click(function () {\r\n            $(\"#temp-message\").remove();\r\n        })\r\n    </script>\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<FeedbackCategories>> Html { get; private set; }
    }
}
#pragma warning restore 1591
