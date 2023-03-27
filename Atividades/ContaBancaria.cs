using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividades
{
    public class ContaBancaria
    {
        public int saldo {get; private set;}

        public int numero {get; set;}

        public ContaBancaria(int saldoInicial)
        {
            if (saldoInicial > 0){
                Depositar(saldoInicial);
            }
        }

        public int Depositar(int valor)
        {
            saldo += valor;
            return saldo;
        }

        public int Sacar(int valor)
        {
            saldo -= valor;
            return saldo;
        }

        public int ObterSaldo()
        {
            return saldo;
        }
    }
}