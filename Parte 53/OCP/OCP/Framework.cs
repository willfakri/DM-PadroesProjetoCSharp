using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    public abstract class FormaGeometrica
    {
        public abstract double CalcularArea();
    }

    public class Retangulo : FormaGeometrica
    {
        public double Altura { get; set; }
        public double Largura { get; set; }

        public override double CalcularArea()
        {
            return Altura * Largura;
        }
    }

    public class Circulo : FormaGeometrica
    {
        public double Raio { get; set; }

        public override double CalcularArea()
        {
            return Raio * Raio * Math.PI;
        }
    }

    public class AreaCalc
    {
        public double CalcularArea(FormaGeometrica[] formas)
        {
            double area = 0;
            foreach(var forma in formas)
                area = area + forma.CalcularArea();            
            return area;
        }
    }
}
