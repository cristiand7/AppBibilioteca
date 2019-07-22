using Backend.Biblioteca.Entities;
using Backend.Biblioteca.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Biblioteca.Repository.Repositories
{
    public class RepositoryLibro: IRepositoryLibro
    { 
        private readonly LibraryDbContext _context;

        public RepositoryLibro(LibraryDbContext dbContext)
        {
            _context = dbContext;
        }


        public async Task<bool> Create(Libro autor)
        {
            _context.Add(autor);
            await _context.SaveChangesAsync();
            return true;
        }
        
        public async Task<bool> CreateCategorias(List<LibroCategorias>  libroCategorias)
        {
            _context.AddRange(libroCategorias);
            await _context.SaveChangesAsync();
            return true;
        }


        public async Task<bool> Update(Libro autor)
        {
            _context.Update(autor);
            await _context.SaveChangesAsync();
            return true;

        }

        public async Task<bool> Delete(Libro autor)
        {
            _context.Remove(autor);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteRange(List<LibroCategorias> libroCategorias)
        {
            _context.RemoveRange(libroCategorias);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<List<LibroCategorias>> LibroCategoriasById(string id)
        {
            return await _context.LibroCategorias.Where(x => x.LibroId == id).ToListAsync();
        }


        public async Task<Libro> LibroById(string id)
        {
            var sql = from l in _context.Libro
                      join a in _context.Autor on l.AutorId equals a.Id
                      where l.Id == id
                      select new Libro
                      {
                          Id = l.Id,
                          AutorId = l.Id,
                          ISBN = l.ISBN,
                          Nombre = l.Nombre,
                          Autor = $"{a.Nombres} {a.Apellidos}"
                      };

            var libro = await sql.FirstOrDefaultAsync();
            libro.ListaCategorias = categoriasbylibro(libro.Id);
            return libro;
        }


        private List<Categoria> categoriasbylibro(string libroId) {
            var sql = from lc in _context.LibroCategorias
                      join c in _context.Categoria on lc.CategoriaId equals c.Id 
                      where lc.LibroId == libroId
                      select c;

            return sql.ToList();
        }

        public async Task<List<Libro>> List(string nombre, string categoria, string autor)
        {
          
            var sql = from l in _context.Libro
                      join a in _context.Autor on l.AutorId equals a.Id
                      select new Libro {
                          Id = l.Id,
                          AutorId = l.Id,
                          ISBN = l.ISBN,
                          Nombre = l.Nombre,
                          Autor = $"{a.Nombres} {a.Apellidos}"
                      };
            if (!string.IsNullOrEmpty(nombre)) {
                sql = sql.Where(x=>x.Nombre.Contains(nombre));
            }
            if (!string.IsNullOrEmpty(autor))
            {
                sql = sql.Where(x => x.Autor.Contains(autor));
            }
            var libros = await sql.ToListAsync();
            foreach (var l in libros)
            {
                l.ListaCategorias = categoriasbylibro(l.Id);
            }
            
            if (!string.IsNullOrEmpty(categoria))
            {
                var cat = _context.Categoria.FirstOrDefault(x => x.Nombre.Contains(categoria));
                libros = libros.Where(x => x.ListaCategorias.Contains(cat)).ToList();
            }
            return libros;
        }
    }
}
