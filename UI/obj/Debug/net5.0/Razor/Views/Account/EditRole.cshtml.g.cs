#pragma checksum "C:\Users\Elvin\source\repos\ComplaintModule\UI\Views\Account\EditRole.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "28ce7fbe05d6ceb70802e446044d87416d8d47e5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_EditRole), @"mvc.1.0.view", @"/Views/Account/EditRole.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28ce7fbe05d6ceb70802e446044d87416d8d47e5", @"/Views/Account/EditRole.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2152411017d56b9cfbbe846c6b6acea3a060f1a", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_EditRole : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RoleDetails>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditRole", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Elvin\source\repos\ComplaintModule\UI\Views\Account\EditRole.cshtml"
  
    ViewData["Title"] = "EditRole";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"post d-flex flex-column-fluid\" id=\"kt_post\">\r\n    <div id=\"kt_content_container\" class=\"container-xxl\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "28ce7fbe05d6ceb70802e446044d87416d8d47e54368", async() => {
                WriteLiteral("\r\n            <input type=\"hidden\" name=\"RoleID\"");
                BeginWriteAttribute("value", " value=\"", 342, "\"", 364, 1);
#nullable restore
#line 9 "C:\Users\Elvin\source\repos\ComplaintModule\UI\Views\Account\EditRole.cshtml"
WriteAttributeValue("", 350, Model.Role.Id, 350, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n            <input type=\"hidden\" name=\"RoleName\"");
                BeginWriteAttribute("value", " value=\"", 416, "\"", 440, 1);
