using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfismoTreino
{
    public class Bicicleta : MeioTransporte
    {        
        public int QuantidadeMarchas { get; set; }

        public override void Mover()
        {
            Console.WriteLine(string.Concat(Modelo, " de ",QuantidadeMarchas, " marchas está andando."));
        }
    }
}
