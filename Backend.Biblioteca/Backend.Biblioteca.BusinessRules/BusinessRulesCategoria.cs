using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Backend.Biblioteca.Entities;
using Backend.Biblioteca.Repository.Interfaces;

namespace Backend.Biblioteca.BusinessRules
{
    public class BusinessRulesCategoria
    {
        private readonly IRepositoryCategoria _repository;

        public BusinessRulesCategoria(IRepositoryCategoria repository)
        {
            _repository = repository;
        }

        public async Task<List<Categoria>> List()
        {
            return await _repository.List();
        }
        public async Task<Categoria> CategoriaById(string categoriaId)
        {
            return await _repository.CategoriaById(categoriaId);
        }

        public async Task<bool> Create(Categoria categoria)
        {

            categoria.Id= Guid.NewGuid().ToString();
            return await _repository.Create(categoria);
        }

        public async Task<bool> Update(Categoria categoria)
        {
            var aux = await _repository.CategoriaById(categoria.Id);
            aux.Nombre = categoria.Nombre;
            aux.Descripcion = categoria.Descripcion; 
            return await _repository.Update(aux);
        }

        public async Task<bool> Delete(string categoriaId)
        {
            var aux = await _repository.CategoriaById(categoriaId);
            return await _repository.Delete(aux);
        }

        
      

    }
}
