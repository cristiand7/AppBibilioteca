using Backend.Biblioteca.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Biblioteca.Repository.Interfaces
{
    public interface IRepositoryLibro
    {
        Task<bool> Create(Libro libro);
        Task<bool> CreateCategorias(List<LibroCategorias> libroCategorias);
        Task<bool> Update(Libro libro);
        Task<bool> Delete(Libro libro);
        Task<bool> DeleteRange(List<LibroCategorias> libroCategorias);
        Task<Libro> LibroById(string id);
        Task<List<LibroCategorias>> LibroCategoriasById(string id);
        Task<List<Libro>> List(string nombre,string categoria,string autor);
    }
}
