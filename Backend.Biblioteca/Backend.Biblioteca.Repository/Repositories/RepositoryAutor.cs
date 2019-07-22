using Backend.Biblioteca.Entities;
using Backend.Biblioteca.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Biblioteca.Repository.Repositories
{
    public class RepositoryAutor: IRepositoryAutor
    {
        private readonly LibraryDbContext _context;

        public RepositoryAutor(LibraryDbContext dbContext)
        {
            _context = dbContext;
        }


        public async Task<bool> Create(Autor autor)
        {
            _context.Add(autor);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Update(Autor autor)
        {
            _context.Update(autor);
            await _context.SaveChangesAsync();
            return true;

        }

        public async Task<bool> Delete(Autor autor)
        {
            _context.Remove(autor);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<Autor> AutorById(string id)
        {
            return await _context.Autor.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<Autor>> List()
        {
                return await _context.Autor.ToListAsync();
        }
    }
}
