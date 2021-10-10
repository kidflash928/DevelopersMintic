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
#nullable restore
#line 1 "C:\Proyecto_Ciclo3\Peliculas\Client\Pages\Componentes\FormularioPelicula.razor"
using Peliculas.Client.Pages.Componentes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Proyecto_Ciclo3\Peliculas\Client\Pages\Componentes\FormularioPelicula.razor"
using Peliculas.Client.Model;

#line default
#line hidden
#nullable disable
    public partial class FormularioPelicula : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 81 "C:\Proyecto_Ciclo3\Peliculas\Client\Pages\Componentes\FormularioPelicula.razor"
 
    [Parameter] public Pelicula Pelicula {get;set;}
    [Parameter] public EventCallback OnValidSubmit {get;set;}
    [Parameter] public List<Categoria> CategoriasSeleccionadas {get;set;} = new List<Categoria>();
    [Parameter] public List<Categoria> CategoriasNoSeleccionadas {get;set;} = new List<Categoria>();
    [Parameter] public List<Actor> ActoresSeleccionados {get;set;}=new List<Actor>();
        
    private string posterTemporal;
    private List<SelectorMultipleModel> NoSeleccionados {get;set;} = new List<SelectorMultipleModel>();
    
    private List<SelectorMultipleModel> Seleccionados {get;set;} = new List<SelectorMultipleModel>();

    private void ImagenSeleccionada(string imageB64)
    {
        Pelicula.Imagen = imageB64;
    }

    protected override void OnInitialized()
    {
        Seleccionados = CategoriasSeleccionadas.Select(x => new SelectorMultipleModel(x.Id.ToString(), x.Nombre)).ToList();
        NoSeleccionados= CategoriasNoSeleccionadas.Select(x => new SelectorMultipleModel(x.Id.ToString(), x.Nombre)).ToList();
        if (!string.IsNullOrWhiteSpace(Pelicula.Imagen))
        {
            posterTemporal = Pelicula.Imagen;
            Pelicula.Imagen = null;
        }
    }
    private async Task<IEnumerable<Actor>> BuscarActores (string searchText)
    {
        return new List<Actor>(){
            new Actor(){Id=1, NombreActor="Yaneth Mejia",Foto="https://pbs.twimg.com/profile_images/1079060744891785216/dAsFSbHH_400x400.jpg"},
            new Actor(){Id=2,NombreActor ="Carolina Marquez", Foto="https://archivo.autonoma.edu.co/sites/default/files/styles/medium/public/carolina-marquez-narvaez.jpg?itok=CcL43PAR"},
            new Actor(){Id=3,NombreActor="Juan Esteban",Foto="https://cdn1.vectorstock.com/i/1000x1000/29/65/cinema-award-best-actor-flat-style-vector-13602965.jpg"}
        };
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
