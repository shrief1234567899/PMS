#pragma checksum "/home/sherif/dotnet/pms/Views/Project/Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3c03b89e8601b037615ad91c7f3f7aae314e45c6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Project_Show), @"mvc.1.0.view", @"/Views/Project/Show.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Project/Show.cshtml", typeof(AspNetCore.Views_Project_Show))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c03b89e8601b037615ad91c7f3f7aae314e45c6", @"/Views/Project/Show.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66cec1d1563926953c0e36752bf8226dd1f44e36", @"/Views/_ViewImports.cshtml")]
    public class Views_Project_Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1959, true);
            WriteLiteral(@"<div class=""card mb-3 border-primary shadow view-project-card"">
    <div class=""card-header bg-primary text-white view-project-header"">PJ #1</div>
    <div class=""card-body"">
      <ul class=""list-group list-group-flush"">
            <li class=""list-group-item"">
                <h5 class=""card-title"">Name</h5>
                <h6 class=""card-subtitle mb-2 text-muted view-project-name"">Pic W Post</h6>
            </li>
            <li class=""list-group-item"">
                <h5 class=""card-title"">Description</h5>
                <h6 class=""card-subtitle mb-2 text-muted view-project-description"">PicWPost is a start up on the rise that is poised to change the world of accounting experience.</h6>
            </li>
            <li class=""list-group-item"">
                <h5 class=""card-title"">Experience</h5>
                <h6 class=""card-subtitle mb-2 text-muted view-project-experience"">3 years +</h6>
            </li>
            <li class=""list-group-item"">
                <h5 class=""card-title"">Manager</h5>");
            WriteLiteral(@"
                <h6 class=""card-subtitle mb-2 text-muted view-project-manager"">
                    Ahmed mohamed
                    <span class=""badge badge-dark float-right"">Assigned from 1/1/2018</span>
                </h6>
            </li>
            <li class=""list-group-item"">
                <h5 class=""card-title"">Details</h5>
                <h6 class=""card-subtitle mb-2 text-muted"">
                    <a href=""#"" class='view-project-details'>details.pdf</a>
                </h6>
            </li>
        </ul>
    </div>
    <div class=""card-footer bg-primary view-project-footer"">
        <div class=""card-text text-white float-left"">
            Created:
            <span class=""text-white small"">1/1/2019 1:00 am</span>
        </div>
        <div class=""card-text text-white float-right"">
            Updated:
            <span class=""text-white small"">2/1/2019 1:00 am</span>
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
