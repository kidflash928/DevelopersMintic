using System.Collections.ObjectModel;
using System;
using System.Security.AccessControl;
namespace Shared.Entidades
{
    public class Pelicula: General
    {
      public DateTime FechaEstreno {get;set;}
      public string Categoria {get;set;}   
      public string PuntuacionUsuario {get;set;}  
      public int Duracion {get;set;}  
      public byte Imagen {get;set;}     
      public string Idioma {get;set;} 
      public string Estado {get;set;}    
      public string Sinopsis {get;set;}    
      public byte Trailer {get;set;}   
      public Collection.Generic.List<Genero> Genero {get;set;}
    }
}