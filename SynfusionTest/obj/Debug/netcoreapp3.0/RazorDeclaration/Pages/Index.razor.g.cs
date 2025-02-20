#pragma checksum "E:\IEJNC\blazor\githubsamples\New folder\EJ2-DataGrid-BlazorServer-Globalization-with-CLDR-Files-master\SynfusionTest\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e7428704d3f328e83fd32f5fb9bce33e405ff537"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace SynfusionTest.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "E:\IEJNC\blazor\githubsamples\New folder\EJ2-DataGrid-BlazorServer-Globalization-with-CLDR-Files-master\SynfusionTest\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "E:\IEJNC\blazor\githubsamples\New folder\EJ2-DataGrid-BlazorServer-Globalization-with-CLDR-Files-master\SynfusionTest\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#line 3 "E:\IEJNC\blazor\githubsamples\New folder\EJ2-DataGrid-BlazorServer-Globalization-with-CLDR-Files-master\SynfusionTest\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#line 4 "E:\IEJNC\blazor\githubsamples\New folder\EJ2-DataGrid-BlazorServer-Globalization-with-CLDR-Files-master\SynfusionTest\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 5 "E:\IEJNC\blazor\githubsamples\New folder\EJ2-DataGrid-BlazorServer-Globalization-with-CLDR-Files-master\SynfusionTest\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 6 "E:\IEJNC\blazor\githubsamples\New folder\EJ2-DataGrid-BlazorServer-Globalization-with-CLDR-Files-master\SynfusionTest\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 8 "E:\IEJNC\blazor\githubsamples\New folder\EJ2-DataGrid-BlazorServer-Globalization-with-CLDR-Files-master\SynfusionTest\_Imports.razor"
using SynfusionTest;

#line default
#line hidden
#line 9 "E:\IEJNC\blazor\githubsamples\New folder\EJ2-DataGrid-BlazorServer-Globalization-with-CLDR-Files-master\SynfusionTest\_Imports.razor"
using SynfusionTest.Shared;

#line default
#line hidden
#line 10 "E:\IEJNC\blazor\githubsamples\New folder\EJ2-DataGrid-BlazorServer-Globalization-with-CLDR-Files-master\SynfusionTest\_Imports.razor"
using Syncfusion.EJ2.Blazor;

#line default
#line hidden
#line 11 "E:\IEJNC\blazor\githubsamples\New folder\EJ2-DataGrid-BlazorServer-Globalization-with-CLDR-Files-master\SynfusionTest\_Imports.razor"
using Syncfusion.EJ2.Blazor.Calendars;

#line default
#line hidden
#line 3 "E:\IEJNC\blazor\githubsamples\New folder\EJ2-DataGrid-BlazorServer-Globalization-with-CLDR-Files-master\SynfusionTest\Pages\Index.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 4 "E:\IEJNC\blazor\githubsamples\New folder\EJ2-DataGrid-BlazorServer-Globalization-with-CLDR-Files-master\SynfusionTest\Pages\Index.razor"
using Syncfusion.EJ2.Blazor.Grids;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 14 "E:\IEJNC\blazor\githubsamples\New folder\EJ2-DataGrid-BlazorServer-Globalization-with-CLDR-Files-master\SynfusionTest\Pages\Index.razor"
      
    [Inject]
    IJSRuntime JsRuntime { get; set; }

    public List<Order> Orders { get; set; }

    protected override void OnInitialized()
    {
        Orders = Enumerable.Range(1, 75).Select(x => new Order()
        {
            OrderID = 1000 + x,
            CustomerID = (new string[] { "ALFKI", "ANANTR", "ANTON", "BLONP", "BOLID" })[new Random().Next(5)],
            Freight = 2.1 * x,
            OrderDate = DateTime.Now.AddDays(-x),
        }).ToList();
    }

    public class Order
    {
        public int? OrderID { get; set; }
        public string CustomerID { get; set; }
        public DateTime? OrderDate { get; set; }
        public double? Freight { get; set; }
    }
    protected override void OnAfterRender(bool isrender)    
    {
        this.JsRuntime.Ejs().LoadLocaleData("wwwroot/de.json").SetCulture("de");
        this.JsRuntime.Ejs().LoadCldrData(new string[] { "wwwroot/scripts/cldr-data/main/de/currencies.json", "wwwroot/scripts/cldr-data/main/de/numbers.json", "wwwroot/scripts/cldr-data/main/de/ca-gregorian.json", "wwwroot/scripts/cldr-data/main/de/timeZoneNames.json",  "wwwroot/scripts/cldr-data/supplemental/numberingSystems.json" }).SetCulture("de");
    }



#line default
#line hidden
    }
}
#pragma warning restore 1591
