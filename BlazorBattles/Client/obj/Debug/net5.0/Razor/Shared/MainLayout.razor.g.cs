#pragma checksum "C:\Users\dszemenk\source\repos\BlazorBattles\BlazorBattles\Client\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f876c561835569a9bcbeaf43afefcb3dcefaa4ff"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorBattles.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\dszemenk\source\repos\BlazorBattles\BlazorBattles\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\dszemenk\source\repos\BlazorBattles\BlazorBattles\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\dszemenk\source\repos\BlazorBattles\BlazorBattles\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\dszemenk\source\repos\BlazorBattles\BlazorBattles\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\dszemenk\source\repos\BlazorBattles\BlazorBattles\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\dszemenk\source\repos\BlazorBattles\BlazorBattles\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\dszemenk\source\repos\BlazorBattles\BlazorBattles\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\dszemenk\source\repos\BlazorBattles\BlazorBattles\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\dszemenk\source\repos\BlazorBattles\BlazorBattles\Client\_Imports.razor"
using BlazorBattles.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\dszemenk\source\repos\BlazorBattles\BlazorBattles\Client\_Imports.razor"
using BlazorBattles.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\dszemenk\source\repos\BlazorBattles\BlazorBattles\Client\_Imports.razor"
using BlazorBattles.Client.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\dszemenk\source\repos\BlazorBattles\BlazorBattles\Client\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\dszemenk\source\repos\BlazorBattles\BlazorBattles\Client\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\dszemenk\source\repos\BlazorBattles\BlazorBattles\Client\_Imports.razor"
using BlazorBattles.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\dszemenk\source\repos\BlazorBattles\BlazorBattles\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\dszemenk\source\repos\BlazorBattles\BlazorBattles\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\dszemenk\source\repos\BlazorBattles\BlazorBattles\Client\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\dszemenk\source\repos\BlazorBattles\BlazorBattles\Client\Shared\MainLayout.razor"
using Blazored.Toast.Configuration;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page");
            __builder.AddAttribute(2, "b-l1st1jcckf");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "sidebar");
            __builder.AddAttribute(5, "b-l1st1jcckf");
            __builder.OpenComponent<BlazorBattles.Client.Shared.NavMenu>(6);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n\r\n    ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "main");
            __builder.AddAttribute(10, "b-l1st1jcckf");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "top-row px-4");
            __builder.AddAttribute(13, "b-l1st1jcckf");
            __builder.OpenComponent<BlazorBattles.Client.Shared.TopMenu>(14);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n\r\n        ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "content px-4");
            __builder.AddAttribute(18, "b-l1st1jcckf");
            __builder.AddContent(19, 
#nullable restore
#line 15 "C:\Users\dszemenk\source\repos\BlazorBattles\BlazorBattles\Client\Shared\MainLayout.razor"
             Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n\r\n");
            __builder.OpenComponent<Blazored.Toast.BlazoredToasts>(21);
            __builder.AddAttribute(22, "Position", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazored.Toast.Configuration.ToastPosition>(
#nullable restore
#line 20 "C:\Users\dszemenk\source\repos\BlazorBattles\BlazorBattles\Client\Shared\MainLayout.razor"
                          ToastPosition.BottomRight

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
