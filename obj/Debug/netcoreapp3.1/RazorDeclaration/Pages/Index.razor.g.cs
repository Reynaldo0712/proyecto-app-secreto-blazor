#pragma checksum "C:\Users\DELL\Source\Repos\Tarea5\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4567ac05872142b6796463a89551ae19c7808259"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Tarea5.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\DELL\Source\Repos\Tarea5\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\DELL\Source\Repos\Tarea5\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\DELL\Source\Repos\Tarea5\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\DELL\Source\Repos\Tarea5\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\DELL\Source\Repos\Tarea5\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\DELL\Source\Repos\Tarea5\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\DELL\Source\Repos\Tarea5\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\DELL\Source\Repos\Tarea5\_Imports.razor"
using Tarea5;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\DELL\Source\Repos\Tarea5\_Imports.razor"
using Tarea5.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\DELL\Source\Repos\Tarea5\Pages\Index.razor"
using Tarea5.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 29 "C:\Users\DELL\Source\Repos\Tarea5\Pages\Index.razor"
      
    private List<User> _users = new List<User>();
    private User _user = new User();
    private string user, password, message;

    protected override async Task OnInitializedAsync()
    {
        _users = await userServices.GetUsersAsync();
    }

    private async Task toContent()
    {
        _user = _users.FirstOrDefault(p => p.Cedula + p.Clave == user + password);
        if (_user != null)
        {
            _user.State = "on";
            await userServices.UpdateUserAsync(_user);
            nav.NavigateTo($"/content/{_user.UserId}");
            message = "";
        }
        else
        {
            message = "User or Password incorrect";
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserServices userServices { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager nav { get; set; }
    }
}
#pragma warning restore 1591
