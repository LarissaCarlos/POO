using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AP1
{
    public class ProdutoRepositorio : Produto
    {
        private static List<Produto> _produto = new List<Produto>();

        public ProdutoRepositorio(long codBarras, string nome, string valor, string marca, Fornecedor fornecedor) : base(codBarras, nome, valor, marca, fornecedor)
        {}


        public static void Adicionar()
        {
            Console.WriteLine("Codigo de barra: ");
            long codBarras = long.Parse(Console.ReadLine());

            Console.WriteLine("Nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Valor: ");
            double valor = double.Parse(Console.ReadLine());
            string valorStr = valor.ToString();

            Console.WriteLine("Marca: ");
            string marca = Console.ReadLine();

            Console.WriteLine("Fornecedor: ");
            string nomeFornecedor = Console.ReadLine();
            AP1.Fornecedor fornecedor = new AP1.Fornecedor(nomeFornecedor);

            ProdutoSimples produtoSimples = new ProdutoSimples(codBarras, nome, valor.ToString(), marca, fornecedor);

            _produto.Add(produtoSimples);
        }

        public static void get()
        {
            if (_produto == null)
            {
                System.Console.WriteLine("\nNenhum usuário cadastrado!");
            }
            foreach (var c in _produto)
            {
                Console.WriteLine($"\nCódigo de barras: {c.CodBarras} | Nome: {c.Nome} | Valor: {c.Valor} | Marca: {c.Marca}");
            }
        }
         public class Listar
    {
        public static void Produto(List<Produto> produto)
        {
            if (produto == null)
            {
                System.Console.WriteLine("\nNenhum produto cadastrado!");
            }
            foreach (var c in produto)
            {
                Console.WriteLine($"\nCódigo de barras: {c.CodBarras} | Nome: {c.Nome} | Valor: {c.Valor} | Marca: {c.Marca}");
            }
        }
    }
        public static void ListarProdutos()
        {
            Listar.Produto(_produto);
        }
        public static Produto get(long codBarras)
        {
            if (_produto == null)
            {
                System.Console.WriteLine("\nNenhum usuário cadastrado!");
            }

            return _produto.Find(p => p.CodBarras == codBarras);
        }
    }
}

