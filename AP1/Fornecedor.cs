using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AP1
{
    public class Fornecedor : FornecedorRepositorio
    {
       private string nomeFornecedor;

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cnpj { get; set; }

        public Fornecedor(int id, string nome, String cnpj)
        {
            this.Id = id;
            this.Nome = nome;
            this.Cnpj = cnpj;

        }

        public Fornecedor(string nomeFornecedor)
        {
            this.nomeFornecedor = nomeFornecedor;
        }

    }
}