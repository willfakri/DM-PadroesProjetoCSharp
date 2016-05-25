using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    class Program
    {
        static void Main(string[] args)
        {
            var ret1 = new Retangulo() { Altura = 10, Largura = 10 };
            var ret2 = new Retangulo() { Altura = 20, Largura = 20 };
            var circ1 = new Circulo() { Raio = 20 };
            FormaGeometrica[] formas = {ret1, ret2, circ1};
            var calc = new AreaCalc();
            var area = calc.CalcularArea(formas);
            Console.WriteLine(area);
            Console.ReadLine();
        }
    }
}
