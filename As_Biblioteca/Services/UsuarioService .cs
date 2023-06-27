using System.Collections.Generic;
using System.Threading.Tasks;
using As_Biblioteca.Domain.DTOs;
using As_Biblioteca.Domain.Entities;
using As_Biblioteca.Domain.Entities.Interfaces;

public class UsuarioService : IUsuarioService
{
    private readonly IUsuarioRepository _usuarioRepository;

    public UsuarioService(IUsuarioRepository usuarioRepository)
    {
        _usuarioRepository = usuarioRepository;
    }

    public async Task<List<Usuario>> ObterTodosUsuarios()
    {
        return await _usuarioRepository.ObterTodos();
    }

    public async Task<Usuario> ObterUsuarioPorId(int id)
    {
        return await _usuarioRepository.ObterPorId(id);
    }

    public async Task<int> AdicionarUsuario(Usuario usuario)
    {
        return await _usuarioRepository.Inserir(usuario);
    }

    public async Task AtualizarUsuario(Usuario usuario)
    {
        await _usuarioRepository.Atualizar(usuario);
    }

    public async Task RemoverUsuario(int id)
    {
        await _usuarioRepository.Remover(id);
    }

    public object GetAllUsuarios()
    {
        throw new NotImplementedException();
    }

    public object GetUsuarioById(int id)
    {
        throw new NotImplementedException();
    }

    public List<LivroDTO> ObterLivrosEmprestados(int id)
    {
        throw new NotImplementedException();
    }

    public void CreateUsuario(Usuario usuario)
    {
        throw new NotImplementedException();
    }

    public void UpdateUsuario(Usuario usuario)
    {
        throw new NotImplementedException();
    }

    public void DeleteUsuario(int id)
    {
        throw new NotImplementedException();
    }

    public void EmprestarLivro(object usuario, object livro)
    {
        throw new NotImplementedException();
    }

    public void DevolverLivro(object usuario, object livro)
    {
        throw new NotImplementedException();
    }
}
