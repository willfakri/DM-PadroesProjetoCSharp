using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfismoTreino
{
    public class Drone : MeioTransporte
    {       
        public int QuantidadeHelices { get; set; }
        public override void Mover()
        {
            Console.WriteLine(string.Concat(Modelo + " de " + QuantidadeHelices + " hélices está voando."));
        }
    }
}
