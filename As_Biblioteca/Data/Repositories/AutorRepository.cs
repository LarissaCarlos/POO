using System.Collections.Generic;
using System.Threading.Tasks;
using As_Biblioteca.Domain.Entities;
using As_Biblioteca.Domain.Entities.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace As_Biblioteca.Repositories
{
    public class AutorRepository : IAutorRepository
    {
        private readonly DbContext _dbContext;

        public AutorRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Autor>> ObterTodos()
        {
            return await _dbContext.Set<Autor>().ToListAsync();
        }

        public async Task<Autor> ObterPorId(int id)
        {
            return await _dbContext.Set<Autor>().FindAsync(id);
        }

        public async Task<int> Inserir(Autor autor)
        {
            await _dbContext.Set<Autor>().AddAsync(autor);
            await _dbContext.SaveChangesAsync();

            return autor.Id;
        }

        public async Task Atualizar(Autor autor)
        {
            _dbContext.Entry(autor).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        public async Task Remover(int id)
        {
            var autor = await _dbContext.Set<Autor>().FindAsync(id);
            _dbContext.Set<Autor>().Remove(autor);
            await _dbContext.SaveChangesAsync();
        }
    }
}
