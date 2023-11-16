// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace FinanceMentor.Client.Pages
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Repos\FinanceMentor\FinanceMentor\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Repos\FinanceMentor\FinanceMentor\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Repos\FinanceMentor\FinanceMentor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Repos\FinanceMentor\FinanceMentor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Repos\FinanceMentor\FinanceMentor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Repos\FinanceMentor\FinanceMentor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Repos\FinanceMentor\FinanceMentor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Repos\FinanceMentor\FinanceMentor\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Repos\FinanceMentor\FinanceMentor\Client\_Imports.razor"
using FinanceMentor.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Repos\FinanceMentor\FinanceMentor\Client\_Imports.razor"
using FinanceMentor.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Repos\FinanceMentor\FinanceMentor\Client\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Repos\FinanceMentor\FinanceMentor\Client\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Repos\FinanceMentor\FinanceMentor\Client\Pages\Index.razor"
using FinanceMentor.Client.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Repos\FinanceMentor\FinanceMentor\Client\Pages\Index.razor"
using System.Globalization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Repos\FinanceMentor\FinanceMentor\Client\Pages\Index.razor"
using FinanceMentor.Client.Components;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 68 "C:\Repos\FinanceMentor\FinanceMentor\Client\Pages\Index.razor"
       
    private static int currentYear = DateTime.Today.Year;
    private ICollection<string> colors = new List<string>() { "#FBC687", "#F4F7C5", "#93ABD3" };
    private ICollection<YearlyItem> yearlyExpenses;
    private ICollection<YearlyItem> yearlyEarnings;
    private ThreeMonthsData earnings;
    private ThreeMonthsData expenses;

    protected override async Task OnInitializedAsync()
    {
        earnings = await _dataService.LoadLast3MonthsEarnings();
        expenses = await _dataService.LoadLast3MonthsExpenses();
        yearlyExpenses = await _dataService.LoadCurrentYearExpenses();
        yearlyEarnings = await _dataService.LoadCurrentYearEarnings();

        StateHasChanged();
    }

    string FormatAsUSD(object value)
    {
        return ((double)value).ToString("C0", CultureInfo.CreateSpecificCulture("en-US"));
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDataService _dataService { get; set; }
    }
}
#pragma warning restore 1591