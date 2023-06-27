using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace As_Biblioteca.Domain.Entities
{
    public class Livro
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public List<Autor> Autores { get; set; }
        public ICollection<Usuario> UsuariosEmprestados { get; set; }
    }
}