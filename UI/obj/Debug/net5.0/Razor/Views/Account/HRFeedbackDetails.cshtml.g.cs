#pragma checksum "C:\Users\Elvin\source\repos\ComplaintModule\UI\Views\Account\HRFeedbackDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c239c03d8c81f68a6b284b91017390653783cb84"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_HRFeedbackDetails), @"mvc.1.0.view", @"/Views/Account/HRFeedbackDetails.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c239c03d8c81f68a6b284b91017390653783cb84", @"/Views/Account/HRFeedbackDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2152411017d56b9cfbbe846c6b6acea3a060f1a", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_HRFeedbackDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UserFeedback>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "HRFeedbackDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Elvin\source\repos\ComplaintModule\UI\Views\Account\HRFeedbackDetails.cshtml"
  
    ViewData["Title"] = "HRFeedbackDetails";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""post d-flex flex-column-fluid"" id=""kt_post"">
    <div id=""kt_content_container"" class=""container-xxl"">
        <div class=""d-flex flex-column flex-xl-row"" style=""justify-content: center;"">
            <div class=""flex-column flex-lg-row-auto w-100 w-xl-600px mb-10"">
                <div class=""card mb-5 mb-xl-8"">
                    <div class=""card-body"">

                        <div class=""d-flex flex-center flex-column py-5"">

");
#nullable restore
#line 16 "C:\Users\Elvin\source\repos\ComplaintModule\UI\Views\Account\HRFeedbackDetails.cshtml"
                             if (Model.Feedback.FeedbackFile != null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"symbol symbol-100px symbol-circle mb-7\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c239c03d8c81f68a6b284b91017390653783cb846005", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 818, "~/img/", 818, 6, true);
