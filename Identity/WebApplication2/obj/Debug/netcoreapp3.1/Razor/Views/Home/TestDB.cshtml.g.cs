#pragma checksum "C:\Users\User\Documents\GitHub\RS1-Vjezbe\Identity\WebApplication2\Views\Home\TestDB.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f79a704d63270361651ea5fb95a7fe22ce7383ca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_TestDB), @"mvc.1.0.view", @"/Views/Home/TestDB.cshtml")]
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
#line 1 "C:\Users\User\Documents\GitHub\RS1-Vjezbe\Identity\WebApplication2\Views\_ViewImports.cshtml"
using WebApplication2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Documents\GitHub\RS1-Vjezbe\Identity\WebApplication2\Views\_ViewImports.cshtml"
using WebApplication2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f79a704d63270361651ea5fb95a7fe22ce7383ca", @"/Views/Home/TestDB.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b36aee4455a440795f240a74431c307640c545e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_TestDB : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication2.Data.ApplicationDbContext>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("Faktura count: ");
#nullable restore
#line 7 "C:\Users\User\Documents\GitHub\RS1-Vjezbe\Identity\WebApplication2\Views\Home\TestDB.cshtml"
          Write(Model.Faktura.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\nProizvod count: ");
#nullable restore
#line 9 "C:\Users\User\Documents\GitHub\RS1-Vjezbe\Identity\WebApplication2\Views\Home\TestDB.cshtml"
           Write(Model.Proizvod.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\nPonuda count: ");
#nullable restore
#line 11 "C:\Users\User\Documents\GitHub\RS1-Vjezbe\Identity\WebApplication2\Views\Home\TestDB.cshtml"
         Write(Model.Ponuda.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\nPonuda koja nije fakturisana count: ");
#nullable restore
#line 13 "C:\Users\User\Documents\GitHub\RS1-Vjezbe\Identity\WebApplication2\Views\Home\TestDB.cshtml"
                               Write(Model.Ponuda.Count(p => p.FakturaId==null));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication2.Data.ApplicationDbContext> Html { get; private set; }
    }
}
#pragma warning restore 1591
