#pragma checksum "C:\Users\Caleb\source\repos\CST465_Final\CST465_Final\Views\Admin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7a266a0eec3df06e3456e87c2095043e4cc492f9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Index), @"mvc.1.0.view", @"/Views/Admin/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/Index.cshtml", typeof(AspNetCore.Views_Admin_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a266a0eec3df06e3456e87c2095043e4cc492f9", @"/Views/Admin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb36af1f447ed1534cf15452c51ba049193c0ff5", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/DefaultStyles.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-group"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Admin/InsertRole"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Admin/UpdateUserRole"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Caleb\source\repos\CST465_Final\CST465_Final\Views\Admin\Index.cshtml"
  
    Layout = "~/Views/Shared/_DefaultLayout.cshtml";

#line default
#line hidden
            BeginContext(147, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("navBar", async() => {
                BeginContext(165, 53, true);
                WriteLiteral("\r\n    <!DOCTYPE HTML>\r\n\r\n    <html lang=\"en\">\r\n\r\n    ");
                EndContext();
                BeginContext(218, 785, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a31ba18d44344aeebe393e27a30d49df", async() => {
                    BeginContext(224, 10, true);
                    WriteLiteral("\r\n        ");
                    EndContext();
                    BeginContext(234, 52, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "07347a30b53641edb39b850a9f408e3a", async() => {
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
                    BeginContext(286, 710, true);
                    WriteLiteral(@"
        <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css"" integrity=""sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO""
              crossorigin=""anonymous"">
        <meta http-equiv=""Content-Type"" content=""text/html; charset=UTF-8"" />
        <script src=""//cdnjs.cloudflare.com/ajax/libs/jquery/3.1.1/jquery.min.js""></script>
        <script src=""//cdnjs.cloudflare.com/ajax/libs/jquery-validate/1.15.1/jquery.validate.min.js""></script>
        <script src=""//cdnjs.cloudflare.com/ajax/libs/jquery-validation-unobtrusive/3.2.6/jquery.validate.unobtrusive.js""></script>
        <title>Procrastinate With Pirates</title>
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
                BeginContext(1003, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(1008, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("body", async() => {
                BeginContext(1024, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(1030, 1505, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ca3cee811cf244b18309312f1b18c0e8", async() => {
                    BeginContext(1036, 10, true);
                    WriteLiteral("\r\n        ");
                    EndContext();
                    BeginContext(1047, 23, false);
#line 26 "C:\Users\Caleb\source\repos\CST465_Final\CST465_Final\Views\Admin\Index.cshtml"
   Write(Html.Partial("_NavBar"));

#line default
#line hidden
                    EndContext();
                    BeginContext(1070, 53, true);
                    WriteLiteral("\r\n        <div>\r\n            Roles:\r\n        </div>\r\n");
                    EndContext();
#line 30 "C:\Users\Caleb\source\repos\CST465_Final\CST465_Final\Views\Admin\Index.cshtml"
         foreach (var role in RoleMan.Roles)
        {

#line default
#line hidden
                    BeginContext(1180, 47, true);
                    WriteLiteral("            <div>\r\n                Role Name : ");
                    EndContext();
                    BeginContext(1228, 9, false);
#line 33 "C:\Users\Caleb\source\repos\CST465_Final\CST465_Final\Views\Admin\Index.cshtml"
                       Write(role.Name);

#line default
#line hidden
                    EndContext();
                    BeginContext(1237, 22, true);
                    WriteLiteral("\r\n            </div>\r\n");
                    EndContext();
#line 35 "C:\Users\Caleb\source\repos\CST465_Final\CST465_Final\Views\Admin\Index.cshtml"
        }

#line default
#line hidden
                    BeginContext(1270, 55, true);
                    WriteLiteral("\r\n        <div>\r\n            Users:\r\n        </div>\r\n\r\n");
                    EndContext();
#line 41 "C:\Users\Caleb\source\repos\CST465_Final\CST465_Final\Views\Admin\Index.cshtml"
         foreach (var user in UserMan.Users)
        {

#line default
#line hidden
                    BeginContext(1382, 45, true);
                    WriteLiteral("            <div>\r\n                Username: ");
                    EndContext();
                    BeginContext(1428, 13, false);
#line 44 "C:\Users\Caleb\source\repos\CST465_Final\CST465_Final\Views\Admin\Index.cshtml"
                     Write(user.UserName);

#line default
#line hidden
                    EndContext();
                    BeginContext(1441, 22, true);
                    WriteLiteral("\r\n            </div>\r\n");
                    EndContext();
#line 46 "C:\Users\Caleb\source\repos\CST465_Final\CST465_Final\Views\Admin\Index.cshtml"
        }

#line default
#line hidden
                    BeginContext(1474, 64, true);
                    WriteLiteral("\r\n        <div>\r\n            Add Role:\r\n        </div>\r\n        ");
                    EndContext();
                    BeginContext(1538, 346, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "acb40a9ed6fd46cdb5ec27cfad42ea08", async() => {
                        BeginContext(1604, 14, true);
                        WriteLiteral("\r\n            ");
                        EndContext();
                        BeginContext(1619, 23, false);
#line 52 "C:\Users\Caleb\source\repos\CST465_Final\CST465_Final\Views\Admin\Index.cshtml"
       Write(Html.AntiForgeryToken());

#line default
#line hidden
                        EndContext();
                        BeginContext(1642, 235, true);
                        WriteLiteral("\r\n            <label for=\"RoleName\">Role Name</label>\r\n            <input class=\"form-control\" type=\"text\" id=\"RoleName\" name=\"RoleName\" value=\"\" />\r\n\r\n            <button class=\"btn btn-primary\" type=\"submit\">Submit</button>\r\n        ");
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
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(1884, 74, true);
                    WriteLiteral("\r\n\r\n        <div>\r\n            Add User to Role:\r\n        </div>\r\n        ");
                    EndContext();
                    BeginContext(1958, 564, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "78429bab577e4f4d8ea952d713ade6b8", async() => {
                        BeginContext(2028, 14, true);
                        WriteLiteral("\r\n            ");
                        EndContext();
                        BeginContext(2043, 23, false);
#line 63 "C:\Users\Caleb\source\repos\CST465_Final\CST465_Final\Views\Admin\Index.cshtml"
       Write(Html.AntiForgeryToken());

#line default
#line hidden
                        EndContext();
                        BeginContext(2066, 69, true);
                        WriteLiteral("\r\n\r\n            <label for=\"RoleName\">Role Name</label>\r\n            ");
                        EndContext();
                        BeginContext(2136, 143, false);
#line 66 "C:\Users\Caleb\source\repos\CST465_Final\CST465_Final\Views\Admin\Index.cshtml"
       Write(Html.DropDownList("RoleName", (new SelectList(RoleMan.Roles, "Name", "Name")),
                "Select Role", new { @class = "form-control" }));

#line default
#line hidden
                        EndContext();
                        BeginContext(2279, 236, true);
                        WriteLiteral("\r\n\r\n            <label for=\"Username\">Username</label>\r\n            <input class=\"form-control\" type=\"text\" id=\"Username\" name=\"Username\" value=\"\" />\r\n\r\n            <button class=\"btn btn-primary\" type=\"submit\">Submit</button>\r\n        ");
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
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(2522, 6, true);
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
                BeginContext(2535, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<IdentityUser> UserMan { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public RoleManager<IdentityRole> RoleMan { get; private set; }
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
