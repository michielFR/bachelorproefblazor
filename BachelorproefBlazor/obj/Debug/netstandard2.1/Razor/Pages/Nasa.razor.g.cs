#pragma checksum "C:\Users\michi\Documents\School\Jaar 3\Bachelor proef\BachelorproefBlazor\BachelorproefBlazor\Pages\Nasa.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "863dcf5472ccb5bb36b683fbd4c49b1d39b19739"
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
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\michi\Documents\School\Jaar 3\Bachelor proef\BachelorproefBlazor\BachelorproefBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\michi\Documents\School\Jaar 3\Bachelor proef\BachelorproefBlazor\BachelorproefBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\michi\Documents\School\Jaar 3\Bachelor proef\BachelorproefBlazor\BachelorproefBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\michi\Documents\School\Jaar 3\Bachelor proef\BachelorproefBlazor\BachelorproefBlazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\michi\Documents\School\Jaar 3\Bachelor proef\BachelorproefBlazor\BachelorproefBlazor\_Imports.razor"
using BachelorproefBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\michi\Documents\School\Jaar 3\Bachelor proef\BachelorproefBlazor\BachelorproefBlazor\_Imports.razor"
using BachelorproefBlazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\michi\Documents\School\Jaar 3\Bachelor proef\BachelorproefBlazor\BachelorproefBlazor\_Imports.razor"
using ChartJs.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\michi\Documents\School\Jaar 3\Bachelor proef\BachelorproefBlazor\BachelorproefBlazor\Pages\Nasa.razor"
using BachelorproefBlazor.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/nasa")]
    public partial class Nasa : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 5 "C:\Users\michi\Documents\School\Jaar 3\Bachelor proef\BachelorproefBlazor\BachelorproefBlazor\Pages\Nasa.razor"
 if (photos == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.AddMarkupContent(1, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 8 "C:\Users\michi\Documents\School\Jaar 3\Bachelor proef\BachelorproefBlazor\BachelorproefBlazor\Pages\Nasa.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "    ");
            __builder.AddMarkupContent(3, "<h1 className=\"text-center\">Nasa</h1>\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "row");
            __builder.AddMarkupContent(6, "\r\n");
#nullable restore
#line 13 "C:\Users\michi\Documents\School\Jaar 3\Bachelor proef\BachelorproefBlazor\BachelorproefBlazor\Pages\Nasa.razor"
         foreach (var photo in photos)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(7, "            ");
            __builder.OpenComponent<BachelorproefBlazor.Pages.Photo>(8);
            __builder.AddAttribute(9, "p", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BachelorproefBlazor.Models.Picture>(
#nullable restore
#line 15 "C:\Users\michi\Documents\School\Jaar 3\Bachelor proef\BachelorproefBlazor\BachelorproefBlazor\Pages\Nasa.razor"
                     photo

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(10, "\r\n");
#nullable restore
#line 16 "C:\Users\michi\Documents\School\Jaar 3\Bachelor proef\BachelorproefBlazor\BachelorproefBlazor\Pages\Nasa.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(11, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n");
#nullable restore
#line 18 "C:\Users\michi\Documents\School\Jaar 3\Bachelor proef\BachelorproefBlazor\BachelorproefBlazor\Pages\Nasa.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 20 "C:\Users\michi\Documents\School\Jaar 3\Bachelor proef\BachelorproefBlazor\BachelorproefBlazor\Pages\Nasa.razor"
       
    private Picture[] photos;

    protected override async Task OnInitializedAsync()
    {
        var incoming = await Http.GetJsonAsync<Incoming>("https://api.nasa.gov/mars-photos/api/v1/rovers/curiosity/photos?earth_date=2015-6-3&api_key=JiErxLPFtI9gmM24WjFWpaP9m84iXtCZjX0FcfOb");
        photos = incoming.Photos;
    }    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
