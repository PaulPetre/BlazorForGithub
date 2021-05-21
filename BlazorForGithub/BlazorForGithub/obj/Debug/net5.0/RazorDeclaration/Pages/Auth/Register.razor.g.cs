// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorForGithub.Pages.Auth
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Paul\BlazorForGithub\BlazorForGithub\BlazorForGithub\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Paul\BlazorForGithub\BlazorForGithub\BlazorForGithub\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Paul\BlazorForGithub\BlazorForGithub\BlazorForGithub\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Paul\BlazorForGithub\BlazorForGithub\BlazorForGithub\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Paul\BlazorForGithub\BlazorForGithub\BlazorForGithub\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Paul\BlazorForGithub\BlazorForGithub\BlazorForGithub\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Paul\BlazorForGithub\BlazorForGithub\BlazorForGithub\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Paul\BlazorForGithub\BlazorForGithub\BlazorForGithub\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Paul\BlazorForGithub\BlazorForGithub\BlazorForGithub\_Imports.razor"
using BlazorForGithub;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Paul\BlazorForGithub\BlazorForGithub\BlazorForGithub\_Imports.razor"
using BlazorForGithub.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Paul\BlazorForGithub\BlazorForGithub\BlazorForGithub\_Imports.razor"
using BlazorForGithub.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Paul\BlazorForGithub\BlazorForGithub\BlazorForGithub\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Paul\BlazorForGithub\BlazorForGithub\BlazorForGithub\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Paul\BlazorForGithub\BlazorForGithub\BlazorForGithub\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Paul\BlazorForGithub\BlazorForGithub\BlazorForGithub\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Paul\BlazorForGithub\BlazorForGithub\BlazorForGithub\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Paul\BlazorForGithub\BlazorForGithub\BlazorForGithub\Pages\Auth\Register.razor"
using BlazorForGithub.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Paul\BlazorForGithub\BlazorForGithub\BlazorForGithub\Pages\Auth\Register.razor"
using BlazorForGithub.Shared.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(AuthLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/auth/register")]
    public partial class Register : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 43 "C:\Paul\BlazorForGithub\BlazorForGithub\BlazorForGithub\Pages\Auth\Register.razor"
       
    RegisterRequest model = new();

    bool isBusy = false;
    string message = string.Empty;
    AlertMessageType messageType = AlertMessageType.Success;

    public async Task RegisterUser()
    {
        isBusy = true;

        var result = await authService.RegisterUserAsync(model);
        if (result.IsSuccess)
        {
            message = result.Message;
            messageType = AlertMessageType.Success;
        }
        else
        {
            message = result.Errors.FirstOrDefault() ?? result.Message;
            messageType = AlertMessageType.Warning;
        }
        isBusy = false;
    }

    void GoToLogin()
    {
        navigationManager.NavigateTo("/auth/login");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationService authService { get; set; }
    }
}
#pragma warning restore 1591
