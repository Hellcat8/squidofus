#pragma checksum "/Users/amine/Dev/Squidofus/Squidofus/Views/Personnage/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ccf7ca331b6c8c0fb3b3db1a2e247e2cb7f8701a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Personnage_Details), @"mvc.1.0.view", @"/Views/Personnage/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ccf7ca331b6c8c0fb3b3db1a2e247e2cb7f8701a", @"/Views/Personnage/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"743396a0f3aea3c654c368652ed0c951ab4584e1", @"/Views/_ViewImports.cshtml")]
    public class Views_Personnage_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/amine/Dev/Squidofus/Squidofus/Views/Personnage/Details.cshtml"
  
    ViewData["Title"] = $"Personnages - {System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(Context.Request.Query["classe"])}";

#line default
#line hidden
#nullable disable
            WriteLiteral("Classe : ");
#nullable restore
#line 4 "/Users/amine/Dev/Squidofus/Squidofus/Views/Personnage/Details.cshtml"
    Write(Context.Request.Query["classe"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<br>
<br>
<div>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since 
    the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, 
    but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset 
    sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions 
    of Lorem Ipsum.

Why do we use it?
It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. 
The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 
'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors 
now use Lorem Ipsum as their de");
            WriteLiteral(@"fault model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. 
Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).


Where does it come from?
Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, 
making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the 
more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, 
discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of ""de Finibus Bonorum et Malorum"" 
(The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. 
The first line of Lorem Ipsum, ""Lorem ipsum dolor sit amet.."", comes from a line in section 1.10.32.

The");
            WriteLiteral(@" standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from 
""de Finibus Bonorum et Malorum"" by Cicero are also reproduced in their exact original form, accompanied by English versions from the 
1914 translation by H. Rackham.

Where can I get some?
There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, 
by injected humour, or randomised words which don't look even slightly believable. If you are going to use a passage of Lorem Ipsum, 
you need to be sure there isn't anything embarrassing hidden in the middle of text. All the Lorem Ipsum generators on the Internet 
tend to repeat predefined chunks as necessary, making this the first true generator on the Internet. It uses a dictionary of over 
200 Latin words, combined with a handful of model sentence structures, to generate Lorem Ipsum which looks reasonable. 
The generated Lorem Ipsum is therefore always free from repetition, ");
            WriteLiteral("injected humour, or non-characteristic words etc.</div>");
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