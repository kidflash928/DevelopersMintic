using System.Collections.ObjectModel;
using System;
namespace Shared.Entidades
{
    public class RepartoPrincipal:General
    {
        public DateTime RepartoPrincipal {get;set;}  
        public string Bigrafia {get;set;}    
        public string LugarNacimiento {get;set;} 
        public int CreditosActor {get;set;}  
        public Collection.Generic.List<Sexo> Sexo {get;set}  
    }
}