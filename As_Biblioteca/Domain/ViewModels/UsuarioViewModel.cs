using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace As_Biblioteca.Domain.ViewModels
{
    public class UsuarioViewModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public List<LivroViewModel> LivrosEmprestados { get; set; }
    }
}