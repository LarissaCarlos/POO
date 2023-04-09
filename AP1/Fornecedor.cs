using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AP1
{
    public class Fornecedor
    {
        public int Id { get; set; }
        public string Nome { get; set; }

    

        public Fornecedor(int id, string nome)
        {
            this.Id = id;
            this.Nome = nome;

  
        }

    }
}