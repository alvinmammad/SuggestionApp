#pragma checksum "C:\Users\Elvin\source\repos\ComplaintModule\UI\Views\Account\RoleList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "53df8a1367bc1be785da0648d06fc24f0951ee6d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_RoleList), @"mvc.1.0.view", @"/Views/Account/RoleList.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53df8a1367bc1be785da0648d06fc24f0951ee6d", @"/Views/Account/RoleList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2152411017d56b9cfbbe846c6b6acea3a060f1a", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_RoleList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AppRole>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Elvin\source\repos\ComplaintModule\UI\Views\Account\RoleList.cshtml"
  
    ViewData["Title"] = "RoleList";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""post d-flex flex-column-fluid"" id=""kt_post"">
    
    <div id=""kt_content_container"" class=""container-xxl"">
        
        <div class=""createBtn"" style=""margin-bottom:30px"">
            <a href=""/account/createrole"" class=""btn btn-primary"">Vəzifə yarat</a>

        </div>
        <div class=""card"">
           
            <div class=""card-header border-0 pt-6"">
             
                <div class=""card-title"">
                   
                    <h2>Vəzifələr</h2>
                   
                </div>


            </div>
         
            <div class=""card-body pt-0"">
");
#nullable restore
#line 30 "C:\Users\Elvin\source\repos\ComplaintModule\UI\Views\Account\RoleList.cshtml"
                 if (TempData["DeletedRole"] != null)
                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"badge badge-lg badge-light-success\" id=\"temp-message\">\r\n                        <strong></strong>");
#nullable restore
#line 34 "C:\Users\Elvin\source\repos\ComplaintModule\UI\Views\Account\RoleList.cshtml"
                                    Write(TempData["DeletedRole"]);

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
#line 44 "C:\Users\Elvin\source\repos\ComplaintModule\UI\Views\Account\RoleList.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "C:\Users\Elvin\source\repos\ComplaintModule\UI\Views\Account\RoleList.cshtml"
                 if (TempData["DeletedRoleError"] != null)
                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"badge badge-lg badge-light-success\" id=\"temp-message\">\r\n                        <strong></strong>");
