using Backend.Biblioteca.Entities;
using Backend.Biblioteca.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Biblioteca.Repository.Repositories
{
    public class RepositoryCategoria: IRepositoryCategoria
    {
        private readonly LibraryDbContext _context;

        public RepositoryCategoria(LibraryDbContext dbContext)
        {
            _context = dbContext;
        }


        public async Task<bool> Create(Categoria categoria)
        {
            _context.Add(categoria);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Update(Categoria categoria)
        {
            _context.Update(categoria);
            await _context.SaveChangesAsync();
            return true;

        }

        public async Task<bool> Delete(Categoria categoria)
        {
            _context.Remove(categoria);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<Categoria> CategoriaById(string id)
        {
            return await _context.Categoria.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<Categoria>> List()
        {
            return await _context.Categoria.ToListAsync();
        }
    }
}
