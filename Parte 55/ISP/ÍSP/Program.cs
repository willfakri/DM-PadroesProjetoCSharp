using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    class Program
    {
        static void Main(string[] args)
        {
            // programar para uma interface
            IVisualizar arq = new Foto() { Nome = "Dream Theater" };
            arq.Visualizar();
            Console.ReadLine();
        }
    }
}
