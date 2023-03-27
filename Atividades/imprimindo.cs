using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividades
{
    public class imprimindo
    {
        public int Numero {get; set;}

        public List<int> ImprimindoNumPares()
        {
            List<int> numeros = new List<int>();
            for ( int i = 0; i <= this.Numero; i += 2) 
            {
                numeros.Add(i);
            }
            return numeros;

        }
        
    }
}