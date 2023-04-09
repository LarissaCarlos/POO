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
        public Phone Telefone { get; set; }
        public Adress Endereco { get; set; }
    

        public Fornecedor(int id, string nome, Phone telefone, Address endereco)
        {
            this.Id = id;
            this.Nome = nome;
            this.Phone = telefone;
            this.Address = endereco;
  
        }

    }
}