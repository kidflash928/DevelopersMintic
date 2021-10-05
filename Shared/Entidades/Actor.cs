using System;
using System.ComponentModel.DataAnnotations;
namespace Peliculas.Shared.Entidades
{
    public class Actor
    {
        public int Id {get;set;}
        [Required (ErrorMessage = "El campo Nombre del Actor es requerido")]
        public string NombreActor{get;set;}
        public TipoDocumento TipoDocumento{get;set;}
        public string Documento{get;set;}
        public Genero Genero{get;set;}
        [Required (ErrorMessage = "El campo fecha de nacimiento del actor es requerido")]
        public DateTime? FechaNacimiento{get;set;}
        public int Nominaciones {get;set;}
        public string Biografia{get;set;}
        public string Foto {get;set;}
    }

    public enum TipoDocumento
    {
        CedulaCiudadana = 0,
        CedulaExtranjera = 1,
        Pasaporte = 2,
        RegistroCivil = 3
    }

    public enum Genero
    {
        Femenino =0,
        Masculino
    }
}