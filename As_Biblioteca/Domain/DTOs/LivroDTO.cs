using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace As_Biblioteca.Domain.DTOs
{
    public class LivroDTO
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public List<AutorDTO> Autores { get; set; }
    }
}