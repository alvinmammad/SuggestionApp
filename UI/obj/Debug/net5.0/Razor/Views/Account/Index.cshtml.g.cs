#pragma checksum "C:\Users\Elvin\source\repos\ComplaintModule\UI\Views\Account\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a52f00e40365279296f68661b9143277f48c3955"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Index), @"mvc.1.0.view", @"/Views/Account/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a52f00e40365279296f68661b9143277f48c3955", @"/Views/Account/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2152411017d56b9cfbbe846c6b6acea3a060f1a", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Feedback>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Elvin\source\repos\ComplaintModule\UI\Views\Account\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""post d-flex flex-column-fluid"" id=""kt_post"">
    
    <div id=""kt_content_container"" class=""container-xxl"">
       
        <div class=""card"">
            
            <div class=""card-header border-0 pt-6"">
               
                <div class=""card-title"">
                   
                    <h2>Təklif və şikayətlər</h2>
                    
                </div>
                
            </div>
          
            <div class=""card-body pt-0"">

");
#nullable restore
#line 27 "C:\Users\Elvin\source\repos\ComplaintModule\UI\Views\Account\Index.cshtml"
                 if (TempData["DeleteSucceeded"] != null)
                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"badge badge-lg badge-light-success\" id=\"temp-message\">\r\n                        <strong></strong> ");
#nullable restore
#line 31 "C:\Users\Elvin\source\repos\ComplaintModule\UI\Views\Account\Index.cshtml"
                                     Write(TempData["DeleteSucceeded"]);

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
#line 43 "C:\Users\Elvin\source\repos\ComplaintModule\UI\Views\Account\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "C:\Users\Elvin\source\repos\ComplaintModule\UI\Views\Account\Index.cshtml"
                 if (TempData["SendToHRMessage"] != null)
                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"badge badge-lg badge-light-success\" id=\"temp-message\">\r\n                        <strong></strong> ");
#nullable restore
#line 48 "C:\Users\Elvin\source\repos\ComplaintModule\UI\Views\Account\Index.cshtml"
                                     Write(TempData["SendToHRMessage"]);

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
#line 60 "C:\Users\Elvin\source\repos\ComplaintModule\UI\Views\Account\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 61 "C:\Users\Elvin\source\repos\ComplaintModule\UI\Views\Account\Index.cshtml"
                 if (TempData["NotFoundUser"] != null)
                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"badge badge-lg badge-light-danger\" id=\"temp-message\">\r\n                        <strong></strong>");
#nullable restore
#line 65 "C:\Users\Elvin\source\repos\ComplaintModule\UI\Views\Account\Index.cshtml"
                                    Write(TempData["NotFoundUser"]);

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
#line 77 "C:\Users\Elvin\source\repos\ComplaintModule\UI\Views\Account\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 78 "C:\Users\Elvin\source\repos\ComplaintModule\UI\Views\Account\Index.cshtml"
                 if (TempData["NotFoundFeedback"] != null)
                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"badge badge-lg badge-light-danger\" id=\"temp-message\">\r\n                        <strong></strong>");
#nullable restore
#line 82 "C:\Users\Elvin\source\repos\ComplaintModule\UI\Views\Account\Index.cshtml"
                                    Write(TempData["NotFoundFeedback"]);

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
#line 94 "C:\Users\Elvin\source\repos\ComplaintModule\UI\Views\Account\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 95 "C:\Users\Elvin\source\repos\ComplaintModule\UI\Views\Account\Index.cshtml"
                 if (TempData["SecretaryNoteSended"] != null)
                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"badge badge-lg badge-light-success\" id=\"temp-message\">\r\n                        <strong></strong>");
#nullable restore
#line 99 "C:\Users\Elvin\source\repos\ComplaintModule\UI\Views\Account\Index.cshtml"
                                    Write(TempData["SecretaryNoteSended"]);

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
#line 111 "C:\Users\Elvin\source\repos\ComplaintModule\UI\Views\Account\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 112 "C:\Users\Elvin\source\repos\ComplaintModule\UI\Views\Account\Index.cshtml"
                 if (TempData["EmailSended"] != null)
                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"badge badge-lg badge-light-success\" id=\"temp-message\">\r\n                        <strong></strong>");
#nullable restore
#line 116 "C:\Users\Elvin\source\repos\ComplaintModule\UI\Views\Account\Index.cshtml"
                                    Write(TempData["EmailSended"]);

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
#line 128 "C:\Users\Elvin\source\repos\ComplaintModule\UI\Views\Account\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 129 "C:\Users\Elvin\source\repos\ComplaintModule\UI\Views\Account\Index.cshtml"
                 if (TempData["MailException"] != null)
                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"badge badge-lg badge-light-danger\" id=\"temp-message\">\r\n                        <strong></strong>");
