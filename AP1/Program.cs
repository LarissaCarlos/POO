using System;

namespace AP1
{
    public class Program
    {
         private static readonly ProdutoRepositorio produtoRepositorio = new ProdutoRepositorio();
       private static readonly FornecedorRepository _fornecedorRepository = new FornecedorRepository();
        public static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo ao sistema de compras!");

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("1 - Cadastrar produto");
                Console.WriteLine("2 - Listar produtos");
                Console.WriteLine("3 - Cadastrar fornecedor");
                Console.WriteLine("4 - Listar fornecedor");
                Console.WriteLine("5 - Realizar compra");
                Console.WriteLine("0 - Sair");

                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        CadastrarProduto();
                        break;

                    case 2:
                        ListarProduto();
                        break;

                    case 3:
                        CadastrarFornecedor();
                        break;
                    
                    case 4:
                       ListarFornecedor();
                        break;

                    case 5:
                        RealizarCompra();
                        break;

                    case 0:
                        Console.WriteLine("Obrigado por utilizar o sistema de compras!");
                        return;

                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            }
        }

        private static void CadastrarProduto()
        {
            Console.WriteLine("Digite o nome do Produto:");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite o preço do produto:");
            decimal preco = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Produto cadastrado com sucesso!");

        }

        private static void ListarProdutos()
        {
            Console.WriteLine("Produtos cadastrados:");

            foreach (var produto in produtoRepositorio.Listar())
            {
                Console.WriteLine($"[{produto.CodBarras}] {produto.Nome} - R$ {produto.Valor}");
            }
        }

        private static void CadastrarFornecedor()
        {
            Console.WriteLine("Digite o nome do fornecedor:");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite o endereço do fornecedor:");
            string endereco = Console.ReadLine();

            Console.WriteLine("Digite o telefone do fornecedor:");
            string telefone = Console.ReadLine();

            var fornecedor = new Fornecedor
            {
                Id = _fornecedorRepository.ProximoId(),
                Nome = nome,
            };

            _fornecedorRepository.Adicionar(fornecedor);

            Console.WriteLine("Fornecedor cadastrado com sucesso!");
        }

        private static void ListarFornecedores()
        {
            Console.WriteLine("Fornecedores cadastrados:");

            foreach (var fornecedor in _fornecedorRepository.Listar())
            {
                Console.WriteLine($"[{fornecedor.Id}] {fornecedor.Nome}");
            }
        }
     }
}

        

