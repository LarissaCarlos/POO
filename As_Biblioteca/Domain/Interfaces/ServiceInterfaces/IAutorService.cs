using System.Collections.Generic;
using System.Threading.Tasks;
using As_Biblioteca.Domain.Entities;

public interface IAutorService
{
    Task<List<Autor>> ObterTodosAutores();
    Task<Autor> ObterAutorPorId(int id);
    Task<int> AdicionarAutor(Autor autor);
    Task AtualizarAutor(Autor autor);
    Task RemoverAutor(int id);
}
