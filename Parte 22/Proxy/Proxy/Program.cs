using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            ICalc calc = new CalcProxy();
            var r = calc.Somar(3, 5);
            Console.WriteLine(r.ToString());
            Console.ReadLine();
        }
    }
}
