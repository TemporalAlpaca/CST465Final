#pragma checksum "C:\Users\Caleb\source\repos\CST465_Final\CST465_Final\Views\Pirate\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "196371e69f7646948d3d02b511ffc74ba367fe42"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pirate_Create), @"mvc.1.0.view", @"/Views/Pirate/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pirate/Create.cshtml", typeof(AspNetCore.Views_Pirate_Create))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"196371e69f7646948d3d02b511ffc74ba367fe42", @"/Views/Pirate/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"71b888dc17bb5c63826d0980ee01349baf20cd4b", @"/Views/_ViewImports.cshtml")]
    public class Views_Pirate_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CST465_Final.Models.PirateModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/DefaultStyles.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-group"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Insert", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Pirate", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Caleb\source\repos\CST465_Final\CST465_Final\Views\Pirate\Create.cshtml"
  
    Layout = "~/Views/Shared/_DefaultLayout.cshtml";

#line default
#line hidden
            DefineSection("navBar", async() => {
                BeginContext(117, 53, true);
                WriteLiteral("\r\n    <!DOCTYPE HTML>\r\n\r\n    <html lang=\"en\">\r\n\r\n    ");
                EndContext();
                BeginContext(170, 774, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "027c3978bb4b466198b6d93f901d6174", async() => {
                    BeginContext(176, 10, true);
                    WriteLiteral("\r\n        ");
                    EndContext();
                    BeginContext(186, 52, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3da24ec400fe4436ac5113588febe4cb", async() => {
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
                    BeginContext(238, 699, true);
                    WriteLiteral(@"
        <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css"" integrity=""sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO""
              crossorigin=""anonymous"">
        <meta http-equiv=""Content-Type"" content=""text/html; charset=UTF-8"" />
        <script src=""//cdnjs.cloudflare.com/ajax/libs/jquery/3.1.1/jquery.min.js""></script>
        <script src=""//cdnjs.cloudflare.com/ajax/libs/jquery-validate/1.15.1/jquery.validate.min.js""></script>
        <script src=""//cdnjs.cloudflare.com/ajax/libs/jquery-validation-unobtrusive/3.2.6/jquery.validate.unobtrusive.js""></script>
        <title>Create a Pirate</title>
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
                BeginContext(944, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            DefineSection("body", async() => {
                BeginContext(963, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(969, 1480, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "69c6f5a797fe442ea6e50b5a031d9c9e", async() => {
                    BeginContext(975, 78, true);
                    WriteLiteral("\r\n        <div>\r\n            <b>Create a Pirate:</b>\r\n        </div>\r\n        ");
                    EndContext();
                    BeginContext(1053, 1383, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a8fef1228457444a9094ecd6e060f2f7", async() => {
                        BeginContext(1136, 14, true);
                        WriteLiteral("\r\n            ");
                        EndContext();
                        BeginContext(1151, 23, false);
#line 27 "C:\Users\Caleb\source\repos\CST465_Final\CST465_Final\Views\Pirate\Create.cshtml"
       Write(Html.AntiForgeryToken());

#line default
#line hidden
                        EndContext();
                        BeginContext(1174, 37, true);
                        WriteLiteral("\r\n            <div>\r\n                ");
                        EndContext();
                        BeginContext(1212, 26, false);
#line 29 "C:\Users\Caleb\source\repos\CST465_Final\CST465_Final\Views\Pirate\Create.cshtml"
           Write(Html.LabelFor(m => m.name));

#line default
#line hidden
                        EndContext();
                        BeginContext(1238, 18, true);
                        WriteLiteral("\r\n                ");
                        EndContext();
                        BeginContext(1257, 81, false);
#line 30 "C:\Users\Caleb\source\repos\CST465_Final\CST465_Final\Views\Pirate\Create.cshtml"
           Write(Html.EditorFor(m => m.name, new { attributes = new { @class = "form-control" } }));

#line default
#line hidden
                        EndContext();
                        BeginContext(1338, 59, true);
                        WriteLiteral("\r\n            </div>\r\n\r\n            <div>\r\n                ");
                        EndContext();
                        BeginContext(1398, 32, false);
#line 34 "C:\Users\Caleb\source\repos\CST465_Final\CST465_Final\Views\Pirate\Create.cshtml"
           Write(Html.LabelFor(m => m.beardColor));

#line default
#line hidden
                        EndContext();
                        BeginContext(1430, 18, true);
                        WriteLiteral("\r\n                ");
                        EndContext();
                        BeginContext(1449, 87, false);
#line 35 "C:\Users\Caleb\source\repos\CST465_Final\CST465_Final\Views\Pirate\Create.cshtml"
           Write(Html.EditorFor(m => m.beardColor, new { attributes = new { @class = "form-control" } }));

#line default
#line hidden
                        EndContext();
                        BeginContext(1536, 59, true);
                        WriteLiteral("\r\n            </div>\r\n\r\n            <div>\r\n                ");
                        EndContext();
                        BeginContext(1596, 33, false);
#line 39 "C:\Users\Caleb\source\repos\CST465_Final\CST465_Final\Views\Pirate\Create.cshtml"
           Write(Html.LabelFor(m => m.catchPhrase));

#line default
#line hidden
                        EndContext();
                        BeginContext(1629, 18, true);
                        WriteLiteral("\r\n                ");
                        EndContext();
                        BeginContext(1648, 90, false);
#line 40 "C:\Users\Caleb\source\repos\CST465_Final\CST465_Final\Views\Pirate\Create.cshtml"
           Write(Html.TextAreaFor(m => m.catchPhrase, new { attributes = new { @class = "form-control" } }));

#line default
#line hidden
                        EndContext();
                        BeginContext(1738, 59, true);
                        WriteLiteral("\r\n            </div>\r\n\r\n            <div>\r\n                ");
                        EndContext();
                        BeginContext(1798, 29, false);
#line 44 "C:\Users\Caleb\source\repos\CST465_Final\CST465_Final\Views\Pirate\Create.cshtml"
           Write(Html.LabelFor(m => m.numLegs));

#line default
#line hidden
                        EndContext();
                        BeginContext(1827, 18, true);
                        WriteLiteral("\r\n                ");
                        EndContext();
                        BeginContext(1846, 84, false);
#line 45 "C:\Users\Caleb\source\repos\CST465_Final\CST465_Final\Views\Pirate\Create.cshtml"
           Write(Html.EditorFor(m => m.numLegs, new { attributes = new { @class = "form-control" } }));

#line default
#line hidden
                        EndContext();
                        BeginContext(1930, 59, true);
                        WriteLiteral("\r\n            </div>\r\n\r\n            <div>\r\n                ");
                        EndContext();
                        BeginContext(1990, 28, false);
#line 49 "C:\Users\Caleb\source\repos\CST465_Final\CST465_Final\Views\Pirate\Create.cshtml"
           Write(Html.LabelFor(m => m.hasHat));

#line default
#line hidden
                        EndContext();
                        BeginContext(2018, 18, true);
                        WriteLiteral("\r\n                ");
                        EndContext();
                        BeginContext(2037, 85, false);
#line 50 "C:\Users\Caleb\source\repos\CST465_Final\CST465_Final\Views\Pirate\Create.cshtml"
           Write(Html.CheckBoxFor(m => m.hasHat, new { attributes = new { @class = "form-control" } }));

#line default
#line hidden
                        EndContext();
                        BeginContext(2122, 59, true);
                        WriteLiteral("\r\n            </div>\r\n\r\n            <div>\r\n                ");
                        EndContext();
                        BeginContext(2182, 33, false);
#line 54 "C:\Users\Caleb\source\repos\CST465_Final\CST465_Final\Views\Pirate\Create.cshtml"
           Write(Html.LabelFor(m => m.hasEyepatch));

#line default
#line hidden
                        EndContext();
                        BeginContext(2215, 18, true);
                        WriteLiteral("\r\n                ");
                        EndContext();
                        BeginContext(2234, 90, false);
#line 55 "C:\Users\Caleb\source\repos\CST465_Final\CST465_Final\Views\Pirate\Create.cshtml"
           Write(Html.CheckBoxFor(m => m.hasEyepatch, new { attributes = new { @class = "form-control" } }));

#line default
#line hidden
                        EndContext();
                        BeginContext(2324, 105, true);
                        WriteLiteral("\r\n            </div>\r\n            <button class=\"btn btn-primary\" type=\"submit\">Submit</button>\r\n        ");
                        EndContext();
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(2436, 6, true);
                    WriteLiteral("\r\n    ");
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
                BeginContext(2449, 2, true);
                WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CST465_Final.Models.PirateModel> Html { get; private set; }
    }
}
#pragma warning restore 1591