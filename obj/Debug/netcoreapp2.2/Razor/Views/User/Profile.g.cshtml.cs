#pragma checksum "/home/sherif/dotnet/pms/Views/User/Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "93d11277ead55711f04d77bbf975862c5fd9c749"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Profile), @"mvc.1.0.view", @"/Views/User/Profile.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/Profile.cshtml", typeof(AspNetCore.Views_User_Profile))]
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
#line 1 "/home/sherif/dotnet/pms/Views/_ViewImports.cshtml"
using pms;

#line default
#line hidden
#line 2 "/home/sherif/dotnet/pms/Views/_ViewImports.cshtml"
using pms.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93d11277ead55711f04d77bbf975862c5fd9c749", @"/Views/User/Profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66cec1d1563926953c0e36752bf8226dd1f44e36", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Profile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("col-md-8"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/home/sherif/dotnet/pms/Views/User/Profile.cshtml"
  
    ViewData["Title"] = "Profile";

#line default
#line hidden
            BeginContext(40, 2644, true);
            WriteLiteral(@"<div class=""Container"">
    <div class=""row"">
        <div class=""card mb-3 border-primary col-md-12"">
            <div class=""card-header bg-primary text-white font-weight-bold"">
                Profile
            </div>
            <div class=""card-body"">
                <div class=""row"">
                    <div class=""col-md-4"">
                        <div class=""card shadow mb-4 bg-dark text-white"">
                            <div class=""card-header bg-primary white py-3"">
                                <h6 class=""m-0 font-weight-bold"">Projects</h6>
                            </div>
                            <div class=""profile-img mt-2"">
                                <img src=""https://scontent-hbe1-1.xx.fbcdn.net/v/t1.0-9/50549188_2160272934050183_6379706522686980096_n.jpg?_nc_cat=102&_nc_ht=scontent-hbe1-1.xx&oh=3cad7354d843d53dc4641019ddfce9c3&oe=5D4331D3"" alt=""profile photo""/>
                                <div class=""file btn btn-lg btn-primary"">
                                    <input");
            WriteLiteral(@" type=""file"" name=""file""/>
                                    Change Photo
                                </div>
                            </div>
                            <div class=""mb-4"">
                                <div class=""card-body"">
                                    <h4 class=""small font-weight-bold"">Pending<span class=""float-right"">20%</span></h4>
                                    <div class=""progress mb-4"">
                                        <div class=""progress-bar bg-danger"" role=""progressbar"" style=""width: 20%"" aria-valuenow=""20"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                                    </div>
                                    <h4 class=""small font-weight-bold"">Delivered <span class=""float-right"">40%</span></h4>
                                    <div class=""progress mb-4"">
                                        <div class=""progress-bar bg-warning"" role=""progressbar"" style=""width: 40%"" aria-valuenow=""40"" aria-valuemin=""0"" aria-valuemax=""100""></div>
");
            WriteLiteral(@"                                    </div>
                                    <h4 class=""small font-weight-bold"">Not Delivered<span class=""float-right"">60%</span></h4>
                                    <div class=""progress mb-4"">
                                        <div class=""progress-bar"" role=""progressbar"" style=""width: 60%"" aria-valuenow=""60"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    ");
            EndContext();
            BeginContext(2684, 1455, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "93d11277ead55711f04d77bbf975862c5fd9c7496443", async() => {
                BeginContext(2707, 1425, true);
                WriteLiteral(@"
                        <div class=""form-group"">
                            <label for=""first_name"">First Name:</label>
                            <input class=""form-control"" id=""first_name"" placeholder=""first name"">
                        </div>
                        <div class=""form-group"">
                            <label for=""last_name"">Last Name:</label>
                            <input class=""form-control"" id=""last_name"" placeholder=""last name"">
                        </div>
                        <div class=""form-group"">
                            <label for=""job_description"">Job Description:</label>
                            <textarea class=""form-control"" id=""job_description"" placeholder=""job description (Software Engineer)""></textarea>
                        </div>
                        <div class=""form-group"">
                            <label for=""email"">Email:</label>
                            <input class=""form-control"" type=""email"" id=""email"" placeholder=""example@example.com");
                WriteLiteral(@""">
                        </div>
                        <div class=""form-group"">
                            <label for=""mobile"">Mobile:</label>
                            <input class=""form-control"" type=""mobile"" id=""mobile"" placeholder=""mobile"">
                        </div>
                        <button type=""submit"" class=""btn btn-primary btn-block mt-5"">Edit</button>
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
            BeginContext(4139, 75, true);
            WriteLiteral("\n                </div>\n            </div>\n        </div>\n    </div>\n</div>");
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
