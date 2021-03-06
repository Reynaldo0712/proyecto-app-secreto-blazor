#pragma checksum "C:\Users\DELL\Source\Repos\Tarea5\Pages\Content.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a0ff1238e9e3a09f168d4922e88a80339ca0afe8"
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
#line 2 "C:\Users\DELL\Source\Repos\Tarea5\Pages\Content.razor"
using Tarea5.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/content/{id:int}")]
    public partial class Content : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 121 "C:\Users\DELL\Source\Repos\Tarea5\Pages\Content.razor"
       
    [Parameter]
    public int id { get; set; }

    private List<User> _users = new List<User>();
    private List<Secret> _secrets = new List<Secret>();
    private List<Secret> user_secrets = new List<Secret>();
    private User _user = new User();
    private Secret _secret = new Secret();
    private ApiData _data = new ApiData();
    private string image, state;

    protected override async Task OnInitializedAsync()
    {
        _users = await userServices.GetUsersAsync();
        _user = _users.FirstOrDefault(p => p.UserId == id);
        if (_user != null)
        {
            _data = await Http.GetJsonAsync<ApiData>("https://api.adamix.net/apec/cedula/" + _user.Cedula);
            image = _data.foto;
            await RefreshSecrets();
            state = _user.State;
            _user.State = "off";
            await userServices.UpdateUserAsync(_user);
        }
        else
        {
            state = "off";
        }
    }

    private async Task RefreshSecrets()
    {
        _secrets = await secretServices.GetSecretsAsync();
        user_secrets = _secrets.Where(p => p.UserId == id).ToList();
        _secret = new Secret();
    }

    private async Task AddSecret()
    {
        _user._Secrets.Add(_secret);
        await userServices.UpdateUserAsync(_user);
        await RefreshSecrets();
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SecretServices secretServices { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserServices userServices { get; set; }
    }
}
#pragma warning restore 1591
