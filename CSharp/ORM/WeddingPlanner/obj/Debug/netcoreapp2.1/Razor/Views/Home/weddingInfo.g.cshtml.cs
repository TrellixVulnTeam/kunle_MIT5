#pragma checksum "C:\Users\olaku\OneDrive\Documents\CODING_DOJO\CSharp\ORM\WeddingPlanner\Views\Home\weddingInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8df0e7654948b6166c05f460cc1b460ed4f1ce20"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_weddingInfo), @"mvc.1.0.view", @"/Views/Home/weddingInfo.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/weddingInfo.cshtml", typeof(AspNetCore.Views_Home_weddingInfo))]
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
#line 1 "C:\Users\olaku\OneDrive\Documents\CODING_DOJO\CSharp\ORM\WeddingPlanner\Views\_ViewImports.cshtml"
using WeddingPlanner;

#line default
#line hidden
#line 2 "C:\Users\olaku\OneDrive\Documents\CODING_DOJO\CSharp\ORM\WeddingPlanner\Views\_ViewImports.cshtml"
using WeddingPlanner.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8df0e7654948b6166c05f460cc1b460ed4f1ce20", @"/Views/Home/weddingInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e9e38482b8beecdb199b7be73dfa5c3d6a2f574", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_weddingInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Wedding>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(16, 173, true);
            WriteLiteral("\r\n<div class=\"bg-secondary pb-4 d-inline-block col-12\">\r\n    <div class=\"navbar navbar-expand-lg bg-dark text-white justify-content-between\">\r\n        <h3 class=\"display-4\">");
            EndContext();
            BeginContext(190, 13, false);
#line 5 "C:\Users\olaku\OneDrive\Documents\CODING_DOJO\CSharp\ORM\WeddingPlanner\Views\Home\weddingInfo.cshtml"
                         Write(Model.Husband);

#line default
#line hidden
            EndContext();
            BeginContext(203, 5, true);
            WriteLiteral(" and ");
            EndContext();
            BeginContext(209, 10, false);
#line 5 "C:\Users\olaku\OneDrive\Documents\CODING_DOJO\CSharp\ORM\WeddingPlanner\Views\Home\weddingInfo.cshtml"
                                            Write(Model.Wife);

#line default
#line hidden
            EndContext();
            BeginContext(219, 179, true);
            WriteLiteral("\'s Wedding</h3>\r\n        <a href=\"/Dashboard\">Dashboard</a>\r\n        <a href=\"/logout\">Log Out</a>\r\n    </div>\r\n    <div class=\"container col-12 bg-light p-5\">\r\n        <h4>Date: ");
            EndContext();
            BeginContext(399, 36, false);
#line 10 "C:\Users\olaku\OneDrive\Documents\CODING_DOJO\CSharp\ORM\WeddingPlanner\Views\Home\weddingInfo.cshtml"
             Write(Model.Date.ToString("MMMM dd, yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(435, 60, true);
            WriteLiteral("</h4>\r\n        <h4 class=\"mt-3\">Guests: \r\n            <ul>\r\n");
            EndContext();
#line 13 "C:\Users\olaku\OneDrive\Documents\CODING_DOJO\CSharp\ORM\WeddingPlanner\Views\Home\weddingInfo.cshtml"
                  
                    foreach(var guest in Model.Guests)
                    {

#line default
#line hidden
            BeginContext(594, 67, true);
            WriteLiteral("                        <li class=\"font-weight-normal font-italic\">");
            EndContext();
            BeginContext(662, 20, false);
#line 16 "C:\Users\olaku\OneDrive\Documents\CODING_DOJO\CSharp\ORM\WeddingPlanner\Views\Home\weddingInfo.cshtml"
                                                              Write(guest.User.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(682, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(684, 19, false);
#line 16 "C:\Users\olaku\OneDrive\Documents\CODING_DOJO\CSharp\ORM\WeddingPlanner\Views\Home\weddingInfo.cshtml"
                                                                                    Write(guest.User.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(703, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 17 "C:\Users\olaku\OneDrive\Documents\CODING_DOJO\CSharp\ORM\WeddingPlanner\Views\Home\weddingInfo.cshtml"
                    }
                

#line default
#line hidden
            BeginContext(752, 54, true);
            WriteLiteral("            </ul>          \r\n        </h4>\r\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Wedding> Html { get; private set; }
    }
}
#pragma warning restore 1591