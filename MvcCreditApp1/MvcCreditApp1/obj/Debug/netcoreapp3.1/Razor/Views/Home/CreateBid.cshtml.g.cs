#pragma checksum "D:\ASP.NET MVC Repos\MvcCreditApp1\MvcCreditApp1\Views\Home\CreateBid.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1e77306fdf1f4a575083e4df61242e5246dc5989"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_CreateBid), @"mvc.1.0.view", @"/Views/Home/CreateBid.cshtml")]
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
#line 1 "D:\ASP.NET MVC Repos\MvcCreditApp1\MvcCreditApp1\Views\_ViewImports.cshtml"
using MvcCreditApp1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\ASP.NET MVC Repos\MvcCreditApp1\MvcCreditApp1\Views\_ViewImports.cshtml"
using MvcCreditApp1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e77306fdf1f4a575083e4df61242e5246dc5989", @"/Views/Home/CreateBid.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7847e5becdc821575ffe8db777fc478b2b96438e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_CreateBid : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h3>Существующие заявки</h3>\r\n<table class=\"table\">\r\n    <tr>\r\n        <td><p>Имя</p></td>\r\n        <td><p>Тип кредита</p></td>\r\n    </tr>\r\n");
#nullable restore
#line 7 "D:\ASP.NET MVC Repos\MvcCreditApp1\MvcCreditApp1\Views\Home\CreateBid.cshtml"
     foreach (var c in ViewBag.Bids)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td><p>");
#nullable restore
#line 10 "D:\ASP.NET MVC Repos\MvcCreditApp1\MvcCreditApp1\Views\Home\CreateBid.cshtml"
              Write(c.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></td>\r\n            <td><p>");
#nullable restore
#line 11 "D:\ASP.NET MVC Repos\MvcCreditApp1\MvcCreditApp1\Views\Home\CreateBid.cshtml"
              Write(c.CreditHead);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></td>\r\n        </tr>\r\n");
#nullable restore
#line 13 "D:\ASP.NET MVC Repos\MvcCreditApp1\MvcCreditApp1\Views\Home\CreateBid.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<h3>Форма подачи заявки по программам кредитования</h3>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1e77306fdf1f4a575083e4df61242e5246dc59895181", async() => {
                WriteLiteral(@"
    <table class=""table"">
        <tr>
            <td><p>Введите свое имя</p></td>
            <td><input type=""text"" name=""Name"" /></td>
        </tr>
        <tr>
            <td><p>Выберите из списка тип кредита :</p></td>
            <td>
                <select name=""CreditHead"">
");
#nullable restore
#line 26 "D:\ASP.NET MVC Repos\MvcCreditApp1\MvcCreditApp1\Views\Home\CreateBid.cshtml"
                     foreach (var cr in ViewBag.Credits)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1e77306fdf1f4a575083e4df61242e5246dc59896040", async() => {
#nullable restore
#line 28 "D:\ASP.NET MVC Repos\MvcCreditApp1\MvcCreditApp1\Views\Home\CreateBid.cshtml"
                           Write(cr.Head);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 29 "D:\ASP.NET MVC Repos\MvcCreditApp1\MvcCreditApp1\Views\Home\CreateBid.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </select>\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <td><input type=\"submit\" value=\"Отправить\" /></td>\r\n            <td></td>\r\n        </tr>\r\n    </table>\r\n");
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
