#pragma checksum "C:\Proyecto_Ciclo3\Peliculas\Client\Pages\Componentes\FormularioPelicula.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "412ab0f95e292ecec5848a36e795e5cb9ea038d8"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 3 "C:\Proyecto_Ciclo3\Peliculas\Client\Pages\Componentes\FormularioPelicula.razor"
                 Pelicula

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 3 "C:\Proyecto_Ciclo3\Peliculas\Client\Pages\Componentes\FormularioPelicula.razor"
                                           OnValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(4);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(5, "\r\n\r\n    ");
                __builder2.OpenElement(6, "div");
                __builder2.AddAttribute(7, "class", "container");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "jumbotron");
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "form-group");
                __builder2.OpenElement(12, "div");
                __builder2.AddAttribute(13, "class", "row");
                __builder2.OpenElement(14, "div");
                __builder2.AddAttribute(15, "class", "col col-sm-9");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(16);
                __builder2.AddAttribute(17, "class", "form-control");
                __builder2.AddAttribute(18, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 12 "C:\Proyecto_Ciclo3\Peliculas\Client\Pages\Componentes\FormularioPelicula.razor"
                                                                      Pelicula.Nombre

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(19, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Pelicula.Nombre = __value, Pelicula.Nombre))));
                __builder2.AddAttribute(20, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Pelicula.Nombre));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(21, "\r\n                        ");
                __Blazor.Peliculas.Client.Pages.Componentes.FormularioPelicula.TypeInference.CreateValidationMessage_0(__builder2, 22, 23, 
#nullable restore
#line 13 "C:\Proyecto_Ciclo3\Peliculas\Client\Pages\Componentes\FormularioPelicula.razor"
                                                  ()=>Pelicula.Nombre

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "\r\n                    ");
                __builder2.OpenElement(25, "div");
                __builder2.AddAttribute(26, "class", "col col-sm-3");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputCheckbox>(27);
                __builder2.AddAttribute(28, "id", "en cartelera");
                __builder2.AddAttribute(29, "class", "form-check-input");
                __builder2.AddAttribute(30, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 17 "C:\Proyecto_Ciclo3\Peliculas\Client\Pages\Componentes\FormularioPelicula.razor"
                                                                                               Pelicula.EnCartelera

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(31, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Pelicula.EnCartelera = __value, Pelicula.EnCartelera))));
                __builder2.AddAttribute(32, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Boolean>>>(() => Pelicula.EnCartelera));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(33, "\r\n                        ");
                __builder2.AddMarkupContent(34, "<label class=\"form-check-label\" for=\"en_cartelera\">En cartelera</label>\r\n                        ");
                __Blazor.Peliculas.Client.Pages.Componentes.FormularioPelicula.TypeInference.CreateValidationMessage_1(__builder2, 35, 36, 
#nullable restore
#line 19 "C:\Proyecto_Ciclo3\Peliculas\Client\Pages\Componentes\FormularioPelicula.razor"
                                                  ()=>Pelicula.EnCartelera

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(37, "\r\n            ");
                __builder2.OpenElement(38, "div");
                __builder2.AddAttribute(39, "class", "form-group");
                __builder2.OpenElement(40, "div");
                __builder2.AddAttribute(41, "class", "row");
                __builder2.OpenElement(42, "div");
                __builder2.AddAttribute(43, "class", "col");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(44);
                __builder2.AddAttribute(45, "class", "form-control");
                __builder2.AddAttribute(46, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 27 "C:\Proyecto_Ciclo3\Peliculas\Client\Pages\Componentes\FormularioPelicula.razor"
                                                                      Pelicula.Trailer

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(47, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Pelicula.Trailer = __value, Pelicula.Trailer))));
                __builder2.AddAttribute(48, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Pelicula.Trailer));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(49, "\r\n                        ");
                __Blazor.Peliculas.Client.Pages.Componentes.FormularioPelicula.TypeInference.CreateValidationMessage_2(__builder2, 50, 51, 
#nullable restore
#line 28 "C:\Proyecto_Ciclo3\Peliculas\Client\Pages\Componentes\FormularioPelicula.razor"
                                                  ()=>Pelicula.Trailer

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(52, "\r\n                    ");
                __builder2.OpenElement(53, "div");
                __builder2.AddAttribute(54, "class", "col");
                __builder2.OpenElement(55, "div");
                __builder2.AddAttribute(56, "class", "form-group");
                __Blazor.Peliculas.Client.Pages.Componentes.FormularioPelicula.TypeInference.CreateInputDate_3(__builder2, 57, 58, "form-control", 59, 
#nullable restore
#line 33 "C:\Proyecto_Ciclo3\Peliculas\Client\Pages\Componentes\FormularioPelicula.razor"
                                                                          Pelicula.Lanzamiento

#line default
#line hidden
#nullable disable
                , 60, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Pelicula.Lanzamiento = __value, Pelicula.Lanzamiento)), 61, () => Pelicula.Lanzamiento);
                __builder2.AddMarkupContent(62, "\r\n                            ");
                __Blazor.Peliculas.Client.Pages.Componentes.FormularioPelicula.TypeInference.CreateValidationMessage_4(__builder2, 63, 64, 
#nullable restore
#line 34 "C:\Proyecto_Ciclo3\Peliculas\Client\Pages\Componentes\FormularioPelicula.razor"
                                                      ()=>Pelicula.Trailer

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(65, "\r\n            ");
                __builder2.OpenElement(66, "div");
                __builder2.AddAttribute(67, "class", "form-group");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(68);
                __builder2.AddAttribute(69, "class", "form-control");
                __builder2.AddAttribute(70, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 41 "C:\Proyecto_Ciclo3\Peliculas\Client\Pages\Componentes\FormularioPelicula.razor"
                                                                  Pelicula.Sinopsis

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(71, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Pelicula.Sinopsis = __value, Pelicula.Sinopsis))));
                __builder2.AddAttribute(72, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Pelicula.Sinopsis));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(73, "\r\n                ");
                __Blazor.Peliculas.Client.Pages.Componentes.FormularioPelicula.TypeInference.CreateValidationMessage_5(__builder2, 74, 75, 
#nullable restore
#line 42 "C:\Proyecto_Ciclo3\Peliculas\Client\Pages\Componentes\FormularioPelicula.razor"
                                          ()=>Pelicula.Sinopsis

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(76, "\r\n            ");
                __builder2.OpenElement(77, "div");
                __builder2.AddAttribute(78, "class", " form-group");
                __builder2.OpenElement(79, "div");
                __builder2.AddAttribute(80, "class", "row");
                __builder2.OpenElement(81, "div");
                __builder2.AddAttribute(82, "class", "col");
                __builder2.AddMarkupContent(83, "<label>Selecciona las categorías</label>\r\n                        ");
                __builder2.OpenElement(84, "div");
                __builder2.OpenComponent<Peliculas.Client.Pages.Componentes.SelectorMultiple>(85);
                __builder2.AddAttribute(86, "Seleccionados", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<Peliculas.Client.Model.SelectorMultipleModel>>(
#nullable restore
#line 50 "C:\Proyecto_Ciclo3\Peliculas\Client\Pages\Componentes\FormularioPelicula.razor"
                                                              Seleccionados

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(87, "NoSeleccionados", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<Peliculas.Client.Model.SelectorMultipleModel>>(
#nullable restore
#line 50 "C:\Proyecto_Ciclo3\Peliculas\Client\Pages\Componentes\FormularioPelicula.razor"
                                                                                              NoSeleccionados

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(88, "\r\n                    ");
                __builder2.OpenElement(89, "div");
                __builder2.AddAttribute(90, "class", "col");
                __builder2.OpenElement(91, "div");
                __builder2.AddAttribute(92, "class", "form-group");
                __builder2.OpenComponent<Peliculas.Client.Pages.Componentes.ComponenteImagen>(93);
                __builder2.AddAttribute(94, "Label", "");
                __builder2.AddAttribute(95, "ImagenSeleccionada", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, 
#nullable restore
#line 56 "C:\Proyecto_Ciclo3\Peliculas\Client\Pages\Componentes\FormularioPelicula.razor"
                                                                            ImagenSeleccionada

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(96, "URLimagen", "");
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(97, "\r\n            ");
                __builder2.AddMarkupContent(98, "<button type=\"submit\" class=\"btn btn-success\">Aceptar</button>\r\n            ");
                __builder2.AddMarkupContent(99, "<button type=\"submit\" class=\"btn btn-danger\">Cancelar</button>");
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 67 "C:\Proyecto_Ciclo3\Peliculas\Client\Pages\Componentes\FormularioPelicula.razor"
 
    [Parameter] public Pelicula Pelicula {get;set;}
    [Parameter] public EventCallback OnValidSubmit {get;set;}
    [Parameter] public List<Categoria> CategoriasSeleccionadas {get;set;} = new List<Categoria>();
    [Parameter] public List<Categoria> CategoriasNoSeleccionadas {get;set;} = new List<Categoria>();

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

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.Peliculas.Client.Pages.Componentes.FormularioPelicula
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputDate_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
