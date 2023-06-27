using System.Collections.Generic;
using System.Threading.Tasks;
using As_Biblioteca.Domain.Entities;

namespace As_Biblioteca.Domain.Entities.Interfaces
{
    public interface ILivroRepository
    {
        Task<List<Livro>> ObterTodos();
        Task<Livro> ObterPorId(int id);
        Task<int> Inserir(Livro livro);
        Task Atualizar(Livro livro);
        Task Remover(int id);
    }
}
