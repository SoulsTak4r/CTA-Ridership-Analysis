#pragma checksum "C:\Hamza\spring 19\Cs341\project07\cta-web\Views\RidershipByYear.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "51468c0805c455bc13e509be5fff6c00122acd06"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(program.Pages.Views_RidershipByYear), @"mvc.1.0.razor-page", @"/Views/RidershipByYear.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Views/RidershipByYear.cshtml", typeof(program.Pages.Views_RidershipByYear), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51468c0805c455bc13e509be5fff6c00122acd06", @"/Views/RidershipByYear.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65a87352ab55936b7625448d2e9155e1658af919", @"/Views/_ViewImports.cshtml")]
    public class Views_RidershipByYear : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Hamza\spring 19\Cs341\project07\cta-web\Views\RidershipByYear.cshtml"
  
    var Labels = Newtonsoft.Json.JsonConvert.SerializeObject(Model.Years);
    var Totals = Newtonsoft.Json.JsonConvert.SerializeObject(Model.NumRiders);

    ViewData["Title"] = "Total Ridership by Year";

#line default
#line hidden
            BeginContext(253, 57, true);
            WriteLiteral("\r\n<h2>Total Ridership per Year</h2>\r\n\r\n<br />\r\nRaw data: ");
            EndContext();
            BeginContext(311, 16, false);
#line 13 "C:\Hamza\spring 19\Cs341\project07\cta-web\Views\RidershipByYear.cshtml"
     Write(Html.Raw(Totals));

#line default
#line hidden
            EndContext();
            BeginContext(327, 20, true);
            WriteLiteral("\r\n<br />\r\n<br />\r\n\r\n");
            EndContext();
#line 17 "C:\Hamza\spring 19\Cs341\project07\cta-web\Views\RidershipByYear.cshtml"
  
    if (@Model.EX != null)
    {

#line default
#line hidden
            BeginContext(386, 53, true);
            WriteLiteral("        <br />\r\n        <br />\r\n        <h3>**ERROR: ");
            EndContext();
            BeginContext(440, 16, false);
#line 22 "C:\Hamza\spring 19\Cs341\project07\cta-web\Views\RidershipByYear.cshtml"
                Write(Model.EX.Message);

#line default
#line hidden
            EndContext();
            BeginContext(456, 71, true);
            WriteLiteral("</h3>\r\n        <br />\r\n        <hr />\r\n        <br />\r\n        <br />\r\n");
            EndContext();
#line 27 "C:\Hamza\spring 19\Cs341\project07\cta-web\Views\RidershipByYear.cshtml"
    }

#line default
#line hidden
            BeginContext(537, 361, true);
            WriteLiteral(@"
<div class=""box-body"">
    <div class=""chart-container"">
        <canvas id=""myChart""></canvas>
    </div>
</div>

<script src=""https://cdnjs.cloudflare.com/ajax/libs/Chart.js/2.7.3/Chart.bundle.min.js""></script>

<script>
var ctx = document.getElementById(""myChart"");
var myChart = new Chart(ctx, {
    type: 'line',
    data: {
        labels: ");
            EndContext();
            BeginContext(899, 16, false);
#line 43 "C:\Hamza\spring 19\Cs341\project07\cta-web\Views\RidershipByYear.cshtml"
           Write(Html.Raw(Labels));

#line default
#line hidden
            EndContext();
            BeginContext(915, 78, true);
            WriteLiteral(",\r\n        datasets: [{\r\n            label: \"# of riders\",\r\n            data: ");
            EndContext();
            BeginContext(994, 16, false);
#line 46 "C:\Hamza\spring 19\Cs341\project07\cta-web\Views\RidershipByYear.cshtml"
             Write(Html.Raw(Totals));

#line default
#line hidden
            EndContext();
            BeginContext(1010, 359, true);
            WriteLiteral(@",
            borderColor: ""red"",
            pointBackgroundColor: ""black"",
            backgroundColor: ""orange"",
            borderWidth: 1
        }]
    },
    options: {
        scales: {
            yAxes: [{
                ticks: {
                    beginAtZero:true
                }
            }]
        }
    }
});
</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RidershipByYearModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RidershipByYearModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RidershipByYearModel>)PageContext?.ViewData;
        public RidershipByYearModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591