namespace Peliculas.Shared.Entidades
{
    public class CategoriaPelicula
    {
        public int PeliculaId {get;set;}
        public int CategoriaId {get;set;}
        public Categoria Categoria {get;set;}
        public Pelicula Pelicula {get;set;}
    }
}