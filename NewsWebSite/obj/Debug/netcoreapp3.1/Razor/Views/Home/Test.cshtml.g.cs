#pragma checksum "/Users/leonzaitsev/Projects/NewsWebSite/NewsWebSite/Views/Home/Test.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bccb9cf67b41ca16730c81f65a057b7e22d10d2b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Test), @"mvc.1.0.view", @"/Views/Home/Test.cshtml")]
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
#line 1 "/Users/leonzaitsev/Projects/NewsWebSite/NewsWebSite/Views/_ViewImports.cshtml"
using NewsWebSite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/leonzaitsev/Projects/NewsWebSite/NewsWebSite/Views/_ViewImports.cshtml"
using NewsWebSite.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bccb9cf67b41ca16730c81f65a057b7e22d10d2b", @"/Views/Home/Test.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66f0adc126f6b6af83e084cca96c525a5f8a4c19", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Test : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NewsWebSite.Models.ArticleModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<div>");
#nullable restore
#line 3 "/Users/leonzaitsev/Projects/NewsWebSite/NewsWebSite/Views/Home/Test.cshtml"
Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n<div>");
#nullable restore
#line 4 "/Users/leonzaitsev/Projects/NewsWebSite/NewsWebSite/Views/Home/Test.cshtml"
Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n<div>");
#nullable restore
#line 5 "/Users/leonzaitsev/Projects/NewsWebSite/NewsWebSite/Views/Home/Test.cshtml"
Write(Model.Body);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NewsWebSite.Models.ArticleModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
