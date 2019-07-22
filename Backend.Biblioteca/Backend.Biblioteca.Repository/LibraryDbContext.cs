using System;
using System.Collections.Generic;
using System.Text;
using Backend.Biblioteca.Entities;
using Microsoft.EntityFrameworkCore;

namespace Backend.Biblioteca.Repository
{
    public class LibraryDbContext: DbContext
    {

        public virtual DbSet<Autor> Autor { get; set; }
        public virtual DbSet<Libro> Libro { get; set; }
        public virtual DbSet<Categoria> Categoria { get; set; }
        public virtual DbSet<LibroCategorias> LibroCategorias { get; set; }

        public LibraryDbContext(DbContextOptions<LibraryDbContext> options)
            : base(options)
        {
        }
        
        protected override void OnModelCreating(ModelBuilder
            modelBuilder)
        {
            modelBuilder.HasDefaultSchema("Backend.db");
        }


    }
}
