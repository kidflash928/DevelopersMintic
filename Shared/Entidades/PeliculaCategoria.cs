using System;
using System.ComponentModel.DataAnnotations;
namespace Peliculas.Shared.Entidades
{
    public class PeliculaCategoria
    {
        public int Id{get;set;}
        /*Validar el campo nombre para que sea requerido*/
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Categoria{get;set;}
    }
}