using System;

namespace MeuProjeto.UI
{
    public class Program
    {
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
                        
                        break;

                    case 2:
                        
                        break;

                    case 3:
                        
                        break;
                    
                    case 4:
                       
                        break;

                    case 5:
                        
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
    }
}

        

