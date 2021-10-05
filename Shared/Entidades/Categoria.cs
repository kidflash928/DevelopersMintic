using System;
using System.ComponentModel.DataAnnotations;
namespace Peliculas.Shared.Entidades
{
    public class Categoria
    {
        public int Id {get;set;}
        /*Validar que el campo nombre es requerido */
        [Required (ErrorMessage = "El campo {0} es requerido")]
        public string Nombre {get;set;}
    }
}