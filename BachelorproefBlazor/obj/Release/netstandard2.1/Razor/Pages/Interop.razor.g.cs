#pragma checksum "C:\Users\michi\Documents\School\Jaar 3\Bachelor proef\BachelorproefBlazor\BachelorproefBlazor\Pages\Interop.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "67f96e91ee4bff2f4d17e8cf01f80dbf6c0de183"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.AddMarkupContent(0, "<h1>JavaScript Interop</h1>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "card");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "card-header");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "row");
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.AddMarkupContent(10, "<div class=\"col-md-3\">\r\n                <h5>Standaard functies</h5>\r\n            </div>\r\n            ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "col-md-9 text-right");
            __builder.AddMarkupContent(13, "\r\n                ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "btn-group");
            __builder.AddAttribute(16, "role", "group");
            __builder.AddMarkupContent(17, "\r\n                    ");
            __builder.OpenElement(18, "button");
            __builder.AddAttribute(19, "type", "button");
            __builder.AddAttribute(20, "class", "btn btn-success");
            __builder.AddAttribute(21, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 13 "C:\Users\michi\Documents\School\Jaar 3\Bachelor proef\BachelorproefBlazor\BachelorproefBlazor\Pages\Interop.razor"
                                                                            CreateAlert

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(22, "Alert");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                    ");
            __builder.OpenElement(24, "button");
            __builder.AddAttribute(25, "type", "button");
            __builder.AddAttribute(26, "class", "btn btn-success");
            __builder.AddAttribute(27, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 14 "C:\Users\michi\Documents\School\Jaar 3\Bachelor proef\BachelorproefBlazor\BachelorproefBlazor\Pages\Interop.razor"
                                                                            HelloUser

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(28, "Dag gebruiker");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                    ");
            __builder.OpenElement(30, "button");
            __builder.AddAttribute(31, "type", "button");
            __builder.AddAttribute(32, "class", "btn btn-success");
            __builder.AddAttribute(33, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "C:\Users\michi\Documents\School\Jaar 3\Bachelor proef\BachelorproefBlazor\BachelorproefBlazor\Pages\Interop.razor"
                                                                            StartAnimation

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(34, "Start animatie");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n    ");
            __builder.AddMarkupContent(40, @"<div class=""card-body"">
        <div class=""card-title text-center"">
            <p id=""demo""></p>
            <hr>
            <div id=""box"" class=""bg-primary"">
                <div id=""animate"" class=""bg-success""></div>
            </div>
        </div>                
    </div>
");
            __builder.CloseElement();
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