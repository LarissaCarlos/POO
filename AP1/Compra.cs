using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AP1
{
    public class Compra : CompraRepositorio
    {
        public int Id { get; private set; }
        public DateTime Data { get; set; }
        public List<Produto> Produtos { get; set; } = new List<Produto>();
    

        public Compra(int id, DateTime data, Produto produto){
            this.Id = id;
            this.Data = data;
            Produtos.Add(produto);

        }

        public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }

        public Produto(int id, string nome, decimal preco)
        {
            this.Id = id;
            this.Nome = nome;
            this.Preco = preco;
        }
    }
        
    }
}