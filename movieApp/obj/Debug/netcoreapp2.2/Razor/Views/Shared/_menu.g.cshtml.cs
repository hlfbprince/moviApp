#pragma checksum "C:\Users\batul\OneDrive\Belgeler\GitHub\moviApp\movieApp\Views\Shared\_menu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "079f2cadbe3dfea1fb5dd06580ceb9912132ee51"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__menu), @"mvc.1.0.view", @"/Views/Shared/_menu.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_menu.cshtml", typeof(AspNetCore.Views_Shared__menu))]
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
#line 1 "C:\Users\batul\OneDrive\Belgeler\GitHub\moviApp\movieApp\Views\_ViewImports.cshtml"
using movieApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"079f2cadbe3dfea1fb5dd06580ceb9912132ee51", @"/Views/Shared/_menu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"668eed95e824ecf990b70fce2fc1585e73090826", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__menu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Category>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(30, 37, true);
            WriteLiteral("\r\n\r\n\r\n<div class=\"list-group\">\r\n   \r\n");
            EndContext();
#line 7 "C:\Users\batul\OneDrive\Belgeler\GitHub\moviApp\movieApp\Views\Shared\_menu.cshtml"
    foreach (var i in Model)
   {

#line default
#line hidden
            BeginContext(103, 67, true);
            WriteLiteral("        <a href=\"#\" class=\"list-group-item list-group-item-action\">");
            EndContext();
            BeginContext(171, 6, false);
#line 9 "C:\Users\batul\OneDrive\Belgeler\GitHub\moviApp\movieApp\Views\Shared\_menu.cshtml"
                                                              Write(i.Name);

#line default
#line hidden
            EndContext();
            BeginContext(177, 16, true);
            WriteLiteral("\r\n        </a>\r\n");
            EndContext();
#line 11 "C:\Users\batul\OneDrive\Belgeler\GitHub\moviApp\movieApp\Views\Shared\_menu.cshtml"
   }

#line default
#line hidden
            BeginContext(199, 8, true);
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591
