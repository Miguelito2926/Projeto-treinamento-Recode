#pragma checksum "C:\Users\Nextbox\Desktop\Ednaldo\Florent Viagens\Florent Viagens\Views\Contato\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ae21a154ba27d6889c0bcdae057ad68101500591"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contato_Index), @"mvc.1.0.view", @"/Views/Contato/Index.cshtml")]
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
#line 1 "C:\Users\Nextbox\Desktop\Ednaldo\Florent Viagens\Florent Viagens\Views\_ViewImports.cshtml"
using Florent_Viagens;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Nextbox\Desktop\Ednaldo\Florent Viagens\Florent Viagens\Views\_ViewImports.cshtml"
using Florent_Viagens.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae21a154ba27d6889c0bcdae057ad68101500591", @"/Views/Contato/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd8a88dd7f462271a68ec8196efd534a0d44974d", @"/Views/_ViewImports.cshtml")]
    public class Views_Contato_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Florent_Viagens.Models.Contato>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Nextbox\Desktop\Ednaldo\Florent Viagens\Florent Viagens\Views\Contato\Index.cshtml"
   ViewData["Title"] = "Index"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<table class=""container-fluid"">
    <tr>
        <td>

            <div class=""card text-center mt-4 m-md-5  "" style=""width: 11rem ;"">
                <div class=""row card bg-white "" style=""border-radius: 25px;"">
                    <h5 class=""text-success""> WhatsApp </h5>
                    <img src=""./img/zap.png"" class="" card-img-top text-white"" alt=""WhatsApp"" />
                    <p class=""card-text text-success text-center"">(21) 99985-6425  </p>
                </div>
            </div>
        </td>

        <td>
            <div class=""card  text-center mt-4 m-md-5  "" style=""width: 10rem;"">

                <div class=""row card bg-white "" style=""border-radius: 25px;"">
                    <h5 class=""text-success""> E-mail </h5>
                    <img src=""./img/email.png"" class="" card-img-top text-white"" alt=""WhatsApp"" />.
                    <p class=""card-text text-success text-center""> florentviagens.com.br </p>
                </div>

            </div>
        </td>

");
            WriteLiteral(@"        <td>
            <div class=""card  text-center mt-4 m-md-5"" style=""width: 9rem;"">

                <div class=""row card bg-white "" style=""border-radius: 25px;"">
                    <h5 class=""text-success""> Instragan </h5>
                    <img src=""./img/instagram-logo.png"" class="" card-img-top text-white"" alt=""WhatsApp"" />.
                    <p class=""card-text text-success text-center""> ViagensFlorent  </p>
                </div>

            </div>

        </td>
    </tr>
</table>



");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Florent_Viagens.Models.Contato>> Html { get; private set; }
    }
}
#pragma warning restore 1591