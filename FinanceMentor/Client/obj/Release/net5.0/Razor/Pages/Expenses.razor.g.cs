#pragma checksum "C:\Repos\FinanceMentor\FinanceMentor\Client\Pages\Expenses.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "8cd159f840b26788385fe920c0125116c335f2b74a91b1095a0dc7e469295f68"
// <auto-generated/>
#pragma warning disable 1591
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
#line 2 "C:\Repos\FinanceMentor\FinanceMentor\Client\Pages\Expenses.razor"
using FinanceMentor.Client.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Repos\FinanceMentor\FinanceMentor\Client\Pages\Expenses.razor"
using System.Globalization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Repos\FinanceMentor\FinanceMentor\Client\Pages\Expenses.razor"
using FinanceMentor.Shared;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/expenses")]
    public partial class Expenses : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "col-lg-8");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "card");
            __builder.AddMarkupContent(6, "<div class=\"card-header\">\r\n                Expenses\r\n            </div>\r\n            ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "card-body");
            __builder.OpenElement(9, "table");
            __builder.AddAttribute(10, "class", "table table-striped");
            __builder.AddMarkupContent(11, "<thead><tr><th>Date</th>\r\n                            <th>Category</th>\r\n                            <th>Subject</th>\r\n                            <th>Amount</th>\r\n                            <th>&nbsp;</th></tr></thead>\r\n                    ");
            __builder.OpenElement(12, "tbody");
#nullable restore
#line 25 "C:\Repos\FinanceMentor\FinanceMentor\Client\Pages\Expenses.razor"
                         if (expenses == null)
                        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(13, "<tr><td><em>Loading...</em></td></tr>");
#nullable restore
#line 28 "C:\Repos\FinanceMentor\FinanceMentor\Client\Pages\Expenses.razor"
                        }
                        else
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Repos\FinanceMentor\FinanceMentor\Client\Pages\Expenses.razor"
                             foreach (var earning in expenses)
                            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(14, "tr");
            __builder.OpenElement(15, "td");
#nullable restore
#line 34 "C:\Repos\FinanceMentor\FinanceMentor\Client\Pages\Expenses.razor"
__builder.AddContent(16, earning.Date.ToShortDateString());

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n                                    ");
            __builder.OpenElement(18, "td");
#nullable restore
#line 35 "C:\Repos\FinanceMentor\FinanceMentor\Client\Pages\Expenses.razor"
__builder.AddContent(19, earning.Category);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n                                    ");
            __builder.OpenElement(21, "td");
#nullable restore
#line 36 "C:\Repos\FinanceMentor\FinanceMentor\Client\Pages\Expenses.razor"
__builder.AddContent(22, earning.Subject);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                                    ");
            __builder.OpenElement(24, "td");
#nullable restore
#line 37 "C:\Repos\FinanceMentor\FinanceMentor\Client\Pages\Expenses.razor"
__builder.AddContent(25, earning.Amount.ToString("C2", CultureInfo.CreateSpecificCulture("en-US")));

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                                    ");
            __builder.OpenElement(27, "td");
            __builder.OpenElement(28, "button");
            __builder.AddAttribute(29, "type", "button");
            __builder.AddAttribute(30, "class", "btn btn-danger btn-sm");
            __builder.AddAttribute(31, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 38 "C:\Repos\FinanceMentor\FinanceMentor\Client\Pages\Expenses.razor"
                                                                                                      () => OpenDeleteDialog(earning)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(32, "Delete");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 40 "C:\Repos\FinanceMentor\FinanceMentor\Client\Pages\Expenses.razor"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Repos\FinanceMentor\FinanceMentor\Client\Pages\Expenses.razor"
                             
                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n    ");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "col-lg-4");
            __builder.OpenComponent<global::FinanceMentor.Client.Components.ExpenseForm>(36);
            __builder.AddAttribute(37, "OnSubmitCallback", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 48 "C:\Repos\FinanceMentor\FinanceMentor\Client\Pages\Expenses.razor"
                                        Refresh

#line default
#line hidden
#nullable disable
            ))));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n");
            __builder.AddMarkupContent(39, "<div>&nbsp;</div>");
#nullable restore
#line 52 "C:\Repos\FinanceMentor\FinanceMentor\Client\Pages\Expenses.razor"
 if (DeleteDialogOpen)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<global::FinanceMentor.Client.Components.ModalDialog>(40);
            __builder.AddAttribute(41, "Title", (object)("Are you sure?"));
            __builder.AddAttribute(42, "Text", (object)("Do you want to delete this entry?"));
            __builder.AddAttribute(43, "OnClose", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.Boolean>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.Boolean>(this, 
#nullable restore
#line 56 "C:\Repos\FinanceMentor\FinanceMentor\Client\Pages\Expenses.razor"
                           OnDeleteDialogClose

#line default
#line hidden
#nullable disable
            ))));
            __builder.AddAttribute(44, "DialogType", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::FinanceMentor.Client.Components.ModalDialog.ModalDialogType>(
#nullable restore
#line 57 "C:\Repos\FinanceMentor\FinanceMentor\Client\Pages\Expenses.razor"
                             ModalDialog.ModalDialogType.DeleteCancel

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
#nullable restore
#line 59 "C:\Repos\FinanceMentor\FinanceMentor\Client\Pages\Expenses.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 61 "C:\Repos\FinanceMentor\FinanceMentor\Client\Pages\Expenses.razor"
       
    private Expense[] expenses;

    private Expense _expenseToDelete;
    public bool DeleteDialogOpen { get; set; }

    private async Task OnDeleteDialogClose(bool accepted)
    {
        if (accepted)
        {
            await Http.DeleteAsync($"api/Expenses/{_expenseToDelete.Id}");
            await LoadData();
            _expenseToDelete = null;
        }

        DeleteDialogOpen = false;
        StateHasChanged();
    }

    private void OpenDeleteDialog(Expense expense)
    {
        DeleteDialogOpen = true;
        _expenseToDelete = expense;
        StateHasChanged();
    }

    protected async override Task OnInitializedAsync()
    {
        await LoadData();
    }

    private async Task LoadData()
    {
        expenses = await Http.GetFromJsonAsync<Expense[]>("api/Expenses");
        StateHasChanged();
    }

    public async void Refresh()
    {
        await LoadData();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
