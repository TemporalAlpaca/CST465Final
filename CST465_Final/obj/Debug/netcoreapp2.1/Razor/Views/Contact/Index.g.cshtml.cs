#pragma checksum "C:\Users\Caleb\source\repos\CST465_Final\CST465_Final\Views\Contact\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dec7f841a5d7a8c337724c57b8195da71ad53873"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contact_Index), @"mvc.1.0.view", @"/Views/Contact/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Contact/Index.cshtml", typeof(AspNetCore.Views_Contact_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dec7f841a5d7a8c337724c57b8195da71ad53873", @"/Views/Contact/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1190beb42236403c3b6f92a5a61c0976b3bceac", @"/Views/_ViewImports.cshtml")]
    public class Views_Contact_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Assignment1.Models.ContactModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/DefaultStyles.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("~/Contact/Index"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Caleb\source\repos\CST465_Final\CST465_Final\Views\Contact\Index.cshtml"
  
    Layout = "~/Views/Shared/_DefaultLayout.cshtml";

#line default
#line hidden
            DefineSection("navBar", async() => {
                BeginContext(117, 39, true);
                WriteLiteral("\r\n<!DOCTYPE HTML>\r\n<html lang=\"en\">\r\n\r\n");
                EndContext();
                BeginContext(156, 746, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "91fbed67c39c4ad0b393fd1820958dba", async() => {
                    BeginContext(162, 6, true);
                    WriteLiteral("\r\n    ");
                    EndContext();
                    BeginContext(168, 52, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "cd5c6aa5409c44369e36ffb19cb6ebaf", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(220, 675, true);
                    WriteLiteral(@"
    <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css"" integrity=""sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO""
          crossorigin=""anonymous"">
    <meta http-equiv=""Content-Type"" content=""text/html; charset=UTF-8"" />
    <script src=""//cdnjs.cloudflare.com/ajax/libs/jquery/3.1.1/jquery.min.js""></script>
    <script src=""//cdnjs.cloudflare.com/ajax/libs/jquery-validate/1.15.1/jquery.validate.min.js""></script>
    <script src=""//cdnjs.cloudflare.com/ajax/libs/jquery-validation-unobtrusive/3.2.6/jquery.validate.unobtrusive.js""></script>
    <title>Procrastination Station</title>
");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(902, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(907, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("body", async() => {
                BeginContext(923, 2, true);
                WriteLiteral("\r\n");
                EndContext();
                BeginContext(925, 2375, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "310fb677e05849319a3cb44417bffd4a", async() => {
                    BeginContext(931, 6, true);
                    WriteLiteral("\r\n    ");
                    EndContext();
                    BeginContext(938, 23, false);
#line 23 "C:\Users\Caleb\source\repos\CST465_Final\CST465_Final\Views\Contact\Index.cshtml"
Write(Html.Partial("_NavBar"));

#line default
#line hidden
                    EndContext();
                    BeginContext(961, 14, true);
                    WriteLiteral("\r\n    <main>\r\n");
                    EndContext();
#line 25 "C:\Users\Caleb\source\repos\CST465_Final\CST465_Final\Views\Contact\Index.cshtml"
         if (Model == null)
        {

#line default
#line hidden
                    BeginContext(1015, 8, true);
                    WriteLiteral("        ");
                    EndContext();
                    BeginContext(1023, 1804, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "58fc826f860341fa91cdb89c2e51d195", async() => {
                        BeginContext(1092, 181, true);
                        WriteLiteral("\r\n            <div class=\"form-group\">\r\n                <label class=\"control-label col-sm-2\" for=\"Name\">Name:</label>\r\n                <div class=\"col-sm-10\">\r\n                    ");
                        EndContext();
                        BeginContext(1274, 72, false);
#line 31 "C:\Users\Caleb\source\repos\CST465_Final\CST465_Final\Views\Contact\Index.cshtml"
               Write(Html.TextBoxFor(m => m.Name, new { @class = "small-text form-control" }));

#line default
#line hidden
                        EndContext();
                        BeginContext(1346, 2, true);
                        WriteLiteral("\r\n");
                        EndContext();
                        BeginContext(1476, 180, true);
                        WriteLiteral("                </div>\r\n                <label class=\"control-label col-sm-2\" for=\"PhoneNumber\">Phone Number:</label>\r\n                <div class=\"col-sm-10\">\r\n                    ");
                        EndContext();
                        BeginContext(1657, 79, false);
#line 36 "C:\Users\Caleb\source\repos\CST465_Final\CST465_Final\Views\Contact\Index.cshtml"
               Write(Html.TextBoxFor(m => m.PhoneNumber, new { @class = "small-text form-control" }));

#line default
#line hidden
                        EndContext();
                        BeginContext(1736, 2, true);
                        WriteLiteral("\r\n");
                        EndContext();
                        BeginContext(1873, 167, true);
                        WriteLiteral("                </div>\r\n                <label class=\"control-label col-sm-2\" for=\"Email\">Email:</label>\r\n                <div class=\"col-sm-10\">\r\n                    ");
                        EndContext();
                        BeginContext(2041, 73, false);
#line 41 "C:\Users\Caleb\source\repos\CST465_Final\CST465_Final\Views\Contact\Index.cshtml"
               Write(Html.TextBoxFor(m => m.Email, new { @class = "small-text form-control" }));

#line default
#line hidden
                        EndContext();
                        BeginContext(2114, 2, true);
                        WriteLiteral("\r\n");
                        EndContext();
                        BeginContext(2233, 171, true);
                        WriteLiteral("                </div>\r\n                <label class=\"control-label col-sm-2\" for=\"Message\">Message:</label>\r\n                <div class=\"col-sm-10\">\r\n                    ");
                        EndContext();
                        BeginContext(2405, 75, false);
#line 46 "C:\Users\Caleb\source\repos\CST465_Final\CST465_Final\Views\Contact\Index.cshtml"
               Write(Html.TextBoxFor(m => m.Message, new { @class = "small-text form-control" }));

#line default
#line hidden
                        EndContext();
                        BeginContext(2480, 2, true);
                        WriteLiteral("\r\n");
                        EndContext();
                        BeginContext(2604, 216, true);
                        WriteLiteral("                </div>\r\n                <div class=\"col-sm-offset-2 col-sm-10\">\r\n                    <button type=\"submit\" class=\"btn btn-primary\">Submit</button>\r\n                </div>\r\n            </div>\r\n        ");
                        EndContext();
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(2827, 2, true);
                    WriteLiteral("\r\n");
                    EndContext();
#line 54 "C:\Users\Caleb\source\repos\CST465_Final\CST465_Final\Views\Contact\Index.cshtml"
        }
        else
        {

#line default
#line hidden
                    BeginContext(2865, 49, true);
                    WriteLiteral("        <div>\r\n            Name:\r\n            <b>");
                    EndContext();
                    BeginContext(2915, 10, false);
#line 59 "C:\Users\Caleb\source\repos\CST465_Final\CST465_Final\Views\Contact\Index.cshtml"
          Write(Model.Name);

#line default
#line hidden
                    EndContext();
                    BeginContext(2925, 79, true);
                    WriteLiteral("</b>\r\n        </div>\r\n        <div>\r\n            Phone Number:\r\n            <b>");
                    EndContext();
                    BeginContext(3005, 17, false);
#line 63 "C:\Users\Caleb\source\repos\CST465_Final\CST465_Final\Views\Contact\Index.cshtml"
          Write(Model.PhoneNumber);

#line default
#line hidden
                    EndContext();
                    BeginContext(3022, 62, true);
                    WriteLiteral("</b>\r\n        </div><div>\r\n            Email:\r\n            <b>");
                    EndContext();
                    BeginContext(3085, 11, false);
#line 66 "C:\Users\Caleb\source\repos\CST465_Final\CST465_Final\Views\Contact\Index.cshtml"
          Write(Model.Email);

#line default
#line hidden
                    EndContext();
                    BeginContext(3096, 64, true);
                    WriteLiteral("</b>\r\n        </div><div>\r\n            Message:\r\n            <b>");
                    EndContext();
                    BeginContext(3161, 13, false);
#line 69 "C:\Users\Caleb\source\repos\CST465_Final\CST465_Final\Views\Contact\Index.cshtml"
          Write(Model.Message);

#line default
#line hidden
                    EndContext();
                    BeginContext(3174, 22, true);
                    WriteLiteral("</b>\r\n        </div>\r\n");
                    EndContext();
#line 71 "C:\Users\Caleb\source\repos\CST465_Final\CST465_Final\Views\Contact\Index.cshtml"

        }

#line default
#line hidden
                    BeginContext(3209, 84, true);
                    WriteLiteral("    </main>\r\n    <footer>\r\n        <p>Created by Caleb Kauffman</p>\r\n    </footer>\r\n");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3300, 11, true);
                WriteLiteral("\r\n</html>\r\n");
                EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Assignment1.Models.ContactModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
