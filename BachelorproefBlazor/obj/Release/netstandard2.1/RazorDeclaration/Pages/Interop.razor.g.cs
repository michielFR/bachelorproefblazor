#pragma checksum "C:\Users\michi\Documents\School\Jaar 3\Bachelor proef\BachelorproefBlazor\BachelorproefBlazor\Pages\Interop.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "67f96e91ee4bff2f4d17e8cf01f80dbf6c0de183"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BachelorproefBlazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\michi\Documents\School\Jaar 3\Bachelor proef\BachelorproefBlazor\BachelorproefBlazor\_Imports.razor"
using ChartJs.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\michi\Documents\School\Jaar 3\Bachelor proef\BachelorproefBlazor\BachelorproefBlazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\michi\Documents\School\Jaar 3\Bachelor proef\BachelorproefBlazor\BachelorproefBlazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\michi\Documents\School\Jaar 3\Bachelor proef\BachelorproefBlazor\BachelorproefBlazor\_Imports.razor"
using BachelorproefBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\michi\Documents\School\Jaar 3\Bachelor proef\BachelorproefBlazor\BachelorproefBlazor\_Imports.razor"
using BachelorproefBlazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\michi\Documents\School\Jaar 3\Bachelor proef\BachelorproefBlazor\BachelorproefBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\michi\Documents\School\Jaar 3\Bachelor proef\BachelorproefBlazor\BachelorproefBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\michi\Documents\School\Jaar 3\Bachelor proef\BachelorproefBlazor\BachelorproefBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/interop")]
    public partial class Interop : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 31 "C:\Users\michi\Documents\School\Jaar 3\Bachelor proef\BachelorproefBlazor\BachelorproefBlazor\Pages\Interop.razor"
       
    public string InputField { get; set; }
    async Task CreateAlert()
    {
        await JsRuntime.InvokeVoidAsync("createAlert");
    }

    async Task StartAnimation()
    {
        await JsRuntime.InvokeVoidAsync("startAnimation");
    }

    async Task HelloUser()
    {
        await JsRuntime.InvokeVoidAsync("helloUser");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
    }
}
#pragma warning restore 1591