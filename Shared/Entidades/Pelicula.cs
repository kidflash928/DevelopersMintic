using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
namespace Peliculas.Shared.Entidades
{
    public class Pelicula
    {
        public int Id {get;set;}
        public string Imagen {get;set;}
        [Required (ErrorMessage = "El campo {0} es requerido")]
        public string Nombre {get;set;}
        public bool EnCartelera {get;set;}
        [Required (ErrorMessage = "El campo {0} es requerido")]
        public string Sinopsis {get;set;}
        public string Puntaje {get;set;}
        [Required (ErrorMessage = "El campo {0} es requerido")]
        public DateTime Lanzamiento{get;set;}
        [Required (ErrorMessage = "El campo {0} es requerido")]
        public string Trailer {get;set;}
        [Required (ErrorMessage = "El campo {0} es requerido")]
        public List <CategoriaPelicula> CategoriaPelicula {get;set;} = new List <CategoriaPelicula> ();
        public string Director{get;set;}
        public string NombreCorto
        {
            get
            {
                if(string.IsNullOrWhiteSpace(Nombre))
                {
                    return null;
                }
                if (Nombre.Length > 60)
                {
                    return Nombre.Substring(0,60)+"...";
                }else
                {
                    {
                        return Nombre;
                    }
                }

            }
        }
    }
}