#nullable restore
#line 49 "C:\Users\Elvin\source\repos\ComplaintModule\UI\Views\Account\RoleList.cshtml"
                                    Write(TempData["DeletedRoleError"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        <div class=""btn btn-sm btn-icon btn-active-color-primary"" id=""close-btn"">
                            <!--begin::Svg Icon | path: icons/duotune/arrows/arr061.svg-->
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
#line 61 "C:\Users\Elvin\source\repos\ComplaintModule\UI\Views\Account\RoleList.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 62 "C:\Users\Elvin\source\repos\ComplaintModule\UI\Views\Account\RoleList.cshtml"
                 if (TempData["SuccessRole"] != null)
                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"badge badge-lg badge-light-success\" id=\"temp-message\">\r\n                        <strong></strong>");
#nullable restore
#line 66 "C:\Users\Elvin\source\repos\ComplaintModule\UI\Views\Account\RoleList.cshtml"
                                    Write(TempData["SuccessRole"]);

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
#line 76 "C:\Users\Elvin\source\repos\ComplaintModule\UI\Views\Account\RoleList.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"              
                <table class=""table align-middle table-row-dashed fs-6 gy-5"" id=""kt_subscriptions_table secretary-table"">
                  
                    <thead>
                       
                        <tr class=""text-start text-muted fw-bolder fs-7 text-uppercase gs-0"">
                            <th class=""min-w-125px"">ID</th>
                            <th class=""min-w-125px"">Ad soyad</th>
                            <th class=""text-end min-w-70px"">FUNKSİYALAR</th>
                        </tr>
                       
                    </thead>
                   

                    <tbody class=""text-gray-600 fw-bold"">
");
#nullable restore
#line 92 "C:\Users\Elvin\source\repos\ComplaintModule\UI\Views\Account\RoleList.cshtml"
                         foreach (var role in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td style=\"font-weight:bold;\" class=\"text-gray-800 text-hover-primary mb-1\">");
#nullable restore
#line 95 "C:\Users\Elvin\source\repos\ComplaintModule\UI\Views\Account\RoleList.cshtml"
                                                                                                       Write(role.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td class=\"text-gray-800 text-hover-primary mb-1\">\r\n                                    ");
#nullable restore
#line 97 "C:\Users\Elvin\source\repos\ComplaintModule\UI\Views\Account\RoleList.cshtml"
                               Write(role.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </td>

                                <td class=""text-end"">
                                    <a href=""#"" class=""btn btn-light btn-active-light-primary btn-sm"" data-kt-menu-trigger=""click"" data-kt-menu-placement=""bottom-end"">
                                        Seç
                                        <span class=""svg-icon svg-icon-5 m-0"">
                                            <svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24"" viewBox=""0 0 24 24"" fill=""none"">
                                                <path d=""M11.4343 12.7344L7.25 8.55005C6.83579 8.13583 6.16421 8.13584 5.75 8.55005C5.33579 8.96426 5.33579 9.63583 5.75 10.05L11.2929 15.5929C11.6834 15.9835 12.3166 15.9835 12.7071 15.5929L18.25 10.05C18.6642 9.63584 18.6642 8.96426 18.25 8.55005C17.8358 8.13584 17.1642 8.13584 16.75 8.55005L12.5657 12.7344C12.2533 13.0468 11.7467 13.0468 11.4343 12.7344Z"" fill=""black"" />
                                            </svg>
             ");
            WriteLiteral(@"                           </span>
                                      
                                    </a>
                                    
                                    <div class=""menu menu-sub menu-sub-dropdown menu-column menu-rounded menu-gray-600 menu-state-bg-light-primary fw-bold fs-7 w-125px py-4"" data-kt-menu=""true"">
                                      
                                        <div class=""menu-item px-3"">
                                            <a");
            BeginWriteAttribute("href", " href=\"", 6438, "\"", 6471, 2);
            WriteAttributeValue("", 6445, "/account/editrole/", 6445, 18, true);
#nullable restore
#line 114 "C:\Users\Elvin\source\repos\ComplaintModule\UI\Views\Account\RoleList.cshtml"
WriteAttributeValue("", 6463, role.Id, 6463, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""menu-link px-3"">Düzəliş et</a>
                                        </div>
                                       

                                        <div class=""menu-item px-3"">
                                            <input type=""hidden"" name=""RoleId""");
            BeginWriteAttribute("value", " value=\"", 6751, "\"", 6767, 1);
#nullable restore
#line 119 "C:\Users\Elvin\source\repos\ComplaintModule\UI\Views\Account\RoleList.cshtml"
WriteAttributeValue("", 6759, role.Id, 6759, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 6817, "\"", 6852, 2);
            WriteAttributeValue("", 6824, "/account/deleterole/", 6824, 20, true);
#nullable restore
#line 120 "C:\Users\Elvin\source\repos\ComplaintModule\UI\Views\Account\RoleList.cshtml"
WriteAttributeValue("", 6844, role.Id, 6844, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""menu-link px-3"">Sil</a>
                                        </div>


                                    </div>
                                  
                                </td>
                              
                            </tr>
");
#nullable restore
#line 129 "C:\Users\Elvin\source\repos\ComplaintModule\UI\Views\Account\RoleList.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                    </tbody>\r\n                  \r\n                </table>\r\n               \r\n            </div>\r\n           \r\n        </div>\r\n\r\n    </div>\r\n   \r\n</div>\r\n\r\n\r\n\r\n\r\n");
            DefineSection("AdminScripts", async() => {
                WriteLiteral("\r\n\r\n    <script type=\"text/javascript\">\r\n        $(\"#close-btn\").click(function () {\r\n            $(\"#temp-message\").remove();\r\n        })\r\n    </script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AppRole>> Html { get; private set; }
    }
}
#pragma warning restore 1591