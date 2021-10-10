using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Peliculas.Shared.Entidades;
using System;

namespace Peliculas.Server
{
    public class ApplicationDbContext :DbContext
    {
        //cada DbSet es una tabla que crearemos a partir de una entidad
        public DbSet<Pelicula>Peliculas{get;set;}
        public DbSet<Categoria>Categorias{get;set;}
        public DbSet<Actor>Actores{get;set;}
        public DbSet<CategoriaPelicula>CategoriasPelicula{get;set;}
        public DbSet<PeliculaActor>PeliculasActor{get;set;}

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options){

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /* Establecemos los tipos de relaciones entre las tablas que se van a crear
            1-1, 1-*,N-M 
            Creamos una llave primaria compuesta para la tabla CategoriaPelicula */
            modelBuilder.Entity<CategoriaPelicula>().HasKey(x=> new{x.CategoriaId, x.PeliculaId});
            modelBuilder.Entity<PeliculaActor>().HasKey(x=> new{x.PeliculaId,x.ActorId});
            base.OnModelCreating(modelBuilder);
        }

    }
}