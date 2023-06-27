using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace As_Biblioteca.Domain.Entities
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public List<Livro> LivrosEmprestados { get; set; }
        // Outras propriedades do usuário
    }
}