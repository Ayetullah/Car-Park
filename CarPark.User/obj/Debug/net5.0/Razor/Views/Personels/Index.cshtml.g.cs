#pragma checksum "E:\Backend\Car-Park\CarPark.User\Views\Personels\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "91f64060dec22ed0134d7a3418905fe9990c0219"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Personels_Index), @"mvc.1.0.view", @"/Views/Personels/Index.cshtml")]
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
#line 1 "E:\Backend\Car-Park\CarPark.User\Views\_ViewImports.cshtml"
using CarPark.User;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Backend\Car-Park\CarPark.User\Views\_ViewImports.cshtml"
using CarPark.User.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"91f64060dec22ed0134d7a3418905fe9990c0219", @"/Views/Personels/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2afc4cfea809e94fda0fb6038feb0c2458b2ad7d", @"/Views/_ViewImports.cshtml")]
    public class Views_Personels_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CarPark.Entities.Models.Personel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\Backend\Car-Park\CarPark.User\Views\Personels\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<table class=\"table\">\r\n    <tr>\r\n        <td>Id</td>\r\n        <td>Email</td>\r\n        <td>Olusturulma Tarihi</td>\r\n        <td>Kullanıcı Adı</td>\r\n    </tr>\r\n");
#nullable restore
#line 14 "E:\Backend\Car-Park\CarPark.User\Views\Personels\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 17 "E:\Backend\Car-Park\CarPark.User\Views\Personels\Index.cshtml"
           Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 18 "E:\Backend\Car-Park\CarPark.User\Views\Personels\Index.cshtml"
           Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 19 "E:\Backend\Car-Park\CarPark.User\Views\Personels\Index.cshtml"
           Write(item.CreatedDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 20 "E:\Backend\Car-Park\CarPark.User\Views\Personels\Index.cshtml"
           Write(item.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 22 "E:\Backend\Car-Park\CarPark.User\Views\Personels\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CarPark.Entities.Models.Personel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
