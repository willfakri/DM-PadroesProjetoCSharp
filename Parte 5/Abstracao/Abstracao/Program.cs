using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Abstracao
{
    class Program
    {
        static void Main(string[] args)
        {
            Notebook acer = new Notebook("acer aspire");
            acer.Porta1 = new iPhone();
            acer.Porta2 = new Teclado();
            acer.Porta3 = new Tablet();
            Console.ReadLine();

        }
    }
}
