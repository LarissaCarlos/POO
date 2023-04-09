using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividades_02
{
    public class Animal
    {
        public string Name { get; set; }

        public void Talk(){
            System.Console.WriteLine("Falar");
        }

        public void EmitirSom(){
            Console.WriteLine("Emitindo som...");
        }
    }
}