using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividades_02
{
    public class Gato : Animal
    {
        public void Meow(){
            System.Console.WriteLine("Meow, meow");
        }

        public void EmitirSom(){
            base.EmitirSom(); 
            Console.WriteLine("Emitindo som...");
        }
        
    }
}