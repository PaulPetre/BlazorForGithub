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
#line 1 "C:\git\BlazorForGithub\BlazorForGithub\BlazorForGithub\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\git\BlazorForGithub\BlazorForGithub\BlazorForGithub\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\git\BlazorForGithub\BlazorForGithub\BlazorForGithub\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\git\BlazorForGithub\BlazorForGithub\BlazorForGithub\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\git\BlazorForGithub\BlazorForGithub\BlazorForGithub\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\git\BlazorForGithub\BlazorForGithub\BlazorForGithub\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\git\BlazorForGithub\BlazorForGithub\BlazorForGithub\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\git\BlazorForGithub\BlazorForGithub\BlazorForGithub\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\git\BlazorForGithub\BlazorForGithub\BlazorForGithub\_Imports.razor"
using BlazorForGithub;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\git\BlazorForGithub\BlazorForGithub\BlazorForGithub\_Imports.razor"
using BlazorForGithub.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\git\BlazorForGithub\BlazorForGithub\BlazorForGithub\_Imports.razor"
using BlazorForGithub.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\git\BlazorForGithub\BlazorForGithub\BlazorForGithub\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\git\BlazorForGithub\BlazorForGithub\BlazorForGithub\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\git\BlazorForGithub\BlazorForGithub\BlazorForGithub\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\git\BlazorForGithub\BlazorForGithub\BlazorForGithub\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\git\BlazorForGithub\BlazorForGithub\BlazorForGithub\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/auth/redirecttologin")]
    public partial class RedirectToLogin : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 4 "C:\git\BlazorForGithub\BlazorForGithub\BlazorForGithub\Pages\Auth\RedirectToLogin.razor"
       
    protected override void OnInitialized()
    {
        navigationManager.NavigateTo("/BlazorForGithub/auth/login");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
    }
}
#pragma warning restore 1591
