#pragma checksum "D:\SimonHTL\Programmieren\C# - Vogt\Web\WebProjekt\WebProjekt_HauserSimon\WebBsp(Schule)_Einführung\Views\Shop\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2838b73350bcae05cd9b610ce89ef1656cf48580"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shop_Index), @"mvc.1.0.view", @"/Views/Shop/Index.cshtml")]
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
#line 1 "D:\SimonHTL\Programmieren\C# - Vogt\Web\WebProjekt\WebProjekt_HauserSimon\WebBsp(Schule)_Einführung\Views\_ViewImports.cshtml"
using Hauser_WebProjekt;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\SimonHTL\Programmieren\C# - Vogt\Web\WebProjekt\WebProjekt_HauserSimon\WebBsp(Schule)_Einführung\Views\Shop\Index.cshtml"
using Hauser_WebProjekt.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2838b73350bcae05cd9b610ce89ef1656cf48580", @"/Views/Shop/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c05b8f2a245524c7158cfd737ad2adfef6d8bc9", @"/Views/_ViewImports.cshtml")]
    public class Views_Shop_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Artikel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\SimonHTL\Programmieren\C# - Vogt\Web\WebProjekt\WebProjekt_HauserSimon\WebBsp(Schule)_Einführung\Views\Shop\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 10 "D:\SimonHTL\Programmieren\C# - Vogt\Web\WebProjekt\WebProjekt_HauserSimon\WebBsp(Schule)_Einführung\Views\Shop\Index.cshtml"
 if ((Model == null || Model.Count == 0))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>\r\n        Es sind keine Artikel im Shop vorhanden.\r\n    </p>\r\n");
#nullable restore
#line 15 "D:\SimonHTL\Programmieren\C# - Vogt\Web\WebProjekt\WebProjekt_HauserSimon\WebBsp(Schule)_Einführung\Views\Shop\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <table>
        <thead>
            <tr>
                <td>Shopartikel</td>
            </tr>
        </thead>
        <tbody>
            <tr>
                <th>Artikel-ID</th>
                <th>Name</th>
                <th>Beschreibung</th>
                <th>Preis</th>
            </tr>
");
#nullable restore
#line 31 "D:\SimonHTL\Programmieren\C# - Vogt\Web\WebProjekt\WebProjekt_HauserSimon\WebBsp(Schule)_Einführung\Views\Shop\Index.cshtml"
             foreach (Artikel a in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 34 "D:\SimonHTL\Programmieren\C# - Vogt\Web\WebProjekt\WebProjekt_HauserSimon\WebBsp(Schule)_Einführung\Views\Shop\Index.cshtml"
                   Write(a.ArtikelID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 35 "D:\SimonHTL\Programmieren\C# - Vogt\Web\WebProjekt\WebProjekt_HauserSimon\WebBsp(Schule)_Einführung\Views\Shop\Index.cshtml"
                   Write(a.ArtikelName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 36 "D:\SimonHTL\Programmieren\C# - Vogt\Web\WebProjekt\WebProjekt_HauserSimon\WebBsp(Schule)_Einführung\Views\Shop\Index.cshtml"
                   Write(a.Beschreibung);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 37 "D:\SimonHTL\Programmieren\C# - Vogt\Web\WebProjekt\WebProjekt_HauserSimon\WebBsp(Schule)_Einführung\Views\Shop\Index.cshtml"
                   Write(a.Preis);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 39 "D:\SimonHTL\Programmieren\C# - Vogt\Web\WebProjekt\WebProjekt_HauserSimon\WebBsp(Schule)_Einführung\Views\Shop\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n        <tfoot>\r\n            <tr>\r\n                <td colspan=5>\r\n                    alle Artikel unseres Shops\r\n                </td>\r\n            </tr>\r\n        </tfoot>\r\n    </table>\r\n");
#nullable restore
#line 49 "D:\SimonHTL\Programmieren\C# - Vogt\Web\WebProjekt\WebProjekt_HauserSimon\WebBsp(Schule)_Einführung\Views\Shop\Index.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Artikel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
