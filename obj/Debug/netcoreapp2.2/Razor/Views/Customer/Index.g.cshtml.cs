#pragma checksum "/home/sherif/dotnet/pms/Views/Customer/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "40927ac3d1c7d62f94b1412afc1d66835f1f3b7d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_Index), @"mvc.1.0.view", @"/Views/Customer/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Customer/Index.cshtml", typeof(AspNetCore.Views_Customer_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40927ac3d1c7d62f94b1412afc1d66835f1f3b7d", @"/Views/Customer/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66cec1d1563926953c0e36752bf8226dd1f44e36", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-thumbnail"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/pj_logo.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("logo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "/home/sherif/dotnet/pms/Views/Customer/Index.cshtml"
  
    ViewData["Title"] = "Customer";

#line default
#line hidden
            BeginContext(41, 78, true);
            WriteLiteral("\n<div class=\"container\">\n    <div class=\"row\">\n        <div class=\"col-md-5\">\n");
            EndContext();
#line 8 "/home/sherif/dotnet/pms/Views/Customer/Index.cshtml"
              Html.RenderPartial("~/Views/Project/Add.cshtml");

#line default
#line hidden
            BeginContext(184, 290, true);
            WriteLiteral(@"        </div>
        <div class=""col-md-7"">
            <div class=""card shadow"">
                <div class=""card-header"">PJ #1</div>
                <div class=""card-body"">
                    <div class=""row"">
                        <div class=""col-md-3"">
                            ");
            EndContext();
            BeginContext(474, 90, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "40927ac3d1c7d62f94b1412afc1d66835f1f3b7d5566", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(564, 2156, true);
            WriteLiteral(@"
                        </div>
                        <div class=""col-md-9"">
                            <h5 class=""card-title"">Pic W Post</h5>
                            <h6 class=""card-subtitle mb-2 text-muted"">PicWPost is a start up on the rise that is poised to change the world of accounting experience.</h6>
                        </div>
                    </div>
                </div>
                <div class=""card-footer"">
                    <div class=""row"">
                        <div class=""col-md-6"">
                            <small class=""text-muted"">last updated 3 time ago</small>
                        </div>
                        <div class=""col-md-6"">
                            <div class=""accordion"" id=""pjManagerAccordion"">
                                <button class=""btn btn-link float-right"" type=""button"" data-toggle=""collapse"" data-target=""#collapse1"" aria-expanded=""true"" aria-controls=""collapse1"">
                                    Requests
                               ");
            WriteLiteral(@"     <span class=""badge badge-primary"">2</span>
                                </button>
                            </div>
                        </div>
                    </div>
                </div>
                 <div id=""collapse1"" class=""collapse hidden"" aria-labelledby=""headingOne"" data-parent=""#pjManagerAccordion"">
                    <ul class=""list-group list-group-flush"">
                        <li class=""list-group-item"">
                            Ahmed aly
                            <button class=""btn btn-success float-right"">Assign</button>
                        </li>
                        <li class=""list-group-item"">
                            Mohamed fouad
                            <button class=""btn btn-success float-right"">Assign</button>
                        </li>
                    </ul>
                </div>
            </div>

            <div class=""card shadow mt-3"">
                <div class=""card-header"">PJ #1</div>
                <div class=""card-body"">
     ");
            WriteLiteral("               <div class=\"row\">\n                        <div class=\"col-md-3\">\n                            ");
            EndContext();
            BeginContext(2720, 90, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "40927ac3d1c7d62f94b1412afc1d66835f1f3b7d9327", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2810, 2157, true);
            WriteLiteral(@"
                        </div>
                        <div class=""col-md-9"">
                            <h5 class=""card-title"">Pic W Post</h5>
                            <h6 class=""card-subtitle mb-2 text-muted"">PicWPost is a start up on the rise that is poised to change the world of accounting experience.</h6>
                        </div>
                    </div>
                </div>
                <div class=""card-footer"">
                    <div class=""row"">
                        <div class=""col-md-6"">
                            <small class=""text-muted"">last updated 3 time ago</small>
                        </div>
                        <div class=""col-md-6"">
                            <div class=""accordion"" id=""pjManagerAccordion"">
                                <button class=""btn btn-link float-right"" type=""button"" data-toggle=""collapse"" data-target=""#collapse2"" aria-expanded=""true"" aria-controls=""collapse2"">
                                    Requests
                               ");
            WriteLiteral(@"     <span class=""badge badge-primary"">2</span>
                                </button>
                            </div>
                        </div>
                    </div>
                </div>
                 <div id=""collapse2"" class=""collapse hidden"" aria-labelledby=""headingOne"" data-parent=""#pjManagerAccordion"">
                    <ul class=""list-group list-group-flush"">
                        <li class=""list-group-item"">
                            Ahmed aly
                            <button class=""btn btn-success float-right"">Assign</button>
                        </li>
                        <li class=""list-group-item"">
                            Mohamed fouad
                            <button class=""btn btn-success float-right"">Assign</button>
                        </li>
                    </ul>
                </div>
            </div>

             <div class=""card shadow mt-3"">
                <div class=""card-header"">PJ #1</div>
                <div class=""card-body"">
    ");
            WriteLiteral("                <div class=\"row\">\n                        <div class=\"col-md-3\">\n                            ");
            EndContext();
            BeginContext(4967, 90, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "40927ac3d1c7d62f94b1412afc1d66835f1f3b7d13090", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5057, 1938, true);
            WriteLiteral(@"
                        </div>
                        <div class=""col-md-9"">
                            <h5 class=""card-title"">Pic W Post</h5>
                            <h6 class=""card-subtitle mb-2 text-muted"">PicWPost is a start up on the rise that is poised to change the world of accounting experience.</h6>
                        </div>
                    </div>
                </div>
                <div class=""card-footer"">
                    <div class=""row"">
                        <div class=""col-md-6"">
                            <small class=""text-muted"">last updated 3 time ago</small>
                        </div>
                        <div class=""col-md-6"">
                            <div class=""accordion"" id=""pjManagerAccordion"">
                                <button class=""btn btn-link float-right"" type=""button"" data-toggle=""collapse"" data-target=""#collapse3"" aria-expanded=""true"" aria-controls=""collapse3"">
                                    Requests
                               ");
            WriteLiteral(@"     <span class=""badge badge-primary"">2</span>
                                </button>
                            </div>
                        </div>
                    </div>
                </div>
                 <div id=""collapse3"" class=""collapse hidden"" aria-labelledby=""headingOne"" data-parent=""#pjManagerAccordion"">
                    <ul class=""list-group list-group-flush"">
                        <li class=""list-group-item"">
                            Ahmed aly
                            <button class=""btn btn-success float-right"">Assign</button>
                        </li>
                        <li class=""list-group-item"">
                            Mohamed fouad
                            <button class=""btn btn-success float-right"">Assign</button>
                        </li>
                    </ul>
                </div>
            </div>
        </div>
    </div>
</div>");
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
