#pragma checksum "C:\Users\User\Documents\GitHub\RS1-Vjezbe\Vjezba21102020\Vjezba21102020\Views\Student\Prikaz.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5409bd5b942690fe98d5dea6bf7cfb4eb64cfed6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_Prikaz), @"mvc.1.0.view", @"/Views/Student/Prikaz.cshtml")]
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
#line 1 "C:\Users\User\Documents\GitHub\RS1-Vjezbe\Vjezba21102020\Vjezba21102020\Views\_ViewImports.cshtml"
using Vjezba21102020;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Documents\GitHub\RS1-Vjezbe\Vjezba21102020\Vjezba21102020\Views\_ViewImports.cshtml"
using Vjezba21102020.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\User\Documents\GitHub\RS1-Vjezbe\Vjezba21102020\Vjezba21102020\Views\Student\Prikaz.cshtml"
using podaci.EntityModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5409bd5b942690fe98d5dea6bf7cfb4eb64cfed6", @"/Views/Student/Prikaz.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e97129e4f355208b68957a3b467f3ec7a567571", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_Prikaz : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StudentPrikazVM>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\User\Documents\GitHub\RS1-Vjezbe\Vjezba21102020\Vjezba21102020\Views\Student\Prikaz.cshtml"
  
    ViewData["Title"] = "Prikaz";
    //var studenti = (List<Student>)ViewData["studenti"];
    //var search = ViewData["search"];
    StudentPrikazVM m = Model;


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Prikaz</h1>\r\n<a href=\"/Student/Dodaj\" type=\"button\" class=\"btn btn-primary\">Dodaj</a>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5409bd5b942690fe98d5dea6bf7cfb4eb64cfed63997", async() => {
                WriteLiteral("\r\n    <input name=\"search\"");
                BeginWriteAttribute("value", " value=\"", 354, "\"", 371, 1);
#nullable restore
#line 15 "C:\Users\User\Documents\GitHub\RS1-Vjezbe\Vjezba21102020\Vjezba21102020\Views\Student\Prikaz.cshtml"
WriteAttributeValue("", 362, m.search, 362, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <input type=\"submit\" value=\"Trazi\" />\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<table class=""table table-bordered"">
    <thead>
        <tr>
            <th>ID</th>
            <th>Ime</th>
            <th>Prezime</th>
            <th>OpstinaPrebivalista</th>
            <th>OpstinaRodjenja</th>
            <th>Akcija</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 30 "C:\Users\User\Documents\GitHub\RS1-Vjezbe\Vjezba21102020\Vjezba21102020\Views\Student\Prikaz.cshtml"
         foreach (Student s in m.studenti)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 33 "C:\Users\User\Documents\GitHub\RS1-Vjezbe\Vjezba21102020\Vjezba21102020\Views\Student\Prikaz.cshtml"
               Write(s.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 34 "C:\Users\User\Documents\GitHub\RS1-Vjezbe\Vjezba21102020\Vjezba21102020\Views\Student\Prikaz.cshtml"
               Write(s.Ime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 35 "C:\Users\User\Documents\GitHub\RS1-Vjezbe\Vjezba21102020\Vjezba21102020\Views\Student\Prikaz.cshtml"
               Write(s.Prezime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 36 "C:\Users\User\Documents\GitHub\RS1-Vjezbe\Vjezba21102020\Vjezba21102020\Views\Student\Prikaz.cshtml"
                Write(s.OpstinaPrebivalista.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 37 "C:\Users\User\Documents\GitHub\RS1-Vjezbe\Vjezba21102020\Vjezba21102020\Views\Student\Prikaz.cshtml"
                Write(s.OpstinaRodjenja.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1055, "\"", 1092, 2);
            WriteAttributeValue("", 1062, "/Student/Uredi?StudentID=", 1062, 25, true);
#nullable restore
#line 39 "C:\Users\User\Documents\GitHub\RS1-Vjezbe\Vjezba21102020\Vjezba21102020\Views\Student\Prikaz.cshtml"
WriteAttributeValue("", 1087, s.ID, 1087, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Uredi</a>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1127, "\"", 1165, 2);
            WriteAttributeValue("", 1134, "/Student/Obrisi?StudentID=", 1134, 26, true);
#nullable restore
#line 40 "C:\Users\User\Documents\GitHub\RS1-Vjezbe\Vjezba21102020\Vjezba21102020\Views\Student\Prikaz.cshtml"
WriteAttributeValue("", 1160, s.ID, 1160, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Obrisi</a>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 43 "C:\Users\User\Documents\GitHub\RS1-Vjezbe\Vjezba21102020\Vjezba21102020\Views\Student\Prikaz.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StudentPrikazVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
