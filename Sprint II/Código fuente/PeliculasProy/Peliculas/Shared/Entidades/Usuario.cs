using System.Collections.ObjectModel;
using System;
namespace Shared.Entidades
{
    public class Usuario
    {
        public DateTime FechaNacimiento {get;set;} 
        public Collection.Generic.List<TipoDocumento> TipoDocumento {get; set;}  
        public string NumeroDocumento {get;set;}  
        public int Celular {get;set;}    
        public string Email {get;set;}  
        public Collection.Generic.List<Sexo> Sexo {get;set}  
        public string LugarResidencia {get;set;}
    }

    private void ConsultarPelicula(){}
    private void ConsultarRepartoPrincipal(){}
    private void Comentarios () {}
    
}