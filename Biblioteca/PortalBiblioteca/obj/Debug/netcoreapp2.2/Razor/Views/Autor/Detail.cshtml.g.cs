#pragma checksum "C:\Users\ialima\source\repos\Biblioteca\PortalBiblioteca\Views\Autor\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "56b1e99bf53c3806fd455f96163391f40bf0c4a3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Autor_Detail), @"mvc.1.0.view", @"/Views/Autor/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Autor/Detail.cshtml", typeof(AspNetCore.Views_Autor_Detail))]
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
#line 1 "C:\Users\ialima\source\repos\Biblioteca\PortalBiblioteca\Views\_ViewImports.cshtml"
using PortalBiblioteca;

#line default
#line hidden
#line 1 "C:\Users\ialima\source\repos\Biblioteca\PortalBiblioteca\Views\Autor\Detail.cshtml"
using PortalBiblioteca.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"56b1e99bf53c3806fd455f96163391f40bf0c4a3", @"/Views/Autor/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81fbc20716f7fdf83a30de2063aed39512d096e8", @"/Views/_ViewImports.cshtml")]
    public class Views_Autor_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(32, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\ialima\source\repos\Biblioteca\PortalBiblioteca\Views\Autor\Detail.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#line 6 "C:\Users\ialima\source\repos\Biblioteca\PortalBiblioteca\Views\Autor\Detail.cshtml"
  
    var autor = ViewBag.Message;

#line default
#line hidden
            BeginContext(116, 122, true);
            WriteLiteral("<h1>Index</h1>\r\n\r\n<table>\r\n    <tr>\r\n        <th>Id</th>\r\n        <th>Nome</th>\r\n    </tr>\r\n        <tr>\r\n            <td>");
            EndContext();
            BeginContext(239, 8, false);
#line 17 "C:\Users\ialima\source\repos\Biblioteca\PortalBiblioteca\Views\Autor\Detail.cshtml"
           Write(autor.Id);

#line default
#line hidden
            EndContext();
            BeginContext(247, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(271, 10, false);
#line 18 "C:\Users\ialima\source\repos\Biblioteca\PortalBiblioteca\Views\Autor\Detail.cshtml"
           Write(autor.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(281, 359, true);
            WriteLiteral(@"</td>
        </tr>
</table>

<style>
    table, td, th {
        border: 1px solid black;
    }

    table {
        border-collapse: collapse;
        width: 100%;
    }

    th {
        background-color: #6699ff;
        color: white;
        text-align: left;
    }

    tr:hover {
        background-color: #a6a6a6;
    }
</style>");
            EndContext();
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
