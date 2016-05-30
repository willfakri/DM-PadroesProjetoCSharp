using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfismoTreino
{
    public class Bicicleta
    {
        public string Marca { get; set; }
        public int QuantidadeMarchas { get; set; }

        public void Mover()
        {
            Console.WriteLine(string.Concat(Marca, " de ",QuantidadeMarchas, " marchas está andando."));
        }
    }
}
