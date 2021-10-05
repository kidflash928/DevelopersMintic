using System.Collections.Generic;
using Peliculas.Shared.Entidades;

namespace Peliculas.Client.Servicios
{
    public interface IserviciosPeliculas
    {
        List<Pelicula> GetPelicula();
    }
}