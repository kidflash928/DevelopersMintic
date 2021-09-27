using System;
namespace Peliculas.Shared.Entidades
{
    public class Pelicula
    {
        public string Imagen {get;set;}
        public string Nombre {get;set;}
        public string Sinopsis {get;set;}
        public string Puntaje {get;set;}
        public DateTime Lanzamiento{get;set;}
        public string Director{get;set;}
    }
}