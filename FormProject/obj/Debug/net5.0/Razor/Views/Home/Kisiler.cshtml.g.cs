#pragma checksum "C:\Users\gobur\source\repos\FormProject\FormProject\Views\Home\Kisiler.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b47ace42d5bb649e4aa34fbe8b1f5745367c47db"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Kisiler), @"mvc.1.0.view", @"/Views/Home/Kisiler.cshtml")]
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
#line 1 "C:\Users\gobur\source\repos\FormProject\FormProject\Views\_ViewImports.cshtml"
using FormProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gobur\source\repos\FormProject\FormProject\Views\_ViewImports.cshtml"
using FormProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\gobur\source\repos\FormProject\FormProject\Views\_ViewImports.cshtml"
using FormProject.Entity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b47ace42d5bb649e4aa34fbe8b1f5745367c47db", @"/Views/Home/Kisiler.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"919094fc4993db93d0f09a43f3c7a61e8615046b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Kisiler : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PersonsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/home/delete"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b47ace42d5bb649e4aa34fbe8b1f5745367c47db4380", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"" />
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"" />
    <link rel=""preconnect"" href=""https://fonts.gstatic.com"">
    <link href=""https://fonts.googleapis.com/css2?family=Roboto:ital,wght@0,500;0,700;1,400&display=swap"" rel=""stylesheet"">
    <link rel=""stylesheet"" href=""/css/style.css"">
    <link rel=""preconnect"" href=""https://fonts.googleapis.com"">
    <link rel=""preconnect"" href=""https://fonts.googleapis.com"">
    <link rel=""preconnect"" href=""https://fonts.gstatic.com"" crossorigin>
    <link href=""https://fonts.googleapis.com/css2?family=Open+Sans&display=swap"" rel=""stylesheet"">
");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b47ace42d5bb649e4aa34fbe8b1f5745367c47db6029", async() => {
                WriteLiteral("\r\n\r\n");
#nullable restore
#line 18 "C:\Users\gobur\source\repos\FormProject\FormProject\Views\Home\Kisiler.cshtml"
     foreach (var item in Model.Persons)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("    <div class=\"container\">\r\n        <p>");
#nullable restore
#line 21 "C:\Users\gobur\source\repos\FormProject\FormProject\Views\Home\Kisiler.cshtml"
      Write(item.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n        <br>\r\n        <p>");
#nullable restore
#line 23 "C:\Users\gobur\source\repos\FormProject\FormProject\Views\Home\Kisiler.cshtml"
      Write(item.Surname);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n        <br>\r\n        <p>");
#nullable restore
#line 25 "C:\Users\gobur\source\repos\FormProject\FormProject\Views\Home\Kisiler.cshtml"
      Write(item.Age);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n        <br>\r\n        <p>");
#nullable restore
#line 27 "C:\Users\gobur\source\repos\FormProject\FormProject\Views\Home\Kisiler.cshtml"
      Write(item.StartDate);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b47ace42d5bb649e4aa34fbe8b1f5745367c47db7582", async() => {
                    WriteLiteral("\r\n            <input type=\"hidden\" name=\"PersonId\"");
                    BeginWriteAttribute("value", " value=\"", 1074, "\"", 1096, 1);
#nullable restore
#line 29 "C:\Users\gobur\source\repos\FormProject\FormProject\Views\Home\Kisiler.cshtml"
WriteAttributeValue("", 1082, item.PersonId, 1082, 14, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" />\r\n            <button style=\"margin-left:80%\" type=\"submit\" class=\"btn btn-danger\">Delete</button>\r\n        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        \r\n            <a style=\"margin-left:30%\"");
                BeginWriteAttribute("href", " href=\"", 1265, "\"", 1305, 2);
                WriteAttributeValue("", 1272, "/home/personupdate/", 1272, 19, true);
#nullable restore
#line 33 "C:\Users\gobur\source\repos\FormProject\FormProject\Views\Home\Kisiler.cshtml"
WriteAttributeValue("", 1291, item.PersonId, 1291, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 1306, "\"", 1328, 1);
#nullable restore
#line 33 "C:\Users\gobur\source\repos\FormProject\FormProject\Views\Home\Kisiler.cshtml"
WriteAttributeValue("", 1314, item.PersonId, 1314, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-primary\"  >UPDATE</a>\r\n        \r\n    </div>\r\n    <br>\r\n");
#nullable restore
#line 37 "C:\Users\gobur\source\repos\FormProject\FormProject\Views\Home\Kisiler.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n\r\n");
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
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PersonsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
