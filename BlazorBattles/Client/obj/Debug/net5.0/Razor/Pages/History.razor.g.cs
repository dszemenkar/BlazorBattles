#pragma checksum "C:\Users\dszemenk\source\repos\BlazorBattles\BlazorBattles\Client\Pages\History.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7e085b287563eac9803bc7690afe1dd25107656f"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorBattles.Client.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/history")]
    public partial class History : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>History</h3>\r\n\r\n");
            __builder.OpenElement(1, "table");
            __builder.AddAttribute(2, "class", "table");
            __builder.AddMarkupContent(3, "<thead><tr><th>Date</th>\r\n            <th>Attacker</th>\r\n            <th>Opponent</th>\r\n            <th>Rounds</th>\r\n            <th>Damage</th>\r\n            <th></th></tr></thead>\r\n    ");
            __builder.OpenElement(4, "tbody");
#nullable restore
#line 18 "C:\Users\dszemenk\source\repos\BlazorBattles\BlazorBattles\Client\Pages\History.razor"
         foreach (var battle in BattleService.History)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(5, "tr");
            __builder.AddAttribute(6, "style", 
#nullable restore
#line 20 "C:\Users\dszemenk\source\repos\BlazorBattles\BlazorBattles\Client\Pages\History.razor"
                    GetHistoryStyle(battle)

#line default
#line hidden
#nullable disable
            );
            __builder.OpenElement(7, "td");
            __builder.AddContent(8, 
#nullable restore
#line 21 "C:\Users\dszemenk\source\repos\BlazorBattles\BlazorBattles\Client\Pages\History.razor"
                 battle.BattleDate

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.OpenElement(10, "td");
            __builder.AddContent(11, 
#nullable restore
#line 22 "C:\Users\dszemenk\source\repos\BlazorBattles\BlazorBattles\Client\Pages\History.razor"
                 battle.AttackerName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n            ");
            __builder.OpenElement(13, "td");
            __builder.AddContent(14, 
#nullable restore
#line 23 "C:\Users\dszemenk\source\repos\BlazorBattles\BlazorBattles\Client\Pages\History.razor"
                 battle.OpponentName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n            ");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 24 "C:\Users\dszemenk\source\repos\BlazorBattles\BlazorBattles\Client\Pages\History.razor"
                 battle.RoundsFought

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n            ");
            __builder.OpenElement(19, "td");
            __builder.AddContent(20, 
#nullable restore
#line 25 "C:\Users\dszemenk\source\repos\BlazorBattles\BlazorBattles\Client\Pages\History.razor"
                 battle.WinnerDamageDealt

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n            ");
            __builder.OpenElement(22, "td");
            __builder.AddContent(23, 
#nullable restore
#line 26 "C:\Users\dszemenk\source\repos\BlazorBattles\BlazorBattles\Client\Pages\History.razor"
                  battle.YouWon ? "You won!" : "You lost!"

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 28 "C:\Users\dszemenk\source\repos\BlazorBattles\BlazorBattles\Client\Pages\History.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 32 "C:\Users\dszemenk\source\repos\BlazorBattles\BlazorBattles\Client\Pages\History.razor"
             
    protected override async Task OnInitializedAsync()
    {
        await BattleService.GetHistory();
    }
    string GetHistoryStyle(BattleHistoryEntry entry)
    {
        if (entry.YouWon)
            return "color: green; font-weight: 600;";
        else
            return string.Empty;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IBattleService BattleService { get; set; }
    }
}
#pragma warning restore 1591
