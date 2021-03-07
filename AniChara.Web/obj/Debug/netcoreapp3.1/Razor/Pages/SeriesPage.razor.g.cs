#pragma checksum "C:\Users\trey\source\repos\AniChara\AniChara.Web\Pages\SeriesPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c9b219f32ff820782be7627dfcce76646a15a22a"
// <auto-generated/>
#pragma warning disable 1591
namespace AniChara.Web.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\trey\source\repos\AniChara\AniChara.Web\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\trey\source\repos\AniChara\AniChara.Web\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\trey\source\repos\AniChara\AniChara.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\trey\source\repos\AniChara\AniChara.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\trey\source\repos\AniChara\AniChara.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\trey\source\repos\AniChara\AniChara.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\trey\source\repos\AniChara\AniChara.Web\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\trey\source\repos\AniChara\AniChara.Web\_Imports.razor"
using AniChara.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\trey\source\repos\AniChara\AniChara.Web\_Imports.razor"
using AniChara.Web.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\trey\source\repos\AniChara\AniChara.Web\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\trey\source\repos\AniChara\AniChara.Web\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\trey\source\repos\AniChara\AniChara.Web\Pages\SeriesPage.razor"
using AniChara.API.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/series")]
    public partial class SeriesPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Series</h3>\r\n\r\n");
#nullable restore
#line 8 "C:\Users\trey\source\repos\AniChara\AniChara.Web\Pages\SeriesPage.razor"
 if (series == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.AddMarkupContent(2, "<div><span class=\"spinner-border\"></span></div>\r\n");
#nullable restore
#line 11 "C:\Users\trey\source\repos\AniChara\AniChara.Web\Pages\SeriesPage.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "    ");
            __builder.AddMarkupContent(4, "<h3 style=\"margin-top: 20px;\">Confirm Dialog</h3>\r\n    ");
            __builder.OpenComponent<Radzen.Blazor.RadzenButton>(5);
            __builder.AddAttribute(6, "Text", "Show confirm dialog");
            __builder.AddAttribute(7, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "C:\Users\trey\source\repos\AniChara\AniChara.Web\Pages\SeriesPage.razor"
                                                     args => DialogService.Confirm("Are you sure?", "MyTitle", new ConfirmOptions() { OkButtonText = "Yes", CancelButtonText = "No" })

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(8, "\r\n");
            __builder.AddContent(9, "    ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "card-deck");
            __builder.AddMarkupContent(12, "\r\n");
#nullable restore
#line 18 "C:\Users\trey\source\repos\AniChara\AniChara.Web\Pages\SeriesPage.razor"
         foreach (var s in series)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(13, "            ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "card");
            __builder.AddAttribute(16, "style", "max-width: 25rem;");
            __builder.AddMarkupContent(17, "\r\n                ");
            __builder.OpenElement(18, "img");
            __builder.AddAttribute(19, "class", "card-img-top fixe");
            __builder.AddAttribute(20, "src", 
#nullable restore
#line 21 "C:\Users\trey\source\repos\AniChara\AniChara.Web\Pages\SeriesPage.razor"
                                                     s.Image

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(21, "alt", "Series Image");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                ");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "card-body");
            __builder.AddMarkupContent(25, "\r\n                    ");
            __builder.OpenElement(26, "h5");
            __builder.AddAttribute(27, "class", "card-title");
            __builder.AddContent(28, 
#nullable restore
#line 23 "C:\Users\trey\source\repos\AniChara\AniChara.Web\Pages\SeriesPage.razor"
                                            s.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                    ");
            __builder.OpenElement(30, "p");
            __builder.AddContent(31, 
#nullable restore
#line 24 "C:\Users\trey\source\repos\AniChara\AniChara.Web\Pages\SeriesPage.razor"
                        s.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                ");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "card-footer");
            __builder.AddMarkupContent(36, "\r\n                    ");
            __builder.OpenElement(37, "ul");
            __builder.AddMarkupContent(38, "\r\n\r\n");
#nullable restore
#line 29 "C:\Users\trey\source\repos\AniChara\AniChara.Web\Pages\SeriesPage.razor"
                         foreach (var tag in s.Tags)
                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(39, "                            ");
            __builder.OpenElement(40, "li");
            __builder.AddContent(41, 
#nullable restore
#line 31 "C:\Users\trey\source\repos\AniChara\AniChara.Web\Pages\SeriesPage.razor"
                                 tag

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n");
#nullable restore
#line 32 "C:\Users\trey\source\repos\AniChara\AniChara.Web\Pages\SeriesPage.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(43, "                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n");
#nullable restore
#line 36 "C:\Users\trey\source\repos\AniChara\AniChara.Web\Pages\SeriesPage.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(47, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n");
#nullable restore
#line 38 "C:\Users\trey\source\repos\AniChara\AniChara.Web\Pages\SeriesPage.razor"


}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 42 "C:\Users\trey\source\repos\AniChara\AniChara.Web\Pages\SeriesPage.razor"
       
    public List<Series> series;



    protected override async Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();
        series = await seriesService.GetSeriesAsync();
        Console.WriteLine("img: " + series[0].Image);

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DialogService DialogService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Data.SeriesService seriesService { get; set; }
    }
}
#pragma warning restore 1591
