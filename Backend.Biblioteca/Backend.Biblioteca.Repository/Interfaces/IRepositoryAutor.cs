using Backend.Biblioteca.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Biblioteca.Repository.Interfaces
{
    public interface IRepositoryAutor
    {
        Task<bool> Create(Autor autor);
        Task<bool> Update(Autor autor);
        Task<bool> Delete(Autor autor);
        Task<Autor> AutorById(string id);
        Task<List<Autor>> List();
    }
}
