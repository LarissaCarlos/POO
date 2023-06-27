using System.Collections.Generic;
using System.Threading.Tasks;
using As_Biblioteca.Domain.Entities;

public interface ILivroService
{
    Task<List<Livro>> ObterTodosLivros();
    Task<Livro> ObterLivroPorId(int id);
    Task<int> AdicionarLivro(Livro livro);
    Task AtualizarLivro(Livro livro);
    Task RemoverLivro(int id);
    object GetLivroById(int livroId);
}
