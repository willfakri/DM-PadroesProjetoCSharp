using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            // cria produto
            var carro = new Veiculo("Carro Passeio");
            carro["motor"] = "127c";
            carro["portas"] = "4";
            carro["pneus"] = "4";
            carro.Mostrar();

            // cria produto
            var moto = new Veiculo("Motocicleta");
            moto["motor"] = "50c";
            moto["portas"] = "0";
            moto["pneus"] = "2";
            moto.Mostrar();
            Console.ReadLine();
        }
    }
}
