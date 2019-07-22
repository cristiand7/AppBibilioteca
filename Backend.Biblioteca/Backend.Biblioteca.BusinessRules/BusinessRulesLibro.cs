using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Backend.Biblioteca.Entities;
using Backend.Biblioteca.Repository.Interfaces;

namespace Backend.Biblioteca.BusinessRules
{
    public class BusinessRulesLibro
    {
        private readonly IRepositoryLibro _repository;

        public BusinessRulesLibro(IRepositoryLibro repository)
        {
            _repository = repository;
        }

        public async Task<List<Libro>> List(string nombre, string categoria, string autor)
        {
            return await _repository.List(nombre,categoria,autor);
        }
        public async Task<Libro> LibroById(string libroId)
        {
            return await _repository.LibroById(libroId);
        }

        public async Task<bool> Create(Libro libro)
        {

            libro.Id= Guid.NewGuid().ToString();
            await _repository.Create(libro);

            var listaCategorias = new List<LibroCategorias>();
            foreach (var categoria in libro.ListaCategorias)
            {
                listaCategorias.Add(new LibroCategorias
                {
                    Id = Guid.NewGuid().ToString(),
                    LibroId = libro.Id,
                    CategoriaId = categoria.Id
                });
            }
            return await _repository.CreateCategorias(listaCategorias);
        }

        public async Task<bool> Update(Libro libro)
        {
            var aux = await _repository.LibroById(libro.Id);
            aux.AutorId = libro.AutorId;
            aux.ISBN = libro.ISBN;
            aux.Nombre = libro.Nombre;
            await _repository.Update(aux);

            var lista = await _repository.LibroCategoriasById(libro.Id);

            await _repository.DeleteRange(lista);

            var listaCategorias = new List<LibroCategorias>();
            foreach (var categoria in libro.ListaCategorias)
            {
                listaCategorias.Add(new LibroCategorias
                {
                    Id = libro.Id = Guid.NewGuid().ToString(),
                    LibroId = libro.Id,
                    CategoriaId = categoria.Id
                });
            }
            return await _repository.CreateCategorias(listaCategorias);
        }

        public async Task<bool> Delete(string libroId)
        {
            var aux = await _repository.LibroById(libroId);
            var lista = await _repository.LibroCategoriasById(libroId);
            await _repository.DeleteRange(lista);
            await _repository.Delete(aux);

            return true;
        }

        
      

    }
}
