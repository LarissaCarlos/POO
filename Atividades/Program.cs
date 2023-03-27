// See https://aka.ms/new-console-template for more information

using Atividades;

Console.WriteLine("Digite um número:");
imprimindo imprimir = new imprimindo();
imprimir.Numero = Convert.ToInt32(Console.ReadLine());

var numeros = imprimir.ImprimindoNumPares();

foreach (var numero in numeros)
{
    Console.WriteLine(numero);
}