#nullable restore
#line 19 "C:\Users\Elvin\source\repos\ComplaintModule\UI\Views\Account\HRFeedbackDetails.cshtml"
AddHtmlAttributeValue("", 824, Model.Feedback.FeedbackFile, 824, 28, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </div>\r\n");
#nullable restore
#line 21 "C:\Users\Elvin\source\repos\ComplaintModule\UI\Views\Account\HRFeedbackDetails.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                            <span href=\"#\" class=\"fs-3 text-gray-800 text-hover-primary fw-bolder mb-3\">");
#nullable restore
#line 24 "C:\Users\Elvin\source\repos\ComplaintModule\UI\Views\Account\HRFeedbackDetails.cshtml"
                                                                                                   Write(Model.Feedback.FeedbackCategory.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>

                            <div class=""mb-9"">

                                <div class=""badge badge-lg badge-light-primary d-inline"">Müştəri feedback`i</div>

                            </div>


                        </div>

                        <div class=""d-flex flex-stack fs-4 py-3"">
                            <div class=""fw-bolder rotate collapsible"" data-bs-toggle=""collapse"" href=""#kt_user_view_details"" role=""button"" aria-expanded=""true"" aria-controls=""kt_user_view_details"">
                                Detallı
                                <span class=""ms-2 rotate-180"">
                                    <span class=""svg-icon svg-icon-3"">
                                        <svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24"" viewBox=""0 0 24 24"" fill=""none"">
                                            <path d=""M11.4343 12.7344L7.25 8.55005C6.83579 8.13583 6.16421 8.13584 5.75 8.55005C5.33579 8.96426 5.33579 9.63583 5.75 10.05L11.2929 15.5929C11.68");
            WriteLiteral(@"34 15.9835 12.3166 15.9835 12.7071 15.5929L18.25 10.05C18.6642 9.63584 18.6642 8.96426 18.25 8.55005C17.8358 8.13584 17.1642 8.13584 16.75 8.55005L12.5657 12.7344C12.2533 13.0468 11.7467 13.0468 11.4343 12.7344Z"" fill=""black""></path>
                                        </svg>
                                    </span>
                                </span>
                            </div>

                        </div>

                        <div class=""separator""></div>

                        <div id=""kt_user_view_details"" class=""collapse show""");
            BeginWriteAttribute("style", " style=\"", 2690, "\"", 2698, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <div class=\"pb-5 fs-6\">\r\n\r\n");
#nullable restore
#line 54 "C:\Users\Elvin\source\repos\ComplaintModule\UI\Views\Account\HRFeedbackDetails.cshtml"
                                  
                                    var statusAZ = "";
                                    var badgeColor = "";
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 58 "C:\Users\Elvin\source\repos\ComplaintModule\UI\Views\Account\HRFeedbackDetails.cshtml"
                                 if (Model.Feedback.FeedbackStatus == Entity.Enums.FeedbackStatus.inProgress)
                                {
                                    statusAZ = "İcrada";
                                    badgeColor = "badge-light-warning";
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 63 "C:\Users\Elvin\source\repos\ComplaintModule\UI\Views\Account\HRFeedbackDetails.cshtml"
                                 if (Model.Feedback.FeedbackStatus == Entity.Enums.FeedbackStatus.Pending)
                                {
                                    statusAZ = "Gözləmədə";
                                    badgeColor = "badge-light";

                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 68 "C:\Users\Elvin\source\repos\ComplaintModule\UI\Views\Account\HRFeedbackDetails.cshtml"
                                   if (Model.Feedback.FeedbackStatus == Entity.Enums.FeedbackStatus.Approved)
                                {
                                    statusAZ = "Təsdiqləndi";
                                    badgeColor = "badge-light-success";

                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 73 "C:\Users\Elvin\source\repos\ComplaintModule\UI\Views\Account\HRFeedbackDetails.cshtml"
                                   if (Model.Feedback.FeedbackStatus == Entity.Enums.FeedbackStatus.Rejected)
                                {
                                    statusAZ = "Ləğv edildi";
                                    badgeColor = "badge-light-danger";

                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                <div class=\"fw-bolder mt-5 text-primary\">Müştəri ID</div>\r\n                                <div class=\"text-gray-800 fw-normal mb-5\">ID - ");
#nullable restore
#line 81 "C:\Users\Elvin\source\repos\ComplaintModule\UI\Views\Account\HRFeedbackDetails.cshtml"
                                                                          Write(Model.Feedback.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n                                <div class=\"fw-bolder mt-5 text-primary\">Ad soyad</div>\r\n                                <div class=\"text-gray-800 fw-normal mb-5\">");
#nullable restore
#line 84 "C:\Users\Elvin\source\repos\ComplaintModule\UI\Views\Account\HRFeedbackDetails.cshtml"
                                                                     Write(Model.Feedback.CustomerName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 84 "C:\Users\Elvin\source\repos\ComplaintModule\UI\Views\Account\HRFeedbackDetails.cshtml"
                                                                                                  Write(Model.Feedback.CustomerSurname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n                                <div class=\"fw-bolder mt-5 text-primary\">E-poçt adresi</div>\r\n                                <div class=\"text-gray-800 fw-normal mb-5\">");
#nullable restore
#line 87 "C:\Users\Elvin\source\repos\ComplaintModule\UI\Views\Account\HRFeedbackDetails.cshtml"
                                                                     Write(Model.Feedback.CustomerEmail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n                                <div class=\"fw-bolder mt-5 text-primary\">Tarix</div>\r\n                                <div class=\"text-gray-800 fw-normal mb-5\">");
#nullable restore
#line 90 "C:\Users\Elvin\source\repos\ComplaintModule\UI\Views\Account\HRFeedbackDetails.cshtml"
                                                                     Write(Model.Feedback.CreatedDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n                                <div class=\"fw-bolder mt-5 text-primary\">Feedback statusu</div>\r\n                                <div");
            BeginWriteAttribute("class", " class=\"", 5097, "\"", 5160, 6);
            WriteAttributeValue("", 5105, "text-gray-800", 5105, 13, true);
            WriteAttributeValue(" ", 5118, "fw-normal", 5119, 10, true);
            WriteAttributeValue(" ", 5128, "mb-5", 5129, 5, true);
            WriteAttributeValue(" ", 5133, "badge", 5134, 6, true);
            WriteAttributeValue(" ", 5139, "badge-lg", 5140, 9, true);
#nullable restore
#line 93 "C:\Users\Elvin\source\repos\ComplaintModule\UI\Views\Account\HRFeedbackDetails.cshtml"
WriteAttributeValue(" ", 5148, badgeColor, 5149, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 93 "C:\Users\Elvin\source\repos\ComplaintModule\UI\Views\Account\HRFeedbackDetails.cshtml"
                                                                                                Write(statusAZ);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n                                <div class=\"fw-bolder mt-5 text-primary\">Feedback</div>\r\n                                <div class=\"text-gray-800 fw-normal mb-5\">");
#nullable restore
#line 96 "C:\Users\Elvin\source\repos\ComplaintModule\UI\Views\Account\HRFeedbackDetails.cshtml"
                                                                     Write(Model.Feedback.FeedbackDesc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                <hr />\r\n");
#nullable restore
#line 98 "C:\Users\Elvin\source\repos\ComplaintModule\UI\Views\Account\HRFeedbackDetails.cshtml"
                                 if (Model.SecretaryNote != null)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div class=\"fw-bolder mt-5 text-primary\">Katibin feedbacki</div>\r\n                                    <div class=\"text-gray-800 fw-normal mb-5\">");
#nullable restore
#line 101 "C:\Users\Elvin\source\repos\ComplaintModule\UI\Views\Account\HRFeedbackDetails.cshtml"
                                                                         Write(Model.SecretaryNote);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 102 "C:\Users\Elvin\source\repos\ComplaintModule\UI\Views\Account\HRFeedbackDetails.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                <div class=""card-px text-center pt-20 pb-5"">
                                    <a href=""#"" class=""btn btn-primary er fs-6 px-8 py-4"" data-bs-toggle=""modal"" data-bs-target=""#kt_modal_invite_friends"">Geri feedback</a>
                                </div>

                            </div>
                        </div>

                    </div>

                </div>

            </div>

        </div>

    </div>
    <div class=""modal fade"" id=""kt_modal_invite_friends"" tabindex=""-1"" style=""display: none;"" aria-hidden=""true"">
      
        <div class=""modal-dialog mw-650px"">
           
            <div class=""modal-content"">
               
                <div class=""modal-header pb-0 border-0 justify-content-end"">
                  
                    <div class=""btn btn-sm btn-icon btn-active-color-primary"" data-bs-dismiss=""modal"">
                        <span class=""svg-icon svg-icon-1"">
                            <svg xmlns=""http://ww");
            WriteLiteral(@"w.w3.org/2000/svg"" width=""24"" height=""24"" viewBox=""0 0 24 24"" fill=""none"">
                                <rect opacity=""0.5"" x=""6"" y=""17.3137"" width=""16"" height=""2"" rx=""1"" transform=""rotate(-45 6 17.3137)"" fill=""black""></rect>
                                <rect x=""7.41422"" y=""6"" width=""16"" height=""2"" rx=""1"" transform=""rotate(45 7.41422 6)"" fill=""black""></rect>
                            </svg>
                        </span>
                       
                    </div>
                    
                </div>
                
                <div class=""modal-body scroll-y mx-5 mx-xl-18 pt-0 pb-15"">
                  
                    <div class=""text-center mb-13"">
                       
                        <h1 class=""mb-3"">Geri feedback</h1>
                      
                        <div class=""text-muted fw-bold fs-5"">
                            Feedbackiniz katibin yoxlamasından sonra müvafiq müştəriyə göndəriləcəkdir.
                            Əks halda fe");
            WriteLiteral("edback-ə yenidən baxılması üçün sizə geri göndəriləcək.\r\n                        </div>\r\n                       \r\n                    </div>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c239c03d8c81f68a6b284b91017390653783cb8419978", async() => {
                WriteLiteral(@"
                        <div class=""d-flex flex-column mb-8"">
                            <label class=""fs-6 fw-bold mb-2"">HR notu</label>
                            <textarea class=""form-control form-control-solid"" rows=""3"" name=""HRNote"" placeholder=""Notu bura yazın...""></textarea>
                        </div>
                        <input type=""hidden"" name=""FeedbackStatus""");
                BeginWriteAttribute("value", " value=\"", 8439, "\"", 8477, 1);
#nullable restore
#line 157 "C:\Users\Elvin\source\repos\ComplaintModule\UI\Views\Account\HRFeedbackDetails.cshtml"
WriteAttributeValue("", 8447, Model.Feedback.FeedbackStatus, 8447, 30, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                        <div class=\"text-center\">\r\n                            <input type=\"hidden\" name=\"FeedbackID\"");
                BeginWriteAttribute("value", " value=\"", 8600, "\"", 8626, 1);
#nullable restore
#line 159 "C:\Users\Elvin\source\repos\ComplaintModule\UI\Views\Account\HRFeedbackDetails.cshtml"
WriteAttributeValue("", 8608, Model.Feedback.ID, 8608, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n\r\n                            <button type=\"submit\" class=\"btn btn-primary\">\r\n                                <span class=\"indicator-label\">Göndər</span>\r\n\r\n                            </button>\r\n\r\n                        </div>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                      \r\n\r\n                </div>\r\n               \r\n            </div>\r\n            \r\n        </div>\r\n       \r\n    </div>\r\n\r\n   \r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UserFeedback> Html { get; private set; }
    }
}
#pragma warning restore 1591
