#pragma checksum "C:\Users\mat33\source\repos\BridgeMonitor\BridgeMonitor\Views\Fermeture\FermetureDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "774659e6a45c222d85e000f51e5866a2c57992dd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Fermeture_FermetureDetail), @"mvc.1.0.view", @"/Views/Fermeture/FermetureDetail.cshtml")]
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
#line 1 "C:\Users\mat33\source\repos\BridgeMonitor\BridgeMonitor\Views\_ViewImports.cshtml"
using BridgeMonitor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mat33\source\repos\BridgeMonitor\BridgeMonitor\Views\_ViewImports.cshtml"
using BridgeMonitor.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\mat33\source\repos\BridgeMonitor\BridgeMonitor\Views\Fermeture\FermetureDetail.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"774659e6a45c222d85e000f51e5866a2c57992dd", @"/Views/Fermeture/FermetureDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f76db85423d1966422131999df760b0ec79fa9c", @"/Views/_ViewImports.cshtml")]
    public class Views_Fermeture_FermetureDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Boats>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\mat33\source\repos\BridgeMonitor\BridgeMonitor\Views\Fermeture\FermetureDetail.cshtml"
  
    ViewData["Title"] = "Détails Fermeture";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\Users\mat33\source\repos\BridgeMonitor\BridgeMonitor\Views\Fermeture\FermetureDetail.cshtml"
  

    var duree = Model.ReopeningDate - Model.ClosingDate;
    var timebefore = Model.ClosingDate - DateTime.Now;
    CultureInfo fr = CultureInfo.GetCultureInfo("fr-FR");



#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <style href=""https://bootswatch.com/4/cerulean/bootstrap.css""></style>
    <div class=""d-flex justify-content-center flex-column"">
        <div class=""card border-primary mb-3"" style=""max-width: 20rem; margin:auto"">
            <div class=""card-header"">Cause : ");
#nullable restore
#line 18 "C:\Users\mat33\source\repos\BridgeMonitor\BridgeMonitor\Views\Fermeture\FermetureDetail.cshtml"
                                        Write(Model.BoatName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            <div class=\"card-body\">\r\n                <h4>Du ");
#nullable restore
#line 20 "C:\Users\mat33\source\repos\BridgeMonitor\BridgeMonitor\Views\Fermeture\FermetureDetail.cshtml"
                  Write(Model.ClosingDate.ToString("F", fr));

#line default
#line hidden
#nullable disable
            WriteLiteral(" au ");
#nullable restore
#line 20 "C:\Users\mat33\source\repos\BridgeMonitor\BridgeMonitor\Views\Fermeture\FermetureDetail.cshtml"
                                                          Write(Model.ReopeningDate.ToString("F", fr));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                <h5>Durée : ");
#nullable restore
#line 21 "C:\Users\mat33\source\repos\BridgeMonitor\BridgeMonitor\Views\Fermeture\FermetureDetail.cshtml"
                       Write(duree);

#line default
#line hidden
#nullable disable
            WriteLiteral(" heure(s)</h5>\r\n                <div class=\"alert alert-dismissible alert-info\" id=\"stolencountdown\"></div>\r\n");
#nullable restore
#line 23 "C:\Users\mat33\source\repos\BridgeMonitor\BridgeMonitor\Views\Fermeture\FermetureDetail.cshtml"
                 if ((7 <= Model.ClosingDate.Hour & Model.ClosingDate.Hour < 9) ^ (17 <= Model.ClosingDate.Hour & Model.ClosingDate.Hour < 19))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <h5>Risque de bouchons : Elevé</h5>\r\n");
#nullable restore
#line 26 "C:\Users\mat33\source\repos\BridgeMonitor\BridgeMonitor\Views\Fermeture\FermetureDetail.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <h5>Risque de bouchons : Faible</h5>\r\n");
#nullable restore
#line 30 "C:\Users\mat33\source\repos\BridgeMonitor\BridgeMonitor\Views\Fermeture\FermetureDetail.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n        <p id=\"nextclose\" style=\"display: none;\">");
#nullable restore
#line 33 "C:\Users\mat33\source\repos\BridgeMonitor\BridgeMonitor\Views\Fermeture\FermetureDetail.cshtml"
                                            Write(Model.ClosingDate.ToString("o"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
    </div>
    <script>
        var countDownDate = new Date(document.getElementById(""nextclose"").innerHTML).getTime()

        var x = setInterval(function () {
            var now = new Date().getTime();
            var distance = countDownDate - now;
            var days = Math.floor(distance / (1000 * 60 * 60 * 24));
            var hours = Math.floor((distance % (1000 * 60 * 60 * 24)) / (1000 * 60 * 60));
            var minutes = Math.floor((distance % (1000 * 60 * 60)) / (1000 * 60));
            var seconds = Math.floor((distance % (1000 * 60)) / 1000);
            document.getElementById(""stolencountdown"").innerHTML = days + "" jour(s) "" + hours + "" heure(s) ""
                + minutes + ""m "" + seconds + ""s"";
            if (distance < 0) {
                clearInterval(x);
                document.getElementById(""stolencountdown"").innerHTML = ""Cette fermeture est terminé"";
            }
        }, 1000);
    </script>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Boats> Html { get; private set; }
    }
}
#pragma warning restore 1591
