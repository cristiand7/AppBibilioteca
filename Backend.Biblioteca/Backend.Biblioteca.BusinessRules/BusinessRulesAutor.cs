using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Backend.Biblioteca.Entities;
using Backend.Biblioteca.Repository.Interfaces;

namespace Backend.Biblioteca.BusinessRules
{
    public class BusinessRulesAutor
    {
        private readonly IRepositoryAutor _repository;

        public BusinessRulesAutor(IRepositoryAutor repository)
        {
            _repository = repository;
        }

        public async Task<List<Autor>> List()
        {
            return await _repository.List();
        }
        public async Task<Autor> AutorById(string autorId)
        {
            return await _repository.AutorById(autorId);
        }

        public async Task<bool> Create(Autor autor)
        {

            autor.Id= Guid.NewGuid().ToString();
            return await _repository.Create(autor);
        }

        public async Task<bool> Update(Autor autor)
        {
            var aux = await _repository.AutorById(autor.Id);
            aux.Apellidos = autor.Apellidos;
            aux.FechaNacimiento = autor.FechaNacimiento;
            aux.Nombres = autor.Nombres;            
            return await _repository.Update(aux);
        }

        public async Task<bool> Delete(string autorId)
        {
            var aux = await _repository.AutorById(autorId);
            return await _repository.Delete(aux);
        }

        
      

    }
}
