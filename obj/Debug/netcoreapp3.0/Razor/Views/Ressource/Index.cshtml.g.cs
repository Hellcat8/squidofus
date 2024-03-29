#pragma checksum "/Users/amine/Dev/Squidofus/Squidofus/Views/Ressource/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "386ce4f7a6251f01fd20c99ec41f90489d3ae184"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ressource_Index), @"mvc.1.0.view", @"/Views/Ressource/Index.cshtml")]
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
#line 1 "/Users/amine/Dev/Squidofus/Squidofus/Views/_ViewImports.cshtml"
using Squidofus;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/amine/Dev/Squidofus/Squidofus/Views/_ViewImports.cshtml"
using Squidofus.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"386ce4f7a6251f01fd20c99ec41f90489d3ae184", @"/Views/Ressource/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"743396a0f3aea3c654c368652ed0c951ab4584e1", @"/Views/_ViewImports.cshtml")]
    public class Views_Ressource_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Squidofus.Models.Ressource>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<div class=\"row\">\n");
#nullable restore
#line 4 "/Users/amine/Dev/Squidofus/Squidofus/Views/Ressource/Index.cshtml"
     foreach (Ressource r in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card\">\n            <div class=\"card-body\">\n                <h5 class=\"card-title\">");
#nullable restore
#line 8 "/Users/amine/Dev/Squidofus/Squidofus/Views/Ressource/Index.cshtml"
                                  Write(r.Label);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (Niveau ");
#nullable restore
#line 8 "/Users/amine/Dev/Squidofus/Squidofus/Views/Ressource/Index.cshtml"
                                                   Write(r.Level);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</h5>\n                <h6 class=\"card-subtitle mb-2 text-muted\">");
#nullable restore
#line 9 "/Users/amine/Dev/Squidofus/Squidofus/Views/Ressource/Index.cshtml"
                                                     Write(r.IdTypeRessourceNavigation.Label);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\n                <p class=\"card-text\">");
#nullable restore
#line 10 "/Users/amine/Dev/Squidofus/Squidofus/Views/Ressource/Index.cshtml"
                                Write(r.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n");
#nullable restore
#line 11 "/Users/amine/Dev/Squidofus/Squidofus/Views/Ressource/Index.cshtml"
                 if (r.RessourceEffect.Any())
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <table class=\"table table-striped\">\n                        <tbody>\n");
#nullable restore
#line 15 "/Users/amine/Dev/Squidofus/Squidofus/Views/Ressource/Index.cshtml"
                                 foreach (RessourceEffect re in r.RessourceEffect)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\n                                        <td>");
#nullable restore
#line 18 "/Users/amine/Dev/Squidofus/Squidofus/Views/Ressource/Index.cshtml"
                                       Write(re.Effect);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                    </tr>\n");
#nullable restore
#line 20 "/Users/amine/Dev/Squidofus/Squidofus/Views/Ressource/Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\n                    </table>\n");
#nullable restore
#line 23 "/Users/amine/Dev/Squidofus/Squidofus/Views/Ressource/Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\n        </div>\n");
#nullable restore
#line 26 "/Users/amine/Dev/Squidofus/Squidofus/Views/Ressource/Index.cshtml"
    }

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Squidofus.Models.Ressource>> Html { get; private set; }
    }
}
#pragma warning restore 1591
