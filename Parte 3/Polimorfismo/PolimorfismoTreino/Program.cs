using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfismoTreino
{
    class Program
    {
        static void Main(string[] args)
        {
            MeioTransporte barco = new Barco { Modelo = "Barco Maroto" };
            barco.Mover();

            MeioTransporte bicicleta = new Bicicleta() { Modelo = "Caloi Master Plus", QuantidadeMarchas = 18 };
            bicicleta.Mover();

            MeioTransporte drone = new Drone() { Modelo="Drone militar", QuantidadeHelices=4 };
            drone.Mover();

            Console.ReadKey();
        }
    }
}
