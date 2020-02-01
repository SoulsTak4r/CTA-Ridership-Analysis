#pragma checksum "C:\Hamza\spring 19\Cs341\project07\cta-web\Views\TopStations.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3533d20f63568709061e5c0fb5519ccfd4e28c7b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(program.Pages.Views_TopStations), @"mvc.1.0.razor-page", @"/Views/TopStations.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Views/TopStations.cshtml", typeof(program.Pages.Views_TopStations), null)]
namespace program.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Hamza\spring 19\Cs341\project07\cta-web\Views\_ViewImports.cshtml"
using program;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3533d20f63568709061e5c0fb5519ccfd4e28c7b", @"/Views/TopStations.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65a87352ab55936b7625448d2e9155e1658af919", @"/Views/_ViewImports.cshtml")]
    public class Views_TopStations : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Hamza\spring 19\Cs341\project07\cta-web\Views\TopStations.cshtml"
  
    ViewData["Title"] = "Top 10 Stations";

#line default
#line hidden
            BeginContext(83, 59, true);
            WriteLiteral("\r\n<h2>Top 10 Stations by Ridership</h2>\r\n\r\n<br />\r\n<br />\r\n");
            EndContext();
#line 11 "C:\Hamza\spring 19\Cs341\project07\cta-web\Views\TopStations.cshtml"
  
    if (@Model.EX != null)
    {

#line default
#line hidden
            BeginContext(181, 21, true);
            WriteLiteral("        <h3>**ERROR: ");
            EndContext();
            BeginContext(203, 16, false);
#line 14 "C:\Hamza\spring 19\Cs341\project07\cta-web\Views\TopStations.cshtml"
                Write(Model.EX.Message);

#line default
#line hidden
            EndContext();
            BeginContext(219, 71, true);
            WriteLiteral("</h3>\r\n        <br />\r\n        <hr />\r\n        <br />\r\n        <br />\r\n");
            EndContext();
#line 19 "C:\Hamza\spring 19\Cs341\project07\cta-web\Views\TopStations.cshtml"
    }

#line default
#line hidden
            BeginContext(300, 282, true);
            WriteLiteral(@"
<table class=""table"">
    <thead>
        <tr>
            <th>
                Rank
            </th>
            <th>
                Name
            </th>
            <th>
                Total Ridership
            </th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 37 "C:\Hamza\spring 19\Cs341\project07\cta-web\Views\TopStations.cshtml"
           
            int rank = 1;
        

#line default
#line hidden
            BeginContext(633, 8, true);
            WriteLiteral("        ");
            EndContext();
#line 40 "C:\Hamza\spring 19\Cs341\project07\cta-web\Views\TopStations.cshtml"
         foreach (var item in Model.StationList)
        {

#line default
#line hidden
            BeginContext(694, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(755, 4, false);
#line 44 "C:\Hamza\spring 19\Cs341\project07\cta-web\Views\TopStations.cshtml"
               Write(rank);

#line default
#line hidden
            EndContext();
            BeginContext(759, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(827, 16, false);
#line 47 "C:\Hamza\spring 19\Cs341\project07\cta-web\Views\TopStations.cshtml"
               Write(item.StationName);

#line default
#line hidden
            EndContext();
            BeginContext(843, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(911, 14, false);
#line 50 "C:\Hamza\spring 19\Cs341\project07\cta-web\Views\TopStations.cshtml"
               Write(item.riderShip);

#line default
#line hidden
            EndContext();
            BeginContext(925, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 53 "C:\Hamza\spring 19\Cs341\project07\cta-web\Views\TopStations.cshtml"
            rank++;
        }

#line default
#line hidden
            BeginContext(1001, 26, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TopStationsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<TopStationsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<TopStationsModel>)PageContext?.ViewData;
        public TopStationsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
