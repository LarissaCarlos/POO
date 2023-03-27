// See https://aka.ms/new-console-template for more information

using Atividades;

//imprimindo

//Console.WriteLine("Digite um número:");
//imprimindo imprimir = new imprimindo();
//imprimir.Numero = Convert.ToInt32(Console.ReadLine());

//var numeros = imprimir.ImprimindoNumPares();

//foreach (var numero in numeros)
//{
//    Console.WriteLine(numero);
//}



//pessoa

//Pessoa pessoa = new Pessoa("Larissa", 19);

//Console.WriteLine(pessoa.Apresentar());



//Conta Bancaria

ContaBancaria minhaConta = new ContaBancaria(10);
Console.WriteLine("Digite o valor do depósito:");
int valorDeposito = int.Parse(Console.ReadLine());
int saldoAtual = minhaConta.Depositar(valorDeposito);
Console.WriteLine("O novo saldo da conta é:" + saldoAtual);

Console.WriteLine("Digite o valor do saque:");
int valorSaque = int.Parse(Console.ReadLine());
saldoAtual = minhaConta.Sacar(valorSaque);
Console.WriteLine("O saldo atual da sua conta é:" + saldoAtual);
