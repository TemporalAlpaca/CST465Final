#pragma checksum "C:\Users\Caleb\source\repos\CST465_Final\CST465_Final\Views\Shared\_DefaultLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a9824dea9870f35c65c7d0cd888a5d2274a4721f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__DefaultLayout), @"mvc.1.0.view", @"/Views/Shared/_DefaultLayout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_DefaultLayout.cshtml", typeof(AspNetCore.Views_Shared__DefaultLayout))]
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
#line 1 "C:\Users\Caleb\source\repos\CST465_Final\CST465_Final\Views\_ViewImports.cshtml"
using CST465_Final;

#line default
#line hidden
#line 2 "C:\Users\Caleb\source\repos\CST465_Final\CST465_Final\Views\_ViewImports.cshtml"
using CST465_Final.Models;

#line default
#line hidden
#line 3 "C:\Users\Caleb\source\repos\CST465_Final\CST465_Final\Views\_ViewImports.cshtml"
using Assignment1.Models;

#line default
#line hidden
#line 4 "C:\Users\Caleb\source\repos\CST465_Final\CST465_Final\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9824dea9870f35c65c7d0cd888a5d2274a4721f", @"/Views/Shared/_DefaultLayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb36af1f447ed1534cf15452c51ba049193c0ff5", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__DefaultLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(9, 23, false);
#line 2 "C:\Users\Caleb\source\repos\CST465_Final\CST465_Final\Views\Shared\_DefaultLayout.cshtml"
Write(RenderSection("navBar"));

#line default
#line hidden
            EndContext();
#line 2 "C:\Users\Caleb\source\repos\CST465_Final\CST465_Final\Views\Shared\_DefaultLayout.cshtml"
                            ;
    

#line default
#line hidden
            BeginContext(40, 21, false);
#line 3 "C:\Users\Caleb\source\repos\CST465_Final\CST465_Final\Views\Shared\_DefaultLayout.cshtml"
Write(RenderSection("body"));

#line default
#line hidden
            EndContext();
#line 3 "C:\Users\Caleb\source\repos\CST465_Final\CST465_Final\Views\Shared\_DefaultLayout.cshtml"
                          ;

#line default
#line hidden
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
