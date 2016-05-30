using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstracaoTreino
{
    public class Mouse : USB
    {
        public override void Desplugar()
        {
            Console.WriteLine("Mouse desplugado.");
        }

        public override void Plugar()
        {
            Console.WriteLine("Mouse plugado."); 
        }
    }
}