#nullable restore
#line 10 "C:\Users\Elvin\source\repos\ComplaintModule\UI\Views\Account\EditRole.cshtml"
WriteAttributeValue("", 424, Model.Role.Name, 424, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
            
            <div class=""card"">
                
                <div class=""card-header border-0 pt-6"">
                   
                    <div class=""card-title"">
                        
                        <h2 class="" text-white p-1"">");
#nullable restore
#line 18 "C:\Users\Elvin\source\repos\ComplaintModule\UI\Views\Account\EditRole.cshtml"
                                               Write(Model.Role.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(@" roluna əlavə et</h2>                    <!--end::Search-->
                    </div>

                </div>
                
                <div class=""card-body pt-0"">
                 
                   
                    <table class=""table align-middle table-row-dashed fs-6 gy-5"" id=""kt_subscriptions_table secretary-table"">
");
#nullable restore
#line 27 "C:\Users\Elvin\source\repos\ComplaintModule\UI\Views\Account\EditRole.cshtml"
                         if (Model.NonMembers.Count() == 0)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <tr>\r\n                                <td colspan=\"2\">Bütün istifadəçilər bu rola aiddir</td>\r\n                            </tr>\r\n");
#nullable restore
#line 32 "C:\Users\Elvin\source\repos\ComplaintModule\UI\Views\Account\EditRole.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                            <thead>
                               
                                <tr class=""text-start text-muted fw-bolder fs-7 text-uppercase gs-0"">
                                    <th class=""min-w-125px"">ID</th>
                                    <th class=""min-w-125px"">İSTİFADƏÇİ ADI</th>
                                    <th class=""min-w-125px"">SEÇ</th>
                                </tr>
                              
                            </thead>
                            <tbody class=""text-gray-600 fw-bold"">
");
#nullable restore
#line 45 "C:\Users\Elvin\source\repos\ComplaintModule\UI\Views\Account\EditRole.cshtml"
                                 foreach (var user in Model.NonMembers)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <tr>\r\n                                        <td style=\"font-weight:bold;\" class=\"text-gray-800 text-hover-primary mb-1\">");
#nullable restore
#line 48 "C:\Users\Elvin\source\repos\ComplaintModule\UI\Views\Account\EditRole.cshtml"
                                                                                                               Write(user.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                        <td class=\"text-gray-800 text-hover-primary mb-1\">");
#nullable restore
#line 49 "C:\Users\Elvin\source\repos\ComplaintModule\UI\Views\Account\EditRole.cshtml"
                                                                                     Write(user.UserName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                        <td>\r\n                                            <div class=\"form-check form-check-sm form-check-custom form-check-solid me-3\">\r\n                                                <input name=\"IDsToAdd\"");
                BeginWriteAttribute("value", " value=\"", 2603, "\"", 2619, 1);
#nullable restore
#line 52 "C:\Users\Elvin\source\repos\ComplaintModule\UI\Views\Account\EditRole.cshtml"
WriteAttributeValue("", 2611, user.Id, 2611, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-check-input\" type=\"checkbox\" data-kt-check=\"true\" data-kt-check-target=\"\" value=\"1\">\r\n                                            </div>\r\n                                        </td>\r\n                                    </tr>\r\n");
#nullable restore
#line 56 "C:\Users\Elvin\source\repos\ComplaintModule\UI\Views\Account\EditRole.cshtml"


                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                            </tbody>\r\n");
#nullable restore
#line 60 "C:\Users\Elvin\source\repos\ComplaintModule\UI\Views\Account\EditRole.cshtml"

                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    </table>
                    
                </div>
                
            </div>

            <div style=""margin-top:50px;"" class=""card"">
                
                <div class=""card-header border-0 pt-6"">
                   
                    <div class=""card-title"">
                      
                        <h2 class="" text-white p-1"">");
#nullable restore
#line 74 "C:\Users\Elvin\source\repos\ComplaintModule\UI\Views\Account\EditRole.cshtml"
                                               Write(Model.Role.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(@" rolundan sil</h2>                    <!--end::Search-->
                    </div>

                </div>
               
                <div class=""card-body pt-0"">

                  
                    <table class=""table align-middle table-row-dashed fs-6 gy-5"" id=""kt_subscriptions_table secretary-table"">
");
#nullable restore
#line 83 "C:\Users\Elvin\source\repos\ComplaintModule\UI\Views\Account\EditRole.cshtml"
                         if (Model.Members.Count() == 0)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <tr>\r\n                                <td colspan=\"2\">Bu rola aid istifadəçi yoxdur</td>\r\n                            </tr>\r\n");
#nullable restore
#line 88 "C:\Users\Elvin\source\repos\ComplaintModule\UI\Views\Account\EditRole.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    <thead>
                      
                        <tr class=""text-start text-muted fw-bolder fs-7 text-uppercase gs-0"">
                            <th class=""min-w-125px"">ID</th>
                            <th class=""min-w-125px"">İSTİFADƏÇİ ADI</th>
                            <th class=""min-w-125px"">SEÇ</th>
                        </tr>
                       
                    </thead>
                            <tbody class=""text-gray-600 fw-bold"">
");
#nullable restore
#line 101 "C:\Users\Elvin\source\repos\ComplaintModule\UI\Views\Account\EditRole.cshtml"
                                 foreach (var user in Model.Members)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <tr>\r\n                                        <td style=\"font-weight:bold;\" class=\"text-gray-800 text-hover-primary mb-1\">");
#nullable restore
#line 104 "C:\Users\Elvin\source\repos\ComplaintModule\UI\Views\Account\EditRole.cshtml"
                                                                                                               Write(user.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                        <td class=\"text-gray-800 text-hover-primary mb-1\">");
#nullable restore
#line 105 "C:\Users\Elvin\source\repos\ComplaintModule\UI\Views\Account\EditRole.cshtml"
                                                                                     Write(user.UserName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                        <td>\r\n                                            <div class=\"form-check form-check-sm form-check-custom form-check-solid me-3\">\r\n                                                <input name=\"IDsToDelete\"");
                BeginWriteAttribute("value", " value=\"", 5149, "\"", 5165, 1);
#nullable restore
#line 108 "C:\Users\Elvin\source\repos\ComplaintModule\UI\Views\Account\EditRole.cshtml"
WriteAttributeValue("", 5157, user.Id, 5157, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-check-input\" type=\"checkbox\" data-kt-check=\"true\" data-kt-check-target=\"\" value=\"1\">\r\n                                            </div>\r\n                                        </td>\r\n                                    </tr>\r\n");
#nullable restore
#line 112 "C:\Users\Elvin\source\repos\ComplaintModule\UI\Views\Account\EditRole.cshtml"
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                            </tbody>\r\n");
#nullable restore
#line 114 "C:\Users\Elvin\source\repos\ComplaintModule\UI\Views\Account\EditRole.cshtml"

                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    </table>
                   
                </div>
                
            </div>
            
            <div style=""margin-top:50px;margin-bottom:50px;"" class=""card"">
                <div class=""card-footer text-center"">
                    <button type=""submit"" class=""btn btn-primary"">Düzəliş et</button>

                </div>

            </div>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n   \r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RoleDetails> Html { get; private set; }
    }
}
#pragma warning restore 1591