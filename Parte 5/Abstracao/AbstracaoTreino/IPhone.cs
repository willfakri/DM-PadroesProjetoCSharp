
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstracaoTreino
{
    public class IPhone : USB
    {
        public override void Desplugar()
        {
            Console.WriteLine("Iphone desplugado.");
        }

        public override void Plugar()
        {
            Console.WriteLine("Iphone plugado.");
        }
    }
}
