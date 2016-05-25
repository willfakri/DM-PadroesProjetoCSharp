using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = 10;
            int y1 = 20;
            Calc c = new Calc();
            int r1 = c.Somar(x1, y1);
            int x2 = 30;
            int y2 = 40;
            int r2 = c.Somar(x2, y2);

            Console.WriteLine("A soma de {0} com {1} é {2}", x1, y1, r1);
            Console.WriteLine("A soma de {0} com {1} é {2}", x2, y2, r2);
            Console.ReadLine();
        }


    }
}
