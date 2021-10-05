// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Peliculas.Client.Pages.Componentes
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Proyecto_Ciclo3\Peliculas\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Proyecto_Ciclo3\Peliculas\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Proyecto_Ciclo3\Peliculas\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Proyecto_Ciclo3\Peliculas\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Proyecto_Ciclo3\Peliculas\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Proyecto_Ciclo3\Peliculas\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Proyecto_Ciclo3\Peliculas\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Proyecto_Ciclo3\Peliculas\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Proyecto_Ciclo3\Peliculas\Client\_Imports.razor"
using Peliculas.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Proyecto_Ciclo3\Peliculas\Client\_Imports.razor"
using Peliculas.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Proyecto_Ciclo3\Peliculas\Client\_Imports.razor"
using Peliculas.Client.Servicios;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Proyecto_Ciclo3\Peliculas\Client\_Imports.razor"
using Peliculas.Shared.Entidades;

#line default
#line hidden
#nullable disable
    public partial class ComponenteImagen : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "C:\Proyecto_Ciclo3\Peliculas\Client\Pages\Componentes\ComponenteImagen.razor"
 
    [Parameter] public string Label {get;set;} ="Imagen";
    [Parameter] public string URLimagen {get;set;}
    [Parameter] public EventCallback<string> ImagenSeleccionada {get;set;}
    
    private string imagenT;
    async Task OnChange(InputFileChangeEventArgs e)
    {
        var imagenes = e.GetMultipleFiles();
        foreach (var imagen in imagenes)
        {
            var tamaño = new byte[imagen.Size];
            await imagen.OpenReadStream().ReadAsync(tamaño);
            imagenT = Convert.ToBase64String(tamaño);
            URLimagen = null;
            await ImagenSeleccionada.InvokeAsync(imagenT);
            StateHasChanged();
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
