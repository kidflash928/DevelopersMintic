using System;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace blazorProyI.Client.Helpers
{
    
    public class UtilidadesString
    {
        public static string funcion_convert_mayus(string valor) => valor.ToUpper();
        public static string funcion_convert_minus(string valor) => valor.ToLower();
    }
}
