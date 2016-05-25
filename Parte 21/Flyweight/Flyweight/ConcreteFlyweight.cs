using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public class ConcreteFlyweight:Flyweight
    {
        public override void Operation(int ext)
        {
            Console.WriteLine("Concrete Flyweight: " + ext);
        }
    }
}
