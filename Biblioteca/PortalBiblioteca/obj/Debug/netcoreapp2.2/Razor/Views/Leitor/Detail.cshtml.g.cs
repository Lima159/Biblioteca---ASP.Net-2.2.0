#pragma checksum "C:\Users\ialima\source\repos\PortalBiblioteca\Biblioteca\PortalBiblioteca\Views\Leitor\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d253797f8a82a2f9a18accd54373c21e033b98bd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Leitor_Detail), @"mvc.1.0.view", @"/Views/Leitor/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Leitor/Detail.cshtml", typeof(AspNetCore.Views_Leitor_Detail))]
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
#line 1 "C:\Users\ialima\source\repos\PortalBiblioteca\Biblioteca\PortalBiblioteca\Views\_ViewImports.cshtml"
using PortalBiblioteca;

#line default
#line hidden
#line 1 "C:\Users\ialima\source\repos\PortalBiblioteca\Biblioteca\PortalBiblioteca\Views\Leitor\Detail.cshtml"
using PortalBiblioteca.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d253797f8a82a2f9a18accd54373c21e033b98bd", @"/Views/Leitor/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81fbc20716f7fdf83a30de2063aed39512d096e8", @"/Views/_ViewImports.cshtml")]
    public class Views_Leitor_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(32, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\ialima\source\repos\PortalBiblioteca\Biblioteca\PortalBiblioteca\Views\Leitor\Detail.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#line 6 "C:\Users\ialima\source\repos\PortalBiblioteca\Biblioteca\PortalBiblioteca\Views\Leitor\Detail.cshtml"
  
    var leitor = ViewBag.Message;

#line default
#line hidden
            BeginContext(117, 173, true);
            WriteLiteral("<h1>Index</h1>\r\n\r\n<table>\r\n    <tr>\r\n        <th>Id</th>\r\n        <th>Nome</th>\r\n        <th>CPF</th>\r\n        <th>Data de Nascimento</th>\r\n    </tr>\r\n    <tr>\r\n        <td>");
            EndContext();
            BeginContext(291, 9, false);
#line 19 "C:\Users\ialima\source\repos\PortalBiblioteca\Biblioteca\PortalBiblioteca\Views\Leitor\Detail.cshtml"
       Write(leitor.Id);

#line default
#line hidden
            EndContext();
            BeginContext(300, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(320, 11, false);
#line 20 "C:\Users\ialima\source\repos\PortalBiblioteca\Biblioteca\PortalBiblioteca\Views\Leitor\Detail.cshtml"
       Write(leitor.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(331, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(351, 10, false);
#line 21 "C:\Users\ialima\source\repos\PortalBiblioteca\Biblioteca\PortalBiblioteca\Views\Leitor\Detail.cshtml"
       Write(leitor.CPF);

#line default
#line hidden
            EndContext();
            BeginContext(361, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(381, 21, false);
#line 22 "C:\Users\ialima\source\repos\PortalBiblioteca\Biblioteca\PortalBiblioteca\Views\Leitor\Detail.cshtml"
       Write(leitor.DataNascimento);

#line default
#line hidden
            EndContext();
            BeginContext(402, 355, true);
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