#nullable restore
#line 133 "C:\Users\Elvin\source\repos\ComplaintModule\UI\Views\Account\Index.cshtml"
                                    Write(TempData["MailException"]);

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
#line 145 "C:\Users\Elvin\source\repos\ComplaintModule\UI\Views\Account\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"              
                <table class=""table align-middle table-row-dashed fs-6 gy-5"" id=""kt_subscriptions_table secretary-table"">
                  
                    <thead>
                       
                        <tr class=""text-start text-muted fw-bolder fs-7 text-uppercase gs-0"">
                            <th class=""min-w-100px"">ID</th>
                            <th class=""min-w-125px"">Ad soyad</th>

                            <th class=""min-w-125px"">E-poçt</th>
                            <th class=""min-w-125px"">KATEQORİYA</th>
                            <th class=""min-w-125px"">Status</th>
                            <th class=""min-w-125px"">yaranma/DƏYİŞİLMƏ VAXTI</th>

                            <th class=""text-end min-w-70px"">FUNKSİYALAR</th>
                        </tr>
                        
                    </thead>
                    

                    <tbody class=""text-gray-600 fw-bold"">
");
#nullable restore
#line 167 "C:\Users\Elvin\source\repos\ComplaintModule\UI\Views\Account\Index.cshtml"
                         foreach (Feedback feedback in Model)
                        {
                            var color = "";
                            var textColor = "";
                            var statusAZ = "";
                            var pending = Entity.Enums.FeedbackStatus.Pending;
                            var inProgress = Entity.Enums.FeedbackStatus.inProgress;
                            var approved = Entity.Enums.FeedbackStatus.Approved;
                            var rejected = Entity.Enums.FeedbackStatus.Rejected;
                            if (feedback.FeedbackStatus == pending)
                            {
                                color = "badge-light";
                                textColor = "#cdcdde";
                                statusAZ = "Gözləmədə";
                            }
                            else if (feedback.FeedbackStatus == inProgress)
                            {
                                color = "badge-light-warning";
                                textColor = "#ffa800";
                                statusAZ = "Yoxlanışdadır";

                            }
                            else if (feedback.FeedbackStatus == approved)
                            {
                                color = "badge-light-success";
                                textColor = "#0bb783";
                                statusAZ = "Təsdiq edilib";


                            }
                            else if (feedback.FeedbackStatus == rejected)
                            {
                                color = "badge-light-danger";
                                textColor = "#f64e60";
                                statusAZ = "Ləğv edilib";

                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td style=\"font-weight:bold;\" class=\"text-gray-800 text-hover-primary mb-1\">");
#nullable restore
#line 205 "C:\Users\Elvin\source\repos\ComplaintModule\UI\Views\Account\Index.cshtml"
                                                                                                       Write(feedback.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td class=\"text-gray-800 text-hover-primary mb-1\">\r\n                                    ");
#nullable restore
#line 207 "C:\Users\Elvin\source\repos\ComplaintModule\UI\Views\Account\Index.cshtml"
                               Write(feedback.CustomerName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 207 "C:\Users\Elvin\source\repos\ComplaintModule\UI\Views\Account\Index.cshtml"
                                                      Write(feedback.CustomerSurname);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td class=\"text-gray-800 text-hover-primary mb-1\">");
#nullable restore
#line 209 "C:\Users\Elvin\source\repos\ComplaintModule\UI\Views\Account\Index.cshtml"
                                                                             Write(feedback.CustomerEmail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                                <td class=\"text-gray-800 text-hover-primary mb-1\">");
#nullable restore
#line 211 "C:\Users\Elvin\source\repos\ComplaintModule\UI\Views\Account\Index.cshtml"
                                                                             Write(feedback.FeedbackCategory.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>\r\n                                    <div");
            BeginWriteAttribute("style", " style=\"", 12017, "\"", 12042, 3);
            WriteAttributeValue("", 12025, "color:", 12025, 6, true);
#nullable restore
#line 213 "C:\Users\Elvin\source\repos\ComplaintModule\UI\Views\Account\Index.cshtml"
WriteAttributeValue("", 12031, textColor, 12031, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 12041, ";", 12041, 1, true);
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 12043, "\"", 12096, 5);
            WriteAttributeValue("", 12051, "badge", 12051, 5, true);
            WriteAttributeValue(" ", 12056, "badge-lg", 12057, 9, true);
#nullable restore
#line 213 "C:\Users\Elvin\source\repos\ComplaintModule\UI\Views\Account\Index.cshtml"
WriteAttributeValue(" ", 12065, color, 12066, 6, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 12072, "text-hover-primary", 12073, 19, true);
            WriteAttributeValue(" ", 12091, "mb-1", 12092, 5, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 213 "C:\Users\Elvin\source\repos\ComplaintModule\UI\Views\Account\Index.cshtml"
                                                                                                                    Write(statusAZ);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n                                </td>\r\n                                <td class=\"text-gray-800 text-hover-primary mb-1\">");
#nullable restore
#line 216 "C:\Users\Elvin\source\repos\ComplaintModule\UI\Views\Account\Index.cshtml"
                                                                             Write(feedback.CreatedDate.ToString("MMM dd yyyy, HH:mm"));

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
                                        </span>");
            WriteLiteral(@"
                                       
                                    </a>
                                  
                                    <div class=""menu menu-sub menu-sub-dropdown menu-column menu-rounded menu-gray-600 menu-state-bg-light-primary fw-bold fs-7 w-125px py-4"" data-kt-menu=""true"">
                                       
                                        <div class=""menu-item px-3"">
                                            <a");
            BeginWriteAttribute("href", " href=\"", 13788, "\"", 13832, 2);
            WriteAttributeValue("", 13795, "/account/feedbackdetails/", 13795, 25, true);
#nullable restore
#line 232 "C:\Users\Elvin\source\repos\ComplaintModule\UI\Views\Account\Index.cshtml"
WriteAttributeValue("", 13820, feedback.ID, 13820, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"menu-link px-3\">Detallı</a>\r\n                                        </div>\r\n                                       \r\n                                        <div class=\"menu-item px-3\">\r\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 14075, "\"", 14118, 2);
            WriteAttributeValue("", 14082, "/account/deletefeedback/", 14082, 24, true);
#nullable restore
#line 236 "C:\Users\Elvin\source\repos\ComplaintModule\UI\Views\Account\Index.cshtml"
WriteAttributeValue("", 14106, feedback.ID, 14106, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"menu-link px-3\">Sil</a>\r\n                                        </div>\r\n                                       \r\n                                        <div class=\"menu-item px-3\">\r\n");
#nullable restore
#line 240 "C:\Users\Elvin\source\repos\ComplaintModule\UI\Views\Account\Index.cshtml"
                                             if (feedback.FeedbackStatus == Entity.Enums.FeedbackStatus.inProgress)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <a");
            BeginWriteAttribute("href", " href=\"", 14525, "\"", 14571, 2);
            WriteAttributeValue("", 14532, "/account/checkfeedbacknote/", 14532, 27, true);
#nullable restore
#line 242 "C:\Users\Elvin\source\repos\ComplaintModule\UI\Views\Account\Index.cshtml"
WriteAttributeValue("", 14559, feedback.ID, 14559, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-kt-subscriptions-table-filter=\"delete_row\" class=\"menu-link px-3\">Yoxla</a>\r\n");
#nullable restore
#line 243 "C:\Users\Elvin\source\repos\ComplaintModule\UI\Views\Account\Index.cshtml"
                                            }
                                            else if (feedback.FeedbackStatus == Entity.Enums.FeedbackStatus.Pending)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <a");
            BeginWriteAttribute("href", " href=\"", 14917, "\"", 14954, 2);
            WriteAttributeValue("", 14924, "/account/sendtohr/", 14924, 18, true);
#nullable restore
#line 246 "C:\Users\Elvin\source\repos\ComplaintModule\UI\Views\Account\Index.cshtml"
WriteAttributeValue("", 14942, feedback.ID, 14942, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-kt-subscriptions-table-filter=\"delete_row\" class=\"menu-link px-3\">HR-a göndər</a>\r\n");
#nullable restore
#line 247 "C:\Users\Elvin\source\repos\ComplaintModule\UI\Views\Account\Index.cshtml"
                                            }
                                            else
                                            {

                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                        </div>

                                      
                                    </div>
                                   
                                </td>
                                
                            </tr>
");
#nullable restore
#line 260 "C:\Users\Elvin\source\repos\ComplaintModule\UI\Views\Account\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                    </tbody>\r\n                   \r\n                </table>\r\n              \r\n            </div>\r\n           \r\n        </div>\r\n       \r\n    </div>\r\n   \r\n</div>\r\n\r\n");
            DefineSection("AdminScripts", async() => {
                WriteLiteral(" \r\n\r\n    <script type=\"text/javascript\">\r\n        $(\"#close-btn\").click(function () {\r\n            $(\"#temp-message\").remove();\r\n        })\r\n    </script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Feedback>> Html { get; private set; }
    }
}
#pragma warning restore 1591
