using System.Collections.Generic;
using System.Threading.Tasks;
using As_Biblioteca.Domain.DTOs;
using As_Biblioteca.Domain.Entities;

public interface IUsuarioService
{
    Task<List<Usuario>> ObterTodosUsuarios();
    Task<Usuario> ObterUsuarioPorId(int id);
    Task<int> AdicionarUsuario(Usuario usuario);
    Task AtualizarUsuario(Usuario usuario);
    Task RemoverUsuario(int id);
    object GetAllUsuarios();
    object GetUsuarioById(int id);
    List<LivroDTO> ObterLivrosEmprestados(int id);
    void CreateUsuario(Usuario usuario);
    void UpdateUsuario(Usuario usuario);
    void DeleteUsuario(int id);
    void EmprestarLivro(object usuario, object livro);
    void DevolverLivro(object usuario, object livro);
}
