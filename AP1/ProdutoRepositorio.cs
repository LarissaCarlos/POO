using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AP1
{
    public class ProdutoRepositorio
    { 
        private static List<Produto> _produtos = new List<Produto>(); // Criando a Lista Produtos

        public static void Adicionar(Produto produto) 
        {
            _produtos.Add(produto);
        }

        public IEnumerable<Produto> Listar()  // IEnumerable -> funciona apenas como leitura, n permitindo alteração nas coleções, forma sequencial ou retornar ao início.
        {
            return _produtos;
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

