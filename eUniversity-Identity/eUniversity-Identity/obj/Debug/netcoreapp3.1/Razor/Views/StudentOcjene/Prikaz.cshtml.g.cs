#pragma checksum "C:\Users\User\Documents\GitHub\RS1-Vjezbe\eUniversity-Identity\eUniversity-Identity\Views\StudentOcjene\Prikaz.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "98c33c639cc3b71d1c06a1f0843b6d73d58a3a46"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_StudentOcjene_Prikaz), @"mvc.1.0.view", @"/Views/StudentOcjene/Prikaz.cshtml")]
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
#nullable restore
#line 2 "C:\Users\User\Documents\GitHub\RS1-Vjezbe\eUniversity-Identity\eUniversity-Identity\Views\StudentOcjene\Prikaz.cshtml"
using Data.EntityModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"98c33c639cc3b71d1c06a1f0843b6d73d58a3a46", @"/Views/StudentOcjene/Prikaz.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7a8776e5ce5c68bb8ee61cc2e92b934ddeba0c8", @"/Views/_ViewImports.cshtml")]
    public class Views_StudentOcjene_Prikaz : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<StudentOcjenePrikazVM>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
            WriteLiteral("\n");
#nullable restore
#line 5 "C:\Users\User\Documents\GitHub\RS1-Vjezbe\eUniversity-Identity\eUniversity-Identity\Views\StudentOcjene\Prikaz.cshtml"
      
        ViewData["Title"] = "Prikaz";
        Layout = null;
    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <table class=""table table-bordered"">
        <thead>
            <tr>
                <th>Naziv predmeta</th>
                <th>Ocjena</th>
                <th>Datum</th>
                <th>Akcija</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 20 "C:\Users\User\Documents\GitHub\RS1-Vjezbe\eUniversity-Identity\eUniversity-Identity\Views\StudentOcjene\Prikaz.cshtml"
             foreach (StudentOcjenePrikazVM s in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <td>");
#nullable restore
#line 23 "C:\Users\User\Documents\GitHub\RS1-Vjezbe\eUniversity-Identity\eUniversity-Identity\Views\StudentOcjene\Prikaz.cshtml"
               Write(s.NazivPredmeta);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 24 "C:\Users\User\Documents\GitHub\RS1-Vjezbe\eUniversity-Identity\eUniversity-Identity\Views\StudentOcjene\Prikaz.cshtml"
               Write(s.BrojcanaOcjena);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 25 "C:\Users\User\Documents\GitHub\RS1-Vjezbe\eUniversity-Identity\eUniversity-Identity\Views\StudentOcjene\Prikaz.cshtml"
               Write(s.Datum.ToString("dd.MM.yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\n                <td>\n                    <button");
            BeginWriteAttribute("onclick", " onclick=\"", 683, "\"", 717, 3);
            WriteAttributeValue("", 693, "OcjeneUredi(", 693, 12, true);
#nullable restore
#line 27 "C:\Users\User\Documents\GitHub\RS1-Vjezbe\eUniversity-Identity\eUniversity-Identity\Views\StudentOcjene\Prikaz.cshtml"
WriteAttributeValue("", 705, s.OcjenaID, 705, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 716, ")", 716, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Uredi</button>\n                </td>\n            </tr>\n");
#nullable restore
#line 30 "C:\Users\User\Documents\GitHub\RS1-Vjezbe\eUniversity-Identity\eUniversity-Identity\Views\StudentOcjene\Prikaz.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\n    </table>\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<StudentOcjenePrikazVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591
