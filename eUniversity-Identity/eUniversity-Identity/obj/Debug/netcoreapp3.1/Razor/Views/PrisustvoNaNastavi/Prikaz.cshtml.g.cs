#pragma checksum "C:\Users\User\Documents\GitHub\RS1-Vjezbe\eUniversity-Identity\eUniversity-Identity\Views\PrisustvoNaNastavi\Prikaz.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5ce0a7ff2c7242b8f1d6baf2ef37639d0cf463e3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PrisustvoNaNastavi_Prikaz), @"mvc.1.0.view", @"/Views/PrisustvoNaNastavi/Prikaz.cshtml")]
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
#line 1 "C:\Users\User\Documents\GitHub\RS1-Vjezbe\eUniversity-Identity\eUniversity-Identity\Views\_ViewImports.cshtml"
using eUniversity_Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Documents\GitHub\RS1-Vjezbe\eUniversity-Identity\eUniversity-Identity\Views\_ViewImports.cshtml"
using eUniversity_Identity.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ce0a7ff2c7242b8f1d6baf2ef37639d0cf463e3", @"/Views/PrisustvoNaNastavi/Prikaz.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7a8776e5ce5c68bb8ee61cc2e92b934ddeba0c8", @"/Views/_ViewImports.cshtml")]
    public class Views_PrisustvoNaNastavi_Prikaz : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PrisustvoNaNastaviPrikazVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\User\Documents\GitHub\RS1-Vjezbe\eUniversity-Identity\eUniversity-Identity\Views\PrisustvoNaNastavi\Prikaz.cshtml"
   
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("Ime studenta: \r\n");
#nullable restore
#line 7 "C:\Users\User\Documents\GitHub\RS1-Vjezbe\eUniversity-Identity\eUniversity-Identity\Views\PrisustvoNaNastavi\Prikaz.cshtml"
Write(Model.ImeStudenta);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<br />
<table class=""table table-bordered"">
    <thead>
        <tr>
            <th>Predmet</th>
            <th>Datum</th>
            <th>Prisutan</th>
            <th>Komentar</th>
            <th>Akcija</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 20 "C:\Users\User\Documents\GitHub\RS1-Vjezbe\eUniversity-Identity\eUniversity-Identity\Views\PrisustvoNaNastavi\Prikaz.cshtml"
         foreach (var x in  Model.Zapisi)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 23 "C:\Users\User\Documents\GitHub\RS1-Vjezbe\eUniversity-Identity\eUniversity-Identity\Views\PrisustvoNaNastavi\Prikaz.cshtml"
               Write(x.Predmet);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 24 "C:\Users\User\Documents\GitHub\RS1-Vjezbe\eUniversity-Identity\eUniversity-Identity\Views\PrisustvoNaNastavi\Prikaz.cshtml"
               Write(x.Datum);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 25 "C:\Users\User\Documents\GitHub\RS1-Vjezbe\eUniversity-Identity\eUniversity-Identity\Views\PrisustvoNaNastavi\Prikaz.cshtml"
                Write(x.Prisutan?"DA":"NE");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 26 "C:\Users\User\Documents\GitHub\RS1-Vjezbe\eUniversity-Identity\eUniversity-Identity\Views\PrisustvoNaNastavi\Prikaz.cshtml"
               Write(x.Komentar);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    <button");
            BeginWriteAttribute("onclick", " onclick=\"", 646, "\"", 704, 3);
            WriteAttributeValue("", 656, "PrisustvoNaNastaviUredi(", 656, 24, true);
#nullable restore
#line 28 "C:\Users\User\Documents\GitHub\RS1-Vjezbe\eUniversity-Identity\eUniversity-Identity\Views\PrisustvoNaNastavi\Prikaz.cshtml"
WriteAttributeValue("", 680, x.PrisustvoNaNastaviID, 680, 23, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 703, ")", 703, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Uredi</button>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 31 "C:\Users\User\Documents\GitHub\RS1-Vjezbe\eUniversity-Identity\eUniversity-Identity\Views\PrisustvoNaNastavi\Prikaz.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PrisustvoNaNastaviPrikazVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
