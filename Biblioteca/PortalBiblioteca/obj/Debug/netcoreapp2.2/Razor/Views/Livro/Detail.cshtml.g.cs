#pragma checksum "C:\Users\ialima\source\repos\PortalBiblioteca\Biblioteca\PortalBiblioteca\Views\Livro\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9c93a1f0bee86b42da96186e9ac575a515194d8c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Livro_Detail), @"mvc.1.0.view", @"/Views/Livro/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Livro/Detail.cshtml", typeof(AspNetCore.Views_Livro_Detail))]
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
#line 1 "C:\Users\ialima\source\repos\PortalBiblioteca\Biblioteca\PortalBiblioteca\Views\Livro\Detail.cshtml"
using PortalBiblioteca.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c93a1f0bee86b42da96186e9ac575a515194d8c", @"/Views/Livro/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81fbc20716f7fdf83a30de2063aed39512d096e8", @"/Views/_ViewImports.cshtml")]
    public class Views_Livro_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(32, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\ialima\source\repos\PortalBiblioteca\Biblioteca\PortalBiblioteca\Views\Livro\Detail.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#line 6 "C:\Users\ialima\source\repos\PortalBiblioteca\Biblioteca\PortalBiblioteca\Views\Livro\Detail.cshtml"
  
    var livro = ViewBag.Message;

#line default
#line hidden
            BeginContext(116, 227, true);
            WriteLiteral("<h1>Index</h1>\r\n\r\n<table>\r\n    <tr>\r\n        <th>Id</th>\r\n        <th>Titulo</th>\r\n        <th>Numero de Paginas</th>\r\n        <th>Autor</th>\r\n        <th>Editora</th>\r\n        <th>Genero</th>\r\n    </tr>\r\n    <tr>\r\n        <td>");
            EndContext();
            BeginContext(344, 8, false);
#line 21 "C:\Users\ialima\source\repos\PortalBiblioteca\Biblioteca\PortalBiblioteca\Views\Livro\Detail.cshtml"
       Write(livro.Id);

#line default
#line hidden
            EndContext();
            BeginContext(352, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(372, 12, false);
#line 22 "C:\Users\ialima\source\repos\PortalBiblioteca\Biblioteca\PortalBiblioteca\Views\Livro\Detail.cshtml"
       Write(livro.Titulo);

#line default
#line hidden
            EndContext();
            BeginContext(384, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(404, 19, false);
#line 23 "C:\Users\ialima\source\repos\PortalBiblioteca\Biblioteca\PortalBiblioteca\Views\Livro\Detail.cshtml"
       Write(livro.NumeroPaginas);

#line default
#line hidden
            EndContext();
            BeginContext(423, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(443, 13, false);
#line 24 "C:\Users\ialima\source\repos\PortalBiblioteca\Biblioteca\PortalBiblioteca\Views\Livro\Detail.cshtml"
       Write(livro.AutorId);

#line default
#line hidden
            EndContext();
            BeginContext(456, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(476, 15, false);
#line 25 "C:\Users\ialima\source\repos\PortalBiblioteca\Biblioteca\PortalBiblioteca\Views\Livro\Detail.cshtml"
       Write(livro.EditoraId);

#line default
#line hidden
            EndContext();
            BeginContext(491, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(511, 14, false);
#line 26 "C:\Users\ialima\source\repos\PortalBiblioteca\Biblioteca\PortalBiblioteca\Views\Livro\Detail.cshtml"
       Write(livro.GeneroId);

#line default
#line hidden
            EndContext();
            BeginContext(525, 355, true);
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