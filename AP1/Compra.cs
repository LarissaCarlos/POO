using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AP1
{
    public class Compra
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public List<Produto> Products { get; set; } = new List<Produto>();
        public int Montagem { get; set; }

        public Compra(int id, DateTime data, Produto produto, int montagem){
            this.Id = id;
            this.Data = data;
            Products.Add(produto);
            this.Montagem = montagem;
        }
        
    }
}