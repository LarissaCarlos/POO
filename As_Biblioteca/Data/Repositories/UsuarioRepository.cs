using System.Collections.Generic;
using System.Threading.Tasks;
using As_Biblioteca.Domain.Entities;
using As_Biblioteca.Domain.Entities.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace As_Biblioteca.Data.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly DbContext _dbContext;

        public UsuarioRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Usuario>> ObterTodos()
        {
            return await _dbContext.Set<Usuario>().ToListAsync();
        }

        public async Task<Usuario> ObterPorId(int id)
        {
            return await _dbContext.Set<Usuario>().FindAsync(id);
        }

        public async Task<int> Inserir(Usuario usuario)
        {
            await _dbContext.Set<Usuario>().AddAsync(usuario);
            await _dbContext.SaveChangesAsync();

            return usuario.Id;
        }

        public async Task Atualizar(Usuario usuario)
        {
            _dbContext.Entry(usuario).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        public async Task Remover(int id)
        {
            var usuario = await _dbContext.Set<Usuario>().FindAsync(id);
            _dbContext.Set<Usuario>().Remove(usuario);
            await _dbContext.SaveChangesAsync();
        }
    }
}
