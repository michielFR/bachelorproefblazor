#pragma checksum "C:\Users\michi\Documents\School\Jaar 3\Bachelor proef\BachelorproefBlazor\BachelorproefBlazor\Pages\Sort.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "af42136e7900b95dc4f272fb5544cb8d5df766aa"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/sort")]
    public partial class Sort : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Genereren & Sorteren</h1>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "card");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "card-header");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "row");
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "col-md-2");
            __builder.AddMarkupContent(12, "\r\n                ");
            __builder.OpenElement(13, "h5");
            __builder.AddContent(14, 
#nullable restore
#line 9 "C:\Users\michi\Documents\School\Jaar 3\Bachelor proef\BachelorproefBlazor\BachelorproefBlazor\Pages\Sort.razor"
                     currentdistribution

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n            ");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "col-md-9 text-right");
            __builder.AddMarkupContent(19, "\r\n                ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "btn-group");
            __builder.AddAttribute(22, "role", "group");
            __builder.AddMarkupContent(23, "\r\n                    ");
            __builder.OpenElement(24, "button");
            __builder.AddAttribute(25, "type", "button");
            __builder.AddAttribute(26, "class", "btn btn-success");
            __builder.AddAttribute(27, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 13 "C:\Users\michi\Documents\School\Jaar 3\Bachelor proef\BachelorproefBlazor\BachelorproefBlazor\Pages\Sort.razor"
                                                                            GenereerRandomGetallen

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(28, "Random");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                    ");
            __builder.OpenElement(30, "button");
            __builder.AddAttribute(31, "type", "button");
            __builder.AddAttribute(32, "class", "btn btn-success");
            __builder.AddAttribute(33, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 14 "C:\Users\michi\Documents\School\Jaar 3\Bachelor proef\BachelorproefBlazor\BachelorproefBlazor\Pages\Sort.razor"
                                                                            GenereerReversedGetallen

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(34, "Reversed");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                    ");
            __builder.OpenElement(36, "button");
            __builder.AddAttribute(37, "type", "button");
            __builder.AddAttribute(38, "class", "btn btn-success");
            __builder.AddAttribute(39, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "C:\Users\michi\Documents\School\Jaar 3\Bachelor proef\BachelorproefBlazor\BachelorproefBlazor\Pages\Sort.razor"
                                                                            GenereerFewUniqueGetallen

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(40, "Few unique");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n                    ");
            __builder.OpenElement(42, "button");
            __builder.AddAttribute(43, "type", "button");
            __builder.AddAttribute(44, "class", "btn btn-success");
            __builder.AddAttribute(45, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "C:\Users\michi\Documents\School\Jaar 3\Bachelor proef\BachelorproefBlazor\BachelorproefBlazor\Pages\Sort.razor"
                                                                            GenereerAlmostSortedGetallen

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(46, "Almost sorted");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n            ");
            __builder.OpenElement(50, "div");
            __builder.AddAttribute(51, "class", "col-md-1");
            __builder.AddMarkupContent(52, "\r\n                ");
            __builder.OpenElement(53, "button");
            __builder.AddAttribute(54, "class", "btn btn-warning");
            __builder.AddAttribute(55, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 20 "C:\Users\michi\Documents\School\Jaar 3\Bachelor proef\BachelorproefBlazor\BachelorproefBlazor\Pages\Sort.razor"
                                                          BubbleSort

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(56, "Sorteer");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "        \r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n    ");
            __builder.OpenElement(61, "div");
            __builder.AddAttribute(62, "class", "card-body");
            __builder.AddMarkupContent(63, "\r\n        ");
            __builder.AddMarkupContent(64, "<h5 class=\"card-title\">Gegenereerd</h5>\r\n");
#nullable restore
#line 26 "C:\Users\michi\Documents\School\Jaar 3\Bachelor proef\BachelorproefBlazor\BachelorproefBlazor\Pages\Sort.razor"
         if (gegenereerd == null)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(65, "            ");
            __builder.AddMarkupContent(66, "<p>nog niets gegenereerd</p>\r\n");
#nullable restore
#line 29 "C:\Users\michi\Documents\School\Jaar 3\Bachelor proef\BachelorproefBlazor\BachelorproefBlazor\Pages\Sort.razor"
        }
        else
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\michi\Documents\School\Jaar 3\Bachelor proef\BachelorproefBlazor\BachelorproefBlazor\Pages\Sort.razor"
             for (int i = 0; i < 100; i++)
            {
                string text = gegenereerd[i].ToString() + " - ";
                

#line default
#line hidden
#nullable disable
            __builder.AddContent(67, 
#nullable restore
#line 35 "C:\Users\michi\Documents\School\Jaar 3\Bachelor proef\BachelorproefBlazor\BachelorproefBlazor\Pages\Sort.razor"
                 text

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 35 "C:\Users\michi\Documents\School\Jaar 3\Bachelor proef\BachelorproefBlazor\BachelorproefBlazor\Pages\Sort.razor"
                     
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Users\michi\Documents\School\Jaar 3\Bachelor proef\BachelorproefBlazor\BachelorproefBlazor\Pages\Sort.razor"
             
        }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(68, "\r\n        <hr>\r\n        ");
            __builder.AddMarkupContent(69, "<h5 class=\"card-title\">Gesorteerd</h5>\r\n");
#nullable restore
#line 41 "C:\Users\michi\Documents\School\Jaar 3\Bachelor proef\BachelorproefBlazor\BachelorproefBlazor\Pages\Sort.razor"
         if (gesorteerd == null)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(70, "            ");
            __builder.AddMarkupContent(71, "<p>nog niets gegenereerd</p>\r\n");
#nullable restore
#line 44 "C:\Users\michi\Documents\School\Jaar 3\Bachelor proef\BachelorproefBlazor\BachelorproefBlazor\Pages\Sort.razor"
        }
        else
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "C:\Users\michi\Documents\School\Jaar 3\Bachelor proef\BachelorproefBlazor\BachelorproefBlazor\Pages\Sort.razor"
             for (int i = 0; i < 100; i++)
            {
                string text = gesorteerd[i].ToString() + " - ";
                

#line default
#line hidden
#nullable disable
            __builder.AddContent(72, 
#nullable restore
#line 50 "C:\Users\michi\Documents\School\Jaar 3\Bachelor proef\BachelorproefBlazor\BachelorproefBlazor\Pages\Sort.razor"
                 text

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 50 "C:\Users\michi\Documents\School\Jaar 3\Bachelor proef\BachelorproefBlazor\BachelorproefBlazor\Pages\Sort.razor"
                     
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "C:\Users\michi\Documents\School\Jaar 3\Bachelor proef\BachelorproefBlazor\BachelorproefBlazor\Pages\Sort.razor"
             
        }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(73, "\r\n");
#nullable restore
#line 54 "C:\Users\michi\Documents\School\Jaar 3\Bachelor proef\BachelorproefBlazor\BachelorproefBlazor\Pages\Sort.razor"
         if (justsorted == true)
        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(74, "            <hr>\r\n            ");
            __builder.OpenElement(75, "h5");
            __builder.AddMarkupContent(76, "<b>Uitvoertijd</b> = ");
            __builder.AddContent(77, 
#nullable restore
#line 57 "C:\Users\michi\Documents\School\Jaar 3\Bachelor proef\BachelorproefBlazor\BachelorproefBlazor\Pages\Sort.razor"
                                      difference

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(78, " ms");
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n            ");
            __builder.OpenElement(80, "h5");
            __builder.AddMarkupContent(81, "<b>Vergelijkingen</b> = ");
            __builder.AddContent(82, 
#nullable restore
#line 58 "C:\Users\michi\Documents\School\Jaar 3\Bachelor proef\BachelorproefBlazor\BachelorproefBlazor\Pages\Sort.razor"
                                         comparisons.ToString("0,0")

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(83, "  ");
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n            ");
            __builder.OpenElement(85, "h5");
            __builder.AddMarkupContent(86, "<b>Array wijzigingen</b> = ");
            __builder.AddContent(87, 
#nullable restore
#line 59 "C:\Users\michi\Documents\School\Jaar 3\Bachelor proef\BachelorproefBlazor\BachelorproefBlazor\Pages\Sort.razor"
                                            arraychecks.ToString("0,0")

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(88, "  ");
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\r\n");
#nullable restore
#line 60 "C:\Users\michi\Documents\School\Jaar 3\Bachelor proef\BachelorproefBlazor\BachelorproefBlazor\Pages\Sort.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(90, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(91, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 64 "C:\Users\michi\Documents\School\Jaar 3\Bachelor proef\BachelorproefBlazor\BachelorproefBlazor\Pages\Sort.razor"
       
    private string currentdistribution = "Genereer eerst";
    private int[] gegenereerd;
    private int[] gesorteerd;
    private long difference = 0;
    private long comparisons = 0;
    private long arraychecks = 0;
    private bool justsorted = false;


    private void GenereerRandomGetallen()
    {
        currentdistribution = "Random";
        justsorted = false;
        gegenereerd = new int[5000];
        Random randNum = new Random();
        for (int i = 0; i < gegenereerd.Length; i++)
        {
            gegenereerd[i] = randNum.Next(0, 1000);
        }
        FillGesorteerd();
    }

    private void GenereerReversedGetallen()
    {
        currentdistribution = "Reversed";
        justsorted = false;
        gegenereerd = new int[5000];
        for (int i = 0; i < gegenereerd.Length; i++)
        {
            gegenereerd[i] = 5000 - i;
        }
        FillGesorteerd();
    }

    private void GenereerFewUniqueGetallen()
    {
        currentdistribution = "Few unique";
        justsorted = false;
        gegenereerd = new int[5000];
        Random random = new Random();
        int getal = 1;
        for (int i = 0; i < gegenereerd.Length; i++)
        {
            gegenereerd[i] = getal;
            if(i % 500 == 0)
            {
                getal++;
            }
        }
        gegenereerd = gegenereerd.OrderBy(x => random.Next()).ToArray();
        FillGesorteerd();
    }

    private void GenereerAlmostSortedGetallen()
    {
        currentdistribution = "Almost sorted";
        justsorted = false;
        gegenereerd = new int[5000];
        for (int i = 0; i < gegenereerd.Length; i++)
        {
            gegenereerd[i] = i;
        }
        gegenereerd[4500] = 5;
        FillGesorteerd();
    }

    private void FillGesorteerd()
    {
        gesorteerd = new int[5000];
        for (int i = 0; i < gegenereerd.Length; i++)
        {
            gesorteerd[i] = gegenereerd[i];
        }
    }

    private void BubbleSort()
    {
        long _comparisons = 0;
        long _arraychecks = 0;
        long start = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
        bool swapp;
        var x = gesorteerd;
        var n = x.Length - 1;
        do
        {
            swapp = false;
            for (var i = 0; i < n; i++)
            {
                _comparisons += 1;
                if (x[i] > x[i + 1])
                {
                    var temp = x[i];
                    x[i] = x[i + 1];
                    x[i + 1] = temp;
                    swapp = true;
                    _arraychecks += 2;
                }
            }
            n--;
        } while (swapp);
        gesorteerd = x;
        long end = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
        difference = end - start;
        comparisons = _comparisons;
        arraychecks = _arraychecks;
        justsorted = true;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591