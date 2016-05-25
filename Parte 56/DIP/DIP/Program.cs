using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite valor do pedido:");
            var valor = Console.ReadLine();
            var pedido = new Pedido();
            pedido.Pagar(Convert.ToDouble(valor));
            Console.ReadLine();
        }
    }
}
