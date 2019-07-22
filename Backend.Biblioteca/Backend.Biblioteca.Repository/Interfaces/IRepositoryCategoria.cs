using Backend.Biblioteca.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Biblioteca.Repository.Interfaces
{
    public interface IRepositoryCategoria
    {
        Task<bool> Create(Categoria categoria);
        Task<bool> Update(Categoria categoria);
        Task<bool> Delete(Categoria categoria);
        Task<Categoria> CategoriaById(string id);
        Task<List<Categoria>> List();
    }
}
