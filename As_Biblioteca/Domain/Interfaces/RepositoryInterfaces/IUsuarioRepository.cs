using System.Collections.Generic;
using System.Threading.Tasks;
using As_Biblioteca.Domain.Entities;

namespace As_Biblioteca.Domain.Entities.Interfaces
{
    public interface IUsuarioRepository
    {
        Task<List<Usuario>> ObterTodos();
        Task<Usuario> ObterPorId(int id);
        Task<int> Inserir(Usuario usuario);
        Task Atualizar(Usuario usuario);
        Task Remover(int id);
    }
}
