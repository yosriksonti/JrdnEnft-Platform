#pragma checksum "/Users/MrStealYourMom/Projects/test_request/test_request/Views/Shared/sidebar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0f271d12ec419bac1b18fa21460f7c2e4cbe44a5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_sidebar), @"mvc.1.0.view", @"/Views/Shared/sidebar.cshtml")]
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
#line 1 "/Users/MrStealYourMom/Projects/test_request/test_request/Views/_ViewImports.cshtml"
using test_request;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/MrStealYourMom/Projects/test_request/test_request/Views/_ViewImports.cshtml"
using test_request.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f271d12ec419bac1b18fa21460f7c2e4cbe44a5", @"/Views/Shared/sidebar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af006a6d0653c15ada2bd9e8dce2213ac9649948", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_sidebar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""app-sidebar sidebar-shadow"">
    <div class=""app-header__logo"">
        <div class=""logo-src""></div>
        <div class=""header__pane ml-auto"">
            <div>
                <button type=""button"" class=""hamburger close-sidebar-btn hamburger--elastic"" data-class=""closed-sidebar"">
                    <span class=""hamburger-box"">
                        <span class=""hamburger-inner""></span>
                    </span>
                </button>
            </div>
        </div>
    </div>
    <div class=""app-header__mobile-menu"">
        <div>
            <button type=""button"" class=""hamburger hamburger--elastic mobile-toggle-nav"">
                <span class=""hamburger-box"">
                    <span class=""hamburger-inner""></span>
                </span>
            </button>
        </div>
    </div>
    <div class=""app-header__menu"">
        <span>
            <button type=""button"" class=""btn-icon btn-icon-only btn btn-primary btn-sm mobile-toggle-header-nav"">
                <span class=""btn-");
            WriteLiteral(@"icon-wrapper"">
                    <i class=""fa fa-ellipsis-v fa-w-6""></i>
                </span>
            </button>
        </span>
    </div>
    <div class=""scrollbar-sidebar"">
        <div class=""app-sidebar__inner"">
            <ul class=""vertical-nav-menu"">
                <li>
                    <a href=""#"">
                        <i class=""metismenu-icon pe-7s-browser""></i>Reclamation
                        <i class=""metismenu-state-icon pe-7s-angle-down caret-left""></i>
                    </a>
                    <ul>
                        <li>
                            <a href=""/Reclamation_Back/Add_Reclamation/1"">
                                <i class=""metismenu-icon""></i> Add Reclamation
                            </a>
                        </li>
                        <li>
                            <a href=""/Reclamation_Back/Reclamations"">
                                <i class=""metismenu-icon""></i> Reclamations
                            </a>
                        </li>");
            WriteLiteral(@"
                    </ul>
                </li>
                <li>
                    <a href=""#"">
                        <i class=""metismenu-icon pe-7s-browser""></i>Director
                        <i class=""metismenu-state-icon pe-7s-angle-down caret-left""></i>
                    </a>
                    <ul>
                        <li>
                            <a href=""/Director/Add_Director/1"">
                                <i class=""metismenu-icon""></i> Add Director
                            </a>
                        </li>
                        <li>
                            <a href=""/Director/Directors"">
                                <i class=""metismenu-icon""></i> Directors
                            </a>
                        </li>
                    </ul>
                </li>
                <li>
                    <a href=""#"">
                        <i class=""metismenu-icon pe-7s-browser""></i>Daycare
                        <i class=""metismenu-state-icon pe-7s-angle-down");
            WriteLiteral(@" caret-left""></i>
                    </a>
                    <ul>
                        <li>
                            <a href=""/Daycare_Back/Add_Daycare"">
                                <i class=""metismenu-icon""></i> Add Daycare
                            </a>
                        </li>
                        <li>
                            <a href=""/Daycare_Back/Daycares"">
                                <i class=""metismenu-icon""></i> Daycares
                            </a>
                        </li>
                        <li>
                            <a href=""/Daycare_Back/Daycares_Statistics"">
                                <i class=""metismenu-icon""></i> Statistics
                            </a>
                        </li>
                    </ul>
                </li>
            </ul>
        </div>
    </div>
</div>");
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
