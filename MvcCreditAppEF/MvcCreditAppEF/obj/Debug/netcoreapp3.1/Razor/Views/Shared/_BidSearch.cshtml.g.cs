#pragma checksum "D:\ASP.NET MVC Repos\MvcCreditAppEF\MvcCreditAppEF\Views\Shared\_BidSearch.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dfb1482932d2ed615d320a7d5b4dbc492773f7ee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__BidSearch), @"mvc.1.0.view", @"/Views/Shared/_BidSearch.cshtml")]
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
#line 1 "D:\ASP.NET MVC Repos\MvcCreditAppEF\MvcCreditAppEF\Views\_ViewImports.cshtml"
using MvcCreditAppEF;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\ASP.NET MVC Repos\MvcCreditAppEF\MvcCreditAppEF\Views\_ViewImports.cshtml"
using MvcCreditAppEF.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dfb1482932d2ed615d320a7d5b4dbc492773f7ee", @"/Views/Shared/_BidSearch.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01c8c1577f76c8f4601185816cc1466a04d0fdf2", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__BidSearch : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MvcCreditAppEF.Models.Bid>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div>\r\n    <h4> Все заявители кредита \"");
#nullable restore
#line 4 "D:\ASP.NET MVC Repos\MvcCreditAppEF\MvcCreditAppEF\Views\Shared\_BidSearch.cshtml"
                           Write(Model.First().CreditHead);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"</h4>\r\n    <ul>\r\n");
#nullable restore
#line 6 "D:\ASP.NET MVC Repos\MvcCreditAppEF\MvcCreditAppEF\Views\Shared\_BidSearch.cshtml"
          if (Model.Count() != 0)
            {
                foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li>");
#nullable restore
#line 10 "D:\ASP.NET MVC Repos\MvcCreditAppEF\MvcCreditAppEF\Views\Shared\_BidSearch.cshtml"
                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 11 "D:\ASP.NET MVC Repos\MvcCreditAppEF\MvcCreditAppEF\Views\Shared\_BidSearch.cshtml"
                }
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MvcCreditAppEF.Models.Bid>> Html { get; private set; }
    }
}
#pragma warning restore 1591