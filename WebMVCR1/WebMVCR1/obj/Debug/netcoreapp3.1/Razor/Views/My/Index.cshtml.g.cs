#pragma checksum "D:\ASP.NET MVC Repos\WebMVCR1\WebMVCR1\Views\My\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "93dab5ccc76ea6013efa0f9c4fa4506f1cdc91c2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_My_Index), @"mvc.1.0.view", @"/Views/My/Index.cshtml")]
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
#line 1 "D:\ASP.NET MVC Repos\WebMVCR1\WebMVCR1\Views\_ViewImports.cshtml"
using WebMVCR1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\ASP.NET MVC Repos\WebMVCR1\WebMVCR1\Views\_ViewImports.cshtml"
using WebMVCR1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93dab5ccc76ea6013efa0f9c4fa4506f1cdc91c2", @"/Views/My/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"361494229c79d7c682e0f24f09f2362211a49701", @"/Views/_ViewImports.cshtml")]
    public class Views_My_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\ASP.NET MVC Repos\WebMVCR1\WebMVCR1\Views\My\Index.cshtml"
   
    ViewBag.Title = "Главная";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\r\n    <h2>\r\n        ");
#nullable restore
#line 6 "D:\ASP.NET MVC Repos\WebMVCR1\WebMVCR1\Views\My\Index.cshtml"
   Write(ViewBag.Greeting);

#line default
#line hidden
#nullable disable
            WriteLiteral(", спасибо, что зашли и ");
#nullable restore
#line 6 "D:\ASP.NET MVC Repos\WebMVCR1\WebMVCR1\Views\My\Index.cshtml"
                                           Write(ViewData["Mes"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </h2>\r\n    <p>\r\n        ");
#nullable restore
#line 9 "D:\ASP.NET MVC Repos\WebMVCR1\WebMVCR1\Views\My\Index.cshtml"
   Write(Html.ActionLink("Введите свои данные", "InputData"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </p>\r\n    <p>\r\n        ");
#nullable restore
#line 12 "D:\ASP.NET MVC Repos\WebMVCR1\WebMVCR1\Views\My\Index.cshtml"
   Write(Html.ActionLink("Посмотрите, кто уже здесь", "OutputData"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </p>\r\n</div>");
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
