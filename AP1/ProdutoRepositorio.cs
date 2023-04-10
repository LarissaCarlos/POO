using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AP1
{
    public class ProdutoRepositorio
    { 
        private static List<Produto> _produtos = new List<Produto>();

        public static void Adicionar(Produto produto)
        {
            _produtos.Add(produto);
        }

        public static void get()
        {
            int i = 0;
            if (_produtos == null)
            {
                System.Console.WriteLine("\nNenhum usuário cadastrado!");
            }
            foreach (var c in _produtos)
            {
                Console.WriteLine($"\nCódigo de barras: {c.CodBarras} | Nome: {c.Nome} | Valor: {c.Valor} | Marca: {c.Marca}");
            }
        }
        public static Produto get(long codBarras)
        {
            if (_produtos == null)
            {
                System.Console.WriteLine("\nNenhum usuário cadastrado!");
            }

            return _produtos.Find(p => p.CodBarras == codBarras);
        }

    }
}

