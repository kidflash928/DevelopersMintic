#pragma checksum "C:\Proyecto_Ciclo3\Peliculas\Client\Pages\Categorias\MostrarCategoria.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc89c171fce265ba9d0226b3024e88260279d894"
// <auto-generated/>
#pragma warning disable 1591
namespace Peliculas.Client.Pages.Categorias
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/categoria/{CategoriaId:int}")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/categoria/{CategoriaId:int}/{Nombre}")]
    public partial class MostrarCategoria : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h6>Ver informacion de una categoría en específico</h6>");
        }
        #pragma warning restore 1998
#nullable restore
#line 6 "C:\Proyecto_Ciclo3\Peliculas\Client\Pages\Categorias\MostrarCategoria.razor"
 
    [Parameter] public int CategoriaId {get;set;}
    [Parameter] public string Nombre {get;set;}
    protected override void OnInitialized()
    {
        Console.WriteLine($"El id de la categoría es {CategoriaId} y el nombre {Nombre}");
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
