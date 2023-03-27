// See https://aka.ms/new-console-template for more information
using Aula_02_OO_basic;


//instanciar um objeto

Garrafa garrafaDaLarissa = new Garrafa(1234, "cinza", 2000, "garrafa mais bonita");

Console.WriteLine(garrafaDaLarissa.AnoFabricacao + " " + garrafaDaLarissa.Cor);
garrafaDaLarissa.Cor = ("tricolor");

Console.WriteLine(garrafaDaLarissa.AnoFabricacao + " " + garrafaDaLarissa.Cor);

Garrafa garrafaDoPedro = new Garrafa(5555, "azul", 2021, "teste");
Console.WriteLine(garrafaDoPedro.AnoFabricacao);

// Console.WriteLine("Digite um número inteiro:");
// var retorno = Convert.ToInt32(Console.ReadLine());
// Console.Write("Você digitou " + retorno);



var obj = new Calculadora();
var result = obj.Calcular(12,20,"somar");

Console.WriteLine("a soma é " + result);
