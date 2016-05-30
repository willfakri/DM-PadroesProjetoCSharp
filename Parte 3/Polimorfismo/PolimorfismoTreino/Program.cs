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
            Barco barco = new Barco { Modelo = "Barco Maroto" };
            barco.Mover();

            Bicicleta bicicleta = new Bicicleta() { Marca = "Caloi", QuantidadeMarchas = 18 };
            bicicleta.Mover();

            Drone drone = new Drone() { Modelo="Drone militar", QuantidadeHelices=4 };
            drone.Mover();

            Console.ReadKey();
        }
    }
}
