using System.Collections.Generic;
using System.Threading.Tasks;
using As_Biblioteca.Domain.Entities;

namespace As_Biblioteca.Domain.Entities.Interfaces
{
    public interface IAutorRepository
    {
        Task<List<Autor>> ObterTodos();
        Task<Autor> ObterPorId(int id);
        Task<int> Inserir(Autor autor);
        Task Atualizar(Autor autor);
        Task Remover(int id);
    }
}
