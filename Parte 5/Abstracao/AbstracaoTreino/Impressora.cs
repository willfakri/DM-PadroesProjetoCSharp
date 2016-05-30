using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstracaoTreino
{
    public class Impressora : USB
    {
        public override void Desplugar()
        {
            Console.WriteLine("Impressora desplugada.");
        }

        public override void Plugar()
        {
            Console.WriteLine("Impressora plugada.");
        }
    }
}
