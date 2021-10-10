namespace Peliculas.Shared.Entidades
{
    public class PeliculaActor
    {
        public int ActorId {get;set;}
        public int PeliculaId {get;set;}
        public Actor Actor {get;set;}
        public Pelicula Pelicula {get;set;}
        // Campos adicionales en la relación débil de muchos a muchos
        public int OordenarCreditos {get;set;}
        public string Personaje {get;set;}
    }
}