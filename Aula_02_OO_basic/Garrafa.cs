using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_02_OO_basic
{
    public class Garrafa
    {

        //caracteristicas 

        public int Codigo { get; protected set; }

        public string Cor { get; set; }

        public int AnoFabricacao { get; protected set; }

        public string Identificacao { get; protected set; }

        public int Volume { get; }


        public Garrafa(int codigo, string cor, int anoFabricacao, string Identificacao)
        {

            this.Codigo = codigo;
            this.Cor = cor;
            this.AnoFabricacao = anoFabricacao;
            this.Identificacao = Identificacao;

        }


    }

}
