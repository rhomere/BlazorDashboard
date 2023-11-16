#pragma checksum "C:\Repos\FinanceMentor\FinanceMentor\Client\Components\EarningForm.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5f2e2d588c21156acfa663ffa79a32a6aa21ad6e1d6fa7e89516fac3597ef428"
// <auto-generated/>
#pragma warning disable 1591
namespace FinanceMentor.Client.Components
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
#line 1 "C:\Repos\FinanceMentor\FinanceMentor\Client\Components\EarningForm.razor"
using FinanceMentor.Shared;

#line default
#line hidden
#nullable disable
    public partial class EarningForm : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "id", "earnings-container");
            __builder.AddAttribute(2, "class", "card");
            __builder.AddMarkupContent(3, "<div class=\"card-header\">\r\n        Add an earning\r\n    </div>\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "card-body");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.EditForm>(6);
            __builder.AddAttribute(7, "Model", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Object>(
#nullable restore
#line 9 "C:\Repos\FinanceMentor\FinanceMentor\Client\Components\EarningForm.razor"
                          earning

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(8, "OnValidSubmit", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::Microsoft.AspNetCore.Components.Forms.EditContext>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 9 "C:\Repos\FinanceMentor\FinanceMentor\Client\Components\EarningForm.razor"
                                                   HandleValidSubmit

#line default
#line hidden
#nullable disable
            ))));
            __builder.AddAttribute(9, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(10);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(11, "\r\n            ");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationSummary>(12);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(13, "\r\n            ");
                __builder2.OpenElement(14, "div");
                __builder2.AddAttribute(15, "class", "form-group");
                __builder2.AddMarkupContent(16, "<label for=\"dateInput\">Date</label>\r\n                ");
                global::__Blazor.FinanceMentor.Client.Components.EarningForm.TypeInference.CreateInputDate_0(__builder2, 17, 18, "form-control", 19, "dateInput", 20, 
#nullable restore
#line 14 "C:\Repos\FinanceMentor\FinanceMentor\Client\Components\EarningForm.razor"
                                                                            earning.Date

#line default
#line hidden
#nullable disable
                , 21, global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => earning.Date = __value, earning.Date)), 22, () => earning.Date);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(23, "\r\n            ");
                __builder2.OpenElement(24, "div");
                __builder2.AddAttribute(25, "class", "form-group");
                __builder2.AddMarkupContent(26, "<label for=\"subjectInput\">Subject</label>\r\n                ");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputText>(27);
                __builder2.AddAttribute(28, "class", (object)("form-control"));
                __builder2.AddAttribute(29, "id", (object)("subjectInput"));
                __builder2.AddAttribute(30, "Value", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 18 "C:\Repos\FinanceMentor\FinanceMentor\Client\Components\EarningForm.razor"
                                                                               earning.Subject

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(31, "ValueChanged", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.String>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => earning.Subject = __value, earning.Subject)))));
                __builder2.AddAttribute(32, "ValueExpression", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Linq.Expressions.Expression<System.Func<System.String>>>(() => earning.Subject)));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(33, "\r\n            ");
                __builder2.OpenElement(34, "div");
                __builder2.AddAttribute(35, "class", "form-group");
                __builder2.AddMarkupContent(36, "<label for=\"categoryInput\">Category</label>\r\n                ");
                global::__Blazor.FinanceMentor.Client.Components.EarningForm.TypeInference.CreateInputSelect_1(__builder2, 37, 38, "form-control", 39, "categoryInput", 40, 
#nullable restore
#line 22 "C:\Repos\FinanceMentor\FinanceMentor\Client\Components\EarningForm.razor"
                                                                                  earning.Category

#line default
#line hidden
#nullable disable
                , 41, global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => earning.Category = __value, earning.Category)), 42, () => earning.Category, 43, (__builder3) => {
#nullable restore
#line 23 "C:\Repos\FinanceMentor\FinanceMentor\Client\Components\EarningForm.razor"
                      
                        foreach (var value in Enum.GetValues(typeof(EarningCategory)))
                        {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(44, "option");
                    __builder3.AddAttribute(45, "value", 
#nullable restore
#line 26 "C:\Repos\FinanceMentor\FinanceMentor\Client\Components\EarningForm.razor"
                                            value

#line default
#line hidden
#nullable disable
                    );
#nullable restore
#line 26 "C:\Repos\FinanceMentor\FinanceMentor\Client\Components\EarningForm.razor"
__builder3.AddContent(46, value);

#line default
#line hidden
#nullable disable
                    __builder3.CloseElement();
#nullable restore
#line 27 "C:\Repos\FinanceMentor\FinanceMentor\Client\Components\EarningForm.razor"
                        }
                    

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(47, "\r\n            ");
                __builder2.OpenElement(48, "div");
                __builder2.AddAttribute(49, "class", "form-group");
                __builder2.AddMarkupContent(50, "<label for=\"amountInput\">Amount</label>\r\n                ");
                global::__Blazor.FinanceMentor.Client.Components.EarningForm.TypeInference.CreateInputNumber_2(__builder2, 51, 52, "form-control", 53, "amountInput", 54, 
#nullable restore
#line 33 "C:\Repos\FinanceMentor\FinanceMentor\Client\Components\EarningForm.razor"
                                                                                earning.Amount

#line default
#line hidden
#nullable disable
                , 55, global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => earning.Amount = __value, earning.Amount)), 56, () => earning.Amount);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(57, "\r\n            ");
                __builder2.AddMarkupContent(58, "<div><button type=\"submit\" id=\"submitEarning\" class=\"btn btn-primary\">Submit</button></div>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 42 "C:\Repos\FinanceMentor\FinanceMentor\Client\Components\EarningForm.razor"
       
    private EarningModel earning = new EarningModel { Date = DateTime.Today };

    [Parameter]
    public EventCallback OnSubmitCallback { get; set; }

    public async Task HandleValidSubmit()
    {
        await Http.PostAsJsonAsync<EarningModel>("api/Earnings", earning);
        await OnSubmitCallback.InvokeAsync();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
namespace __Blazor.FinanceMentor.Client.Components.EarningForm
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputDate_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Object __arg0, int __seq1, global::System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", (object)__arg0);
        __builder.AddAttribute(__seq1, "id", (object)__arg1);
        __builder.AddAttribute(__seq2, "Value", (object)__arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", (object)__arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", (object)__arg4);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Object __arg0, int __seq1, global::System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", (object)__arg0);
        __builder.AddAttribute(__seq1, "id", (object)__arg1);
        __builder.AddAttribute(__seq2, "Value", (object)__arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", (object)__arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", (object)__arg4);
        __builder.AddAttribute(__seq5, "ChildContent", (object)__arg5);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Object __arg0, int __seq1, global::System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", (object)__arg0);
        __builder.AddAttribute(__seq1, "id", (object)__arg1);
        __builder.AddAttribute(__seq2, "Value", (object)__arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", (object)__arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", (object)__arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591