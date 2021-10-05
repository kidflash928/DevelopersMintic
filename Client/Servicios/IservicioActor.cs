using Peliculas.Shared.Entidades;
using System.Collections.Generic;
namespace Peliculas.Client.Servicios
{
    public interface IservicioActor
    {
        List<Actor> GetActores();
    }
}